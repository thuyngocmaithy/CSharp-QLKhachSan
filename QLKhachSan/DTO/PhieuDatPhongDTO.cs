using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class PhieuDatPhongDTO
    {
        string maphieudatphong, hotenkhachhang, sodienthoai, thoigiandat, ngaynhanphong,
            ngaytraphong, tientratruoc, ghichu, trangthai;
        public PhieuDatPhongDTO(string maphieudatphong, string hotenkhachhang, string sodienthoai, string thoigiandat, string ngaynhanphong, string ngaytraphong, string tientratruoc, string ghichu, string trangthai)
        {
            this.maphieudatphong = maphieudatphong;
            this.hotenkhachhang = hotenkhachhang;
            this.sodienthoai = sodienthoai;
            this.thoigiandat = thoigiandat;
            this.ngaynhanphong = ngaynhanphong;
            this.ngaytraphong = ngaytraphong;
            this.tientratruoc = tientratruoc;
            this.ghichu = ghichu;
            this.trangthai = trangthai;
        }
        public PhieuDatPhongDTO()
        {

        }
        public string Maphieudatphong
        {
            get { return this.maphieudatphong; }
            set { maphieudatphong = value; }
        }
        public string Hotenkhachhang
        {
            get { return this.hotenkhachhang; }
            set { hotenkhachhang = value; }
        }
        public string Sodienthoai
        {
            get { return this.sodienthoai; }
            set { sodienthoai = value; }
        }
        public string Thoigiandat
        {
            get { return this.thoigiandat; }
            set { thoigiandat = value; }
        }
        public string Ngaynhanphong
        {
            get { return this.ngaynhanphong; }
            set { ngaynhanphong = value; }
        }
        public string Ngaytraphong
        {
            get { return this.ngaytraphong; }
            set { ngaytraphong = value; }
        }
        public string Tientratruoc
        {
            get { return this.tientratruoc; }
            set { tientratruoc = value; }
        }
        public string Ghichu
        {
            get { return this.ghichu; }
            set { ghichu = value; }
        }
        public string Trangthai
        {
            get { return this.trangthai; }
            set { trangthai = value; }
        }
    }

}
