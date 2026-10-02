using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc
{
    internal class KhoVouCher
    {
        public string Sdt { get; set; }
        public string LoaiVoucher { get; set; }
        public int GhiChu { get; set; }

        public KhoVouCher(string sdt, string loaiVoucher, int ghiChu)
        {
            Sdt = sdt;
            LoaiVoucher = loaiVoucher;
            GhiChu = ghiChu;
        }
    }
}
