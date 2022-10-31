using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
/*using QLKhachSanDAO;*/
using QLKhachSanDTO;


namespace QLKhachSan.BUS
{
    public class MenuBUS
    {
        MenuDAO mnDAO = new MenuDAO();
        public DataTable GetMenu()
        {
            return mnDAO.GetMenu();
        }
        public DataTable GetMenu(string sql)
        {
            return mnDAO.GetMenu(sql);
        }
        public bool ThemMenu(MenuDTO mn)
        {
            return mnDAO.ThemMenu(mn);

        }
        public bool SuaMenu(MenuDTO mn)
        {
            return mnDAO.SuaMenu(mn);
        }
        public bool XoaMenu(string mn)
        {
            return mnDAO.XoaMenu(mn);
        }
    }
}
