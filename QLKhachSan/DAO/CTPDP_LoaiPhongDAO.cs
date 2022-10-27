using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace QLKhachSan
{
    public class CTPDP_LoaiPhongDAO : DBConnect
    {

        public DataTable getCTPDP_LoaiPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CTPhieuDatPhong_LoaiPhong", conn);
            DataTable dataCTPDP_LoaiPhong = new DataTable();
            da.Fill(dataCTPDP_LoaiPhong);
            return dataCTPDP_LoaiPhong;
        }
        public DataTable getCTPDP_LoaiPhong(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataCTPDP_LoaiPhong = new DataTable();
            da.Fill(dataCTPDP_LoaiPhong);
            return dataCTPDP_LoaiPhong;
        }
        public bool ThemCTPDP_LoaiPhong(CTPDP_LoaiPhongDTO ctpdp_lp)
        {
            try
            {
                // Ket noi
                conn.Open();

                string SQL = string.Format("INSERT INTO CTPhieuDatPhong_LoaiPhong VALUES ('{0}', '{1}', '{2}', {3})", ctpdp_lp.MaCTPDP_loaiphong, ctpdp_lp.Maphieudatphong, ctpdp_lp.Maloaiphong, ctpdp_lp.Soluong);   
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
        public bool SuaCTPDP_LoaiPhong(CTPDP_LoaiPhongDTO ctpdp_lp)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format("UPDATE CTPhieuDatPhong_LoaiPhong SET SLPhong = {0} WHERE MaPhieuDatPhong = '{1}' AND MaLoaiPhong = '{2}'", ctpdp_lp.Soluong, ctpdp_lp.Maphieudatphong, ctpdp_lp.Maloaiphong);
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
        public bool XoaCTPDP_LoaiPhong(string maphieudatphong)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM CTPhieuDatPhong_LoaiPhong WHERE MaPhieuDatPhong = '" + maphieudatphong + "'";

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
        public string TaoMaCTPhieuDatPhong_LoaiPhong()
        {
            conn.Open();
            string sql = "SELECT * FROM CTPhieuDatPhong_LoaiPhong";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string ma = "";

            if (dataTable.Rows.Count <= 0)
            {
                ma = "CTPD001";
            }
            else
            {
                int number;
                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][1].ToString().Substring(4));

                ma = String.Format("CTPD{0:000}", number + 1);
            }
            return ma;
        }
    }
}