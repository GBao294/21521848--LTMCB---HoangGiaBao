using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            string inputFile = "input5.txt";
            string outputZipFile = "output5.zip";
            // string outputGzFile = "output5.gz";
            

            try
            {
                // Nén tập tin input5.txt thành tập tin ZIP
                using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open))
                {
                    using (FileStream outputFileStream = new FileStream(outputZipFile, FileMode.Create))
                    {
                        using (ZipArchive archive = new ZipArchive(outputFileStream, ZipArchiveMode.Create))
                        {
                            ZipArchiveEntry entry = archive.CreateEntry("input5.txt");
                            using (Stream entryStream = entry.Open())
                            {
                                
                                // Tính tổng số byte của tập tin input5.txt
                                long totalBytes = inputFileStream.Length;
                                long processedBytes = 0;

                                // Đọc và ghi từng byte để nén
                                byte[] buffer = new byte[1024];
                                int bytesRead;
                                while ((bytesRead = inputFileStream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    entryStream.Write(buffer, 0, bytesRead);
                                    processedBytes += bytesRead;
                                    progressZip.Value = 0;
                                    // Cập nhật giá trị của ProgressBar
                                    int progressPercentage = (int)(processedBytes * 10 / totalBytes);
                                    try
                                    {
                                        while (progressPercentage <= 100) { progressZip.Value += progressPercentage; await Task.Delay(100); }
                                    }
                                    catch { }
                                   // await Task.Delay(200); // Đợi 200ms để ProgressBar được cập nhật
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Nén tập tin thành công, file output5zip ở mục debug !");

                //// Nén tập tin thành file GZ
                //using (FileStream fileStreamInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                //{
                //    using (FileStream fileStreamOutput = new FileStream(outputGzFile, FileMode.Create, FileAccess.Write))
                //    {
                //        using (GZipStream gzipStream = new GZipStream(fileStreamOutput, CompressionMode.Compress))
                //        {
                //            fileStreamInput.CopyTo(gzipStream);

                //        }
                //    }

                //}

                //MessageBox.Show("Nén tập tin thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            // Ẩn ProgressBar sau khi hoàn thành quá trình nén
            //progressZip.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rs();
            string fileName = "output5.zip";
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            string extractDirectory = Directory.GetCurrentDirectory();

            // Gọi phương thức giải nén với progress bar
            UnzipFile(filePath, extractDirectory);
            //try
            //{
            //    using (FileStream sourceStream = new FileStream("output5.gz", FileMode.Open))
            //    using (FileStream targetStream = File.Create(Path.Combine(extractDirectory, "output5gz.txt")))
            //    using (GZipStream gzipStream = new GZipStream(sourceStream, CompressionMode.Decompress))
            //    {
            //        gzipStream.CopyTo(targetStream);

            //    }
            //    MessageBox.Show("Giải nén file zip thành công, đồng thời xuất ra file output5gz.txt");
            //}




        }
        private async void UnzipFile(string zipFilePath, string extractPath)
        {
           
            try
            {
                using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
                {
                    long totalBytes = archive.Entries.Sum(entry => entry.Length);
                    long processedBytes = 0;

                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        string entryExtractPath = Path.Combine(extractPath, "output5.txt");
                        if (string.IsNullOrEmpty(entry.Name))
                        {
                            Directory.CreateDirectory(entryExtractPath);
                        }
                        else
                        {
                            using (Stream entryStream = entry.Open())
                            using (FileStream entryFileStream = new FileStream(entryExtractPath, FileMode.Create))
                            {
                                progressZip.Value = 0;
                                byte[] buffer = new byte[1024];
                                int bytesRead;
                                while ((bytesRead = entryStream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    entryFileStream.Write(buffer, 0, bytesRead);
                                    processedBytes += bytesRead;

                                    int progressPercentage = (int)(processedBytes * 10 / totalBytes);
                                    try
                                    {
                                        while (progressPercentage <= 100) { progressZip.Value += progressPercentage; await Task.Delay(100); }
                                    }
                                    catch { }
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Giải nén tập tin thành công, file giải nén ở Debug!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        void rs()
        {
            progressZip.Value = 0;
        }
        
    }
}
