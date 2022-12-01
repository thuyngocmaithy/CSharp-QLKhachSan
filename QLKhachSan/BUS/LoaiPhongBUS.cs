using QLKhachSan.DTO;

using System.Data;

namespace QLKhachSan.BUS
{
    public class LoaiPhongBUS
    {
        LoaiPhongDAO LoaiPhongDAO = new LoaiPhongDAO();

        public DataTable GetLoaiPhong()
        {
            return LoaiPhongDAO.getLoaiPhong();
        }
        public DataTable GetLoaiPhong(string sql)
        {
            return LoaiPhongDAO.getLoaiPhong(sql);
        }

        public bool ThemLoaiPhong(LoaiPhongDTO lp)
        {
            return LoaiPhongDAO.ThemLoaiPhong(lp);
        }

        public bool SuaLoaiPhong(LoaiPhongDTO lp)
        {
            return LoaiPhongDAO.SuaLoaiPhong(lp);
        }

        public bool XoaLoaiPhong(string maloaiphong)
        {
            return LoaiPhongDAO.XoaLoaiPhong(maloaiphong);
        }
        public string TaoMaLoaiPhong()
        {
            string maloaiphong = LoaiPhongDAO.TaoMaloaiphong();
            return maloaiphong;
        }
    }
}
