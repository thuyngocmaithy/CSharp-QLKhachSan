
using System.Data.SqlClient;


namespace QLKhachSan
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Data Source=DESKTOP-Q8MOQPE\\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");
    }
}
