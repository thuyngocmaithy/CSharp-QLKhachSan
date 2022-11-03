
using System.Data.SqlClient;


namespace QLKhachSan
{
    public class DBConnect
    {
        public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4TLUI4C\\SQLEXPRESS01;Initial Catalog=QLKhachSan;Integrated Security=True");
    }
}
