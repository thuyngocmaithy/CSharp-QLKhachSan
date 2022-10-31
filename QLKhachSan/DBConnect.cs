
using System.Data.SqlClient;


namespace QLKhachSan
{
    public class DBConnect
    {
        public SqlConnection conn = new SqlConnection("Data Source=PHUONGTHUY\\MAYAO;Initial Catalog=QLKhachSan;Integrated Security=True");
    }
}
