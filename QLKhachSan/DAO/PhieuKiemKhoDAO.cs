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
    public class PhieuKiemKhoDAO : DBConnect
    {

        public DataTable getPhieuKiemKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhieuKiemKho", conn);
            DataTable dataPhieuKiemKho = new DataTable();
            da.Fill(dataPhieuKiemKho);
            return dataPhieuKiemKho;
        }
        public DataTable getPhieuKiemKho(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataPhieuKiemKho = new DataTable();
            da.Fill(dataPhieuKiemKho);
            return dataPhieuKiemKho;
        }
        /// Thêm
        public bool ThemPhieuKiemKho(PhieuKiemKhoDTO kk)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("INSERT INTO PhieuKiemKho VALUES ('{0}', '{1}', '{2}')", kk.MaPhieuKiemKho, kk.ThoiGianTaoPhieu, kk.TaiKhoanTaoPhieu);
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
        public string TaoMaPhieuKiemKho()
        {
            conn.Open();
            string sql = "SELECT * FROM PhieuKiemKho";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string ma = "";

            if (dataTable.Rows.Count <= 0)
            {
                ma = "PKK001";
            }
            else
            {
                int number;

                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(3));

                ma = String.Format("PKK{0:000}", number + 1);
            }
            return ma;
        }
    }
}
