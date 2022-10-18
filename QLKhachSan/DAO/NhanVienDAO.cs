using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    public class NhanVienDAO : DBConnect
    {

        public DataTable getNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            DataTable dataLoaiPhong = new DataTable();
            da.Fill(dataLoaiPhong);
            return dataLoaiPhong;
        }
     
    }
}
