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

namespace QLKhachSan.GUI.QLKhoGUI.DieuChinhKho
{
    public partial class frmDieuChinhKho : Form
    {
        DieuChinhKhoBUS DieuChinhKhoBUS = new DieuChinhKhoBUS();
        public frmDieuChinhKho()
        {
            InitializeComponent();
        }

        private void frmDieuChinhKho_Load(object sender, EventArgs e)
        {
            Reset();
            dgvDieuChinhKho.AllowUserToAddRows = false;
            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvDieuChinhKho.Columns.Insert(4, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 100;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        
        public void Reset()
        {
            dgvDieuChinhKho.DataSource = DieuChinhKhoBUS.GetDieuChinhKho();
        }

        private void btnAddDieuChinhKho_Click(object sender, EventArgs e)
        {
            dialogThemDieuChinhKho dialogThemDieuChinhKho = new dialogThemDieuChinhKho();
            dialogThemDieuChinhKho.Show();
        }

        private void dgvDieuChinhKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dgvDieuChinhKho.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa điều chỉnh kho này?", row.Cells["MaDieuChinhKho"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (DieuChinhKhoBUS.XoaDieuChinhKho(row.Cells["MaDieuChinhKho"].Value.ToString()))
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
        }
    }
}
