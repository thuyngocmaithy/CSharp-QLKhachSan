using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class ChucNangDTO
    {
        private String machucnang, tenchucnang;
        public ChucNangDTO()
        {
        }

        public ChucNangDTO(String machucnang, String tenchucnang)
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
