using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTichDiem_TNK47_Buoi3
{
    internal class QuanLyKhachHang
    {
        public List<KhachHang> DsKhachHang { get; set; }

        public QuanLyKhachHang()
        {
            DsKhachHang = new List<KhachHang>();
        }

        public void ThemKhachHang(KhachHang kh)
        {
            DsKhachHang.Add(kh);
        }

        public KhachHang Tim1KhachHangTheoSDT(string sdt)
        {
            KhachHang kq = null;
            foreach (var kh in DsKhachHang)
            {
                if (kh.Sdt == sdt)
                {
                    kq = kh;
                    break;
                }
            }
            return kq;
        }

        public List<KhachHang> TimKhachHangTheoHoTen(string hoTen)
        {
            List<KhachHang> kq = new List<KhachHang>();
            foreach (var kh in DsKhachHang)
            {
                if (kh.HoTen.ToLower().Contains(hoTen.ToLower()))
                {
                    kq.Add(kh);
                }
            }
            return kq;
        }

        public List<KhachHang> TimKhachHangTheoSDT(string sdt)
        {
            List<KhachHang> kq = new List<KhachHang>();
            foreach (var kh in DsKhachHang)
            {
                if (kh.Sdt.Contains(sdt))
                {
                    kq.Add(kh);
                }
            }
            return kq;
        }

        public void DocTuFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length >= 3)
                    {
                        KhachHang kh = new KhachHang();
                        kh.Sdt = parts[0].Trim();
                        kh.HoTen = parts[1].Trim();
                        kh.DiemTL = int.Parse(parts[2].Trim());

                        // Đọc thêm các cột mở rộng nếu file có dữ liệu
                        if (parts.Length >= 6)
                        {
                            kh.MaGiaDinh = parts[3].Trim();
                            kh.TongChiTieu12Thang = decimal.Parse(parts[4].Trim());
                            kh.SoLuotMua12Thang = int.Parse(parts[5].Trim());
                        }

                        ThemKhachHang(kh);
                    }
                }
            }
        }

        public void GhiXuongFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var kh in DsKhachHang)
                {
                    string maGiaDinh = string.IsNullOrEmpty(kh.MaGiaDinh) ? "" : kh.MaGiaDinh;
                    string line = kh.Sdt + "," + kh.HoTen + "," + kh.DiemTL + "," + maGiaDinh + "," + kh.TongChiTieu12Thang + "," + kh.SoLuotMua12Thang;
                    writer.WriteLine(line);
                }
            }
        }
    }
}
