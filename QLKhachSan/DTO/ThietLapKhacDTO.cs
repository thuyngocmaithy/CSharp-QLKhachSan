using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class ThietLapKhacDTO
    {
        string tenkhachsan, diachi, sdt, thoigian, logo, panel;

        public ThietLapKhacDTO()
        {

        }

        public ThietLapKhacDTO(string tenkhachsan, string diachi, string sdt, string thoigian, string logo, string panel)
        {
            this.tenkhachsan = tenkhachsan;
            this.diachi = diachi;
            this.sdt = sdt;
            this.thoigian = thoigian;
            this.logo = logo;
            this.panel = panel;
        }

        public string Tenkhachsan
        {
            get { return tenkhachsan; }
            set { tenkhachsan = value; }
        }

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string Thoigian
        {
            get { return thoigian; }
            set { thoigian = value; }
        }
        public string Logo
        {
            get { return logo; }
            set {logo = value; }
        }

        public string Panel
        {
            get { return panel; }
            set { panel = value; }
        }
    }
}
