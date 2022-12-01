using QLKhachSan.DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QLKhachSan
{
    public class ThietLapKhacDAO : DBConnect
    {
        public DataTable getThietLapKhac()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ThietLapKhac", conn);
            DataTable dataThietLapKhac = new DataTable();
            da.Fill(dataThietLapKhac);
            return dataThietLapKhac;
        }
        public DataTable getThietLapKhac(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataThietLapKhac = new DataTable();
            da.Fill(dataThietLapKhac);
            return dataThietLapKhac;
        }
        //tự động cập nhập thời gian

        /// Sửa
        public bool SuaThietLapKhac(ThietLapKhacDTO tlk)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format("UPDATE ThietLapKhac SET DiaChi = '{0}', SDT = '{1}', ThoiGian = '{2}'  WHERE TenKhachSan = '{3}'", tlk.Diachi, tlk.Sdt, tlk.Thoigian, tlk.Tenkhachsan);

                // Command (mặc định command type = text).
                SqlCommand cmd = new SqlCommand(SQL, conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                conn.Close();
            }

            return false;
        }
    }
}
