using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLKhachSan.BUS
{
    public class PhieuDatPhongBUS
    {
        PhieuDatPhongDAO phieuDatPhongDAO = new PhieuDatPhongDAO();
        public List<PhieuDatPhongDTO> dsPhieuDatPhong;
        public DataTable GetPhieuDatPhong()
        {
            return phieuDatPhongDAO.getPhieuDatPhong();
        }
        public DataTable GetPhieuDatPhong(string sql)
        {
            return phieuDatPhongDAO.getPhieuDatPhong(sql);
        }
        public bool ThemPhieuDatPhong(PhieuDatPhongDTO pdp)
        {
            return phieuDatPhongDAO.ThemPhieuDatPhong(pdp);
        }
        public bool SuaPhieuDatPhong(PhieuDatPhongDTO pdp)
        {
            return phieuDatPhongDAO.SuaPhieuDatPhong(pdp);
        }
        public bool SuaPhieuDatPhong(string maphieudatphong)
        {
            return phieuDatPhongDAO.SuaPhieuDatPhong(maphieudatphong);
        }
        public bool XoaPhieuDatPhong(string maphieudatphong)
        {
            return phieuDatPhongDAO.XoaPhieuDatPhong(maphieudatphong);
        }
        public string TaoMaPhieuDatPhong()
        {
            string ma = phieuDatPhongDAO.TaoMaPhieuDatPhong();
            return ma;
        }
    }
}