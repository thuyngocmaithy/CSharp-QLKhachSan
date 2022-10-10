using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class LoaiPhongDTO
    {
        string maloaiphong, tenloaiphong;
        int uutienhienthi;
        public LoaiPhongDTO()
        {
        }
        public LoaiPhongDTO(string maloaiphong, string tenloaiphong, int uutienhienthi)
        {
            this.maloaiphong = maloaiphong;
            this.tenloaiphong = tenloaiphong;
            this.uutienhienthi = uutienhienthi;
        }
        public string Maloaiphong
        {
            get { return maloaiphong; }
            set { maloaiphong = value; }
        }
        public string Tenloaiphong
        {
            get { return tenloaiphong; }
            set { tenloaiphong = value; }
        }
        public int Uutienhienthi
        {
            get { return uutienhienthi; }
            set { uutienhienthi = value; }
        }
    }
   
}
