
using QLKhachSan.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLKhachSan.BUS
{
    public class LoaiPhongBUS
    {
        LoaiPhongDAO loaiPhongDAO = new LoaiPhongDAO();
        public List<LoaiPhongDTO> dsLoaiPhong;
        public DataTable GetLoaiPhong()
        {
            return loaiPhongDAO.getLoaiPhong();
        }
        public DataTable GetLoaiPhong(string sql)
        {
            return loaiPhongDAO.getLoaiPhong(sql);
        }

        public bool ThemLoaiPhong(LoaiPhongDTO lp)
        {
            return loaiPhongDAO.ThemLoaiPhong(lp);
        }

        public bool SuaLoaiPhong(LoaiPhongDTO lp)
        {
            return loaiPhongDAO.SuaLoaiPhong(lp);
        }

        public bool XoaLoaiPhong(string maloaiphong)
        {
            return loaiPhongDAO.XoaLoaiPhong(maloaiphong);
        }
        public string TaoMaLoaiPhong()
        {
            string maloaiphong = loaiPhongDAO.TaoMaloaiphong();
            return maloaiphong;
        }
        public List<LoaiPhongDTO> list()
        {
            dsLoaiPhong = new List<LoaiPhongDTO>();
            dsLoaiPhong = loaiPhongDAO.list();
            return dsLoaiPhong;
        }
    }
}
