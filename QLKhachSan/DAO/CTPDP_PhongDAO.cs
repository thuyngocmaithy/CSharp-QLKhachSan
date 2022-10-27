using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace QLKhachSan
{
    public class CTPDP_PhongDAO : DBConnect
    {

        public DataTable getCTPDP_Phong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CTPhieuDatPhong_Phong", conn);
            DataTable dataCTPDP_Phong = new DataTable();
            da.Fill(dataCTPDP_Phong);
            return dataCTPDP_Phong;
        }
        public DataTable getCTPDP_Phong(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataCTPDP_Phong = new DataTable();
            da.Fill(dataCTPDP_Phong);
            return dataCTPDP_Phong;

        }
        public bool ThemCTPDP_Phong(CTPDP_PhongDTO ctpdp_p)
        {
            try
            {
                // Ket noi
                conn.Open();

                string SQL = string.Format("INSERT INTO CTPhieuDatPhong_Phong VALUES ('{0}', '{1}', '{2}')", ctpdp_p.MaCTPDP_phong, ctpdp_p.Maphieudatphong, ctpdp_p.Maphong);
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
        public bool SuaCTPDP_Phong(CTPDP_PhongDTO ctpdp_p)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format("UPDATE CTPhieuDatPhong_Phong SET MaPhong = '{0}' WHERE MaPhieuDatPhong = '{1}' AND MaCTPhieuDatPhong_Phong = '{2}'", ctpdp_p.Maphong, ctpdp_p.Maphieudatphong, ctpdp_p.MaCTPDP_phong);
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
        public bool XoaCTPDP_Phong(string maphieudatphong)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM CTPhieuDatPhong_Phong WHERE MaPhieuDatPhong = '" + maphieudatphong + "'";

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
        public string TaoMaCTPhieuDatPhong_Phong()
        {
            conn.Open();
            string sql = "SELECT * FROM CTPhieuDatPhong_Phong";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string ma = "";

            if (dataTable.Rows.Count <= 0)
            {
                ma = "CTPDPP001";
            }
            else
            {
                int number;
                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(6));
                ma = String.Format("CTPDPP{0:000}", number + 1);
            }
            return ma;
        }
    }
}