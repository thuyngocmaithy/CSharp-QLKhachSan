using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.DAO
{
    public class CTPhieuKiemKhoDAO : DBConnect
    {

        public DataTable GetCTPhieuKiemKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CTPhieuKiemKho", conn);
            DataTable dataCTPhieuKiemKho = new DataTable();
            da.Fill(dataCTPhieuKiemKho);
            return dataCTPhieuKiemKho;
        }
        public DataTable GetCTPhieuKiemKho(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataCTPhieuKiemKho = new DataTable();
            da.Fill(dataCTPhieuKiemKho);
            return dataCTPhieuKiemKho;
        }
    }
}
