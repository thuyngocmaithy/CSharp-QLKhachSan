using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLKhachSan.BUS
{
    public class PhieuDatPhongBUS
    {
        PhieuDatPhongDAO loaiPhongDAO = new PhieuDatPhongDAO();
        public List<PhieuDatPhongDTO> dsPhieuDatPhong;
        public DataTable GetPhieuDatPhong()
        {
            return loaiPhongDAO.getPhieuDatPhong();
        }
        public DataTable GetPhieuDatPhong(string sql)
        {
            return loaiPhongDAO.getPhieuDatPhong(sql);
        }
    }
}