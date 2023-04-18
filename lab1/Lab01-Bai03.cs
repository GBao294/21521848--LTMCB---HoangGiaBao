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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = "", num1Str = textBoxNhapSoNguyen.Text.Trim();
            if (num1Str.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập một số nguyên từ 0 đến 9");
            }

            try
            {
                int num1 = int.Parse(num1Str);
                switch (num1)
                {
                    case 0:
                        {
                            num = "Không";
                        }
                        break;
                    case 1:
                        {
                            num = "Một";
                        }
                        break;
                    case 2:
                        {
                            num = "Hai";
                        }
                        break;
                    case 3:
                        {
                            num = "Ba";
                        }
                        break;
                    case 4:
                        {
                            num = "Bốn";
                        }
                        break;
                    case 5:
                        {
                            num = "Năm";
                        }
                        break;
                    case 6:
                        {
                            num = "Sáu";
                        }
                        break;
                    case 7:
                        {
                            num = "Bảy";
                        }
                        break;
                    case 8:
                        {
                            num = "Tám";
                        }
                        break;
                    case 9:
                        {
                            num = "Chín";
                        }
                        break;
                }
                textBoxKetQua.Text = num;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNhapSoNguyen.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
