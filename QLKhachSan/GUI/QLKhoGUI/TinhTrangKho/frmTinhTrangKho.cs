using QLKhachSan.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLKhoGUI.TinhTrangKho
{
    public partial class frmTinhTrangKho : Form
    {
        MenuBUS MenuBUS = new MenuBUS();
        HoaDon_MenuBUS HoaDon_MenuBUS = new HoaDon_MenuBUS();
        CTPNKhoBUS CTPNKhoBUS = new CTPNKhoBUS();
        //  CTPhieuKiemKhoBUS CTPhieuKiemKhoBUS = new CTPhieuKiemKhoBUS();
        DieuChinhKho_MenuBUS DieuChinhKho_MenuBUS = new DieuChinhKho_MenuBUS();
        public frmTinhTrangKho()
        {
            InitializeComponent();
        }

        private void btnFindTinhTrangKho_OnTextChange(object sender, EventArgs e)
        {
            dgvTinhTrangKho.DataSource = getSLHienTai(btnFindTinhTrangKho.text.Trim());
        }



        private void frmTinhTrangKho_Load(object sender, EventArgs e)
        {
            dgvTinhTrangKho.DataSource = getSLHienTai(null);
            dgvTinhTrangKho.Columns[0].Width = 500;
            dgvTinhTrangKho.Columns[1].Width = 500;

        }

        public DataTable getSLHienTai(string tenmenu)
        {
            //tạo mới một instance class DataTable
            DataTable table = new DataTable("TinhTrangKho");
            //tạo một datacolumns với tất cả các thuộc tính có sẵn
            // Thêm các cột vào bảng
            table.Columns.Add("Tên Menu");
            table.Columns.Add("Số lượng hiện tại");

            //tính
            int slnhap = 0, slsudung = 0;
            int slhientai = 0;
            DataTable dtMenu = new DataTable();
            if (tenmenu != null)
            {
                dtMenu = MenuBUS.GetMenu(
                    "SELECT TenMenu, Menu.MaMenu, SUM(SLThucTe) AS 'SL' " +
                    "FROM DieuChinhKho, Menu, DieuChinhKho_Menu " +
                    "WHERE DieuChinhKho.MaDieuChinhKho = DieuChinhKho_Menu.MaDieuChinhKho " +
                    "AND DieuChinhKho.ThoiGianDieuChinh IN(SELECT MAX(DieuChinhKho.ThoiGianDieuChinh) FROM DieuChinhKho) " +
                    "AND Menu.MaMenu = DieuChinhKho_Menu.MaMenu " +
                    "AND TenMenu LIKE N'%" + btnFindTinhTrangKho.text.Trim() + "%'" +
                    "GROUP BY TenMenu, Menu.MaMenu");
            }
            else
            {
                dtMenu = MenuBUS.GetMenu(
                "SELECT TenMenu, Menu.MaMenu, SUM(SLThucTe) AS 'SL' " +
           "FROM DieuChinhKho, Menu, DieuChinhKho_Menu " +
           "WHERE DieuChinhKho.MaDieuChinhKho = DieuChinhKho_Menu.MaDieuChinhKho " +
           "AND DieuChinhKho.ThoiGianDieuChinh IN(SELECT MAX(DieuChinhKho.ThoiGianDieuChinh) FROM DieuChinhKho) " +
           "AND Menu.MaMenu = DieuChinhKho_Menu.MaMenu " +
           "GROUP BY TenMenu, Menu.MaMenu");

            }
            foreach (DataRow dataMenu in dtMenu.Rows)
            {
                if (dataMenu["SL"].ToString() != "")
                {
                    slnhap = Int32.Parse(dataMenu["SL"].ToString());
                }
                foreach (DataRow dataMenuHoaDon in HoaDon_MenuBUS.GetHoaDon_Menu(
                    "SELECT SUM(SL) AS TongSLSuDung " +
                    "FROM HoaDon_Menu " +
                    "WHERE MaMenu = '" + dataMenu["MaMenu"].ToString() + "'").Rows)
                    if (dataMenuHoaDon["TongSLSuDung"].ToString() != "")
                    {
                        slsudung = Int32.Parse(dataMenuHoaDon["TongSLSuDung"].ToString());
                    }
                slhientai = slnhap - slsudung;
                table.Rows.Add(dataMenu["TenMenu"].ToString(), slhientai);
            }
            return table;
        }

    }
}
