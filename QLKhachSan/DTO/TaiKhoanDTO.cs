using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class TaiKhoanDTO
    {
        String mataikhoan, tentaikhoan, matkhau, maquyen;

        public TaiKhoanDTO()
        {
        }

        public TaiKhoanDTO(String mataikhoan, String tentaikhoan, String matkhau, String maquyen)
        {
            this.mataikhoan = mataikhoan;
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.maquyen = maquyen;
        }

        public string Mataikhoan
        {
            get { return mataikhoan; }
            set { mataikhoan = value; }
        }
        public string Tentaikhoan
        {
            get { return tentaikhoan; }
            set { tentaikhoan = value; }
        }
        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public string Maquyen
        {
            get { return maquyen; }
            set { maquyen = value; }
        }
    }
}
