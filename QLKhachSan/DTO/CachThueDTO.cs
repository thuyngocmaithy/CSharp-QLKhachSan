using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLKhachSan.DTO
{
    public class CachThueDTO
    {
        string MaCachThue;
        string TenCachThue;


        public CachThueDTO()
        {

        }



        public CachThueDTO(string MaCachThue, string TenCachThue)
        {
            this.MaCachThue1 = MaCachThue;
            this.TenCachThue1 = TenCachThue;
        }

        public string MaCachThue1 { get => MaCachThue; set => MaCachThue = value; }
        public string TenCachThue1 { get => TenCachThue; set => TenCachThue = value; }



    }
}
