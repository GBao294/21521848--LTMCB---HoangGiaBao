using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text= sr.ReadToEnd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  FileStream fs = new FileStream("thuchanh.txt", FileMode.CreateNew);
            StreamWriter sw = new StreamWriter("output.txt",true);
             sw.WriteLine(richTextBox1.Text.ToUpper());
             sw.Close();
          
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
