using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class DieuChinhKhoDTO
    {
        string madieuchinhpkho, thoigiandieuchinh ;
        int tongsldieuchinh;
        public DieuChinhKhoDTO()
        {
        }
        public DieuChinhKhoDTO(string madieuchinhkho, string thoigiandieuchinh, int tongsldieuchinh)
        {
            this.madieuchinhpkho = madieuchinhkho;
            this.thoigiandieuchinh = thoigiandieuchinh;
            this.tongsldieuchinh = tongsldieuchinh;
        }
        public string MaDieuChinhKho
        {
            get { return madieuchinhpkho; }
            set { madieuchinhpkho = value; }
        }
        public string ThoiGianDieuChinh
        {
            get { return thoigiandieuchinh; }
            set { thoigiandieuchinh = value; }
        }
        public int TongSLDieuChinh
        {
            get { return tongsldieuchinh; }
            set { tongsldieuchinh = value; }
        }
    }
}
