using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTichDiem_TNK47_Buoi3
{
    public class KhachHang
    {
        public string Sdt { get; set; }

        public string HoTen { get; set; }

        public int DiemTL { get; set; }

        public DateTime NgaySinh { get; set; }
        public decimal TongChiTieu12Thang { get; set; }
        public int SoLuotMua12Thang { get; set; }
        public string HangThe { get; set; }
        public string MaGiaDinh { get; set; }
        public KhachHang()
        {
            Sdt = "";
            HoTen = "";
            DiemTL = 0;
            HangThe = "Bạc"; 
            TongChiTieu12Thang = 0;
            SoLuotMua12Thang = 0;
            NgaySinh = DateTime.Now;
            MaGiaDinh = "";
        }

        public KhachHang(string sdt, string hoTen, int diemTL = 0)
        {
            Sdt = sdt;
            HoTen = hoTen;
            DiemTL = diemTL;
            MaGiaDinh = "";
        }
    }
}
