using QLKhachSan.BUS;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.QLLoaiPhongGUI
{
    public partial class frmQLLoaiPhong : Form
    {
        LoaiPhongBUS loaiPhongBUS = new LoaiPhongBUS();
        public frmQLLoaiPhong()
        {
            InitializeComponent();
        }

        private void frmQLLoaiPhong_Load(object sender, EventArgs e)
        {
            LoadLoaiPhong();
            dgvLoaiPhong.AllowUserToAddRows = false;
            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvLoaiPhong.Columns.Insert(3, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 100;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            //Add btnEdit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvLoaiPhong.Columns.Insert(4, btnEdit);
            btnEdit.HeaderText = "Edit";
            btnEdit.Width = 100;
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

            //Chọn text trong cmbFind
            cmbCachTim.SelectedItem = "Cách tìm";
        }


        private void btnAddDatPhong_Click(object sender, EventArgs e)
        {
            dialogThemLoaiPhong dialogThemLoaiPhong = new dialogThemLoaiPhong();
            dialogThemLoaiPhong.Show();
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            LoadLoaiPhong();
        }

        private void dgvLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dgvLoaiPhong.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa loại phòng này?", row.Cells["MaLoaiPhong"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (loaiPhongBUS.XoaLoaiPhong(row.Cells["MaLoaiPhong"].Value.ToString()))
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadLoaiPhong();

                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            if (e.ColumnIndex == 1)
            {
                DataGridViewRow row = dgvLoaiPhong.Rows[e.RowIndex];
                dialogSuaLoaiPhong dialogSuaLoaiPhong = new dialogSuaLoaiPhong(row.Cells["MaLoaiPhong"].Value.ToString());
                dialogSuaLoaiPhong.Show();

            }
        }
       public void LoadLoaiPhong()
        {

            dgvLoaiPhong.DataSource = loaiPhongBUS.GetLoaiPhong(); // Get Loại Phòng
            this.dgvLoaiPhong.Sort(this.dgvLoaiPhong.Columns["UuTienHienThi"], ListSortDirection.Ascending);
        }
        //Phương thức truy vấn để xem dữ liệu

        private void btnFindLoaiPhong_OnTextChange(object sender, EventArgs e)
        {
   
            if(cmbCachTim.Text=="Mã loại phòng")
            {
                dgvLoaiPhong.DataSource = loaiPhongBUS.GetLoaiPhong("SELECT * FROM LoaiPhong WHERE MaLoaiPhong LIKE N'%"+btnFindLoaiPhong.text.Trim()+"%' ");
            }
            if (cmbCachTim.Text == "Tên loại phòng")
            {
                dgvLoaiPhong.DataSource = loaiPhongBUS.GetLoaiPhong("SELECT * FROM LoaiPhong WHERE TenLoaiPhong LIKE N'%" + btnFindLoaiPhong.text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Ưu tiên hiển thị")
            {
                dgvLoaiPhong.DataSource = loaiPhongBUS.GetLoaiPhong("SELECT * FROM LoaiPhong WHERE UuTienHienThi LIKE N'%" + btnFindLoaiPhong.text.Trim() + "%' ");
            }
            if(cmbCachTim.Text == "Cách tìm")
            {
                MessageBox.Show("Bạn chưa chọn cách tìm kiếm");
            }    
        }





    }
}