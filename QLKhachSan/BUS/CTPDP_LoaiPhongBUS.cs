using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLKhachSan.BUS
{
    public class CTPDP_LoaiPhongBUS
    {
        CTPDP_LoaiPhongDAO ctpdp_lpDAO = new CTPDP_LoaiPhongDAO();
        public DataTable GetCTPDP_LoaiPhong()
        {
            return ctpdp_lpDAO.getCTPDP_LoaiPhong();
        }
        public DataTable GetCTPDP_LoaiPhong(string sql)
        {
            return ctpdp_lpDAO.getCTPDP_LoaiPhong(sql);
        }
        public bool ThemCTPDP_LoaiPhong(CTPDP_LoaiPhongDTO ctpdp_lp)
        {
            return ctpdp_lpDAO.ThemCTPDP_LoaiPhong(ctpdp_lp);
        }
        public bool SuaCTPDP_LoaiPhong(CTPDP_LoaiPhongDTO ctpdp_lp)
        {
            return ctpdp_lpDAO.SuaCTPDP_LoaiPhong(ctpdp_lp);
        }
        public bool XoaCTPDP_LoaiPhong(string maphieudatphong)
        {
            return ctpdp_lpDAO.XoaCTPDP_LoaiPhong(maphieudatphong);
        }
        public string TaoMaCTPhieuDatPhong_LoaiPhong()
        {
            string ma = ctpdp_lpDAO.TaoMaCTPhieuDatPhong_LoaiPhong();
            return ma;
        }
    }
}