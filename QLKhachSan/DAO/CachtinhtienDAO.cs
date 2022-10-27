using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLKhachSan
{
    public class CachtinhtienDAO : DBConnect
    {
        public DataTable getCachtinhtien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CachTinhTien", conn);
            DataTable dataCachtinhtien = new DataTable();
            da.Fill(dataCachtinhtien);
            return dataCachtinhtien;
        }
        public DataTable getCachtinhtien(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataCachtinhtien = new DataTable();
            da.Fill(dataCachtinhtien);
            return dataCachtinhtien;
        }

    }
}
