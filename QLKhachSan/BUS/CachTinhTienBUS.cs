using QLKhachSanDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKhachSanDTO;
using QLKhachSan.DAO;
using QLKhachSan.DTO;

namespace QLKhachSan.BUS
{
   public class CachtinhtienBUS
    {
        
        CachTinhTienDAO cachTinhTienDAO = new CachTinhTienDAO();
        public DataTable GetCachTinhTien()
        {
            return cachTinhTienDAO.GetCachTinhTien();
        }
        public DataTable GetCachTinhTien(string sql)
        {
            return cachTinhTienDAO.GetCachTinhTien(sql);
        }

        public string TaoMaCachTinhtien()
        {
            string macachtinhtien =  cachTinhTienDAO.TaoMaCachTinhTien();
            return macachtinhtien;

        }
        public bool ThemCachTinhTien(CachTinhTienDTO cachtinhtien)
            
        {
            return cachTinhTienDAO.ThemCachtinhtien(cachtinhtien);
        }

        public bool SuaCachTinhtien(CachTinhTienDTO cachtinhtien)
        {
            return cachTinhTienDAO.SuaCachTinhTien(cachtinhtien);
        }
        public bool XoaCachTinhTien(string macachtinhtien)
        {
            return cachTinhTienDAO.XoaCachTinhTien(macachtinhtien);

        }
    }
} 
