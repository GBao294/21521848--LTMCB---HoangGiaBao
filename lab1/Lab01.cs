namespace Lab01
{
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void Lab01_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 l = new Lab01_Bai03();
            this.Hide();
            l.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab01_Bai04 l = new Lab01_Bai04();
            this.Hide();
            l.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 l = new Lab01_Bai05();
            this.Hide();
            l.ShowDialog();
            this.Show();
        }
    }
}