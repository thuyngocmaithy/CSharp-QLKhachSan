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

        public dialogSuaTaiKhoan(string mataikhoan )
        {
            InitializeComponent();
            loadcmbChonQuyen();
            this.mataikhoan = mataikhoan;
         
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
            if (txtSuaTenTaiKhoan.Text == "")
                MessageBox.Show("Sửa thất bại , tên tài khoản trống !");
            else
                if (txtSuaMatKhau.Text == "")
                MessageBox.Show("Sửa thất bại , mật khẩu trống !");
            else
                if (txtNhapLaiMatKhau.Text != txtSuaMatKhau.Text)
                MessageBox.Show("Sửa thất bại , mật khẩu nhập lại chưa chính xác ! ");
            else
            {
                String maquyen = cmbChonQuyen.SelectedValue.ToString();
                TaiKhoanDTO tk = new TaiKhoanDTO(mataikhoan, txtSuaTenTaiKhoan.Text, txtSuaMatKhau.Text, maquyen);

                // Them
                if (TaiKhoanBUS.SuaTaiKhoan(tk))
                {
                    MessageBox.Show("Sửa thành công");
                }
            }
        }
       
    }
}
