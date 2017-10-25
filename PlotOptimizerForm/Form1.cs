using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

//https://forums.burst-team.us/topic/288/plots-101/4

namespace PlotOptimizerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int SCOOP_SIZE = 64;
        const int PLOTSIZE = 262144;  // 256 KB        
        const int SCOOPS = 4096; // (PLOTSIZE / SCOOP_SIZE)

        private long _key;
        private long _startNonce;
        private long _nonces;
        private long _stagger;
        private long _blocks;
        private int _scoopsPerLoop;
        private int _blockSize;
        private long _staggerPlotSize;
        private string _inputPath;
        private string _outputPath;
        private int _startScoop = 0;
        private int _endScoop = SCOOPS;
        private int _checkScoop = 0;

        private bool run = true;
        private bool running = false;
        private int _readingBlock = 0;
        private int _writingScoop = 0;
        private int _writingBlock = 0;

        private void btSetMemory_Click(object sender, EventArgs e)
        {
            SetMemoryParams();
        }

        private void SetMemoryParams()
        {
            if (running)
                return;

            _endScoop = Convert.ToInt32(tbEndScoop.Text);
            _inputPath = tbInputPath.Text;
            string fileName = Path.GetFileName(_inputPath);

            var parts = fileName.Split('_'); // (!sscanf(lastslash, "%I64u_%I64u_%I64u_%I64u", &key, &startnonce, &nonces, stagger))
            _key = Convert.ToInt64(parts[0]);
            _startNonce = Convert.ToInt64(parts[1]);
            _nonces = Convert.ToInt64(parts[2]);
            _stagger = Convert.ToInt64(parts[3]);
                 
            _blocks = _nonces / _stagger;

            string outputFileName = String.Format("{0}_{1}_{2}_{3}", _key, _startNonce, _nonces, _nonces);
            string outputDir = tbOutputDir.Text;
            _outputPath = Path.Combine(outputDir, outputFileName);

            _scoopsPerLoop = GetScoopsPerLoop();

            if (File.Exists(_outputPath))
            {
                long outputFileLength = new System.IO.FileInfo(_outputPath).Length;
                long scoopSize = _nonces * SCOOP_SIZE;
                if (outputFileLength % scoopSize == 0)
                {
                    long written = outputFileLength / scoopSize;
                    tbScoopsWritten.Text = written.ToString("N0", CultureInfo.InvariantCulture);
                    _startScoop = (int) written;
                    _checkScoop = (int)written - _scoopsPerLoop;
                    tbCheckScoop.Text = _checkScoop.ToString();
                }                
            }
            
            long memused = _nonces * SCOOP_SIZE * _scoopsPerLoop; // blocks * stagger * SCOOP_SIZE * scoopsPerLoop;

            _blockSize = (int)_stagger * SCOOP_SIZE * _scoopsPerLoop; // * 64 * scoopsPerLoop
            _staggerPlotSize = _stagger * PLOTSIZE;  // * 262144

            long mem = memused / (1024 * 1024);
            tbMemUsed.Text = mem.ToString("N0", CultureInfo.InvariantCulture) + " MB";
            tbSsize.Text = _scoopsPerLoop.ToString("N0", CultureInfo.InvariantCulture);
            tbNonces.Text = _nonces.ToString("N0", CultureInfo.InvariantCulture);
            tbStagger.Text = _stagger.ToString("N0", CultureInfo.InvariantCulture);
            tbBlocks.Text = _blocks.ToString("N0", CultureInfo.InvariantCulture);
            tbBlockSize.Text = _blockSize.ToString("N0", CultureInfo.InvariantCulture);
        }

        private int GetScoopsPerLoop()
        {
            int scoopsPerLoop = SCOOPS;
            long memused = 0;
            long memory = Convert.ToInt32(tbRam.Text);
            memory *= 1024 * 1024 * 1024;

            //Determines how many blocks to process at a time within specified memory size
            for (; scoopsPerLoop >= 1; scoopsPerLoop /= 2)
            {
                memused = _nonces * SCOOP_SIZE * scoopsPerLoop; // blocks * stagger * SCOOP_SIZE * scoopsPerLoop;
                if (memused <= memory)
                    break;
            }
            return scoopsPerLoop;
        }

        private void DisableButtons()
        {
            btnCheckScoop.Enabled = false;
            btSetMemory.Enabled = false;
            btnOptimize.Enabled = false;
            btnDeleteLastScoop.Enabled = false;
        }

        private void EnableButtons()
        {
            btnCheckScoop.Enabled = true;
            btSetMemory.Enabled = true;
            btnOptimize.Enabled = true;
            btnDeleteLastScoop.Enabled = true;
        }

        private void btnOptimize_Click(object sender, EventArgs e)
        {
            if (running)
                return;

            running = true;
            DisableButtons();
            SetMemoryParams();
            Cursor = Cursors.WaitCursor;
            run = true;
            new Thread(new ThreadStart(OnRun)).Start();
            new Thread(new ThreadStart(InfoThread)).Start();
        }

        private void OnRun()
        {
            byte[][] buffer = new byte[_blocks][];
            int i;
            for (i = 0; i < _blocks; i++)
            {
                buffer[i] = new byte[_blockSize];
            }
            
            for (i = _startScoop; i < _endScoop && run; i += _scoopsPerLoop)            
            {                
                PrintMessage(i.ToString());

                long origin = i * _stagger * SCOOP_SIZE;
                using (BinaryReader b = new BinaryReader(File.Open(_inputPath, FileMode.Open)))
                {                    
                    for (int block = 0; block < _blocks && run; ++block)
                    {
                        _readingBlock = block;
                        b.BaseStream.Seek(origin, SeekOrigin.Begin);
                        b.Read(buffer[block], 0, _blockSize);
                        origin += _staggerPlotSize;
                    }
                    _readingBlock = -1;
                }

                if (!run)
                {
                    break;
                }

                using (FileStream fs = new FileStream(_outputPath, File.Exists(_outputPath) ? FileMode.Append : FileMode.OpenOrCreate))
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    for (int k = 0; k < _scoopsPerLoop; k++)
                    {
                        _writingScoop = k;
                        for (int block = 0; block < _blocks; ++block)
                        {
                            _writingBlock = block;
                            bw.Write(buffer[block], (int)_stagger * SCOOP_SIZE * k, (int)_stagger * SCOOP_SIZE);
                        }
                    }
                    _writingScoop = -1;
                    _writingBlock = -1;
                }
            }
            PrintMessage(i.ToString());

            buffer = null;
            GC.WaitForPendingFinalizers(); //GC.Collect();

            Invoke((MethodInvoker)delegate () {
                EnableButtons();
                Cursor = Cursors.Default;
                running = false;
            });
        }

        private void InfoThread()
        {
            while (running)
            {
                Invoke((MethodInvoker)delegate ()
                {
                    string strWs = _writingScoop == -1 ? "done" : _writingScoop.ToString();
                    string strWb = _writingBlock == -1 ? "done" : _writingBlock.ToString();
                    tbWrittingScoop1.Text = $"{strWs} | {strWb}";

                    tbReadingBlock1.Text = _readingBlock == -1 ? "done" : _readingBlock.ToString();
                });
                Thread.Sleep(100);
            }
        }

        private void btnCheckScoop_Click(object sender, EventArgs e)
        {
            if (running)
                return;

            running = true;
            DisableButtons();
            SetMemoryParams();
            Cursor = Cursors.WaitCursor;
            run = true;
            _checkScoop = Convert.ToInt32(tbCheckScoop.Text);
            new Thread(new ThreadStart(CheckScoop)).Start();            
        }

        private void btnDeleteLastScoop_Click(object sender, EventArgs e)
        {
            if (!running && File.Exists(_outputPath))
            {
                int scoopsPerLoop = GetScoopsPerLoop();
                long outputFileLength = new FileInfo(_outputPath).Length;
                long scoopSize = _nonces * SCOOP_SIZE;
                long written = outputFileLength / scoopSize;
                int deleteScoop = (int)written - scoopsPerLoop;

                using (var file = File.Open(_outputPath, FileMode.Open, FileAccess.Write))
                {
                    file.SetLength(scoopSize * deleteScoop);
                }
            }
        }

        private void PrintMessage(string format, params object[] args)
        {
            Invoke((MethodInvoker)delegate ()
            {
                tbProcessingScoop.Text = string.Format(format, args);
                //listBoxOutput.Items.Add(string.Format(format, args));
            });
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            run = false;
        }

        private void CheckScoop()
        {
            int i;
            byte[][] buffer = new byte[_blocks][];
            for (i = 0; i < _blocks; i++)
            {
                buffer[i] = new byte[_blockSize];
            }

            bool ok = true;
            i = _checkScoop;            
                            
            PrintMessage(i.ToString());
            long origin = i * _stagger * SCOOP_SIZE;

            using (BinaryReader b = new BinaryReader(File.Open(_inputPath, FileMode.Open)))
            {
                //Read from original plot file off hard drive and save to buffers[block #] in memory
                for (int block = 0; block < _blocks && run; ++block)
                {
                    b.BaseStream.Seek(origin, SeekOrigin.Begin);
                    b.Read(buffer[block], 0, _blockSize);
                    origin += _staggerPlotSize;
                }
            }

            int readSize = (int)_stagger * SCOOP_SIZE;

            byte[] buffer2 = new byte[readSize];
            long scoopSize = _nonces * SCOOP_SIZE;
            using (BinaryReader b2 = new BinaryReader(File.Open(_outputPath, FileMode.Open)))
            {
                b2.BaseStream.Seek(scoopSize * _checkScoop, SeekOrigin.Begin);
                for (int k = 0; k < _scoopsPerLoop && ok; k++)
                {
                    for (int block = 0; block < _blocks && ok; ++block)
                    {
                        b2.Read(buffer2, 0, readSize);
                        int w = readSize * k;
                        for (int z = 0; z < readSize; ++z)
                        {                                
                            if (buffer[block][w] != buffer2[z])
                            {
                                ok = false;
                                break;
                            }
                            ++w;
                        }
                        //bw.Write(buffer[block], (int)stagger * SCOOP_SIZE * k, (int)stagger * SCOOP_SIZE);
                    }
                }
            }                           

            PrintMessage("scoop {0} is {1}", i.ToString(), ok);

            for (i = 0; i < _blocks; i++)
            {
                buffer[i] = null;
            }
            buffer = null;
            GC.WaitForPendingFinalizers(); //GC.Collect();

            Invoke((MethodInvoker)delegate () {
                EnableButtons();
                Cursor = Cursors.Default;
                running = false;
            });
        }
    }
}
