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
using System.Collections;
namespace Lab2
{
    public partial class bai3 : Form
    {
        public bai3()
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
            sr.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pheptoan();
            xuatfile();
         
        }
        private double tinh(string contents)
        {
            DataTable tb = new DataTable();
            return Convert.ToDouble(tb.Compute(contents, String.Empty));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void pheptoan()
        {
            Stack MyStack = new Stack();
            string words;
            words = richTextBox1.Text;
            string text = "";

            for (int j = 0; j < words.Length;)
            {

                while ((j < words.Length && words[j] != '\n' && words[j] != '\t'))
                {
                    text += words[j];
                    j++;
                }
                MyStack.Push(text);
                text = "";
                j++;
            }
            richTextBox1.Text = "";
            int length = MyStack.Count;
            textBox1.Text = length.ToString();

            for (int i =0; i < length; i++) 
            {
                string k = MyStack.Pop().ToString();
                //richTextBox1.Text += tinh("1+2+3").ToString() +" = \n";
                try
                {
                    richTextBox1.Text += k + " = " + tinh(k).ToString() + "  \n";
                }
                catch
                {
                    MessageBox.Show(k + "Khong tinh duoc");
                }
            }

        }
        private void xuatfile()
        {
            StreamWriter sw = new StreamWriter("output3.txt", true);
            sw.WriteLine(richTextBox1.Text);
            MessageBox.Show("Đã xuất file kết quả dưới tên output3");
            sw.Close();

        }

    }


    }

