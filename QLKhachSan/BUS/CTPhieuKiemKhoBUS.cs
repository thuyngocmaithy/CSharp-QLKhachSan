using QLKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.BUS
{
    public class CTPhieuKiemKhoBUS
    {
        CTPhieuKiemKhoDAO CTPhieuKiemKhoDAO = new CTPhieuKiemKhoDAO();

        public DataTable GetCTPhieuKiemKho()
        {
            return CTPhieuKiemKhoDAO.GetCTPhieuKiemKho();
        }
        public DataTable GetCTPhieuKiemKho(string sql)
        {
            return CTPhieuKiemKhoDAO.GetCTPhieuKiemKho(sql);
        }
    }
}
