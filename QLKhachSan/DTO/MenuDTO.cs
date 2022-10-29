using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLKhachSanDTO
{
    public class MenuDTO
    {
        string maMenu;
        string tenMenu, loaiMenu;
        string gianhap, giaban;
        int uutienhienthi;
        public MenuDTO()
        {

        }
        public MenuDTO(string maMenu, string tenMenu, string loaiMenu, string gianhap, string giaban, int uutienhienthi)
        {
            this.MaMenu = maMenu;
            this.TenMenu = tenMenu;
            this.LoaiMenu = loaiMenu;
            this.Gianhap = gianhap;
            this.Giaban = giaban;
            this.Uutienhienthi = uutienhienthi;

        }

        public global::System.String TenMenu { get => tenMenu; set => tenMenu = value; }
        public global::System.String LoaiMenu { get => loaiMenu; set => loaiMenu = value; }
        public global::System.String Gianhap { get => gianhap; set => gianhap = value; }
        public global::System.String Giaban { get => giaban; set => giaban = value; }
        public global::System.Int32 Uutienhienthi { get => uutienhienthi; set => uutienhienthi = value; }
        public global::System.String MaMenu { get => maMenu; set => maMenu = value; }
    }
}

