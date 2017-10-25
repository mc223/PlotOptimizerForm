namespace PlotOptimizerForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOptimize = new System.Windows.Forms.Button();
            this.tbInputPath = new System.Windows.Forms.TextBox();
            this.lbInputPath = new System.Windows.Forms.Label();
            this.lbOutputDir = new System.Windows.Forms.Label();
            this.tbOutputDir = new System.Windows.Forms.TextBox();
            this.tbRam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSetMemory = new System.Windows.Forms.Button();
            this.tbSsize = new System.Windows.Forms.TextBox();
            this.lbSsize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNonces = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStagger = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBlocks = new System.Windows.Forms.TextBox();
            this.lbBlockSize = new System.Windows.Forms.Label();
            this.tbBlockSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMemUsed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbScoopsWritten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEndScoop = new System.Windows.Forms.TextBox();
            this.tbProcessingScoop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnCheckScoop = new System.Windows.Forms.Button();
            this.tbCheckScoop = new System.Windows.Forms.TextBox();
            this.btnDeleteLastScoop = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbReadingBlock1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbWrittingScoop1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOptimize
            // 
            this.btnOptimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOptimize.Location = new System.Drawing.Point(12, 326);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(106, 29);
            this.btnOptimize.TabIndex = 0;
            this.btnOptimize.Text = "Optimize";
            this.btnOptimize.UseVisualStyleBackColor = true;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click);
            // 
            // tbInputPath
            // 
            this.tbInputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbInputPath.Location = new System.Drawing.Point(149, 4);
            this.tbInputPath.Name = "tbInputPath";
            this.tbInputPath.Size = new System.Drawing.Size(861, 27);
            this.tbInputPath.TabIndex = 1;
            this.tbInputPath.Text = "c:\\Plots\\SkyHawk07\\6485090210343332768_304000000_38000000_20000";
            // 
            // lbInputPath
            // 
            this.lbInputPath.AutoSize = true;
            this.lbInputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInputPath.Location = new System.Drawing.Point(18, 11);
            this.lbInputPath.Name = "lbInputPath";
            this.lbInputPath.Size = new System.Drawing.Size(84, 20);
            this.lbInputPath.TabIndex = 2;
            this.lbInputPath.Text = "Input Path";
            // 
            // lbOutputDir
            // 
            this.lbOutputDir.AutoSize = true;
            this.lbOutputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOutputDir.Location = new System.Drawing.Point(18, 40);
            this.lbOutputDir.Name = "lbOutputDir";
            this.lbOutputDir.Size = new System.Drawing.Size(87, 20);
            this.lbOutputDir.TabIndex = 3;
            this.lbOutputDir.Text = "Output Dir";
            // 
            // tbOutputDir
            // 
            this.tbOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOutputDir.Location = new System.Drawing.Point(149, 37);
            this.tbOutputDir.Name = "tbOutputDir";
            this.tbOutputDir.Size = new System.Drawing.Size(861, 27);
            this.tbOutputDir.TabIndex = 4;
            this.tbOutputDir.Text = "c:\\Plots\\IronWolf07";
            // 
            // tbRam
            // 
            this.tbRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRam.Location = new System.Drawing.Point(149, 70);
            this.tbRam.Name = "tbRam";
            this.tbRam.Size = new System.Drawing.Size(201, 27);
            this.tbRam.TabIndex = 5;
            this.tbRam.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max RAM [GB]";
            // 
            // btSetMemory
            // 
            this.btSetMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSetMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSetMemory.Location = new System.Drawing.Point(914, 136);
            this.btSetMemory.Name = "btSetMemory";
            this.btSetMemory.Size = new System.Drawing.Size(96, 29);
            this.btSetMemory.TabIndex = 7;
            this.btSetMemory.Text = "Set Memory";
            this.btSetMemory.UseVisualStyleBackColor = true;
            this.btSetMemory.Click += new System.EventHandler(this.btSetMemory_Click);
            // 
            // tbSsize
            // 
            this.tbSsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSsize.Location = new System.Drawing.Point(149, 136);
            this.tbSsize.Name = "tbSsize";
            this.tbSsize.ReadOnly = true;
            this.tbSsize.Size = new System.Drawing.Size(201, 27);
            this.tbSsize.TabIndex = 8;
            // 
            // lbSsize
            // 
            this.lbSsize.AutoSize = true;
            this.lbSsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSsize.Location = new System.Drawing.Point(18, 139);
            this.lbSsize.Name = "lbSsize";
            this.lbSsize.Size = new System.Drawing.Size(49, 20);
            this.lbSsize.TabIndex = 9;
            this.lbSsize.Text = "ssize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "nonces";
            // 
            // tbNonces
            // 
            this.tbNonces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNonces.Location = new System.Drawing.Point(149, 169);
            this.tbNonces.Name = "tbNonces";
            this.tbNonces.ReadOnly = true;
            this.tbNonces.Size = new System.Drawing.Size(201, 27);
            this.tbNonces.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "stagger";
            // 
            // tbStagger
            // 
            this.tbStagger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbStagger.Location = new System.Drawing.Point(149, 202);
            this.tbStagger.Name = "tbStagger";
            this.tbStagger.ReadOnly = true;
            this.tbStagger.Size = new System.Drawing.Size(201, 27);
            this.tbStagger.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(18, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "blocks";
            // 
            // tbBlocks
            // 
            this.tbBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBlocks.Location = new System.Drawing.Point(149, 240);
            this.tbBlocks.Name = "tbBlocks";
            this.tbBlocks.ReadOnly = true;
            this.tbBlocks.Size = new System.Drawing.Size(201, 27);
            this.tbBlocks.TabIndex = 14;
            // 
            // lbBlockSize
            // 
            this.lbBlockSize.AutoSize = true;
            this.lbBlockSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbBlockSize.Location = new System.Drawing.Point(18, 277);
            this.lbBlockSize.Name = "lbBlockSize";
            this.lbBlockSize.Size = new System.Drawing.Size(89, 20);
            this.lbBlockSize.TabIndex = 17;
            this.lbBlockSize.Text = "Block Size";
            // 
            // tbBlockSize
            // 
            this.tbBlockSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBlockSize.Location = new System.Drawing.Point(149, 273);
            this.tbBlockSize.Name = "tbBlockSize";
            this.tbBlockSize.ReadOnly = true;
            this.tbBlockSize.Size = new System.Drawing.Size(201, 27);
            this.tbBlockSize.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(18, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "mem used";
            // 
            // tbMemUsed
            // 
            this.tbMemUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMemUsed.Location = new System.Drawing.Point(149, 103);
            this.tbMemUsed.Name = "tbMemUsed";
            this.tbMemUsed.ReadOnly = true;
            this.tbMemUsed.Size = new System.Drawing.Size(201, 27);
            this.tbMemUsed.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(497, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Scoops written";
            // 
            // tbScoopsWritten
            // 
            this.tbScoopsWritten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScoopsWritten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbScoopsWritten.Location = new System.Drawing.Point(641, 70);
            this.tbScoopsWritten.Name = "tbScoopsWritten";
            this.tbScoopsWritten.ReadOnly = true;
            this.tbScoopsWritten.Size = new System.Drawing.Size(369, 27);
            this.tbScoopsWritten.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(477, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Process to scoop";
            // 
            // tbEndScoop
            // 
            this.tbEndScoop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEndScoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEndScoop.Location = new System.Drawing.Point(641, 103);
            this.tbEndScoop.Name = "tbEndScoop";
            this.tbEndScoop.Size = new System.Drawing.Size(369, 27);
            this.tbEndScoop.TabIndex = 22;
            this.tbEndScoop.Text = "4096";
            // 
            // tbProcessingScoop
            // 
            this.tbProcessingScoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbProcessingScoop.Location = new System.Drawing.Point(299, 368);
            this.tbProcessingScoop.Name = "tbProcessingScoop";
            this.tbProcessingScoop.ReadOnly = true;
            this.tbProcessingScoop.Size = new System.Drawing.Size(139, 27);
            this.tbProcessingScoop.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(150, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Processing scoop";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStop.Location = new System.Drawing.Point(928, 326);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(82, 29);
            this.btnStop.TabIndex = 26;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnCheckScoop
            // 
            this.btnCheckScoop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckScoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheckScoop.Location = new System.Drawing.Point(897, 235);
            this.btnCheckScoop.Name = "btnCheckScoop";
            this.btnCheckScoop.Size = new System.Drawing.Size(113, 28);
            this.btnCheckScoop.TabIndex = 27;
            this.btnCheckScoop.Text = "Check Scoop";
            this.btnCheckScoop.UseVisualStyleBackColor = true;
            this.btnCheckScoop.Click += new System.EventHandler(this.btnCheckScoop_Click);
            // 
            // tbCheckScoop
            // 
            this.tbCheckScoop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCheckScoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCheckScoop.Location = new System.Drawing.Point(791, 236);
            this.tbCheckScoop.Name = "tbCheckScoop";
            this.tbCheckScoop.Size = new System.Drawing.Size(100, 27);
            this.tbCheckScoop.TabIndex = 28;
            // 
            // btnDeleteLastScoop
            // 
            this.btnDeleteLastScoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteLastScoop.Location = new System.Drawing.Point(366, 136);
            this.btnDeleteLastScoop.Name = "btnDeleteLastScoop";
            this.btnDeleteLastScoop.Size = new System.Drawing.Size(136, 29);
            this.btnDeleteLastScoop.TabIndex = 29;
            this.btnDeleteLastScoop.Text = "Delete Last Scoops";
            this.btnDeleteLastScoop.UseVisualStyleBackColor = true;
            this.btnDeleteLastScoop.Click += new System.EventHandler(this.btnDeleteLastScoop_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(150, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Reading Block";
            // 
            // tbReadingBlock1
            // 
            this.tbReadingBlock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbReadingBlock1.Location = new System.Drawing.Point(299, 401);
            this.tbReadingBlock1.Name = "tbReadingBlock1";
            this.tbReadingBlock1.ReadOnly = true;
            this.tbReadingBlock1.Size = new System.Drawing.Size(139, 27);
            this.tbReadingBlock1.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(150, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Writing Scoop";
            // 
            // tbWrittingScoop1
            // 
            this.tbWrittingScoop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbWrittingScoop1.Location = new System.Drawing.Point(299, 434);
            this.tbWrittingScoop1.Name = "tbWrittingScoop1";
            this.tbWrittingScoop1.ReadOnly = true;
            this.tbWrittingScoop1.Size = new System.Drawing.Size(139, 27);
            this.tbWrittingScoop1.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1022, 478);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbWrittingScoop1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbReadingBlock1);
            this.Controls.Add(this.btnDeleteLastScoop);
            this.Controls.Add(this.tbCheckScoop);
            this.Controls.Add(this.btnCheckScoop);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbProcessingScoop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbEndScoop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbScoopsWritten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMemUsed);
            this.Controls.Add(this.lbBlockSize);
            this.Controls.Add(this.tbBlockSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBlocks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbStagger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNonces);
            this.Controls.Add(this.lbSsize);
            this.Controls.Add(this.tbSsize);
            this.Controls.Add(this.btSetMemory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRam);
            this.Controls.Add(this.tbOutputDir);
            this.Controls.Add(this.lbOutputDir);
            this.Controls.Add(this.lbInputPath);
            this.Controls.Add(this.tbInputPath);
            this.Controls.Add(this.btnOptimize);
            this.Name = "Form1";
            this.Text = "BurstCoin Plot Optimizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOptimize;
        private System.Windows.Forms.TextBox tbInputPath;
        private System.Windows.Forms.Label lbInputPath;
        private System.Windows.Forms.Label lbOutputDir;
        private System.Windows.Forms.TextBox tbOutputDir;
        private System.Windows.Forms.TextBox tbRam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSetMemory;
        private System.Windows.Forms.TextBox tbSsize;
        private System.Windows.Forms.Label lbSsize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNonces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStagger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBlocks;
        private System.Windows.Forms.Label lbBlockSize;
        private System.Windows.Forms.TextBox tbBlockSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMemUsed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbScoopsWritten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEndScoop;
        private System.Windows.Forms.TextBox tbProcessingScoop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnCheckScoop;
        private System.Windows.Forms.TextBox tbCheckScoop;
        private System.Windows.Forms.Button btnDeleteLastScoop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbReadingBlock1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbWrittingScoop1;
    }
}

