using QLKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLKhachSan.GUI.QLKhoGUI.TinhTrangKho;
using QLKhachSan.DTO;

namespace QLKhachSan.GUI.QLKhoGUI.DieuChinhKho
{
    public partial class dialogThemDieuChinhKho : Form
    {
        MenuBUS MenuBUS = new MenuBUS();
        DieuChinhKhoBUS DieuChinhKhoBUS = new DieuChinhKhoBUS();
        frmTinhTrangKho frmTinhTrangKho = new frmTinhTrangKho();
        public dialogThemDieuChinhKho()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFindThemDieuChinhKho_OnTextChange(object sender, EventArgs e)
        {
            dgvThemDieuChinhKho.DataSource = MenuBUS.GetMenu("SELECT * FROM Menu WHERE TenMenu LIKE N'%" + btnFindThemDieuChinhKho.text.Trim() + "%' ");
        }

        private void btnThemDieuChinhKho_Click(object sender, EventArgs e)
        {
            
        }
        /*private DataTable getDieuChinh()
        {
            DataTable table = new DataTable("ThemDieuChinhKho");
        }*/

        private void dialogThemDieuChinhKho_Load(object sender, EventArgs e)
        {
            
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            dgvThemDieuChinhKho.DataSource = MenuBUS.GetMenu();
        }
    }
}
