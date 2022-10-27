using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class HoaDon_MenuDTO
    {
        string mamenu, mahoadon;
        int sl;

        public HoaDon_MenuDTO()
        {
        }

        public HoaDon_MenuDTO(string mamenu, string mahoadon, int sl)
        {
            this.Mamenu = mamenu;
            this.Mahoadon = mahoadon;
            this.Sl = sl;
        }

        public string Mamenu { get => mamenu; set => mamenu = value; }
        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public int Sl { get => sl; set => sl = value; }
    }
}
