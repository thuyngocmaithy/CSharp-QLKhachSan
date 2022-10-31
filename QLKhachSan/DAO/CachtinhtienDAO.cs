using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    public class Cachtinhtien : DBConnect
    {
        public DataTable Gettinhtien()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Cachtinhtien", conn);
            DataTable dataCachtinhtien = new DataTable();
            da.Fill(dataCachtinhtien);
            return dataCachtinhtien;
        }

        public DataTable Gettinhtien(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable resultCachtinhtien = new DataTable();
            da.Fill(resultCachtinhtien);
            return resultCachtinhtien;
        }

        /*blic bool Themtinhtien(CachtinhtienDTO ct)
         {
             try
             {
                 conn.Open();
                 string SQL = String.Format("insert into Cachtinhtien values (")
             }
         }*/
    }
}

