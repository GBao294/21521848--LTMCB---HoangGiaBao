using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV
{
    [Serializable]
    public class SinhVien
    {
        public string HoTen { get; set; }
        public int MSSV { get; set; }
        public string DienThoai { get; set; }
        public float DiemMon1 { get; set; }
        public float DiemMon2 { get; set; }
        public float DiemMon3 { get; set; }
        public float DiemTrungBinh { get; set; }
    }
   
}
