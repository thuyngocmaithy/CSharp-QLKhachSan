using QLKhachSan.BUS;
using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.GUI.TaiKhoanGUI
{
    public partial class dialogSuaTaiKhoan : Form
    {
        
        TaiKhoanBUS TaiKhoanBUS = new TaiKhoanBUS();
        QuyenBUS quyenBUS = new QuyenBUS();
        string mataikhoan;

        public dialogSuaTaiKhoan(string mataikhoan)
        {
            InitializeComponent();
            loadcmbChonQuyen();
            this.mataikhoan = mataikhoan;
        }
        
        private void setText()
        {
            foreach (DataRow dr in TaiKhoanBUS.GetTaiKhoan(
                "SELECT * " +
                "FROM TaiKhoan " +
                "WHERE MaTaiKhoan = '"+mataikhoan+"'").Rows)
            {
                cmbChonQuyen.SelectedValue = dr["MaQuyen"].ToString();
            }
        }
        public void loadcmbChonQuyen()
        {
            cmbChonQuyen.Items.Clear();
            cmbChonQuyen.Items.Add("Chọn Quyền");
            cmbChonQuyen.DataSource = quyenBUS.GetCmb();
            cmbChonQuyen.DisplayMember = "TenQuyen";
            cmbChonQuyen.ValueMember = "MaQuyen";
        }            
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "")
                MessageBox.Show("Mật khẩu cũ không chính xác!");
            else
                if (txtMatKhauMoi.Text == "")
                MessageBox.Show("Mật khẩu mới trống!");
            else
                if (txtNhapLaiMatKhau.Text != txtMatKhauMoi.Text)
                MessageBox.Show("Mật khẩu nhập lại không chính xác");
            else
            {
                String maquyen = cmbChonQuyen.SelectedValue.ToString();
                String matkhau = TaiKhoanBUS.Encrypt(txtMatKhauMoi.Text, true);
                TaiKhoanDTO tk = new TaiKhoanDTO(mataikhoan, matkhau, maquyen);

                // Them
                if (TaiKhoanBUS.SuaTaiKhoan(tk))
                {
                    MessageBox.Show("Sửa thành công");
                }
            }
        }

        private void dialogSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            setText();

        }


    }
}
