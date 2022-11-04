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
    public class DieuChinhKho_MenuDAO: DBConnect
    {
        public DataTable getDieuChinhKho_Menu()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DieuChinhKho_Menu", conn);
            DataTable dataDieuChinhKho_Menu = new DataTable();
            da.Fill(dataDieuChinhKho_Menu);
            return dataDieuChinhKho_Menu;
        }
        public DataTable getDieuChinhKho_Menu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataDieuChinhKho_Menu = new DataTable();
            da.Fill(dataDieuChinhKho_Menu);
            return dataDieuChinhKho_Menu;
        }
        public bool ThemDieuChinhKho_Menu(DieuChinhKho_MenuDTO dck_mn)
        {
            try
            {
                // Ket noi
                conn.Open();

                string SQL = string.Format("INSERT INTO DieuChinhKho_Menu VALUES ('{0}', '{1}', {2}, {3})", dck_mn.Madieuchinhkho, dck_mn.Mamenu, dck_mn.Slthucte, dck_mn.Sldieuchinh);

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

        public bool SuaDieuChinhKho_Menu(DieuChinhKho_MenuDTO dck_mn)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format("UPDATE DieuChinhKho_Menu SET SLThucTe = {0}, " +
                    "SLDieuChinh = {1} " +
                    "WHERE MaDieuChinhKho = '{2}' " +
                    "AND MaMenu = '{3}'", dck_mn.Slthucte, dck_mn.Sldieuchinh, dck_mn.Madieuchinhkho, dck_mn.Mamenu);

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

        public bool XoaDieuChinhKho_Menu(string maDieuChinhKho)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM DieuChinhKho_Menu WHERE MaDieuChinhKho = '" + maDieuChinhKho + "'";

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
