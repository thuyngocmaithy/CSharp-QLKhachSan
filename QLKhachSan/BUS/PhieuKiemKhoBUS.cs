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
    public class PhieuKiemKhoBUS
    {
        PhieuKiemKhoDAO PhieuKiemKhoDAO = new PhieuKiemKhoDAO();

        public DataTable GetPhieuKiemKho()
        {
            return PhieuKiemKhoDAO.getPhieuKiemKho();
        }
        public DataTable GetPhieuKiemKho(string sql)
        {
            return PhieuKiemKhoDAO.getPhieuKiemKho(sql);
        }

        public bool ThemPhieuKiemKho(PhieuKiemKhoDTO kk)
        {
            return PhieuKiemKhoDAO.ThemPhieuKiemKho(kk);
        }
        public string TaoMaPhieuKiemKho()
        {
            string maphieukiemkho = PhieuKiemKhoDAO.TaoMaPhieuKiemKho();
            return maphieukiemkho;
        }
    }
}
