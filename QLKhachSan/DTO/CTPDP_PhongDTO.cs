using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class CTPDP_PhongDTO
    {
        string maCTPPDP_phong, maphieudatphong, maphong;
        public CTPDP_PhongDTO(string maCTPPDP_phong, string maphieudatphong, string maphong)
        {
            this.maCTPPDP_phong = maCTPPDP_phong;
            this.maphieudatphong = maphieudatphong;
            this.maphong = maphong;
        }
        public CTPDP_PhongDTO()
        {

        }
        public string MaCTPDP_phong
        {
            get { return maCTPPDP_phong; }
            set { maCTPPDP_phong = value; }
        }
        public string Maphieudatphong
        {
            get { return maphieudatphong; }
            set { maphieudatphong = value; }
        }
        public string Maphong
        {
            get { return maphong; }
            set { maphong = value; }
        }
    }
}
