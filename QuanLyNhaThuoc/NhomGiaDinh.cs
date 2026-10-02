using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc
{
    internal class NhomGiaDinh
    {
        public string MaGiaDinh { get; set; }
        public DateTime NgayThanhLap { get; set; }

        public NhomGiaDinh(string maGiaDinh, DateTime ngayThanhLap)
        {
            MaGiaDinh = maGiaDinh;
            NgayThanhLap = ngayThanhLap;
        }
    }
}
