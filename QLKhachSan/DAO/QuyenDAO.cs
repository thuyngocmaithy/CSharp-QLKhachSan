using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKhachSan.DTO;
using System.Collections;
using System.Data.OleDb;
using System.Windows.Forms;

namespace QLKhachSan.DAO
{
    public class QuyenDAO : DBConnect
    {
        public DataTable getQuyen()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Quyen", conn);
            DataTable dataQuyen = new DataTable();
            da.Fill(dataQuyen);
            return dataQuyen;
        }
        public DataTable getQuyen(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataQuyen = new DataTable();
            da.Fill(dataQuyen);
            return dataQuyen;
        }
        /// Thêm
        public bool ThemQuyen(QuyenDTO quyen)
        {
            try
            {
                // Ket noi
                conn.Open();

                string SQL = string.Format("INSERT INTO Quyen VALUES ('{0}', '{1}')", quyen.Maquyen, quyen.Tenquyen);

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
        public bool SuaQuyen(QuyenDTO quyen)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format("UPDATE Quyen SET TenQuyen = N'{0}' WHERE  MaQuyen='{1}'", quyen.Tenquyen, quyen.Maquyen);

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
        public bool XoaQuyen(string maquyen)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM Quyen WHERE MaQuyen = '" + maquyen + "'";

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

        //Xóa quyen - chuc nang //
        public bool XoaQuyenChucNang(String maquyen)
        {
            try
            {
                // Ket noi
                conn.Open();
                string sqldelete = string.Format("DELETE FROM Quyen_ChucNang WHERE MaQuyen = '" + maquyen + "'");
                SqlCommand cmddl = new SqlCommand(sqldelete, conn);
                if (cmddl.ExecuteNonQuery() > 0)
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
        //Thêm quyen-chuc nang //
        public bool ThemQuyenChucNang(String maquyen, String chucnang)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("INSERT INTO Quyen_ChucNang VALUES ('{0}', '{1}')", maquyen, chucnang);
                // Command (mặc định command type = text).
                SqlCommand cmd = new SqlCommand(SQL, conn);
                           
                    //    //// Query và kiểm tra
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                    //}
                
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
        //lấy ds chuc nang thuoc quyen
        public DataTable getChucnang(string maquyen) {
            string sql = string.Format("SELECT DISTINCT MaChucNang from Quyen_ChucNang WHERE MaQuyen = '" + maquyen + "'", conn);
            // Command (mặc định command type = text).
           // SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dataCN = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dataCN);
            return dataCN;

        }
        //load cmb
        public DataTable GetTbl()
        {
            conn.Open();
            string ChuoiSQL = "select * from Quyen " ;
            DataTable tbl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(ChuoiSQL, conn);
            da.Fill(tbl);
            return tbl;
        }
        public string TaoMaQuyen()
        {
            conn.Open();
            string sql = "SELECT * FROM Quyen";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string ma = "";

            if (dataTable.Rows.Count <= 0)
            {
                ma = "Q001";
            }
            else
            {
                int number;
                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(1));

                ma = String.Format("Q{0:000}", number + 1);
            }
            return ma;
        }
    }
}