using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SV;



namespace Lab2
{
   
    public partial class bai4 : Form
    {
          List<SinhVien> ds = new List<SinhVien>();
        public bai4()
        {
            InitializeComponent();
          
        }

        private void bai4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();

            if (txtphone.Text.Length != 10 || !txtphone.Text.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }

            if (txtid.Text.Length != 8)
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ!");
                return;
            }

            try
            {
                Convert.ToSingle(txtc1.Text);
                Convert.ToSingle(txtc2.Text);
                Convert.ToSingle(txtc3.Text);
                if (Convert.ToSingle(txtc1.Text) < 0 || Convert.ToSingle(txtc1.Text) > 10 || Convert.ToSingle(txtc2.Text) < 0 || Convert.ToSingle(txtc2.Text) > 10 || float.Parse(txtc3.Text) < 0 || float.Parse(txtc3.Text) > 10)
                {
                    MessageBox.Show("Điểm không hợp lệ!");
                    return;
                }
                sv.HoTen = txtname.Text;
                sv.MSSV = Convert.ToInt32(txtid.Text);
                sv.DienThoai = txtphone.Text;
                sv.DiemMon1 = Convert.ToSingle(txtc1.Text);
                sv.DiemMon2 = Convert.ToSingle(txtc2.Text);
                sv.DiemMon3 = Convert.ToSingle(txtc3.Text);
                ds.Add(sv);
                MessageBox.Show("Nhập thông tin sinh viên thành công!");
                richTextBox1.Text += txtname.Text + "\n";
                richTextBox1.Text += txtid.Text + "\n";
                richTextBox1.Text += txtphone.Text + "\n";
                richTextBox1.Text += txtc1.Text + "\n";
                richTextBox1.Text += txtc2.Text + "\n";
                richTextBox1.Text += txtc3.Text + "\n";
                richTextBox1.Text += txtav.Text + "\n";
            }
            catch { MessageBox.Show("Điểm phải là số"); }



           
        }





      

        private void button1_Click(object sender, EventArgs e)
        {
                 // Ghi danh sách sinh viên xuống file "input4.txt"
                GhiDanhSachSinhVien(ds, "input4.txt");
                MessageBox.Show("Ghi danh sách sinh viên vào file thành công!");

        }









        int i =0;
       
        private void XuatDanhSachSinhVien(List<SinhVien> dsSinhVien,int i)
        {

            


            SinhVien sinhVien = ds[i]; // Chỉ số bắt đầu từ 0, nên sinh viên thứ 2 có chỉ số là 1

            name.Text = sinhVien.HoTen.ToString();
            id.Text = sinhVien.MSSV.ToString();
            phone.Text = sinhVien.DienThoai.ToString();
            c1.Text = sinhVien.DiemMon1.ToString();
            c2.Text = sinhVien.DiemMon2.ToString();
            c3.Text = sinhVien.DiemMon3.ToString();
            float k = (sinhVien.DiemMon1 + sinhVien.DiemMon2 + sinhVien.DiemMon3) / 3;
            avg.Text = "0";
            // Hiển thị thông tin của sinh viên thứ i
            MessageBox.Show($"Thông tin sinh viên \n"+
                $"Họ tên: {sinhVien.HoTen}\n" +
                $"MSSV: {sinhVien.MSSV}\n" +
                $"Điện thoại: {sinhVien.DienThoai}\n" +
                $"Điểm môn 1: {sinhVien.DiemMon1}\n" +
                $"Điểm môn 2: {sinhVien.DiemMon2}\n" +
                $"Điểm môn 3: {sinhVien.DiemMon3}\n" +
                $"Điểm trung bình: {k}") ;
            i += 1;
            label15.Text = i.ToString();
            i--;


        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Đọc danh sách sinh viên từ file "input4.txt"
                ds = DocDanhSachSinhVien("input4.txt");
                foreach (SinhVien sv in ds)
                {
                    sv.DiemTrungBinh = (sv.DiemMon1 + sv.DiemMon2 + sv.DiemMon3) / 3;
                }
                MessageBox.Show("Đọc danh sách sinh viên từ file thành công!, đồng thời xuất ra output4 cần thiết");

                GhiDanhSachSinhVien(ds, "output4.txt");
                XuatDanhSachSinhVien(ds, i);
            }
            catch { }

        }
        
        

        private void button4_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
              
                    i -= 1;
                   
                try { XuatDanhSachSinhVien(ds, i); }
                catch { }
            
            }
            else
                MessageBox.Show("không thể lùi nữa");
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (i < ds.Count-1)
            {
              
                i += 1;
                try { XuatDanhSachSinhVien(ds, i); }
                catch { }
            }
            else
                MessageBox.Show("không thể tiến nữa");
            
        }




        private List<SinhVien> DocDanhSachSinhVien(string tenFile)
        {
            List<SinhVien> dsSinhVien;
            using (FileStream fileStream = new FileStream(tenFile, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                dsSinhVien = (List<SinhVien>)binaryFormatter.Deserialize(fileStream);
            }
            return dsSinhVien;
        }
        private void GhiDanhSachSinhVien(List<SinhVien> dsSinhVien, string tenFile)
        {
            using (FileStream fileStream = new FileStream(tenFile, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, dsSinhVien);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }
        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
