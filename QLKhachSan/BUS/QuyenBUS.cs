using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.BUS
{
    public class QuyenBUS
    {
        QuyenDAO QuyenDAO = new QuyenDAO();
       
        public DataTable GetQuyen()
        {
            return QuyenDAO.getQuyen();
        }
        public DataTable GetQuyen(string sql)
        {
            return QuyenDAO.getQuyen(sql);
        }
        public bool ThemQuyen(QuyenDTO quyen)
        {
            return QuyenDAO.ThemQuyen(quyen);
        }
        public bool SuaTQuyen(QuyenDTO quyen)
        {
            return QuyenDAO.SuaQuyen(quyen);
        }
        public bool XoaQuyen(String maquyen)
        {
           return QuyenDAO.XoaQuyen(maquyen);
        }
        public bool ThemQuyenChucNang(String maquyen , String ChucNang)
        {
            return QuyenDAO.ThemQuyenChucNang(maquyen, ChucNang);
        }
        public bool XoaQuyenChucNang(String maquyen)
        {
            return QuyenDAO.XoaQuyenChucNang(maquyen) ;
        }
        public DataTable getChucNang(String maquyen)
        {
            return QuyenDAO.getChucnang(maquyen);
        }
        //get cmb
        public DataTable GetCmb()
        {
            return QuyenDAO.GetTbl();
        }
        public string TaoMaQuyen()
        {
            string ma = QuyenDAO.TaoMaQuyen();
            return ma;
        }
    }
}
