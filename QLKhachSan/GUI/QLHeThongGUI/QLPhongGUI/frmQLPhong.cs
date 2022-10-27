using QLKhachSan.BUS;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.QLPhongGUI
{
    public partial class frmQLPhong : Form
    {
        PhongBUS phongBUS = new PhongBUS();
        LoaiPhongBUS loaiPhongBUS = new LoaiPhongBUS();
        public frmQLPhong()
        {
            InitializeComponent();
        }

        private void frmQLPhong_Load(object sender, EventArgs e)
        {

            dgvPhong.AllowUserToAddRows = false;
            //Add MaPhong
            DataGridViewTextBoxColumn txtMaPhong = new DataGridViewTextBoxColumn();
            dgvPhong.Columns.Insert(0, txtMaPhong);
            txtMaPhong.HeaderText = "Mã phòng";
            txtMaPhong.Name = "MaPhong";
            txtMaPhong.DataPropertyName = "MaPhong";
            txtMaPhong.Width = 70;
            //Loại phòng
            DataGridViewComboBoxColumn cmbMaLoaiPhong = new DataGridViewComboBoxColumn();
            dgvPhong.Columns.Insert(1, cmbMaLoaiPhong);
            cmbMaLoaiPhong.HeaderText = "Loại phòng";
            cmbMaLoaiPhong.Name = "MaLoaiPhong";
            cmbMaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            cmbMaLoaiPhong.Width = 150;
            cmbMaLoaiPhong.ReadOnly = true;
            cmbMaLoaiPhong.DataSource = loaiPhongBUS.GetLoaiPhong(); // Get Loại Phòng
            cmbMaLoaiPhong.DisplayMember = "TenLoaiPhong";
            cmbMaLoaiPhong.ValueMember = "MaLoaiPhong";
            //Tình trạng
            DataGridViewComboBoxColumn cmbTinhTrang = new DataGridViewComboBoxColumn();
            dgvPhong.Columns.Insert(2, cmbTinhTrang);
            cmbTinhTrang.HeaderText = "Tình trạng";
            cmbTinhTrang.Name = "TinhTrang";
            cmbTinhTrang.DataPropertyName = "TinhTrang";
            cmbTinhTrang.Width = 150;
            cmbTinhTrang.ReadOnly = true;
            cmbTinhTrang.Items.Clear();
            cmbTinhTrang.Items.Add("Phòng chờ");
            cmbTinhTrang.Items.Add("Phòng đang thuê");
            cmbTinhTrang.Items.Add("Phòng chờ dọn");
            //Add SoKhachToiDa
            DataGridViewTextBoxColumn txtSoKhachToiDa = new DataGridViewTextBoxColumn();
            dgvPhong.Columns.Insert(3, txtSoKhachToiDa);
            txtSoKhachToiDa.HeaderText = "Số khách tối đa";
            txtSoKhachToiDa.Name = "SoKhachToiDa";
            txtSoKhachToiDa.DataPropertyName = "SoKhachToiDa";
            txtSoKhachToiDa.Width = 120;
            //Cách tính tiền
            DataGridViewTextBoxColumn cmbCachTinhTien = new DataGridViewTextBoxColumn();
            dgvPhong.Columns.Insert(4, cmbCachTinhTien);
            cmbCachTinhTien.HeaderText = "Cách tính tiền";
            cmbCachTinhTien.Name = "MaCachTinhTien";
            cmbCachTinhTien.DataPropertyName = "MaCachTinhTien";
            cmbCachTinhTien.Width = 100;
            //Add UuTienHienThi            
            DataGridViewTextBoxColumn txtUuTienHienThi = new DataGridViewTextBoxColumn();
            dgvPhong.Columns.Insert(5, txtUuTienHienThi);
            txtUuTienHienThi.HeaderText = "Ưu tiên hiển thị";
            txtUuTienHienThi.Name = "UuTienHienThi";
            txtUuTienHienThi.DataPropertyName = "UuTienHienThi";
            txtUuTienHienThi.Width = 96;
            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvPhong.Columns.Insert(6, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 85;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            //Add btnEdit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvPhong.Columns.Insert(7, btnEdit);
            btnEdit.HeaderText = "Edit";
            btnEdit.Width = 85;
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            //Chọn text trong cmbFind
            cmbCachTim.SelectedItem = "Cách tìm";
            //Fill Data
            FillData();
        }


        private void btnAddDatPhong_Click(object sender, EventArgs e)
        {
            dialogThemPhong dialogThemPhong = new dialogThemPhong();
            dialogThemPhong.Show();
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dgvPhong.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa loại phòng này?", row.Cells["MaPhong"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (phongBUS.XoaPhong(row.Cells["MaPhong"].Value.ToString()))
                    {
                        MessageBox.Show("Xóa thành công");
                        FillData();

                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            if (e.ColumnIndex == 1)
            {
                DataGridViewRow row = dgvPhong.Rows[e.RowIndex];
                string maphong_Sua = row.Cells["MaPhong"].Value.ToString();
                string maloaiphong_Sua = row.Cells["MaLoaiPhong"].Value.ToString();
                string tinhtrang_Sua = row.Cells["TinhTrang"].Value.ToString();
                string sokhachtoida_Sua = row.Cells["SoKhachToiDa"].Value.ToString();
                string macachtinhtien_Sua = row.Cells["MaCachTinhTien"].Value.ToString();
                string uutienhienthi_Sua = row.Cells["UuTienHienThi"].Value.ToString();
                dialogSuaPhong dialogSuaPhong = new dialogSuaPhong(maphong_Sua, maloaiphong_Sua, tinhtrang_Sua, sokhachtoida_Sua, macachtinhtien_Sua, uutienhienthi_Sua);
                dialogSuaPhong.Show();

            }
        }
        public void FillData()
        {

            dgvPhong.DataSource = phongBUS.GetPhong(); // Get Loại Phòng
            this.dgvPhong.Sort(this.dgvPhong.Columns["UuTienHienThi"], ListSortDirection.Ascending);
        }
        //Phương thức truy vấn để xem dữ liệu

        private void btnFindPhong_OnTextChange(object sender, EventArgs e)
        {
            if (cmbCachTim.Text == "Mã phòng")
            {
                dgvPhong.DataSource = phongBUS.GetPhong("SELECT * FROM Phong WHERE MaPhong LIKE N'%" + btnFindPhong.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Loại phòng")
            {
                dgvPhong.DataSource = phongBUS.GetPhong("SELECT Phong.MaPhong, Phong.MaLoaiPhong, Phong.TinhTrang, Phong.SoKhachToiDa, Phong.MaCachTinhTien, Phong.UuTienHienThi"
                                + "FROM Phong, LoaiPhong"
                                + "WHERE Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong"
                                + "AND LoaiPhong.TenLoaiPhong LIKE N'%" + btnFindPhong.Text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Tình trạng")
            {
                dgvPhong.DataSource = phongBUS.GetPhong("SELECT * FROM Phong WHERE TinhTrang LIKE N'%" + btnFindPhong.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Số khách tối đa")
            {
                dgvPhong.DataSource = phongBUS.GetPhong("SELECT * FROM Phong WHERE SoKhachToiDa LIKE N'%" + btnFindPhong.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Cách tính tiền")
            {
                dgvPhong.DataSource = phongBUS.GetPhong("SELECT Phong.MaPhong, Phong.MaLoaiPhong, Phong.TinhTrang, Phong.SoKhachToiDa, Phong.MaCachTinhTien, Phong.UuTienHienThi"
                                + "FROM Phong, CachTinhTien"
                                + "WHERE Phong.MaCachTinhTien = CachTinhTien.MaCachTinhTien"
                                + "AND CachTinhTien.MaCachTinhTien LIKE N'%" + btnFindPhong.Text.Trim() + "%'");
            }
            if (cmbCachTim.Text == "Ưu tiên hiển thị")
            {
                dgvPhong.DataSource = phongBUS.GetPhong("SELECT * FROM Phong WHERE UuTienHienThi LIKE N'%" + btnFindPhong.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Cách tìm")
            {
                MessageBox.Show("Bạn chưa chọn cách tìm kiếm");
            }
        }

        private void cmbCachTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFindPhong.text = "";
        }
    }
}
