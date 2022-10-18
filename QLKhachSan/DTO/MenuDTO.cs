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
        double gianhap, giaban;
        int uutienhienthi;
        public MenuDTO()
        {

        }
        public MenuDTO(string maMenu, string tenMenu, string loaiMenu, double gianhap, double giaban, int uutienhienthi)
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
        public global::System.Double Gianhap { get => gianhap; set => gianhap = value; }
        public global::System.Double Giaban { get => giaban; set => giaban = value; }
        public global::System.Int32 Uutienhienthi { get => uutienhienthi; set => uutienhienthi = value; }
        public global::System.String MaMenu { get => maMenu; set => maMenu = value; }
    }
}

