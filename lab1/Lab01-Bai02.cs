using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int FindMax(int num1, int num2, int num3)
        {
            int max;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    max = num1;
                }
                else
                {
                    max = num3;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    max = num2;
                }
                else
                {
                    max = num3;
                }
            }
            return max;
        }

        private int FindMin(int num1, int num2, int num3)
        {
            int min;
            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    min = num3;
                }
                else
                {
                    min = num2;
                }
            }
            else
            {
                if (num1 > num3)
                {
                    min = num3;
                }
                else
                {
                    min = num1;
                }
            }
            return min;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string num1Str = textBoxSoThuNhat.Text.Trim();
            string num2Str = textBoxSoThuHai.Text.Trim();
            string num3Str = textBoxSoThuBa.Text.Trim();
            if (num1Str.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số thứ nhất");
            }
            if (num2Str.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số thứ hai");
            }
            if (num3Str.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số thứ ba");
            }

            try
            {
                int num1, num2, num3, max, min;
                num1 = Convert.ToInt32(num1Str);
                num2 = Convert.ToInt32(num2Str);
                num3 = Convert.ToInt32(num3Str);
                max = FindMax(num1, num2, num3);
                min = FindMin(num1, num2, num3);
                textBoxSoLonNhat.Text = max.ToString();
                textBoxSoNhoNhat.Text = min.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxSoThuNhat.Text = "";
            textBoxSoThuHai.Text = "";
            textBoxSoThuBa.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
