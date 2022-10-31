using QLKhachSan.BUS;
using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLKhoGUI.TinhTrangKho
{
    public partial class frmTinhTrangKho : Form
    {
        MenuBUS MenuBUS = new MenuBUS();
        HoaDon_MenuBUS HoaDon_MenuBUS = new HoaDon_MenuBUS();
        CTPNKhoBUS CTPNKhoBUS = new CTPNKhoBUS();
        CTPhieuKiemKhoBUS CTPhieuKiemKhoBUS = new CTPhieuKiemKhoBUS();
        public frmTinhTrangKho()
        {
            InitializeComponent();
        }

        private void btnFindTinhTrangKho_OnTextChange(object sender, EventArgs e)
        {
            dgvTinhTrangKho.DataSource = MenuBUS.GetMenu("SELECT * FROM Menu WHERE TenMenu LIKE N'%" + btnFindTinhTrangKho.text.Trim() + "%' ");
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            dgvTinhTrangKho.DataSource = MenuBUS.GetMenu();
        }

        private void frmTinhTrangKho_Load(object sender, EventArgs e)
        {
            dgvTinhTrangKho.DataSource = getSLHienTai();
        }

        public DataTable getSLHienTai()
        {
            //tạo mới một instance class DataTable
            DataTable table = new DataTable("TinhTrangKho");
            //tạo một datacolumns với tất cả các thuộc tính có sẵn
            // Thêm các cột vào bảng
            table.Columns.Add("Tên Menu");
            table.Columns.Add("Số lượng hiện tại");
            
            //tính
            int slnhap = 0, slsudung = 0, sldieuchinh = 0;
            int slhientai = 0;
            foreach (DataRow dataMenu in MenuBUS.GetMenu().Rows)
            {
                foreach (DataRow dataPNKho in CTPNKhoBUS.GetCTPNKho(
                    "SELECT SL " +
                    "FROM CTPNKho " +
                    "WHERE MaMenu = '" + dataMenu["MaMenu"].ToString() + "'").Rows)
                    if (dataPNKho["SL"].ToString() != "")
                    {
                    slnhap = Int32.Parse(dataPNKho["SL"].ToString());
                    }
                foreach (DataRow dataMenuHoaDon in HoaDon_MenuBUS.GetHoaDon_Menu(
                    "SELECT SUM(SL) AS TongSLSuDung " +
                    "FROM HoaDon_Menu " +
                    "WHERE MaMenu = '" + dataMenu["MaMenu"].ToString() + "'").Rows)
                    if (dataMenuHoaDon["TongSLSuDung"].ToString() != "")
                    {
                    slsudung = Int32.Parse(dataMenuHoaDon["TongSLSuDung"].ToString());
                    }
                foreach (DataRow dataPNKho in CTPhieuKiemKhoBUS.GetCTPhieuKiemKho(
                   "SELECT SUM(SL) AS TongSLSuDung " +
                   "FROM CTPhieuKiemKho " +
                   "WHERE MaMenu = '" + dataMenu["MaMenu"].ToString() + "'").Rows)
                    if (dataPNKho["TongSLSuDung"].ToString() != "")
                    {
                        sldieuchinh = Int32.Parse(dataPNKho["TongSLSuDung"].ToString());
                    } 
                slhientai = slnhap - slsudung + sldieuchinh;
                table.Rows.Add(dataMenu["TenMenu"].ToString() , slhientai);
            }
            return table;
        }
    }
}
