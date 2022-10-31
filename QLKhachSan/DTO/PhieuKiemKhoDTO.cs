using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class PhieuKiemKhoDTO
    {
        string maphieukiemkho, thoigiantaophieu, taikhoantaophieu;
        public PhieuKiemKhoDTO()
        {
        }
        public PhieuKiemKhoDTO(string maphieukiemkho, string thoigiantaophieu, string taikhoantaophieu)
        {
            this.maphieukiemkho = maphieukiemkho;
            this.thoigiantaophieu = thoigiantaophieu;
            this.taikhoantaophieu = taikhoantaophieu;
        }
        public string MaPhieuKiemKho
        {
            get { return maphieukiemkho; }
            set { maphieukiemkho = value; }
        }
        public string ThoiGianTaoPhieu
        {
            get { return thoigiantaophieu; }
            set { thoigiantaophieu = value; }
        }
        public string TaiKhoanTaoPhieu
        {
            get { return taikhoantaophieu; }
            set { taikhoantaophieu = value; }
        }
    }
}
