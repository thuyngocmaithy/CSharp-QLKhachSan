using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.DAO
{
    public class DieuChinhKhoDAO : DBConnect
    {

        public DataTable getDieuChinhKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DieuChinhKho", conn);
            DataTable dataDieuChinhKho = new DataTable();
            da.Fill(dataDieuChinhKho);
            return dataDieuChinhKho;
        }
        public DataTable getDieuChinhKho(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataDieuChinhKho = new DataTable();
            da.Fill(dataDieuChinhKho);
            return dataDieuChinhKho;
        }
        /// Thêm
        public bool ThemDieuChinhKho(DieuChinhKhoDTO dck)
        {
            try
            {
                // Ket noi
                conn.Open();
                //Viết SQL thiếu dấu 
                //Sai thứ tự sql
                //Bớt báo lại
                string SQL = string.Format("INSERT INTO DieuChinhKho VALUES ('{0}', '{1}', '{2}')", dck.MaDieuChinhKho, dck.ThoiGianDieuChinh, dck.TongSLDieuChinh);
                MessageBox.Show(SQL);
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

        public bool XoaDieuChinhKho(string madieuchinhkho)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM DieuChinhKho WHERE MaDieuChinhKho = '" + madieuchinhkho + "'";

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
        public string TaoMaDieuChinhKho()
        {
            conn.Open();
            string sql = "SELECT * FROM DieuChinhKho";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string ma = "";

            if (dataTable.Rows.Count <= 0)
            {
                ma = "DCK001";
            }
            else
            {
                int number;

                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(3));

                ma = String.Format("DCK{0:000}", number + 1);
            }
            return ma;
        }
    }
}
