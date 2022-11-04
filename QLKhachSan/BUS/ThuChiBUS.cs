using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKhachSan.DTO;
using QLKhachSan.DAO;

namespace QLKhachSan.BUS
{
    public class ThuChiBUS
    {
        ThuChiDAO ThuChiDAO = new ThuChiDAO();

        public DataTable GetPhieuThuChi()
        {
            return ThuChiDAO.getPhieuThuChi();
        }
        public DataTable GetPhieuThuChi(string sql)
        {
            return ThuChiDAO.getPhieuThuChi(sql);
        }

        public bool ThemThuChi(ThuChiDTO tc)
        {
            return ThuChiDAO.ThemThuChi(tc);
        }

        public bool SuaThuChi(ThuChiDTO tc)
        {
            return ThuChiDAO.SuaThuChi(tc);
        }

        public bool XoaThuChi(string maphieuthuchi)
        {
            return ThuChiDAO.XoaThuChi(maphieuthuchi);
        }
        public string TaoMaPhieuThuChi()
        {
            string maphieuthuchi = ThuChiDAO.TaoMaPhieuThuChi();
            return maphieuthuchi;
        }
    }
}
