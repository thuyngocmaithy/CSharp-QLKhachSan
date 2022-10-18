using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class KhoDTO
    {
        string maphieunhapkho, ghichu, manhanvien, thoigiannhap;
        int uutienhienthi;
        public KhoDTO()
        {
        }
        public KhoDTO(string maphieunhapkho, string ghichu, string manhanvien, string thoigiannhap,  int uutienhienthi)
        {
            this.maphieunhapkho = maphieunhapkho;
            this.ghichu = ghichu;
            this.manhanvien = manhanvien;
            this.thoigiannhap = thoigiannhap;
            this.uutienhienthi = uutienhienthi;
        }
        public string MaPNKho
        {
            get { return maphieunhapkho; }
            set { maphieunhapkho = value; }
        }
        public string GhiChu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
        public string MaNhanVien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }
        public string ThoiGianNhap
        {
            get { return thoigiannhap; }
            set { thoigiannhap = value; }
        }
        public int Uutienhienthi
        {
            get { return uutienhienthi; }
            set { uutienhienthi = value; }
        }
    }
}
