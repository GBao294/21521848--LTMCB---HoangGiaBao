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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string num1Str = textBoxSoThuNhat.Text.Trim();
                string num2Str = textBoxSoThuHai.Text.Trim();
                if (num1Str.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập số thứ nhất");
                }
                if (num2Str.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập số thứ hai");
                }
                int num1, num2;
                long sum = 0;
                num1 = Int32.Parse(num1Str);
                num2 = Int32.Parse(num2Str);
                sum = num1 + num2;
                textBoxKetQua.Text = sum.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
            }
        }
    }
}
