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
    public class CTPNKhoDAO : DBConnect
    {

        public DataTable GetCTPNKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CTPNKho", conn);
            DataTable dataCTPNKho = new DataTable();
            da.Fill(dataCTPNKho);
            return dataCTPNKho;
        }
        public DataTable GetCTPNKho(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataCTPNKho = new DataTable();
            da.Fill(dataCTPNKho);
            return dataCTPNKho;
        }
    }
}
