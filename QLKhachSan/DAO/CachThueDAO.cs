
using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLKhachSan
{
    public class CachThueDAO : DBConnect
    {
        public DataTable getCachThue()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CachThue", conn);
            DataTable dataCachThue = new DataTable();
            da.Fill(dataCachThue);
            return dataCachThue;
        }
        public DataTable getCachThue(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataCachThue = new DataTable();
            da.Fill(dataCachThue);
            return dataCachThue;
        }
    }
}