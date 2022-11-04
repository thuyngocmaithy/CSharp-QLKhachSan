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
    public class DieuChinhKho_MenuBUS
    {
        DieuChinhKho_MenuDAO dieuChinhKho_MenuDAO = new DieuChinhKho_MenuDAO();
        public DataTable GetDieuChinhKho_Menu()
        {
            return dieuChinhKho_MenuDAO.getDieuChinhKho_Menu();
        }
        public DataTable GetDieuChinhKho_Menu(string sql)
        {
            return dieuChinhKho_MenuDAO.getDieuChinhKho_Menu(sql);
        }
        public bool ThemDieuChinhKho_Menu(DieuChinhKho_MenuDTO dt)
        {
            return dieuChinhKho_MenuDAO.ThemDieuChinhKho_Menu(dt);
        }

        public bool SuaDieuChinhKho_Menu(DieuChinhKho_MenuDTO dt)
        {
            return dieuChinhKho_MenuDAO.SuaDieuChinhKho_Menu(dt);
        }

        public bool XoaDieuChinhKho_Menu(string maDieuChinhKho_Menu)
        {
            return dieuChinhKho_MenuDAO.XoaDieuChinhKho_Menu(maDieuChinhKho_Menu);
        }
    }
}
