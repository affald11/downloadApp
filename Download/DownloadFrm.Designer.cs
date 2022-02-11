namespace Download
{
    partial class DownloadFrm
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
            this.startBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.urlTbx = new System.Windows.Forms.TextBox();
            this.urlLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.resumeBtn = new System.Windows.Forms.Button();
            this.procentLbl = new System.Windows.Forms.Label();
            this.downLoadedLbl1 = new System.Windows.Forms.Label();
            this.downLoadedLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.speedLbl = new System.Windows.Forms.Label();
            this.folderTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.filselectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(500, 144);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "&Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(67, 86);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(699, 28);
            this.progressBar.TabIndex = 1;
            // 
            // urlTbx
            // 
            this.urlTbx.Location = new System.Drawing.Point(67, 9);
            this.urlTbx.Name = "urlTbx";
            this.urlTbx.Size = new System.Drawing.Size(699, 20);
            this.urlTbx.TabIndex = 2;
            // 
            // urlLbl
            // 
            this.urlLbl.AutoSize = true;
            this.urlLbl.Location = new System.Drawing.Point(12, 9);
            this.urlLbl.Name = "urlLbl";
            this.urlLbl.Size = new System.Drawing.Size(23, 13);
            this.urlLbl.TabIndex = 3;
            this.urlLbl.Text = "Url:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status:";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(587, 70);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(25, 13);
            this.statusLbl.TabIndex = 5;
            this.statusLbl.Text = "???";
            // 
            // pauseBtn
            // 
            this.pauseBtn.Enabled = false;
            this.pauseBtn.Location = new System.Drawing.Point(581, 144);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(75, 23);
            this.pauseBtn.TabIndex = 6;
            this.pauseBtn.Text = "&Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // resumeBtn
            // 
            this.resumeBtn.Enabled = false;
            this.resumeBtn.Location = new System.Drawing.Point(662, 144);
            this.resumeBtn.Name = "resumeBtn";
            this.resumeBtn.Size = new System.Drawing.Size(75, 23);
            this.resumeBtn.TabIndex = 7;
            this.resumeBtn.Text = "&Resume";
            this.resumeBtn.UseVisualStyleBackColor = true;
            this.resumeBtn.Click += new System.EventHandler(this.resumeBtn_Click);
            // 
            // procentLbl
            // 
            this.procentLbl.AutoSize = true;
            this.procentLbl.Location = new System.Drawing.Point(722, 70);
            this.procentLbl.Name = "procentLbl";
            this.procentLbl.Size = new System.Drawing.Size(34, 13);
            this.procentLbl.TabIndex = 8;
            this.procentLbl.Text = "% MB";
            // 
            // downLoadedLbl1
            // 
            this.downLoadedLbl1.AutoSize = true;
            this.downLoadedLbl1.Location = new System.Drawing.Point(72, 154);
            this.downLoadedLbl1.Name = "downLoadedLbl1";
            this.downLoadedLbl1.Size = new System.Drawing.Size(70, 13);
            this.downLoadedLbl1.TabIndex = 9;
            this.downLoadedLbl1.Text = "Downloaded:";
            // 
            // downLoadedLbl
            // 
            this.downLoadedLbl.AutoSize = true;
            this.downLoadedLbl.Location = new System.Drawing.Point(162, 154);
            this.downLoadedLbl.Name = "downLoadedLbl";
            this.downLoadedLbl.Size = new System.Drawing.Size(32, 13);
            this.downLoadedLbl.TabIndex = 10;
            this.downLoadedLbl.Text = "0 MB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Speed:";
            // 
            // speedLbl
            // 
            this.speedLbl.AutoSize = true;
            this.speedLbl.Location = new System.Drawing.Point(162, 190);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(35, 13);
            this.speedLbl.TabIndex = 12;
            this.speedLbl.Text = "0 M/s";
            // 
            // folderTxb
            // 
            this.folderTxb.Enabled = false;
            this.folderTxb.Location = new System.Drawing.Point(67, 36);
            this.folderTxb.Name = "folderTxb";
            this.folderTxb.Size = new System.Drawing.Size(670, 20);
            this.folderTxb.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select file\r\nlocation";
            // 
            // filselectBtn
            // 
            this.filselectBtn.Image = global::Download.Properties.Resources.pil1;
            this.filselectBtn.Location = new System.Drawing.Point(737, 35);
            this.filselectBtn.Name = "filselectBtn";
            this.filselectBtn.Size = new System.Drawing.Size(29, 21);
            this.filselectBtn.TabIndex = 15;
            this.filselectBtn.UseVisualStyleBackColor = true;
            this.filselectBtn.Click += new System.EventHandler(this.filselectBtn_Click);
            // 
            // DownloadFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filselectBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.folderTxb);
            this.Controls.Add(this.speedLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.downLoadedLbl);
            this.Controls.Add(this.downLoadedLbl1);
            this.Controls.Add(this.procentLbl);
            this.Controls.Add(this.resumeBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlLbl);
            this.Controls.Add(this.urlTbx);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.startBtn);
            this.Name = "DownloadFrm";
            this.Text = "Download Any File";           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox urlTbx;
        private System.Windows.Forms.Label urlLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button resumeBtn;
        private System.Windows.Forms.Label procentLbl;
        private System.Windows.Forms.Label downLoadedLbl1;
        private System.Windows.Forms.Label downLoadedLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label speedLbl;
        private System.Windows.Forms.TextBox folderTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button filselectBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

