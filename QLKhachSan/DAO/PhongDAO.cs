using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace QLKhachSan.DAO
{
    public class PhongDAO : DBConnect
    {
        public DataTable getPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Phong", conn);
            DataTable dataPhong = new DataTable();
            da.Fill(dataPhong);
            return dataPhong;
        }
        public DataTable getPhong(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataPhong = new DataTable();
            da.Fill(dataPhong);
            return dataPhong;
        }
        /// Thêm
        public bool ThemPhong(PhongDTO p)
        {
            try
            {
                // Ket noi
                conn.Open();

                string SQL = string.Format("INSERT INTO Phong VALUES ('{0}', '{1}', N'{2}', '{3}', '{4}', '{5}')", p.Maphong, p.Maloaiphong, p.Tinhtrang, p.Sokhachtoida, p.Macachtinhtien, p.Uutienhienthi );

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

        public bool SuaPhong(PhongDTO p)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format("UPDATE Phong SET MaLoaiPhong = '{0}', SoKhachToiDa = '{1}', UuTienHienThi = '{2}', MaCachTinhTien = '{3}', TinhTrang = N'{4}'  WHERE MaPhong = '{5}'", p.Maloaiphong, p.Sokhachtoida, p.Uutienhienthi, p.Macachtinhtien, p.Tinhtrang, p.Maphong);

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
        public bool SuaPhong(string maphong, string tinhtrang)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format("UPDATE Phong SET TinhTrang = N'{0}' WHERE MaPhong = '{1}'", tinhtrang, maphong);
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

        public bool XoaPhong(string maPhong)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM Phong WHERE MaPhong = '" + maPhong + "'";

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
        public string TaoMaPhong()
        {
            conn.Open();
            string sql = "SELECT * FROM Phong";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string ma = "";

            if (dataTable.Rows.Count <= 0)
            {
                ma = "P001";
            }
            else
            {
                int number;
                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(1));

                ma = String.Format("P{0:000}", number + 1);
            }
            return ma;
        }

        

    }
}
