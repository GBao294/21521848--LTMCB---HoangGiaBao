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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();


            name.Text = ofd.SafeFileName.ToString();

            size.Text = new FileInfo(ofd.FileName).Length.ToString();

            url.Text = fs.Name.ToString();


            linecount.Text = richTextBox1.Lines.Count().ToString();

         
            charcount.Text = (richTextBox1.Text.Length - (richTextBox1.Lines.Count() - 1)).ToString();
     
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string words;
            words = richTextBox1.Text;
            int i = 0;
            int myWords = 1;
            while (i<= words.Length-1)
            {
                if(words[i]==' '|| words[i] == '\n' || words[i] == '\t')
                {
                    myWords++;
                }
                i++;
            }
            wordcount.Text = myWords.ToString();
           

        }
        
    }
}
