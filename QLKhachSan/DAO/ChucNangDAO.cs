using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    public class ChucNangDAO : DBConnect
    {
        public DataTable getChucNang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChucNang", conn);
            DataTable dataChucNang = new DataTable();
            da.Fill(dataChucNang);
            return dataChucNang;
        }
        public DataTable getChucNang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataChucNang = new DataTable();
            da.Fill(dataChucNang);
            return dataChucNang;
        }
    }
}
