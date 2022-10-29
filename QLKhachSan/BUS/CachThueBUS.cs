
using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLKhachSan.BUS
{
    public class CachThueBUS
    {
        CachThueDAO CachThueDAO = new CachThueDAO();
        public DataTable GetCachThue()
        {
            return CachThueDAO.GetCachthue();
        }
        public DataTable GetCachThue(string sql)
        {
            return CachThueDAO.GetCachthue(sql);
        }
    }
}