using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Windows.Forms;

namespace QLKhachSan.GUI.TaiKhoanGUI
{
    public partial class dialogThemTaiKhoan : Form
    {

        TaiKhoanBUS TaiKhoanBUS = new TaiKhoanBUS();
        QuyenBUS quyenBUS = new QuyenBUS();

        public dialogThemTaiKhoan()
        {
            InitializeComponent();
            loadcmbChonQuyen();
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

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtThemTenTaiKhoan.Text == "")
                MessageBox.Show("Thêm thất bại , tên tài khoản trống !");
            else
            if (txtMatKhau.Text == "")
                MessageBox.Show("Thêm thất bại , mật khẩu trống !");
            else
            if (txtNhapLaiMatKhau.Text != txtMatKhau.Text)
                MessageBox.Show("Thêm thất bại , mật khẩu nhập lại chưa chính xác ! ");
            else
            {
                string mataikhoan = TaiKhoanBUS.TaoMaTaiKhoan();
                string maquyen = cmbChonQuyen.SelectedValue.ToString();
                string matkhau = TaiKhoanBUS.Encrypt(txtMatKhau.Text, true);
                TaiKhoanDTO tk = new TaiKhoanDTO(mataikhoan, txtThemTenTaiKhoan.Text, matkhau, maquyen);
                // Them
                if (TaiKhoanBUS.ThemTaiKhoan(tk))
                {
                    MessageBox.Show("Thêm thành công");
                }
            }

        }
    }
}

