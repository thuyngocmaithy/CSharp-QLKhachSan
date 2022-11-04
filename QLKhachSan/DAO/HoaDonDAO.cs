using QLKhachSan.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace QLKhachSan.DAO
{
    public class HoaDonDAO : DBConnect
    {
        public DataTable getHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDon", conn);
            DataTable dataHoaDon = new DataTable();
            da.Fill(dataHoaDon);
            return dataHoaDon;
        }
        public DataTable getHoaDon(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataHoaDon = new DataTable();
            da.Fill(dataHoaDon);
            return dataHoaDon;
        }
        public bool ThemHoaDon(HoaDonDTO hd)
        {
            try
            {
                // Ket noi
                conn.Open();

                string SQL = string.Format(
             "INSERT INTO HoaDon VALUES ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', N'{10}', '{11}', {12} )"
             , hd.Mahoadon, hd.Maphong, hd.Thoigianbatdau,hd.Thoigianketthuc,hd.Macachthue,hd.Tienphong,hd.Phuthu,hd.Tratruoc, hd.Thugiamtrukhac,hd.Tienmenu,hd.Ghichu, hd.Taikhoannhanphong, hd.Taikhoantraphong );
               // MessageBox.Show(SQL);
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
        public bool suaHoaDon(HoaDonDTO hd)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format("UPDATE HoaDon SET MaPhong = '{0}', ThoiGianBatDau = '{1}', ThoiGianKetThuc = '{2}', MaCachThue = '{3}', TienPhong = '{4}', PhuThu = '{5}', TraTruoc = '{6}', ThuGiamTruKhac = '{7}', TienMenu = '{8}', GhiChu = '{9}', TaiKhoanTraPhong = '{10}' WHERE MaHoaDon = '{11}'", hd.Maphong, hd.Thoigianbatdau, hd.Thoigianketthuc,hd.Macachthue,hd.Tienphong,hd.Phuthu, hd.Tratruoc,hd.Thugiamtrukhac,hd.Tienmenu, hd.Ghichu,  hd.Taikhoantraphong, hd.Mahoadon);

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
        public bool XoaHoaDon(string maHoaDon)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM HoaDon WHERE MaHoaDon = '" + maHoaDon + "'";

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
        public string TaoMaHoaDon()
        {
            conn.Open();
            string sql = "SELECT * FROM HoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string ma = "";

            if (dataTable.Rows.Count <= 0)
            {
                ma = "HD001";
            }
            else
            {
                int number;
                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(2));

                ma = String.Format("HD{0:000}", number + 1);
            }
            return ma;
        }
    }
}
