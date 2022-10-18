using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLKhachSan
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
