using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO TaiKhoanDAO = new TaiKhoanDAO();

        public DataTable GetTaiKhoan()
        {
            return TaiKhoanDAO.getTaiKhoan();
        }
        public DataTable GetTaiKhoan(string sql)
        {
            return TaiKhoanDAO.getTaiKhoan(sql);
        }

        public bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            return TaiKhoanDAO.ThemTaiKhoan(tk);
        }

        public bool SuaTaiKhoan(TaiKhoanDTO tk)
        {
            return TaiKhoanDAO.SuaTaiKhoan(tk);
        }

        public bool XoaTaiKhoan(string mataikhoan)
        {
            return TaiKhoanDAO.XoaTaiKhoan(mataikhoan);
        }
        public string TaoMaTaiKhoan()
        {
            string maloaiphong = TaiKhoanDAO.TaoMaTaiKhoan();
            return maloaiphong;
        }
    }
}
