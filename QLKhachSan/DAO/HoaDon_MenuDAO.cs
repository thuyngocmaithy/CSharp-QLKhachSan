using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKhachSan.DTO;

namespace QLKhachSan.DAO
{
    internal class HoaDon_MenuDAO: DBConnect
    {
        public DataTable getHoaDon_Menu()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDon_Menu", conn);
            DataTable dataHoaDon_Menu = new DataTable();
            da.Fill(dataHoaDon_Menu);
            return dataHoaDon_Menu;
        }
        public DataTable getHoaDon_Menu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataHoaDon_Menu = new DataTable();
            da.Fill(dataHoaDon_Menu);
            return dataHoaDon_Menu;
        }
        public bool ThemHoaDon_Menu(HoaDon_MenuDTO hd_mn)
        {
            try
            {
                // Ket noi
                conn.Open();

                string SQL = string.Format("INSERT INTO HoaDon_Menu VALUES ('{0}', '{1}', '{2}')", hd_mn.Mamenu, hd_mn.Mahoadon, hd_mn.Sl);

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
        public bool SuaHoaDon_Menu(HoaDon_MenuDTO hd_mn)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format("UPDATE HoaDon_Menu SET SL = {0} WHERE MaHoaDon = '{1}' AND MaMenu = '{2}'", hd_mn.Sl, hd_mn.Mahoadon, hd_mn.Mamenu);

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

        public bool XoaHoaDon_Menu(string mahoadon, string mamenu)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM HoaDon_Menu WHERE MaHoaDon = '" + mahoadon + "' AND MaMenu = '"+mamenu+"'";

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
        public bool XoaHoaDon_Menu()
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM HoaDon_Menu";

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
