using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLKhachSan.GUI.TaiKhoanGUI.QuyenGUI
{
    public partial class dialogChonChucNang : Form
    {
        ChucNangBUS chucNangBUS = new ChucNangBUS();
        QuyenBUS quyenBUS = new QuyenBUS();
        public dialogChonChucNang()
        {
            InitializeComponent();
            loadcmbChonQuyen();
           
        }

        private void dialogChonChucNang_Load(object sender, EventArgs e)
        {
            dgvChonChucNang.DataSource = chucNangBUS.GetChucNang();
            
        }
        public void loadChucNangThuocQuyen(String maquyen)
        {
            foreach (DataGridViewRow row in dgvChonChucNang.Rows)
            {
                row.Cells["Chon"].Value = false;
            }
            DataTable dt = quyenBUS.getChucNang(maquyen);
            for(int i =0; i< dgvChonChucNang.Rows.Count; i++)
                foreach(DataRow dr in dt.Rows)
                  foreach(DataColumn dc in dt.Columns)
                    if (dr[dc].Equals(dgvChonChucNang.Rows[i].Cells["MaChucNang"].Value))
                        //    MessageBox.Show("chuc nang dang co " + dr[dc]);
                            dgvChonChucNang.Rows[i].Cells["Chon"].Value = true;                                               

        }
        
        public void loadcmbChonQuyen()
        {
            cmbMaQuyen.Items.Clear();
            cmbMaQuyen.DataSource = quyenBUS.GetCmb();
            cmbMaQuyen.DisplayMember = "TenQuyen";
            cmbMaQuyen.ValueMember = "MaQuyen";
          
        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMaQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadChucNangThuocQuyen(cmbMaQuyen.SelectedValue.ToString());
           // MessageBox.Show("Bạn đã chọn mã quyền " + cmbMaQuyen.SelectedValue.ToString());
        }

        private void btnChonChucNang_Click(object sender, EventArgs e) 
        {
            string maquyen = cmbMaQuyen.SelectedValue.ToString();
            List<String> chucnang = new List<string>();


            foreach (DataGridViewRow row in dgvChonChucNang.Rows)
            {
                if ((bool)row.Cells["Chon"].FormattedValue == true)
                {
                    chucnang.Add(row.Cells["MaChucNang"].Value.ToString());
                    // MessageBox.Show(" Chuc nang duoc chon " + row.Cells["MaChucNang"].Value.ToString() +" mã quyền "+ maquyen);
                }
            }
            quyenBUS.XoaQuyenChucNang(maquyen);
            Boolean them = true;

            foreach (string chucn in chucnang)
            {
                //MessageBox.Show(" Chuc nang duoc chon " + chucn + " mã quyền " + maquyen);
                if (!quyenBUS.ThemQuyenChucNang(maquyen, chucn))
                    them = false;

            }
            if (them)
                MessageBox.Show("Thêm chức năng thành công");
            else
                MessageBox.Show("Thêm chức năng thất bại");
        }

    }
}
