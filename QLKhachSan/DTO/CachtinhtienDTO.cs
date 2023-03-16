using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class CachTinhTienDTO
    {
        string macachtinhtien;
        string tencachtinhtien;
        string giathuecuoituan_le;
        string phuthuquagio;
        int sophutlamtron;

        public CachTinhTienDTO()
        {

        }

        public CachTinhTienDTO(string macachtinhtien, string tencachtinhtien, string giathuecuoituan_le, string phuthuquagio, int sophutlamtron)
        {
            this.macachtinhtien = macachtinhtien;
            this.tencachtinhtien = tencachtinhtien;
            this.Giathuecuoituan_le = giathuecuoituan_le;
            this.Phuthuquagio = phuthuquagio;
            this.sophutlamtron = sophutlamtron;
        }

        public string Macachtinhtien { get => macachtinhtien; set => macachtinhtien = value; }
        public string Tencachtinhtien { get => tencachtinhtien; set => tencachtinhtien = value; }
        public int Sophutlamtron { get => sophutlamtron; set => sophutlamtron = value; }
        public string Giathuecuoituan_le { get => giathuecuoituan_le; set => giathuecuoituan_le = value; }
        public string Phuthuquagio { get => phuthuquagio; set => phuthuquagio = value; }
    }
}