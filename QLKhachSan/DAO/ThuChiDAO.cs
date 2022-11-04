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
    public class ThuChiDAO : DBConnect
    {

        public DataTable getPhieuThuChi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhieuThuChi", conn);
            DataTable dataPhieuThuChi = new DataTable();
            da.Fill(dataPhieuThuChi);
            return dataPhieuThuChi;
        }
        public DataTable getPhieuThuChi(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataPhieuThuChi = new DataTable();
            da.Fill(dataPhieuThuChi);
            return dataPhieuThuChi;
        }
        /// Thêm
        public bool ThemThuChi(ThuChiDTO tc)
        {
            try
            {
                // Ket noi
                conn.Open();
                //Viết SQL thiếu dấu 
                //Sai thứ tự sql
                //Bớt báo lại
                string SQL = string.Format("INSERT INTO PhieuThuChi VALUES ('{0}', '{1}', '{2}', '{3}', N'{4}')", tc.MaPhieuThuChi, tc.ThoiGian, tc.LoaiHinh, tc.SoTien, tc.NoiDung);
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

        public bool SuaThuChi(ThuChiDTO tc)// Kho chứ không phải loại phòng
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string                              còn mấy cái khác đâu??
                //MaNhanVien NOT MaNhienVien
                string SQL = string.Format("UPDATE PhieuThuChi SET ThoiGian = '{0}', LoaiHinh = '{1}', SoTien = '{2}', NoiDung = N'{3}' WHERE MaPhieuThuChi = '{4}'", tc.ThoiGian, tc.LoaiHinh, tc.SoTien, tc.NoiDung, tc.MaPhieuThuChi);

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

        public bool XoaThuChi(string maphieuthuchi)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM PhieuThuChi WHERE MaPhieuThuChi = '" + maphieuthuchi + "'";

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
        public string TaoMaPhieuThuChi()
        {
            conn.Open();
            string sql = "SELECT * FROM PhieuThuChi";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string ma = "";

            if (dataTable.Rows.Count <= 0)
            {
                ma = "PTC001";
            }
            else
            {
                int number;
                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(3));

                ma = String.Format("PTC{0:000}", number + 1);
            }
            return ma;
        }
    }
}
