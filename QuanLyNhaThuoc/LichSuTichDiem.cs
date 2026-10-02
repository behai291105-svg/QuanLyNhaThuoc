using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc
{
    internal class LichSuTichDiem
    {
        public string MaGD {  get; set; }
        public string Sdt { get; set; }
        public DateTime NgayGD { get; set; }
        public int SoDiemNhan { get; set; }
        public int SoDiemConLai { get; set; }

        public LichSuTichDiem(string maGD, string sdt, DateTime ngayGD, int soDiemNhan, int soDiemConLai)
        {
            MaGD = maGD;
            Sdt = sdt;
            NgayGD = ngayGD;
            SoDiemNhan = soDiemNhan;
            SoDiemConLai = soDiemConLai;
        }
    }
}
