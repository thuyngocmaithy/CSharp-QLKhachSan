using QLKhachSan.BUS;
using QLKhachSan.GUI.QLHeThongGUI.QLMenuGUI;
using System;
using System.ComponentModel;
using System.Windows.Forms;



namespace QLKhachSan.GUI.QLHeThongGUI
{
    public partial class frmQLMenu : Form
    {
        MenuBUS mnBUS = new MenuBUS();
        public frmQLMenu()
        {
            InitializeComponent();

        }

        private void frmQLMenu_Load(object sender, EventArgs e)
        {
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.DataSource = mnBUS.GetMenu();
            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvMenu.Columns.Insert(6, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 85;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            //Add btnEdit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvMenu.Columns.Insert(7, btnEdit);
            btnEdit.HeaderText = "Edit";
            btnEdit.Width = 85;
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
        }



        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dialogThemMenu dialogThem = new dialogThemMenu();
            dialogThem.ShowDialog();
        }


        private void lblReset_Click(object sender, EventArgs e)
        {
            Reset();
        }



        public void Reset()
        {
            dgvMenu.DataSource = mnBUS.GetMenu();
            this.dgvMenu.Sort(this.dgvMenu.Columns["UuTienHienThi"], ListSortDirection.Ascending);
        }




        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dgvMenu.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa menu này?", row.Cells["MaMenu"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (mnBUS.XoaMenu(row.Cells["MaMenu"].Value.ToString()))
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
                DataGridViewRow row = dgvMenu.Rows[e.RowIndex];
                string mamenu_Sua = row.Cells["MaMenu"].Value.ToString();
                string tenmenu_Sua = row.Cells["TenMenu"].Value.ToString();
                string loaimenu_Sua = row.Cells["LoaiMenu"].Value.ToString();
                string gianhap_Sua = row.Cells["GiaNhap"].Value.ToString();
                string giaban_Sua = row.Cells["GiaBan"].Value.ToString();
                string uutienhienthi_Sua = row.Cells["UuTienHienThi"].Value.ToString();
                dialogSuaMenu dialogSuaMenu = new dialogSuaMenu(mamenu_Sua, tenmenu_Sua, loaimenu_Sua, gianhap_Sua, giaban_Sua, uutienhienthi_Sua);
                dialogSuaMenu.Show();
            }
        }

        private void btnFindMenu_OnTextChange(object sender, EventArgs e)
        {
            if (cmbCachTim.Text == "Mã menu")
            {
                dgvMenu.DataSource = mnBUS.GetMenu("SELECT * FROM Menu WHERE MaMenu LIKE '%" + btnFindMenu.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Tên menu")
            {
                dgvMenu.DataSource = mnBUS.GetMenu("SELECT * FROM Menu WHERE TenMenu LIKE N'%" + btnFindMenu.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Loại menu")
            {
                dgvMenu.DataSource = mnBUS.GetMenu("SELECT * FROM Menu WHERE LoaiMenu LIKE N'%" + btnFindMenu.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Giá nhập")
            {
                dgvMenu.DataSource = mnBUS.GetMenu("SELECT * FROM Menu WHERE GiaNhap LIKE '%" + btnFindMenu.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Giá bán")
            {
                dgvMenu.DataSource = mnBUS.GetMenu("SELECT * FROM Menu WHERE GiaBan LIKE '%" + btnFindMenu.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Ưu tiên hiển thị")
            {
                dgvMenu.DataSource = mnBUS.GetMenu("SELECT * FROM Menu WHERE UuTienHienThi LIKE '%" + btnFindMenu.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Cách tìm")
            {
                MessageBox.Show("Bạn chưa chọn cách tìm kiếm");
            }

        }
    }
}
