
﻿using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{

    public class CachTinhTienDAO : DBConnect
    {
        public DataTable GetCachTinhTien()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Cachtinhtien", conn);
            DataTable dataCachtinhtien = new DataTable();
            da.Fill(dataCachtinhtien);
            return dataCachtinhtien;
        }

        public DataTable GetCachTinhTien(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable resultCachtinhtien = new DataTable();
            da.Fill(resultCachtinhtien);
            return resultCachtinhtien;
        }

        public string TaoMaCachTinhTien()
        {

            conn.Open();
            string sql = "SELECT * FROM CachTinhTien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string maCachtinhtien = "";

            if (dataTable.Rows.Count <= 0)
            {
                maCachtinhtien = "CTT001";
            }
            else
            {
                int number;
                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(3));

                maCachtinhtien = String.Format("CTT{0:000}", number + 1);
            }
            return maCachtinhtien;
        }

        public bool ThemCachtinhtien(CachTinhTienDTO ctDTO)
        {           
            try
            {
                // Ket noi
                conn.Open();

                string SQL = string.Format("INSERT INTO CachTinhTien values ('{0}', N'{1}', '{2}', '{3}', '{4}') ", ctDTO.Macachtinhtien, ctDTO.Tencachtinhtien, ctDTO.Giathuecuoituan_le, ctDTO.Phuthuquagio, ctDTO.Sophutlamtron);


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


        public bool SuaCachTinhTien(CachTinhTienDTO ctt)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string
                string SQL = string.Format(
                "UPDATE CachTinhTien " +
                "SET TenCachTinhTien = N'{0}', " +
                "GiaThueCuoiTuanVaNgayLe = '{1}', " +
                "PhuThuQuaGio = '{2}', " +
                "SoPhutLamTronThanh1Gio = '{3}' " +
                "WHERE MaCachTinhTien = '{4}'"
                , ctt.Tencachtinhtien, ctt.Giathuecuoituan_le, ctt.Phuthuquagio
                ,ctt.Phuthuquagio,  ctt.Sophutlamtron, ctt.Macachtinhtien);

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
        public bool XoaCachTinhTien(string macachtinhtien)
        {
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM CachTinhTien WHERE MaCachTinhTien = '" + macachtinhtien + "'";

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

