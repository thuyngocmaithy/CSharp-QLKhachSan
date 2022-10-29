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
    public class CachTinhTien_CachThueDAO:DBConnect
    {
        public DataTable getCachTinhTien_CachThue()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CachTinhTien_CachThue", conn);
            DataTable dataCachTinhTien_CachThue = new DataTable();
            da.Fill(dataCachTinhTien_CachThue);
            return dataCachTinhTien_CachThue;
        }
        public DataTable getCachTinhTien_CachThue(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataCachTinhTien_CachThue = new DataTable();
            da.Fill(dataCachTinhTien_CachThue);
            return dataCachTinhTien_CachThue;
        }
        /// Thêm
        public bool ThemCachTinhTien_CachThue(CachTinhTien_CachThueDTO tt)
        {
            try
            {
                // Ket noi
                conn.Open();

                string SQL = string.Format("INSERT INTO CachTinhTien_CachThue VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", tt.Macachtinhtien, tt.Macachthue, tt.Giatheocachthue, tt.Gionhanphong, tt.Giotraphong);

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

        /// Sửa

        public bool SuaCachTinhTien_CachThue(CachTinhTien_CachThueDTO tt)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format(
                "UPDATE CachTinhTien_CachThue SET GiaTheoCachThue = '{0}', GioNhanPhong = '{1}', GioTraPhong = '{2}' " +
                "WHERE MaCachTinhTien = '{3}' AND MaCachThue = '{4}'"
                , tt.Giatheocachthue, tt.Gionhanphong, tt.Giotraphong, tt.Macachtinhtien, tt.Macachthue);

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

        /// Xóa

        public bool XoaCachTinhTien_CachThue(string macachtinhtien, string macachthue)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM CachTinhTien_CachThue " +
                    "WHERE MaCachTinhTien = '" + macachtinhtien + "' " +
                    "AND MaCachThue = '"+macachthue+"'";

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
