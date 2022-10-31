using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System.Data;

namespace QLKhachSan.BUS
{
    public class CTPNKhoBUS
    {
        CTPNKhoDAO CTPNKhoDAO = new CTPNKhoDAO();

        public DataTable GetCTPNKho()
        {
            return CTPNKhoDAO.GetCTPNKho();
        }
        public DataTable GetCTPNKho(string sql)
        {
            return CTPNKhoDAO.GetCTPNKho(sql);
        }
    }
}
