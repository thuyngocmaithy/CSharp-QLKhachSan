using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QLKhachSan.BUS;
using QLKhachSan.DAO;

namespace QLKhachSan.GUI.QLHeThongGUI.QLCachtinhtienGUI
{
    public partial class frmCachtinhtien : Form
    {
        CachtinhtienBUS cachTinhTienBUS = new CachtinhtienBUS();
        public frmCachtinhtien()
        {
            InitializeComponent();
        }
        private void frmCachtinhtien_Load(object sender, EventArgs e)
        {
            dataGridTinhtien.DataSource = cachTinhTienBUS.GetCachTinhTien(
                "SELECT tinhtien.MaCachTinhTien, tinhtien.TenCachTinhTien, " +
                "(SELECT tt.GiaTheoCachThue " +
                "FROM CachTinhTien_CachThue tt " +
                "WHERE tinhtien.MaCachTinhTien = tt.MaCachTinhTien " +
                "AND tt.MaCachThue= 'CT001') as 'Gia1Gio', " +
                "(SELECT tt.GiaTheoCachThue " +
                "FROM CachTinhTien_CachThue tt " +
                "WHERE tinhtien.MaCachTinhTien = tt.MaCachTinhTien " +
                "AND tt.MaCachThue= 'CT002') as 'GiaNgay', " +
                "tinhtien.PhuThuQuaGio " +
                "FROM CachTinhTien tinhtien");

            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dataGridTinhtien.Columns.Insert(5, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 85;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            //Add btnEdit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dataGridTinhtien.Columns.Insert(6, btnEdit);
            btnEdit.HeaderText = "Edit";
            btnEdit.Width = 85;
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
        }
        private void lblReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            dataGridTinhtien.DataSource = cachTinhTienBUS.GetCachTinhTien(
                  "SELECT tinhtien.MaCachTinhTien, tinhtien.TenCachTinhTien, " +
                  "(SELECT tt.GiaTheoCachThue " +
                  "FROM CachTinhTien_CachThue tt " +
                  "WHERE tinhtien.MaCachTinhTien = tt.MaCachTinhTien " +
                  "AND tt.MaCachThue= 'CT001') as 'Gia1Gio', " +
                  "(SELECT tt.GiaTheoCachThue " +
                  "FROM CachTinhTien_CachThue tt " +
                  "WHERE tinhtien.MaCachTinhTien = tt.MaCachTinhTien " +
                  "AND tt.MaCachThue= 'CT002') as 'GiaNgay', " +
                  "tinhtien.PhuThuQuaGio " +
                  "FROM CachTinhTien tinhtien");
        }

     

        private void dataGridTinhtien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dataGridTinhtien.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa cách tính tiền này?", row.Cells["MaCachTinhTien"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (cachTinhTienBUS.XoaCachTinhTien(row.Cells["MaCachTinhTien"].Value.ToString()))
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
                DataGridViewRow row = dataGridTinhtien.Rows[e.RowIndex];
                string macachtinhtien_Sua = row.Cells["MaCachTinhTien"].Value.ToString();
                dialogSuaTinhTien dialogSuaTinhTien = new dialogSuaTinhTien("Sửa",macachtinhtien_Sua);
                dialogSuaTinhTien.Show();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dialogSuaTinhTien dialogSuaTinhTien = new dialogSuaTinhTien("Thêm","");
            dialogSuaTinhTien.Show();
        }
    }
}
