using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System.Data;
namespace QLKhachSan.BUS
{
    public class PhongBUS
    {
        PhongDAO PhongDAO = new PhongDAO();

        public DataTable GetPhong()
        {
            return PhongDAO.getPhong();
        }
        public DataTable GetPhong(string sql)
        {
            return PhongDAO.getPhong(sql);
        }

        public bool ThemPhong(PhongDTO p)
        {
            return PhongDAO.ThemPhong(p);
        }

        public bool SuaPhong(PhongDTO p)
        {
            return PhongDAO.SuaPhong(p);
        }

        public bool XoaPhong(string maPhong)
        {
            return PhongDAO.XoaPhong(maPhong);
        }
        public string TaoMaPhong()
        {
            string maPhong = PhongDAO.TaoMaPhong();
            return maPhong;
        }
    }
}
