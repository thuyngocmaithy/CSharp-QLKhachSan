using QLKhachSan.DTO;
using System.Data;

namespace QLKhachSan.BUS
{
    public class CTPDP_PhongBUS
    {
        CTPDP_PhongDAO ctpdp_pDAO = new CTPDP_PhongDAO();
        public DataTable GetCTPDP_Phong()
        {
            return ctpdp_pDAO.getCTPDP_Phong();
        }
        public DataTable GetCTPDP_Phong(string sql)
        {
            return ctpdp_pDAO.getCTPDP_Phong(sql);
        }
        public bool ThemCTPDP_Phong(CTPDP_PhongDTO ctpdp_p)
        {
            return ctpdp_pDAO.ThemCTPDP_Phong(ctpdp_p);
        }
        public bool SuaCTPDP_Phong(CTPDP_PhongDTO ctpdp_p)
        {
            return ctpdp_pDAO.SuaCTPDP_Phong(ctpdp_p);
        }
        public bool XoaCTPDP_Phong(string maphieudatphong)
        {
            return ctpdp_pDAO.XoaCTPDP_Phong(maphieudatphong);
        }
        public string TaoMaCTPhieuDatPhong_Phong()
        {
            string ma = ctpdp_pDAO.TaoMaCTPhieuDatPhong_Phong();
            return ma;
        }
    }
}