using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLKhachSan.BUS
{
    public class CachtinhtienBUS
    {
        CachtinhtienDAO cachtinhtienDAO = new CachtinhtienDAO();
        public List<CachtinhtienDTO> dsCachtinhtien;
        public DataTable GetCachtinhtien()
        {
            return cachtinhtienDAO.getCachtinhtien();
        }
        public DataTable GetCachtinhtien(string sql)
        {
            return cachtinhtienDAO.getCachtinhtien(sql);
        }
    }
}