
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class NhanVienDTO
    {
        string manhanvien, tennhanvien, sodienthoai, email, gioitinh, mataikhoan;
        public NhanVienDTO()
        {
        }
        public NhanVienDTO(string manhanvien, string tennhanvien, string sodienthoai,
            string email, string gioitinh, string mataikhoan)
        {
            this.manhanvien = manhanvien;
            this.tennhanvien = tennhanvien;
            this.sodienthoai = sodienthoai;
            this.email = email;
            this.gioitinh = gioitinh;
            this.mataikhoan = mataikhoan;


        }
        public string MaNhanVien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }
        public string TenNhanVien
        {
            get { return tennhanvien; }
            set { tennhanvien = value; }
        }
        public string SoDienThoai
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }



        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string GioitTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string MaTaiKhoan
        {
            get { return mataikhoan; }
            set { mataikhoan = value; }
        }
    }
}