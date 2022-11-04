using QLKhachSan.BUS;
using QLKhachSan.DTO;
using QLKhachSan.GUI.QLKhachSan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.GUI
{
    public partial class frmLogin : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tentaikhoan = txtTenDangNhap.Text;
            string matkhau = txtPassword.Text;
            //                KTRA TRẠNG THÁI HOẠT ĐỘNG
            //if (tkBUS.checkTrangThai(tkname) == false)
            //{
            //    JOptionPane.showMessageDialog(null, "Tài khoản của bạn hiện không hoạt động");
            //    return;
            //}
            //                KTRA TÊN ĐĂNG NHẬP VÀ MẬT KHẨU
           
            TaiKhoanDTO tk = taiKhoanBUS.checkLogin(tentaikhoan, matkhau);
            if (tk == null)
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                return;
            }
            else
            {
                if (ckbRemember.Checked)
                {
                    Properties.Settings.Default.TenTaiKhoan = tentaikhoan;
                    Properties.Settings.Default.MatKhau = matkhau;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Check = 1;
                }
                else
                {
                    Properties.Settings.Default.TenTaiKhoan = "";
                    Properties.Settings.Default.MatKhau ="";
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Check = 0;
                }
                frmQLKhachSan frmQLKhachSan = new frmQLKhachSan(tk.Mataikhoan);
                frmQLKhachSan.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckbRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRemember.Checked)
            {
                Properties.Settings.Default.Check = 1;
            }
            else
            {
                Properties.Settings.Default.Check = 0;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TenTaiKhoan != string.Empty)
            {
               txtTenDangNhap.Text = Properties.Settings.Default.TenTaiKhoan;
                txtPassword.Text = Properties.Settings.Default.MatKhau;
                if (Properties.Settings.Default.Check == 1)
                {
                    ckbRemember.Checked = true;
                }
                else
                {
                    ckbRemember.Checked = false;
                }
            }
            else
            {
                txtTenDangNhap.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}
