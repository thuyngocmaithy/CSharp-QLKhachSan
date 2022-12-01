
using QLKhachSan.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLKhachSan
{
    public class LoaiPhongDAO : DBConnect
    {

        public DataTable getLoaiPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LoaiPhong", conn);
            DataTable dataLoaiPhong = new DataTable();
            da.Fill(dataLoaiPhong);
            return dataLoaiPhong;
        }
        public DataTable getLoaiPhong(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataLoaiPhong = new DataTable();
            da.Fill(dataLoaiPhong);
            return dataLoaiPhong;
        }
        /// Thêm
        public bool ThemLoaiPhong(LoaiPhongDTO lp)
        {
            try
            {
                // Ket noi
                conn.Open();

                string SQL = string.Format("INSERT INTO LoaiPhong VALUES ('{0}', '{1}', '{2}')", lp.Maloaiphong, lp.Tenloaiphong, lp.Uutienhienthi);

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

        public bool SuaLoaiPhong(LoaiPhongDTO lp)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format("UPDATE LoaiPhong SET TenLoaiPhong = '{0}' WHERE MaLoaiPhong = '{1}'", lp.Tenloaiphong, lp.Maloaiphong);

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

        public bool XoaLoaiPhong(string maloaiphong)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM LoaiPhong WHERE MaLoaiPhong = '" + maloaiphong +"'"; 

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
        public string TaoMaloaiphong()
        {
            conn.Open();
            string sql = "SELECT * FROM LoaiPhong";
            SqlCommand cmd = new SqlCommand(sql, conn);  
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string ma = "";
          
            if(dataTable.Rows.Count<=0)
            {
                ma = "LP001";
            }    
            else
            {
                int number;
                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(2));
                
                ma = String.Format("LP{0:000}", number+1);
            }
            return ma;
        }
    }

}
