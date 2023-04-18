using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 b1 = new Bai1();
            b1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 b2 = new Bai2();
            b2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                bai3 b3 = new bai3();
                b3.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bai4 b4 = new bai4();
            b4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai5 b5 = new Bai5();
            b5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bai6 b6 = new bai6();
            b6.Show();
        }
    }
}
