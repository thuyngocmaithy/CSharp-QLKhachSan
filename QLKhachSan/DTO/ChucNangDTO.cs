using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class ChucNangDTO
    {
        string machucnang, tenchucnang;
        public ChucNangDTO()
        {
        }
        public ChucNangDTO(string machucnang, string tenchucnang)
        {
            this.machucnang = machucnang;
            this.tenchucnang = tenchucnang;
        }
        public string Machucnang
        {
            get { return machucnang; }
            set { machucnang = value; }
        }
        public string Tenchucnang
        {
            get { return tenchucnang; }
            set { tenchucnang = value; }
        }

    }
}
