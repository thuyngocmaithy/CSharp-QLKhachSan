using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;

namespace QLKhachSan
{
    public class PhieuDatPhongDAO : DBConnect
    {
        public DataTable getPhieuDatPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhieuDatPhong", conn);
            DataTable dataPhieuDatPhong = new DataTable();
            da.Fill(dataPhieuDatPhong);
            return dataPhieuDatPhong;
        }
        public DataTable getPhieuDatPhong(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataPhieuDatPhong = new DataTable();
            da.Fill(dataPhieuDatPhong);
            return dataPhieuDatPhong;
        }
        public bool ThemPhieuDatPhong(PhieuDatPhongDTO pdp)
        {
            try
            {
                // Ket noi
                conn.Open();

                string SQL = string.Format("INSERT INTO PhieuDatPhong VALUES ('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', N'{7}')"
                    , pdp.Maphieudatphong, pdp.Hotenkhachhang, pdp.Sodienthoai, pdp.Ngaynhanphong, pdp.Ngaytraphong, pdp.Tientratruoc, pdp.Ghichu, pdp.Trangthai);

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
        public bool SuaPhieuDatPhong(PhieuDatPhongDTO pdp)
        {

            try
            {
                // Ket noi
                conn.Open();

                // Query string                
                string SQL = string.Format("UPDATE PhieuDatPhong SET HoTenKhachHang = N'{0}', SoDienThoai = '{1}', NgayNhanPhong = '{2}', NgayTraPhong = '{3}', TienTraTruoc = '{4}', GhiChu = N'{5}', TrangThai = N'{6}' WHERE MaPhieuDatPhong = '{7}'"
                    ,pdp.Hotenkhachhang, pdp.Sodienthoai, pdp.Ngaynhanphong, pdp.Ngaytraphong, pdp.Tientratruoc, pdp.Ghichu, pdp.Trangthai, pdp.Maphieudatphong);

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
        public bool SuaPhieuDatPhong(string maphieudatphong)
        {

            try
            {
                // Ket noi
                conn.Open();

                // Query string                
                string SQL = string.Format("UPDATE PhieuDatPhong SET TrangThai = N'{0}' WHERE MaPhieuDatPhong = '{1}'"
                    ,"Đã nhận phòng", maphieudatphong);

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
        public bool XoaPhieuDatPhong(string maphieudatphong)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM PhieuDatPhong WHERE MaPhieuDatPhong = '" + maphieudatphong + "'";

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
        public string TaoMaPhieuDatPhong()
        {
            conn.Open();
            string sql = "SELECT * FROM PhieuDatPhong";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string ma = "";

            if (dataTable.Rows.Count <= 0)
            {
                ma = "PDP001";
            }
            else
            {
                int number;
                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(3));

                ma = String.Format("PDP{0:000}", number + 1);
            }
            return ma;
        }

    }
}
