using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaThuoc
{
    internal class LichSuTichDiem
    {
        public string Sdt { get; set; }
        public int SoDiemNhan { get; set; }
        public int SoDiemConLai { get; set; }

        public int SoLuongTV {  get; set; }

        public int 

        public LichSuTichDiem(string sdt, DateTime ngayGD, int soDiemNhan, int soDiemConLai)
        {
            Sdt = sdt;
            NgayGD = ngayGD;
            SoDiemNhan = soDiemNhan;
            SoDiemConLai = soDiemConLai;
        }
    }
}
