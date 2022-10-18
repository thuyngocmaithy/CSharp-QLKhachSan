using QLKhachSan.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLKhachSan
{
    public class ThietLapKhacDAO : DBConnect
    {
        public DataTable getThietLapKhac()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ThietLapKhac", conn);
            DataTable dataThietLapKhac = new DataTable();
            da.Fill(dataThietLapKhac);
            return dataThietLapKhac;
        }
        public DataTable getThietLapKhac(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataThietLapKhac = new DataTable();
            da.Fill(dataThietLapKhac);
            return dataThietLapKhac;
        }

        /// Sửa
        public bool SuaThietLapKhac(ThietLapKhacDTO tlk)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = "";
                if (getThietLapKhac().Rows.Count == 0)
                {

                    SQL = string.Format("Insert into ThietLapKhac Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", tlk.Tenkhachsan, tlk.Diachi, tlk.Sdt, tlk.Thoigian, tlk.Logo, tlk.Panel);
                }

                else
                {
                    // Query string
                    SQL = string.Format("UPDATE ThietLapKhac SET TenKhachSan = '{0}', DiaChi = '{1}', SDT = '{2}', ThoiGian = '{3}', Logo = '{4}', Panel = '{5}' ", tlk.Tenkhachsan, tlk.Diachi, tlk.Sdt, tlk.Thoigian, tlk.Logo, tlk.Panel);
                }


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
