using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System.Data;

namespace QLKhachSan.BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO HoaDonDAO = new HoaDonDAO();

        public DataTable GetHoaDon()
        {
            return HoaDonDAO.getHoaDon();
        }
        public DataTable GetHoaDon(string sql)
        {
            return HoaDonDAO.getHoaDon(sql);
        }
        public bool ThemHoaDon(HoaDonDTO hd)
        {
            return HoaDonDAO.ThemHoaDon(hd);
        }
        public bool SuaHoaDon(HoaDonDTO hd)
        {
            return HoaDonDAO.suaHoaDon(hd);
        }
        public bool XoaHoaDon(string maHoaDon)
        {
            return HoaDonDAO.XoaHoaDon(maHoaDon);
        }
        public string TaoMaHoaDon()
        {
            string mahoadon = HoaDonDAO.TaoMaHoaDon();
            return mahoadon;
        }
    }
}
