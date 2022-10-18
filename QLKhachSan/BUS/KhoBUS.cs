using QLKhachSan.DTO;

using System.Data;

namespace QLKhachSan.BUS
{
    public class KhoBUS
    {
        KhoDAO KhoDAO = new KhoDAO();

        public DataTable GetPNKho()
        {
            return KhoDAO.getPNKho();
        }
        public DataTable GetPNKho(string sql)
        {
            return KhoDAO.getPNKho(sql);
        }

        public bool ThemKho(KhoDTO k)
        {
            return KhoDAO.ThemKho(k);
        }

        public bool SuaKho(KhoDTO k)
        {
            return KhoDAO.SuaKho(k);
        }

        public bool XoaKho(string maphieunhapkho)
        {
            return KhoDAO.XoaKho(maphieunhapkho);
        }
        public string TaoMaPhieuNhapKho()
        {
            string maphieunhapkho = KhoDAO.TaoMaPhieuNhapKho();
            return maphieunhapkho;
        }
    }
}

