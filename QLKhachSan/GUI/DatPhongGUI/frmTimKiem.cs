using QLKhachSan.BUS;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace QLKhachSan.GUI.DatPhongGUI
{
    public partial class frmTimKiem : Form
    {
        PhieuDatPhongBUS phieuDatPhongBUS = new PhieuDatPhongBUS();
        public frmTimKiem()
        {
            InitializeComponent();
        }
        public void LoadLoaiPhong()
        {        
            //KIỂM TRA NGÀY NHẬN PHÒNG
            dgvFindDonDatPhong.DataSource = phieuDatPhongBUS.GetPhieuDatPhong(
            "SELECT * FROM PhieuDatPhong " +
            "WHERE NgayNhanPhong BETWEEN '" + dateTuNgay.Value.ToString("yyyy-MM-dd") + "' AND '"+ dateDenNgay.Value.ToString("yyyy-MM-dd") + "'");
        }
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            DateTime datedenngay = DateTime.Now.AddMonths(1);
            dateDenNgay.Value = datedenngay;
            LoadLoaiPhong();
            dgvFindDonDatPhong.AllowUserToAddRows = false;
            //Add btnDelete
            DataGridViewButtonColumn btnOperation = new DataGridViewButtonColumn();
            dgvFindDonDatPhong.Columns.Insert(8, btnOperation);
            btnOperation.HeaderText = "Thao tác";
            btnOperation.Width = 100;
            btnOperation.Text = "...";
            btnOperation.UseColumnTextForButtonValue = true;
        }

        private void lblFind_Click(object sender, EventArgs e)
        {
            LoadLoaiPhong();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            txtFind.Text = "";
            txtFind.ForeColor = System.Drawing.Color.Black;
            dgvFindDonDatPhong.DataSource = phieuDatPhongBUS.GetPhieuDatPhong(
                "SELECT * FROM PhieuDatPhong " +
                "WHERE HoTenKhachHang LIKE N'%" + txtFind.Text.Trim() + "%' " +
                "OR SoDienThoai LIKE '%" + txtFind.Text.Trim() + "%'");
        }
    }
}
