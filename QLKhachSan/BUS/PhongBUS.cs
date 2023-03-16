using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLKhachSan.BUS
{
    public class PhongBUS
    {
        PhongDAO phongDAO = new PhongDAO();
       
        public DataTable GetPhong()
        {
            return phongDAO.getPhong();
        }
        public DataTable GetPhong(string sql)
        {
            return phongDAO.getPhong(sql);
        }

        public bool ThemPhong(PhongDTO p)
        {
            return phongDAO.ThemPhong(p);
        }

        public bool SuaPhong(PhongDTO p)
        {
            return phongDAO.SuaPhong(p);
        }
        public bool SuaPhong(string maphong, string tinhtrang)
        {
            return phongDAO.SuaPhong(maphong, tinhtrang);
        }
        public bool XoaPhong(string maPhong)
        {
            return phongDAO.XoaPhong(maPhong);
        }
        public string TaoMaPhong()
        {
            string maPhong = phongDAO.TaoMaPhong();
            return maPhong;
        }
       
    }
}
