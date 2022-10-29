using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKhachSanDTO;
using QLKhachSan.DTO;

namespace QLKhachSan.DAO
{
    public class CachThueDAO : DBConnect
    {
        public DataTable GetCachthue()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CachThue", conn);
            DataTable dataCachthue = new DataTable();
            da.Fill(dataCachthue);
            return dataCachthue;
        }

        public DataTable GetCachthue(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable resultCachthue = new DataTable();
            da.Fill(resultCachthue);
            return resultCachthue;
        }



    }
}
