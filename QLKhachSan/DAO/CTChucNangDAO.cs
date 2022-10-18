using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;

namespace QLKhachSan
{
    public class CTChucNangDAO : DBConnect
    {
        ConvertDataTableToList dataTableToList = new ConvertDataTableToList();

        public DataTable getCTChucNang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CTChucNang", conn);
            DataTable dataCTChucNang = new DataTable();
            da.Fill(dataCTChucNang);
            return dataCTChucNang;
        }
        public DataTable getCTChucNang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataCTChucNang = new DataTable();
            da.Fill(dataCTChucNang);
            return dataCTChucNang;
        }
        public List<CTChucNangDTO> list()
        {
            DataTable dataCTChucNang = getCTChucNang();     
            List<CTChucNangDTO> list = new List<CTChucNangDTO>();
            list = dataTableToList.ConvertDataTable<CTChucNangDTO>(dataCTChucNang);
            return list;
        }
    }
}