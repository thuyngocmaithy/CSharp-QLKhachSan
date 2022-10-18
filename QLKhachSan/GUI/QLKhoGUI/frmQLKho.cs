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

namespace QLKhachSan.GUI.QLKhoGUI
{
    public partial class frmQLKho : Form
    {
        KhoBUS KhoBUS = new KhoBUS();
        public frmQLKho()
        {
            InitializeComponent();
        }

        private void frmQLKho_Load(object sender, EventArgs e)
        {
            Reset();
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

            //Chọn text trong cmbFind
            cmbCachTim.SelectedItem = "Cách tìm";
        }


        private void btnAddPhieuNhapKho_Click(object sender, EventArgs e)
        {
            dialogThemKho dialogThemKho = new dialogThemKho();
            dialogThemKho.Show();
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = dgvKho.Rows[e.RowIndex];
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
            if (e.ColumnIndex == 6)
            {
                DataGridViewRow row = dgvKho.Rows[e.RowIndex];
                dialogSuaKho dialogSuaKho = new dialogSuaKho(row.Cells["MaPNKho"].Value.ToString());
                dialogSuaKho.Show();

            }
        }
        public void Reset()
        {

            dgvKho.DataSource = KhoBUS.GetPNKho();
            this.dgvKho.Sort(this.dgvKho.Columns["UuTienHienThi"], ListSortDirection.Ascending);
        }
        //Phương thức truy vấn để xem dữ liệu

        private void btnFindKho_OnTextChange(object sender, EventArgs e)
        {

            if (cmbCachTim.Text == "Mã hiếu nhập kho")
            {
                dgvKho.DataSource = KhoBUS.GetPNKho("SELECT * FROM PNKho WHERE MaPNKho LIKE N'%" + btnFindKho.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Mã nhân viên")
            {
                dgvKho.DataSource = KhoBUS.GetPNKho("SELECT * FROM PNKho WHERE MaNhanVien LIKE N'%" + btnFindKho.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Ghi chú")
            {
                dgvKho.DataSource = KhoBUS.GetPNKho("SELECT * FROM PNKho WHERE GhiChu LIKE N'%" + btnFindKho.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Thời gian nhập")
            {
                dgvKho.DataSource = KhoBUS.GetPNKho("SELECT * FROM PNKho WHERE ThoiGianNhaps LIKE N'%" + btnFindKho.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Ưu tiên hiển thị")
            {
                dgvKho.DataSource = KhoBUS.GetPNKho("SELECT * FROM PNKho WHERE UuTienHienThi LIKE N'%" + btnFindKho.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Cách tìm")
            {
                MessageBox.Show("Bạn chưa chọn cách tìm kiếm");
            }
        }


    }

}

