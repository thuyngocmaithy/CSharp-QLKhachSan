using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class DieuChinhKho_MenuDTO
    {
        string madieuchinhkho, mamenu;
        int slthucte, sldieuchinh;

        public DieuChinhKho_MenuDTO()
        {
        }

        public DieuChinhKho_MenuDTO(string madieuchinhkho, string mamenu, int slthucte, int sldieuchinh)
        {
            this.Madieuchinhkho = madieuchinhkho;
            this.Mamenu = mamenu;
            this.Slthucte = slthucte;
            this.Sldieuchinh = sldieuchinh;

        }

        public string Madieuchinhkho { get => madieuchinhkho; set => madieuchinhkho = value; }
        public string Mamenu { get => mamenu; set => mamenu = value; }
        public int Slthucte { get => slthucte; set => slthucte = value; }
        public int Sldieuchinh { get => sldieuchinh; set => sldieuchinh = value; }
    }
}
