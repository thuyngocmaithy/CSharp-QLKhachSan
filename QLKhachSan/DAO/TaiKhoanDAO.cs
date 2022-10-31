using QLKhachSan.DTO;
using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLKhachSan.DAO
{
    public class TaiKhoanDAO : DBConnect
    {
        public DataTable getTaiKhoan()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TaiKhoan", conn);
            DataTable dataLoaiPhong = new DataTable();
            da.Fill(dataLoaiPhong);
            return dataLoaiPhong;
        }
        public DataTable getTaiKhoan(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataLoaiPhong = new DataTable();
            da.Fill(dataLoaiPhong);
            return dataLoaiPhong;
        }
        /// Thêm
        public bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            try
            {
                // Ket noi
                conn.Open();

                string SQL = string.Format("INSERT INTO TaiKhoan VALUES ('{0}', '{1}', '{2}' ,'{3}')", tk.Mataikhoan, tk.Tentaikhoan, tk.Matkhau, tk.Maquyen);

                // Command (mặc định command type = text).
                SqlCommand cmd = new SqlCommand(SQL, conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
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

        public bool SuaTaiKhoan(TaiKhoanDTO tk)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format("UPDATE TaiKhoan SET TenTaiKhoan = '{0}' , MatKhau ='{1}' , MaQuyen='{2}' WHERE MaTaiKhoan = '{3}'", tk.Tentaikhoan, tk.Matkhau, tk.Maquyen, tk.Mataikhoan);

                // Command (mặc định command type = text).
                SqlCommand cmd = new SqlCommand(SQL, conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
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

        public bool XoaTaiKhoan(string mataikhoan)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM TaiKhoan WHERE MaTaiKhoan = '" + mataikhoan + "'";

                // Command (mặc định command type = text).
                SqlCommand cmd = new SqlCommand(SQL, conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

            }
            finally
            {
                // Dong ket noi
                conn.Close();
            }

            return false;
        }
        public string TaoMaTaiKhoan()
        {
            conn.Open();
            string sql = "SELECT * FROM TaiKhoan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string ma = "";

            if (dataTable.Rows.Count <= 0)
            {
                ma = "TK001";
            }
            else
            {
                int number;
                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(2));

                ma = String.Format("TK{0:000}", number + 1);
            }
            return ma;
        }
    }
}
