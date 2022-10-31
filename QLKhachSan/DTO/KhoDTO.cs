using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class KhoDTO
    {
        string maphieunhapkho, ghichu, mataikhoan, thoigiannhap;
        int uutienhienthi;
        public KhoDTO()
        {
        }
        public KhoDTO(string maphieunhapkho, string thoigiannhap, string mataikhoan, string ghichu,  int uutienhienthi)
        {
            this.maphieunhapkho = maphieunhapkho;
            this.thoigiannhap = thoigiannhap ;
            this.mataikhoan = mataikhoan;
            this.ghichu = ghichu;
            this.uutienhienthi = uutienhienthi;
        }
        public string MaPNKho
        {
            get { return maphieunhapkho; }
            set { maphieunhapkho = value; }
        }
        public string ThoiGianNhap
        {
            get { return thoigiannhap; }
            set { thoigiannhap = value; }
        }
        public string MaTaiKhoan
        {
            get { return mataikhoan; }
            set { mataikhoan = value; }
        }
        public string GhiChu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
        public int Uutienhienthi
        {
            get { return uutienhienthi; }
            set { uutienhienthi = value; }
        }
    }
}
