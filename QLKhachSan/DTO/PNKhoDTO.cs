using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class PNKhoDTO
    {
        string maphieunhapkho, thoigiannhap, ghichu;

        public PNKhoDTO()
        {
        }

        public PNKhoDTO(string maphieunhapkho, string thoigiannhap, string ghichu)
        {
            this.Maphieunhapkho = maphieunhapkho;
            this.Thoigiannhap = thoigiannhap;
            this.Ghichu = ghichu;
        }

        public string Maphieunhapkho { get => maphieunhapkho; set => maphieunhapkho = value; }
        public string Thoigiannhap { get => thoigiannhap; set => thoigiannhap = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
