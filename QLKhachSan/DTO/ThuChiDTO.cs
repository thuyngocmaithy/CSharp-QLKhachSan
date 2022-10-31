using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class ThuChiDTO
    {
        string maphieuthuchi, thoigian, loaihinh, sotien, noidung;
        public ThuChiDTO()
        {
        }
        public ThuChiDTO(string maphieuthuchi, string thoigian, string loaihinh, string sotien, string noidung)
        {
            this.maphieuthuchi = maphieuthuchi;
            this.thoigian = thoigian;
            this.loaihinh = loaihinh;
            this.sotien = sotien;
            this.noidung = noidung;
        }
        public string MaPhieuThuChi
        {
            get { return maphieuthuchi; }
            set { maphieuthuchi = value; }
        }
        public string ThoiGian
        {
            get { return thoigian; }
            set { thoigian = value; }
        }
        public string LoaiHinh
        {
            get { return loaihinh; }
            set { loaihinh = value; }
        }
        public string SoTien
        {
            get { return sotien; }
            set { sotien = value; }
        }
        public string NoiDung
        {
            get { return noidung; }
            set { noidung = value; }
        }
    }
}
