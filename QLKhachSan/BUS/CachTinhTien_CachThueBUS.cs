using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System.Data;

namespace QLKhachSan.BUS
{
    public class CachTinhTien_CachThueBUS
    {
        CachTinhTien_CachThueDAO CachTinhTien_CachThueDAO = new CachTinhTien_CachThueDAO();

        public DataTable GetCachTinhTien_CachThue()
        {
            return CachTinhTien_CachThueDAO.getCachTinhTien_CachThue();
        }
        public DataTable GetCachTinhTien_CachThue(string sql)
        {
            return CachTinhTien_CachThueDAO.getCachTinhTien_CachThue(sql);
        }
        public bool ThemCachTinhTien_CachThue(CachTinhTien_CachThueDTO tt)
        {
            return CachTinhTien_CachThueDAO.ThemCachTinhTien_CachThue(tt);
        }
        public bool SuaCachTinhTien_CachThue(CachTinhTien_CachThueDTO tt)
        {
            return CachTinhTien_CachThueDAO.SuaCachTinhTien_CachThue(tt);
        }
        public bool XoaCachTinhTien_CachThue(string macachtinhtien, string macachthue)
        {
            return CachTinhTien_CachThueDAO.XoaCachTinhTien_CachThue(macachtinhtien, macachthue);
        }
    }
}
