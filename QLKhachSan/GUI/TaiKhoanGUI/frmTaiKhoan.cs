using QLKhachSan.BUS;
using QLKhachSan.GUI.TaiKhoanGUI.QuyenGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.GUI.TaiKhoanGUI
{

    public partial class frmTaiKhoan : Form
    {
       TaiKhoanBUS TaiKhoanBUS = new TaiKhoanBUS();      


        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        
        
        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa Tài Khoản này?", row.Cells["MaTaiKhoan"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (TaiKhoanBUS.XoaTaiKhoan(row.Cells["MaTaiKhoan"].Value.ToString()))
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
              DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
               dialogSuaTaiKhoan dialogSuaTaiKhoan = new dialogSuaTaiKhoan(row.Cells["MaTaiKhoan"].Value.ToString());
               dialogSuaTaiKhoan.Show();

            }
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            Reset();
            dgvTaiKhoan.AllowUserToAddRows = false;
            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvTaiKhoan.Columns.Insert(4, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 100;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            //Add btnEdit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvTaiKhoan.Columns.Insert(5, btnEdit);
            btnEdit.HeaderText = "Edit";
            btnEdit.Width = 100;
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

            //Chọn text trong cmbFind
            cmbCachTim.SelectedItem = "Cách tìm";
        }
        public void Reset()
        {

            dgvTaiKhoan.DataSource = TaiKhoanBUS.GetTaiKhoan();
            //this.dgvTaiKhoan.Sort(this.dgvTaiKhoan.Columns["MaTaiKhoan"], ListSortDirection.Ascending);
        }

       

        private void lblReset_MouseClick(object sender, MouseEventArgs e)
        {
            Reset();
        }

        private void btnFindTaiKhoan_OnTextChange(object sender, EventArgs e)
        {
            //Cách tìm
          //  Mã Tài Khoản
            //Tên Tài Khoản
            //Mã Quyền
            if (cmbCachTim.Text == "Mã Tài Khoản")
            {
                dgvTaiKhoan.DataSource = TaiKhoanBUS.GetTaiKhoan("SELECT * FROM TaiKhoan WHERE MaTaiKhoan LIKE N'%" + btnFindTaiKhoan.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Tên Tài Khoản")
            {
                dgvTaiKhoan.DataSource = TaiKhoanBUS.GetTaiKhoan("SELECT * FROM TaiKhoan WHERE TenTaiKhoan LIKE N'%" + btnFindTaiKhoan.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Mã Quyền")
            {
                dgvTaiKhoan.DataSource = TaiKhoanBUS.GetTaiKhoan("SELECT * FROM TaiKhoan WHERE MaQuyen LIKE N'%" + btnFindTaiKhoan.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Cách tìm")
            {
                MessageBox.Show("Bạn chưa chọn cách tìm kiếm");
            }
        }

        private void btnAddTaiKhoan_Click(object sender, EventArgs e)
        {
            dialogThemTaiKhoan dialogThemTaiKhoan = new dialogThemTaiKhoan();
            dialogThemTaiKhoan.Show();
        }

        private void btnQuyen_Click(object sender, EventArgs e)
        {
            frmQuyen frmquyen = new frmQuyen();
            frmquyen.Show();
        }
    }
}
