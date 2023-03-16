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

namespace QLKhachSan.GUI.QLThuChiGUI
{
    public partial class frmQLThuChi : Form
    {
        ThuChiBUS ThuChiBUS = new ThuChiBUS();
        public frmQLThuChi()
        {
            InitializeComponent();
        }
        private void frmQLThuChi_Load(object sender, EventArgs e)
        {
            Reset();
            dgvThuChi.AllowUserToAddRows = false;
            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvThuChi.Columns.Insert(5, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 100;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            //Add btnEdit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvThuChi.Columns.Insert(6, btnEdit);
            btnEdit.HeaderText = "Edit";
            btnEdit.Width = 100;
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

            //Chọn text trong cmbFind
            cmbCachTim.SelectedItem = "Cách tìm";
        }


        private void btnAddPhieuThuChi_Click(object sender, EventArgs e)
        {
            dialogThemThuChi dialogThemThuChi = new dialogThemThuChi();
            dialogThemThuChi.Show();
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvThuChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dgvThuChi.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa phiếu thu chi này?", row.Cells["MaPhieuThuChi"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (ThuChiBUS.XoaThuChi(row.Cells["MaPhieuThuChi"].Value.ToString()))
                    {
                        MessageBox.Show("Xóa thành công");
                        Reset();

                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            if (e.ColumnIndex == 1)
            {
                DataGridViewRow row = dgvThuChi.Rows[e.RowIndex];
                dialogSuaThuChi dialogSuaThuChi = new dialogSuaThuChi(row.Cells["MaPhieuThuChi"].Value.ToString());
                dialogSuaThuChi.Show();

            }
        }
        public void Reset()
        {

            dgvThuChi.DataSource = ThuChiBUS.GetPhieuThuChi();
            /*this.dgvThuChi.Sort(this.dgvThuChi.Columns["UuTienHienThi"], ListSortDirection.Ascending);*/
        } // sắp xếp theo thứ tự ưu tiên á

        //Phương thức truy vấn để xem dữ liệu

        private void btnFindThuChi_OnTextChange(object sender, EventArgs e)
        {

            if (cmbCachTim.Text == "Mã phiếu thu chi")
            {
                dgvThuChi.DataSource = ThuChiBUS.GetPhieuThuChi("SELECT * FROM PhieuThuChi WHERE MaPhieuThuChi LIKE N'%" + btnFindThuChi.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Thời gian")
            {
                dgvThuChi.DataSource = ThuChiBUS.GetPhieuThuChi("SELECT * FROM PhieuThuChi WHERE ThoiGian LIKE N'%" + btnFindThuChi.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Loại hình")
            {
                dgvThuChi.DataSource = ThuChiBUS.GetPhieuThuChi("SELECT * FROM PhieuThuChi WHERE LoaiHinh LIKE N'%" + btnFindThuChi.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Nội dung")
            {
                dgvThuChi.DataSource = ThuChiBUS.GetPhieuThuChi("SELECT * FROM PhieuThuChi WHERE NoiDung LIKE N'%" + btnFindThuChi.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Cách tìm")
            {
                MessageBox.Show("Bạn chưa chọn cách tìm kiếm");
            }
        }
    }
}
