
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using QLKhachSan;
using QLKhachSanDTO;


namespace QLKhachSanDAO
{
    public class MenuDAO : DBConnect
    {
        public DataTable GetMenu()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Menu", conn);
            DataTable dataMenu = new DataTable();
            da.Fill(dataMenu);
            return dataMenu;
        }
        public DataTable GetMenu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dataMenu = new DataTable();
            da.Fill(dataMenu);
            return dataMenu;
        }

        //thêm

        public bool ThemMenu(MenuDTO mn)
        {

            try
            {
                conn.Open();
                string SQL = string.Format("Insert into Menu values ('{0}','{1}','{2}','{3}','{4}','{5}')" , mn.MaMenu , mn.TenMenu, mn.LoaiMenu, mn.Gianhap, mn.Giaban, mn.Uutienhienthi);
                /*string sql = "insert into Menu  values (@MaMenu, @tenMenu, @loaiMenu, @gianhap , @giaban, @uutienhienthi) "; 
                
                SqlCommand mycmd = new SqlCommand(sql, conn);
                mycmd.CommandText = sql;
                mycmd.Parameters.AddWithValue("@MaMenu", mn.MaMenu);
                mycmd.Parameters.AddWithValue("@tenMenu", mn.TenMenu);
                mycmd.Parameters.AddWithValue("@loaiMenu", mn.LoaiMenu);
                mycmd.Parameters.AddWithValue("@gianhap", mn.Gianhap);
                mycmd.Parameters.AddWithValue("@giaban", mn.Giaban);
                mycmd.Parameters.AddWithValue("@uutienhienthi", mn.Uutienhienthi);*/
                SqlCommand mycmd = new SqlCommand(SQL, conn);
                mycmd.ExecuteNonQuery();
                return true;

            }





            catch (Exception e)
            {
                Console.WriteLine("Exception Occre while creating table:" + e.Message + "\t" + e.GetType());
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        //checkexistMenuID
        public bool kiemtra(MenuDTO mn)
        {   
            try
            {
                conn.Open ();
                string SQL = string.Format("Seclect Menu.maMenu from Menu where EXISTS (SELECT Menu.maMenu from Menu where Menu.maMenu = '{0}' ", mn.MaMenu);
                SqlCommand mycmd = new SqlCommand (SQL, conn);
                if (mycmd.ExecuteReader().HasRows)
                {
                    return false;
                }
                

            }catch (Exception e)
            {
                Console.WriteLine("Exception happen when checking database : " + e.Message + "\t" + e.GetType());
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        //sửa
        public bool SuaMenu(MenuDTO mn)
        {
            try
            {
                conn.Open();
                string sql = string.Format("update Menu set TenMenu = N'{0}', LoaiMenu = N'{1}' , GiaNhap = '{2}' , GiaBan = '{3}' , UuTienHienThi = '{4}' where MaMenu = '{5}'", mn.TenMenu, mn.LoaiMenu, mn.Gianhap,mn.Giaban, mn.Uutienhienthi, mn.MaMenu);
                SqlCommand mycmd = new SqlCommand(sql, conn);
                mycmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occre while creating table:" + e.Message + "\t" + e.GetType());

            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        //xóa
        public bool XoaMenu(string mn)
        {            
            try
            {
                // Ket noi
                conn.Open();

                // Query string - vì xóa chỉ cần ID nên ko cần 1 DTO, mã là đủ
                string SQL = "DELETE FROM Menu WHERE MaMenu = '" + mn + "'";
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
        public string TaoMaMenu()
        {
            conn.Open();
            string sql = "SELECT * FROM Menu";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            conn.Close();
            string ma = "";

            if (dataTable.Rows.Count <= 0)
            {
                ma = "MN001";
            }
            else
            {
                int number;
                number = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(2));

                ma = String.Format("MN{0:000}", number + 1);
            }
            return ma;
        }
    }
}
