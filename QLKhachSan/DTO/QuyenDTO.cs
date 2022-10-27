using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class QuyenDTO
    {
        private String maquyen, tenquyen;
        public QuyenDTO()
        {

        }
        public QuyenDTO(String maquyen, String tenquyen)
        {
            this.maquyen = maquyen;
            this.tenquyen = tenquyen;
        }

        public string Maquyen
        {
            get { return maquyen; }
            set { maquyen = value; }
        }
        public string Tenquyen
        {
            get { return tenquyen; }
            set { tenquyen = value; }
        }
    }
}
