using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.LichSuGUI
{
    public partial class frmLichSu : Form
    {
        public frmLichSu()
        {
            InitializeComponent();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

        }

        private void frmLichSu_Load(object sender, EventArgs e)
        {
            dgvLichSu.AllowUserToAddRows = false;
            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvLichSu.Columns.Insert(5, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 100;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            //Add btnEdit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvLichSu.Columns.Insert(6, btnEdit);
            btnEdit.HeaderText = "Edit";
            btnEdit.Width = 100;
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
