using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLKhachSan.BUS
{
    public class ChucNangBUS
    {
        ChucNangDAO loaiPhongDAO = new ChucNangDAO();
        public List<ChucNangDTO> dsChucNang;
        public DataTable GetChucNang()
        {
            return loaiPhongDAO.getChucNang();
        }
        public DataTable GetChucNang(string sql)
        {
            return loaiPhongDAO.getChucNang(sql);
        }
    }
}