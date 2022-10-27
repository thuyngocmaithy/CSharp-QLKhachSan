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

namespace QLKhachSan.GUI.TaiKhoanGUI.QuyenGUI
{
    public partial class frmQuyen : Form
    {
        QuyenBUS quyenBUS = new QuyenBUS();

        public frmQuyen()
        {
            InitializeComponent();
            Reset();
        }

        private void frmQuyen_Load(object sender, EventArgs e)
        {
            Reset();
            dgvQuyen.AllowUserToAddRows = false;
            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvQuyen.Columns.Insert(2, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 100;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            //Add btnEdit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvQuyen.Columns.Insert(3, btnEdit);
            btnEdit.HeaderText = "Edit";
            btnEdit.Width = 100;
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

            //Chọn text trong cmbFind
            cmbCachTim.SelectedItem = "Cách tìm";
        }

        private void btnFindQuyen_OnTextChange(object sender, EventArgs e)
        {
            //Cách tìm
            //  Mã Tài Khoản
            //Tên Tài Khoản
            //Mã Quyền
            if (cmbCachTim.Text == "Mã Quyền")
            {
                dgvQuyen.DataSource = quyenBUS.GetQuyen("SELECT * FROM Quyen WHERE MaQuyen LIKE N'%" + btnFindQuyen.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Tên Quyền")
            {
                dgvQuyen.DataSource = quyenBUS.GetQuyen("SELECT * FROM Quyen WHERE TenQuyen LIKE N'%" + btnFindQuyen.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Cách tìm")
            {
                MessageBox.Show("Bạn chưa chọn cách tìm kiếm");
            }
        }

        public void Reset()
        {

            dgvQuyen.DataSource = quyenBUS.GetQuyen();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DataGridViewRow row = dgvQuyen.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa Quyền này?", row.Cells["MaQuyen"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (quyenBUS.XoaQuyen(row.Cells["MaQuyen"].Value.ToString()))
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
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow row = dgvQuyen.Rows[e.RowIndex];
                dialogSuaQuyen dialogSuaQuyen = new dialogSuaQuyen(row.Cells["MaQuyen"].Value.ToString());
                dialogSuaQuyen.Show();

            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnAddQuyen_Click(object sender, EventArgs e)
        {
            dialogThemQuyen dialogThemQuyen = new dialogThemQuyen();
            dialogThemQuyen.Show();
        }

        private void btnChonchucnang_Click(object sender, EventArgs e)
        {
            dialogChonChucNang dialogChonChucNang = new dialogChonChucNang();
            dialogChonChucNang.Show();
        }
    }
}
