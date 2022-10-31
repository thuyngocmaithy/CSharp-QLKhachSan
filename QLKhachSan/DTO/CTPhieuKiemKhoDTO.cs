using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class CTPhieuKiemKhoDTO
    {
        string mactpkkho, maphieukiemkho, mamenu;
        int sl;
        public CTPhieuKiemKhoDTO()
        {
        }
        public CTPhieuKiemKhoDTO(string mactpkkho, string maphieukiemkho, string mamenu, int sl)
        {
            this.mactpkkho = mactpkkho;
            this.maphieukiemkho = maphieukiemkho;
            this.mamenu = mamenu;
            this.sl = sl;
        }
        public string MaCTPKKho
        {
            get { return mactpkkho; }
            set { mactpkkho = value; }
        }
        public string MaPhieuKiemKho
        {
            get { return maphieukiemkho; }
            set { maphieukiemkho = value; }
        }
        public string MaTaiKhoan
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
