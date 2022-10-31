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
using QLKhachSan.GUI;


namespace QLKhachSan.GUI.QLKhoGUI.PNKho
{
    public partial class frmPNKho : Form
    {
        KhoBUS KhoBUS = new KhoBUS();
        public frmPNKho()
        {
            InitializeComponent();
        }

        private void frmPNKho_Load(object sender, EventArgs e)
        {
            Reset();
            dgvPNKho.AllowUserToAddRows = false;
            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvPNKho.Columns.Insert(5, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 100;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            //Add btnEdit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvPNKho.Columns.Insert(6, btnEdit);
            btnEdit.HeaderText = "Edit";
            btnEdit.Width = 100;
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

            //Chọn text trong cmbFind
            cmbCachTim.SelectedItem = "Cách tìm";

        }

        private void btnAddPNKho_Click(object sender, EventArgs e)
        {
            dialogThemKho dialogThemKho = new dialogThemKho();
            dialogThemKho.Show();

        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvPNKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dgvPNKho.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa phiếu nhập kho này?", row.Cells["MaPNKho"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (KhoBUS.XoaKho(row.Cells["MaPNKho"].Value.ToString()))
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
                DataGridViewRow row = dgvPNKho.Rows[e.RowIndex];
                dialogSuaKho dialogSuaKho = new dialogSuaKho(row.Cells["MaPNKho"].Value.ToString());
                dialogSuaKho.Show();

            }
        }
        public void Reset()
        {

            dgvPNKho.DataSource = KhoBUS.GetPNKho();
            this.dgvPNKho.Sort(this.dgvPNKho.Columns["UuTienHienThi"], ListSortDirection.Ascending);

        }

        private void btnFindPNKho_OnTextChange(object sender, EventArgs e)
        {
            if (cmbCachTim.Text == "Mã phiếu nhập kho")
            {
                dgvPNKho.DataSource = KhoBUS.GetPNKho("SELECT * FROM PNKho WHERE MaPNKho LIKE N'%" + btnFindPNKho.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Thời gian nhập")
            {
                dgvPNKho.DataSource = KhoBUS.GetPNKho("SELECT * FROM PNKho WHERE ThoiGianNhap LIKE N'%" + btnFindPNKho.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Mã tài khoản")
            {
                dgvPNKho.DataSource = KhoBUS.GetPNKho("SELECT * FROM PNKho WHERE MaTaiKhoan LIKE N'%" + btnFindPNKho.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Ghi Chú")
            {
                dgvPNKho.DataSource = KhoBUS.GetPNKho("SELECT * FROM PNKho WHERE GhiChu LIKE N'%" + btnFindPNKho.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Ưu tiên hiển thị")
            {
                dgvPNKho.DataSource = KhoBUS.GetPNKho("SELECT * FROM PNKho WHERE UuTienHienThi LIKE N'%" + btnFindPNKho.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Cách tìm")
            {
                MessageBox.Show("Bạn chưa chọn cách tìm kiếm");
            }

        }
    }
}
