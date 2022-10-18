using QLKhachSan.DTO;
using QLKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLKhachSan.BUS
{
    public class NhanVienBUS
    {
       NhanVienDAO nhanVienDAO = new NhanVienDAO();

        public DataTable GetNhanVien()
        {
            return nhanVienDAO.getNhanVien();
        }
 
    }
}
