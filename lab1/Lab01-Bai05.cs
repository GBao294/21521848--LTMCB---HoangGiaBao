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
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBoxNhapA.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập A");
            }

            if (textBoxNhapB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập B");
            }


            try
            {
                int a = Int32.Parse(textBoxNhapA.Text.Trim());
                int b = Int32.Parse(textBoxNhapB.Text.Trim());
                int afactorial = 1, bfactorial = 1, s1 = 0, s2 = 0;
                double s3 = 0;
                for (int i = 1; i <= a; i++)
                {
                    afactorial *= i;
                }
                textBoxKetQua1.Text = "A! = " + afactorial.ToString();

                for (int i = 1; i <= b; i++)
                {
                    bfactorial *= i;
                }
                textBoxKetQua2.Text = "B! = " + bfactorial.ToString();

                if (a <= 1)
                {
                    textBoxKetQua3.Text = "S1 = A = " + a.ToString();
                }
                else if (a == 2)
                {
                    textBoxKetQua3.Text = "S1 = 1 + A = 3";
                }
                else if (a == 3)
                {
                    textBoxKetQua3.Text = "S1 = 1 + 2 + A = 6";
                }
                else if (a == 4)
                {
                    textBoxKetQua3.Text = "S1 = 1 + 2 + 3 + A = 10";
                }
                else if (a == 5)
                {
                    textBoxKetQua3.Text = "S1 = 1 + 2 + 3 + 4 + A = 15";
                }
                else if (a > 5)
                {
                    for (int i = 1; i <= a; i++)
                    {
                        s1 += i;
                    }
                    textBoxKetQua3.Text = "S1 = 1 + 2 + 3 + 4 + ... + A = " + s1.ToString();
                }



                if (b <= 1)
                {
                    textBoxKetQua4.Text = "S2 = B = " + b.ToString();
                }
                else if (b == 2)
                {
                    textBoxKetQua4.Text = "S2 = 1 + B = 3";
                }
                else if (b == 3)
                {
                    textBoxKetQua4.Text = "S2 = 1 + 2 + B = 6";
                }
                else if (b == 4)
                {
                    textBoxKetQua4.Text = "S2 = 1 + 2 + 3 + B = 10";
                }
                else if (b == 5)
                {
                    textBoxKetQua4.Text = "S2 = 1 + 2 + 3 + 4 + B = 15";
                }
                else if (b > 5)
                {
                    for (int i = 1; i <= b; i++)
                    {
                        s2 += i;
                    }
                    textBoxKetQua4.Text = "S2 = 1 + 2 + 3 + 4 + ... + B = " + s2.ToString();
                }






                for (int i = 1; i <= b; i++)
                {
                    s3 += Math.Pow(a, i);
                }



                if (b == 0)
                {
                    textBoxKetQua5.Text = "S3 = A^0 = 1";
                }
                else if (b == 1)
                {
                    textBoxKetQua5.Text = "S3 = A^B = " + a.ToString();
                }
                else if (b == 2)
                {
                    textBoxKetQua5.Text = "S3 = A^1 + A^B = " + s3.ToString();
                }
                else if (b == 3)
                {
                    textBoxKetQua5.Text = "S3 = A^1 + A^2 + A^B = " + s3.ToString();
                }
                else if (b == 4)
                {
                    textBoxKetQua5.Text = "S3 = A^1 + A^2 + A^3 + A^B = " + s3.ToString();
                }
                else if (b == 5)
                {
                    textBoxKetQua5.Text = "S3 = A^1 + A^2 + A^3 + A^4 + A^5 = " + s3.ToString();
                }
                else if (b > 5)
                {
                    textBoxKetQua5.Text = "S3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = " + s3.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxNhapA.Text = "";
            textBoxNhapB.Text = "";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
