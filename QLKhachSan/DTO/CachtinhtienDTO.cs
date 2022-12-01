using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class CachtinhtienDTO
    {
        string Macachtinhtien;
        string tencachtinhtien;
        string macachthue;
        double giathuecuoituan_le;
        double phuthuquagio;
        int sophutlamtron;

        public CachtinhtienDTO()
        {

        }
        public CachtinhtienDTO(string Macachtienhtien, string tencachtinhtien, string macachthue, double giathuecuoituan_le, double phuthuquagio, int sophutlamtron)
        {
            this.Macachtinhtien1 = Macachtienhtien;
            this.Macachthue = macachthue;
            this.Tencachtinhtien = tencachtinhtien;
            this.Giathuecuoituan_le = giathuecuoituan_le;
            this.Phuthuquagio = phuthuquagio;
            this.Sophutlamtron = sophutlamtron;

        }

        public global::System.String Macachtinhtien1 { get => Macachtinhtien; set => Macachtinhtien = value; }
        public global::System.String Tencachtinhtien { get => tencachtinhtien; set => tencachtinhtien = value; }
        public global::System.String Macachthue { get => macachthue; set => macachthue = value; }
        public global::System.Double Giathuecuoituan_le { get => giathuecuoituan_le; set => giathuecuoituan_le = value; }
        public global::System.Double Phuthuquagio { get => phuthuquagio; set => phuthuquagio = value; }
        public global::System.Int32 Sophutlamtron { get => sophutlamtron; set => sophutlamtron = value; }
    }
}
