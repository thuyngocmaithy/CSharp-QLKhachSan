using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLKhachSan.BUS
{
    public class CTChucNangBUS
    {
        CTChucNangDAO ctcnDAO = new CTChucNangDAO();
        public List<CTChucNangDTO> dsCTChucNang;
        public DataTable GetCTChucNang()
        {
            return ctcnDAO.getCTChucNang();
        }
        public DataTable GetCTChucNang(string sql)
        {
            return ctcnDAO.getCTChucNang(sql);
        }
        public List<CTChucNangDTO> list()
        {
            dsCTChucNang = new List<CTChucNangDTO>();
            dsCTChucNang = ctcnDAO.list();
            return dsCTChucNang;
        }
    }
}