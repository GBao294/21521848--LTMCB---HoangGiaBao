using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Upload : Form
    {
        ftp ftpclient;
        string filename;
        public Upload(ftp ftp)
        {
            InitializeComponent();
            ftpclient = ftp;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                    filename = ofd.SafeFileName;
                }
            }
        }


        private async void buttonUpload_Click(object sender, EventArgs e)
        {

            try
            {

                {
                    ftpclient.ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + ftpclient.host + "/" + filename);
                    ftpclient.ftpRequest.Credentials = new NetworkCredential(ftpclient.user, ftpclient.pass);
                    ftpclient.ftpRequest.UseBinary = true;
                    ftpclient.ftpRequest.UsePassive = true;
                    ftpclient.ftpRequest.KeepAlive = true;
                    ftpclient.ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                    ftpclient.ftpStream = ftpclient.ftpRequest.GetRequestStream();
                    using (FileStream localFileStream = new FileStream(textBox1.Text.Trim(), FileMode.Open))
                    {
                        byte[] byteBuffer = new byte[ftpclient.bufferSize];
                        int bytesRead = await localFileStream.ReadAsync(byteBuffer, 0, ftpclient.bufferSize);
                        Panel panel = new Panel();
                        panel.Width = 200;
                        panel.Height = 20;
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        ProgressBar prog = new ProgressBar();
                        prog.Width = 200;
                        prog.Height = 20;
                        panel.Controls.Add(prog);

                        Label nameLabel = new Label();
                        nameLabel.Text = filename;
                        nameLabel.Dock = DockStyle.Top;
                        nameLabel.TextAlign = ContentAlignment.TopLeft;
                        flowLayoutPanel1.Controls.Add(nameLabel);
                        flowLayoutPanel1.Controls.Add(panel);

                        try
                        {
                            while (bytesRead != 0)
                            {
                                await ftpclient.ftpStream.WriteAsync(byteBuffer, 0, bytesRead);
                                bytesRead = await localFileStream.ReadAsync(byteBuffer, 0, ftpclient.bufferSize);
                                double percent = (double)localFileStream.Position / localFileStream.Length * 100;
                                prog.Value = ((int)percent);

                            }
                            MessageBox.Show("Upload file thành công");
                        }
                        catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    }

                    //ftpclient.ftpStream.Close();
                    ftpclient.ftpRequest = null;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Upload_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}