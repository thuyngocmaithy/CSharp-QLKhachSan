

using QLKhachSan.BUS;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLKhoGUI.PNKho
{
    public partial class frmQLPNKho : Form
    {
        PNKhoBUS PNKhoBUS = new PNKhoBUS();
        CTPNKhoBUS CTPNKhoBUS = new CTPNKhoBUS();

        public frmQLPNKho()
        {
            InitializeComponent();
        }

        private void frmPNKho_Load(object sender, EventArgs e)
        {
            LoadPNKho();
            dgvKho.AllowUserToAddRows = false;
            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvKho.Columns.Insert(5, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 100;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            //Add btnEdit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvKho.Columns.Insert(6, btnEdit);
            btnEdit.HeaderText = "Edit";
            btnEdit.Width = 100;
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;


            dgvKho.Columns[0].Width = 140;
            dgvKho.Columns[1].Width = 200;
            dgvKho.Columns[2].Width = 150;
            dgvKho.Columns[3].Width = 150;
            dgvKho.Columns[4].Width = 200;

        }


        private void btnAddPhieuNhapKho_Click(object sender, EventArgs e)
        {
            dialogThemKho dialogThemKho = new dialogThemKho("Thêm", "");
            dialogThemKho.Show();
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            LoadPNKho();
        }

        private void dgvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dgvKho.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa phiếu nhập kho này?", row.Cells["Mã phiếu nhập kho"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (CTPNKhoBUS.XoaCTPNKho(row.Cells["Mã phiếu nhập kho"].Value.ToString()))
                    {
                        if (PNKhoBUS.XoaKho(row.Cells["Mã phiếu nhập kho"].Value.ToString()))
                        {
                            MessageBox.Show("Xóa thành công");
                            LoadPNKho();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            if (e.ColumnIndex == 1)
            {
                DataGridViewRow row = dgvKho.Rows[e.RowIndex];   
                dialogThemKho dialogThemKho = new dialogThemKho("Sửa",row.Cells["Mã phiếu nhập kho"].Value.ToString());
                dialogThemKho.Show();

            }
        }
        public void LoadPNKho()
        {

            dgvKho.DataSource = taoDataTablePNKho();
         
        }


        private DataTable taoDataTablePNKho()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phiếu nhập kho");
            dt.Columns.Add("Thời gian nhập");
            dt.Columns.Add("Tổng số lượng");
            dt.Columns.Add("Tổng giá");
            dt.Columns.Add("Ghi chú");
            
            foreach (DataRow dtPNKho in PNKhoBUS.GetPNKho().Rows)
            {
                int gia = 0, sl = 0;
                int tonggia = 0;
                int tongsl = 0;
                string mapnkho = dtPNKho["MaPNKho"].ToString();
                string thoigiannhapkho = dtPNKho["ThoiGianNhap"].ToString();
                string ghichu = dtPNKho["GhiChu"].ToString();
                foreach (DataRow dtGia in CTPNKhoBUS.GetCTPNKho(
                    "SELECT SL, GiaBan " +
                    "FROM CTPNKho, Menu " +
                    "WHERE MaPNKho = '" + dtPNKho["MaPNKho"] + "' " +
                    "AND CTPNKho.MaMenu = Menu.MaMenu").Rows)
                {
                    gia = int.Parse(dtGia["GiaBan"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                    sl = int.Parse(dtGia["SL"].ToString());
                    tonggia += (gia * sl);
                    tongsl += sl;
                }
                string convertTongGia = tonggia.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
                dt.Rows.Add(mapnkho, thoigiannhapkho, tongsl, convertTongGia, ghichu);
            }
            return dt;
        }

        private void lblFind_Click(object sender, EventArgs e)
        {
            LoadPNKhoFind();
        }
        public void LoadPNKhoFind()
        {
            //KIỂM TRA NGÀY NHẬN PHÒNG
            dgvKho.DataSource = taoDataTablePNKhoFind();
        }
        private DataTable taoDataTablePNKhoFind()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phiếu nhập kho");
            dt.Columns.Add("Thời gian nhập");
            dt.Columns.Add("Tổng số lượng");
            dt.Columns.Add("Tổng giá");
            dt.Columns.Add("Ghi chú");

            foreach (DataRow dtPNKho in PNKhoBUS.GetPNKho(
                "SELECT * " +
                "FROM PNKho " +
                "WHERE ThoiGianNhap BETWEEN '" + dateTuNgay.Value.ToString("yyyy-MM-dd") + "' AND '" + dateDenNgay.Value.ToString("yyyy-MM-dd") + "'").Rows)
            {
                int gia = 0, sl = 0;
                int tonggia = 0;
                int tongsl = 0;
                string mapnkho = dtPNKho["MaPNKho"].ToString();
                string thoigiannhapkho = dtPNKho["ThoiGianNhap"].ToString();
                string ghichu = dtPNKho["GhiChu"].ToString();
                foreach (DataRow dtGia in CTPNKhoBUS.GetCTPNKho(
                    "SELECT SL, GiaBan " +
                    "FROM CTPNKho, Menu " +
                    "WHERE MaPNKho = '" + dtPNKho["MaPNKho"] + "' " +
                    "AND CTPNKho.MaMenu = Menu.MaMenu").Rows)
                {
                    gia = int.Parse(dtGia["GiaBan"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                    sl = int.Parse(dtGia["SL"].ToString());
                    tonggia += (gia * sl);
                    tongsl += sl;
                }
                string convertTongGia = tonggia.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
                dt.Rows.Add(mapnkho, thoigiannhapkho, tongsl, convertTongGia, ghichu);
            }
            return dt;
        }
    }

}

