using AltoHttp;
using System;
using System.IO;
using System.Windows.Forms;

namespace Download
{
    public partial class DownloadFrm : Form
    {
        public DownloadFrm()
        {
            InitializeComponent();
        }
        HttpDownloader httpDownloader;
        private void StartBtn_Click(object sender, EventArgs e)
        {
            string destPath;
            bool urlTest;
            string destFolder = ValidateHttp.GetDownloadFolder();
            string protocol;
            
            
            if (String.IsNullOrEmpty(urlTbx.Text))
                {
                MessageBox.Show("Not a wellformated URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try { 
                 Uri uri = new Uri(urlTbx.Text);
                 protocol = uri.Scheme;
            }
            catch
            {
                MessageBox.Show("Not a wellformated URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            if (protocol=="http")
            {
                urlTest = ValidateHttp.IsUrl(urlTbx.Text, true);
            }
            else
            {
                urlTest = ValidateHttp.IsUrl(urlTbx.Text);
            }
            
            if (!urlTest)
            {
                MessageBox.Show("Ivalid Url", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(folderTxb.Text.Trim()))
                {
                    destPath = $"{destFolder}\\{Path.GetFileName(urlTbx.Text)}";
                    folderTxb.Text=destFolder;
                }
            else
                {
                    destPath = $"{folderTxb.Text}\\{Path.GetFileName(urlTbx.Text)}";
                }

            httpDownloader = new HttpDownloader(urlTbx.Text, destPath);
            httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            httpDownloader.ProgressChanged   += HttpDownloader_ProgressChanged;
           
            httpDownloader.Start();
            pauseBtn.Enabled = true;
            startBtn.Enabled = false;

        }

        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar.Value  = (int)e.Progress;
            procentLbl.Text    = $"{e.Progress.ToString("0.00")} %";
            speedLbl.Text      = string.Format("{0} MB", (e.SpeedInBytes / 1048576).ToString("0.00"));
            downLoadedLbl.Text = string.Format("{0} MB", (e.TotalBytesReceived / 1048576).ToString("0.00"));
            statusLbl.Text     = "Downloading...";
        }

        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                statusLbl.Text  = "Done";
                procentLbl.Text = "100%";
                resumeBtn.Enabled = pauseBtn.Enabled= false;
                startBtn.Enabled = true;
            });
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if(httpDownloader != null)
                httpDownloader.Pause();
            resumeBtn.Enabled = true;
        }

        private void resumeBtn_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
                httpDownloader.Resume();
                resumeBtn.Enabled = false;
        }

        private void filselectBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
           
            folderTxb.Text      = folderBrowserDialog1.SelectedPath;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderTxb.Text                 = folderBrowserDialog1.SelectedPath;
                Environment.SpecialFolder root = folderBrowserDialog1.RootFolder;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
