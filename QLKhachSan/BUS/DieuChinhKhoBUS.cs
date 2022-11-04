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
    public class DieuChinhKhoBUS
    {
        DieuChinhKhoDAO DieuChinhKhoDAO = new DieuChinhKhoDAO();

        public DataTable GetDieuChinhKho()
        {
            return DieuChinhKhoDAO.getDieuChinhKho();
        }
        public DataTable GetDieuChinhKho(string sql)
        {
            return DieuChinhKhoDAO.getDieuChinhKho(sql);
        }

        public bool ThemDieuChinhKho(DieuChinhKhoDTO dck)
        {
            return DieuChinhKhoDAO.ThemDieuChinhKho(dck);
        }
        public bool SuaDieuChinhKho(DieuChinhKhoDTO dck)
        {
            return DieuChinhKhoDAO.SuaDieuChinhKho(dck);
        }
        public bool XoaDieuChinhKho(string madieuchinhkho)
        {
            return DieuChinhKhoDAO.XoaDieuChinhKho(madieuchinhkho);
        }
        public string TaoMaDieuChinhKho()
        {
            string madieuchinhkho = DieuChinhKhoDAO.TaoMaDieuChinhKho();
            return madieuchinhkho;
        }
    }
}
