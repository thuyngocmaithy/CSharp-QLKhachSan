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
    public class CTPNKhoDAO : DBConnect
    {

        public DataTable GetCTPNKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CTPNKho", conn);
            DataTable dataCTPNKho = new DataTable();
            da.Fill(dataCTPNKho);
            return dataCTPNKho;
        }
        public DataTable GetCTPNKho(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataCTPNKho = new DataTable();
            da.Fill(dataCTPNKho);
            return dataCTPNKho;
        }
        public bool ThemCTPNKho(CTPNKhoDTO ctpnk)
        {
            try
            {
                // Ket noi
                conn.Open();

                string SQL = string.Format("INSERT INTO CTPNKho VALUES ('{0}', '{1}', '{2}')", ctpnk.MaPNKho, ctpnk.MaMenu, ctpnk.SL);

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
        public bool SuaCTPNKho(CTPNKhoDTO ctpnkho)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format("UPDATE CTPNKho SET SL = '{0}' " +
                    "WHERE MaPNKho = '{1}' " +
                    "AND MaMenu = '{2}'", ctpnkho.SL, ctpnkho.MaPNKho, ctpnkho.MaMenu);

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

        public bool XoaCTPNKho(string mapnkho)
        {
    
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM CTPNKho " +
                    "WHERE MaPNKho = '" + mapnkho + "'";

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
