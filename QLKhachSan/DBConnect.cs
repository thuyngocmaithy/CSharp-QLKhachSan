
using System.Data.SqlClient;


namespace QLKhachSan
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Data Source=LAPTOP-KHSKSNKT\\MAYAO;Initial Catalog=QLKhachSan;Integrated Security=True");
    }
}
