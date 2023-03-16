using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class PhongDTO
    {
        string maphong, maloaiphong, tinhtrang, macachtinhtien;
        int sokhachtoida, uutienhienthi;
        public PhongDTO()
        {

        }
        public PhongDTO(string maphong, string maloaiphong, string tinhtrang, int sokhachtoida, string macachtinhtien, int uutienhienthi)
        {
            this.maphong = maphong;
            this.maloaiphong = maloaiphong;
            this.tinhtrang = tinhtrang;
            this.sokhachtoida = sokhachtoida;
            this.uutienhienthi = uutienhienthi;
            this.macachtinhtien = macachtinhtien;
        }   
        public string Maphong
        {
            get
            {
                return maphong;
            }

            set
            {
               maphong = value;
            }
        }
        public string Maloaiphong
        {
            get
            {
                return maloaiphong;
            }

            set
            {
                maloaiphong = value;
            }
        }
        public string Tinhtrang
        {
            get
            {
                return tinhtrang;
            }

            set
            {
                tinhtrang = value;
            }
        }
        public int Sokhachtoida
        {
            get
            {
                return sokhachtoida;
            }

            set
            {
                sokhachtoida = value;
            }
        }
        public int Uutienhienthi
        {
            get
            {
                return uutienhienthi;
            }

            set
            {
                uutienhienthi = value;
            }
        }
        public string Macachtinhtien
        {
            get
            {
                return macachtinhtien;
            }

            set
            {
                macachtinhtien = value;
            }
        }
    }
}
