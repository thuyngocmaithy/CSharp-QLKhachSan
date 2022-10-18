using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLKhachSan
{
    public class PhieuDatPhongDAO : DBConnect
    {
        public DataTable getPhieuDatPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhieuDatPhong", conn);
            DataTable dataPhieuDatPhong = new DataTable();
            da.Fill(dataPhieuDatPhong);
            return dataPhieuDatPhong;
        }
        public DataTable getPhieuDatPhong(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataPhieuDatPhong = new DataTable();
            da.Fill(dataPhieuDatPhong);
            return dataPhieuDatPhong;
        }

    }
}
