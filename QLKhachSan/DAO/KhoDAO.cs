using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public class KhoDAO : DBConnect
    {

        public DataTable getPNKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PNKho", conn);
            DataTable dataPNKho = new DataTable();
            da.Fill(dataPNKho);
            return dataPNKho;
        }
        public DataTable getPNKho(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataPNKho = new DataTable();
            da.Fill(dataPNKho);
            return dataPNKho;
        }
        /// Thêm
        public bool ThemKho(KhoDTO lp)
        {
            try
            {
                // Ket noi
                conn.Open();
                                                                                           //Viết SQL thiếu dấu 
                                                                                           //Sai thứ tự sql
                                                                                           //Bớt báo lại
                string SQL = string.Format("INSERT INTO PNKho VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", lp.MaPNKho, lp.ThoiGianNhap, lp.MaNhanVien, lp.GhiChu, lp.Uutienhienthi);
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

        /// Sửa

        public bool SuaKho(KhoDTO k)// Kho chứ không phải loại phòng
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string                              còn mấy cái khác đâu??
                                                             //MaNhanVien NOT MaNhienVien
                string SQL = string.Format("UPDATE PNKho SET MaNhanVien = '{0}', ThoiGianNhap = '{1}', GhiChu = '{2}', UuTienHienThi = '{3}' WHERE MaPNKho = '{4}'", k.MaNhanVien, k.ThoiGianNhap, k.GhiChu, k.Uutienhienthi, k.MaPNKho);

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

        public bool XoaKho(string maphieunhapkho)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM PNKho WHERE MaPNKho = '" + maphieunhapkho + "'";

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
        public string TaoMaPhieuNhapKho()
        {
            conn.Open();
            string sql = "SELECT * FROM PNKho";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string ma = "";

            if (dataTable.Rows.Count <= 0)
            {
                ma = "PNK001";
            }
            else
            {
                int number;
                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(3));

                ma = String.Format("PNK{0:000}", number + 1);
            }
            return ma;
        }
    }
}
