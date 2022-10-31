using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class CTPNKhoDTO
    {
        string mactpnkho, mapnkho, mamenu;
        int sl;
        public CTPNKhoDTO()
        {
        }
        public CTPNKhoDTO(string mactpnkho, string mapnkho, string mamenu, int sl)
        {
            this.mactpnkho = mactpnkho;
            this.mapnkho = mapnkho;
            this.mamenu = mamenu;
            this.sl = sl;
        }
        public string MaCTPNKho
        {
            get { return mactpnkho; }
            set { mactpnkho = value; }
        }
        public string MaPNKho
        {
            get { return mapnkho; }
            set { mapnkho = value; }
        }
        public string MaMenu
        {
            get { return mamenu; }
            set { mamenu = value; }
        }
        public int SL
        {
            get { return sl; }
            set { sl = value; }
        }
    }
}
