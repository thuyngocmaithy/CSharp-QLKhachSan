using QLKhachSan.DTO;
using System.Data;

namespace QLKhachSan.BUS
{
    public class ThietLapKhacBUS
    {
        ThietLapKhacDAO ThietLapKhacDAO = new ThietLapKhacDAO();

        public DataTable GetThietLapKhac()
        {
            return ThietLapKhacDAO.getThietLapKhac();
        }

        public DataTable GetThietLapKhac(string sql)
        {
            return ThietLapKhacDAO.getThietLapKhac(sql);
        }

        public bool SuaThietLapKhac(ThietLapKhacDTO tlk)
        {
            return ThietLapKhacDAO.SuaThietLapKhac(tlk);
        }
    }
}