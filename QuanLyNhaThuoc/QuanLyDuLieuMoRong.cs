using QuanLyTichDiem_TNK47_Buoi3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc
{
    internal class QuanLyDuLieuMoRong
    {
        public List<LichSuTichDiem> DsLichSuTichDiem { get; set; }
        public List<KhoVouCher> DsKhoVoucher { get; set; }
        public List<NhomGiaDinh> DsNhomGiaDinh { get; set; }

        public QuanLyDuLieuMoRong()
        {
            DsLichSuTichDiem = new List<LichSuTichDiem>();
            DsKhoVoucher = new List<KhoVouCher>();
            DsNhomGiaDinh = new List<NhomGiaDinh>();
        }

        // ==========================================
        // THUẬT TOÁN ĐỌC FILE (KHÔNG DÙNG LINQ)
        // ==========================================
        public void DocFileLichSuTichDiem(string filePath)
        {
            if (File.Exists(filePath))
            {
                DsLichSuTichDiem.Clear();
                string[] lines = File.ReadAllLines(filePath);

                // Dùng vòng lặp for truyền thống
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length >= 5)
                    {
                        string maGD = parts[0].Trim();
                        string sdt = parts[1].Trim();
                        DateTime ngayGD;
                        DateTime.TryParse(parts[2].Trim(), out ngayGD);
                        int diemNhan = int.Parse(parts[3].Trim());
                        int diemConLai = int.Parse(parts[4].Trim());

                        DsLichSuTichDiem.Add(new LichSuTichDiem(maGD, sdt, ngayGD, diemNhan, diemConLai));
                    }
                }
            }
        }

        // ==========================================
        // CÁC HÀM NGHIỆP VỤ BẰNG VÒNG LẶP FOREACH
        // ==========================================

        // 1. Lọc danh sách điểm còn hạn (24 tháng) và còn điểm của 1 SĐT
        public List<LichSuTichDiem> LayDiemKhaDungCuaKhach(string sdt)
        {
            List<LichSuTichDiem> ketQua = new List<LichSuTichDiem>();
            DateTime han24Thang = DateTime.Now.AddMonths(-24);

            foreach (LichSuTichDiem ls in DsLichSuTichDiem)
            {
                // Điều kiện: Đúng SĐT + Còn điểm > 0 + Ngày GD nằm trong 24 tháng qua
                if (ls.Sdt == sdt && ls.SoDiemConLai > 0 && ls.NgayGD >= han24Thang)
                {
                    ketQua.Add(ls);
                }
            }

            // Thuật toán sắp xếp nổi bọt (Bubble Sort) để ưu tiên trừ điểm cũ trước (Không dùng OrderBy của LINQ)
            for (int i = 0; i < ketQua.Count - 1; i++)
            {
                for (int j = 0; j < ketQua.Count - 1 - i; j++)
                {
                    if (ketQua[j].NgayGD > ketQua[j + 1].NgayGD)
                    {
                        // Hoán vị
                        LichSuTichDiem temp = ketQua[j];
                        ketQua[j] = ketQua[j + 1];
                        ketQua[j + 1] = temp;
                    }
                }
            }

            return ketQua;
        }

        // 2. Tìm tất cả voucher của một khách hàng
        public List<KhoVouCher> LayVoucherCuaKhach(string sdt)
        {
            List<KhoVouCher> ketQua = new List<KhoVouCher>();
            foreach (KhoVouCher vc in DsKhoVoucher)
            {
                if (vc.Sdt == sdt && vc.GhiChu > 0)
                {
                    ketQua.Add(vc);
                }
            }
            return ketQua;
        }

        public string TinhToanHangGiaDinh(string maGiaDinh, List<QuanLyTichDiem_TNK47_Buoi3.KhachHang> dsKhachHang, out decimal tongDiemChung)
        {
            tongDiemChung = 0;
            decimal tongChiTieu = 0;
            int tongLuotMua = 0;
            int soThanhVien = 0;

            foreach (var kh in dsKhachHang)
            {
                if (kh.MaGiaDinh == maGiaDinh && !string.IsNullOrEmpty(maGiaDinh))
                {
                    tongChiTieu += kh.TongChiTieu12Thang;
                    tongLuotMua += kh.SoLuotMua12Thang;
                    tongDiemChung += kh.DiemTL;
                    soThanhVien++;
                }
            }

            if (soThanhVien < 3)
            {
                return "Chưa kích hoạt (Cần 3 TV)";
            }

            decimal trungBinhDon = tongLuotMua > 0 ? tongChiTieu / tongLuotMua : 0;

            if (tongChiTieu >= 5000000 && tongLuotMua >= 12 && trungBinhDon >= 300000) return "Kim Cương";
            if (tongChiTieu >= 3000000 && tongLuotMua >= 12 && trungBinhDon >= 250000) return "Bạch Kim";
            if (tongChiTieu >= 2000000 && tongLuotMua >= 6 && trungBinhDon >= 200000) return "Vàng";
            if (tongChiTieu >= 1000000 && tongLuotMua >= 6 && trungBinhDon >= 150000) return "Titan";
            if (tongChiTieu >= 500000) return "Bạc";

            return "Thành Viên Thường";
        }

    }
}
