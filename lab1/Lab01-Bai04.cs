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
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        private void buttonChuyenDoi_Click(object sender, EventArgs e)
        {
            string num1Str = textBoxSoTienCanDoi.Text.Trim();

            if (num1Str.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền cần đổi");
            }


            if (comboBoxChonLoaiTien.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn mệnh giá tiền cần đổi");
                textBoxSoTienCanDoi.Text = "";
                textBoxSoTienDaDoi.Text = "";
                textBoxTyGiaQuyDoi.Text = "";
            }




            try
            {
                int inputMoney = Int32.Parse(num1Str);
                if (comboBoxChonLoaiTien.Text == "USD (Đô-la Mỹ)")
                {
                    textBoxSoTienDaDoi.Text = (inputMoney * 22.772).ToString();
                    textBoxTyGiaQuyDoi.Text = "1 USD = 22,772 VND";
                }
                else if (comboBoxChonLoaiTien.Text == "EUR (EURO)")
                {
                    textBoxSoTienDaDoi.Text = (inputMoney * 28.132).ToString();
                    textBoxTyGiaQuyDoi.Text = "1 EUR = 28,132 VND";
                }
                else if (comboBoxChonLoaiTien.Text == "GBP (Bảng Anh)")
                {
                    textBoxSoTienDaDoi.Text = (inputMoney * 31.538).ToString();
                    textBoxTyGiaQuyDoi.Text = "1 GBP = 31,538 VND";
                }
                else if (comboBoxChonLoaiTien.Text == "SGD (Đô-la Singapore)")
                {
                    textBoxSoTienDaDoi.Text = (inputMoney * 17.286).ToString();
                    textBoxTyGiaQuyDoi.Text = "1 SGD = 17,286 VND";
                }
                else
                {
                    textBoxSoTienDaDoi.Text = (inputMoney * 214).ToString();
                    textBoxTyGiaQuyDoi.Text = "1 JPY = 214 VND";
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
            }
        }
    }
}
