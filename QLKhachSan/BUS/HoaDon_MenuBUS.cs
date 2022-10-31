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
    internal class HoaDon_MenuBUS
    {
        HoaDon_MenuDAO HoaDon_MenuDAO = new HoaDon_MenuDAO();
        public List<HoaDon_MenuDTO> dsHoaDon_Menu;
        public DataTable GetHoaDon_Menu()
        {
            return HoaDon_MenuDAO.getHoaDon_Menu();
        }
        public DataTable GetHoaDon_Menu(string sql)
        {
            return HoaDon_MenuDAO.getHoaDon_Menu(sql);
        }
        public bool ThemHoaDon_Menu(HoaDon_MenuDTO hd_mn)
        {
            return HoaDon_MenuDAO.ThemHoaDon_Menu(hd_mn);
        }
        public bool SuaHoaDon_Menu(HoaDon_MenuDTO hd_mn)
        {
            return HoaDon_MenuDAO.SuaHoaDon_Menu(hd_mn);
        }
        public bool XoaHoaDon_Menu()
        {
            return HoaDon_MenuDAO.XoaHoaDon_Menu();
        }
        public bool XoaHoaDon_Menu(string mahoadon, string mamenu)
        {
            return HoaDon_MenuDAO.XoaHoaDon_Menu(mahoadon, mamenu);
        }
    }
}
