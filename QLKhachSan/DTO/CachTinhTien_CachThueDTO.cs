using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class CachTinhTien_CachThueDTO
    {
        string macachtinhtien, macachthue, giatheocachthue, gionhanphong, giotraphong;

        public CachTinhTien_CachThueDTO()
        {
        }

        public CachTinhTien_CachThueDTO(string macachtinhtien, string macachthue, string giatheocachthue, string gionhanphong, string giotraphong)
        {
            this.Macachtinhtien = macachtinhtien;
            this.Macachthue = macachthue;
            this.Giatheocachthue = giatheocachthue;
            this.Gionhanphong = gionhanphong;
            this.Giotraphong = giotraphong;
        }

        public string Macachtinhtien { get => macachtinhtien; set => macachtinhtien = value; }
        public string Macachthue { get => macachthue; set => macachthue = value; }
        public string Giatheocachthue { get => giatheocachthue; set => giatheocachthue = value; }
        public string Gionhanphong { get => gionhanphong; set => gionhanphong = value; }
        public string Giotraphong { get => giotraphong; set => giotraphong = value; }
    }
}
