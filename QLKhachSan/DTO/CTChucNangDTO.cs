using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class CTChucNangDTO
    {
        string mactchucnang, tenctchucnang, machucnang;
        public CTChucNangDTO()
        {
        }
        public CTChucNangDTO(string mactchucnang, string tenctchucnang, string machucnang)
        {
            this.mactchucnang = mactchucnang;
            this.tenctchucnang = tenctchucnang;
            this.machucnang = machucnang;
        }
        public string Mactchucnang
        {
            get { return mactchucnang; }
            set { mactchucnang = value; }
        }
        public string Tenctchucnang
        {
            get { return tenctchucnang; }
            set { tenctchucnang = value; }
        }
        public string Machucnang
        {
            get { return machucnang; }
            set { machucnang = value; }
        }
    }
}
