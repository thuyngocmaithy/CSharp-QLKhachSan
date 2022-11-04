using Guna.UI2.WinForms;
using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLThuChiGUI
{
    public partial class dialogThemThuChi : Form
    {
        ThuChiBUS ThuChiBUS = new ThuChiBUS();
        public dialogThemThuChi()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemThuChi_Click(object sender, EventArgs e)
        {

            if (txtThemSoTien.Text != "")
            {
                string ma = ThuChiBUS.TaoMaPhieuThuChi();
                // Tạo DTO 
                ThuChiDTO tc = new ThuChiDTO(ma, dtThemThoiGian.Value.ToString("yyyy-MM-dd"), cmbLoaiHinh.Text, txtThemSoTien.Text, txtThemNoiDung.Text);              
                // Them
                if (ThuChiBUS.ThemThuChi(tc))
                {
                    MessageBox.Show("Thêm thành công");
                    txtThemSoTien.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn loại hình");

            }

        }

        private void dialogThemThuChi_Load(object sender, EventArgs e)
        {
            dtThemThoiGian.Value = DateTime.Now;
        }

        private void txtThemSoTien_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtThemSoTien);
        }
        public void AddCommaToTextBox(Guna2TextBox guna2TextBox)
        {
            string value = guna2TextBox.Text.Replace(",", "")
                .Replace("đ", "").Replace(".", "").TrimStart('0');
            decimal ul;
            if (decimal.TryParse(value, out ul))
            {
                guna2TextBox.Text = string.Format("{0:#,###}", ul);
                var length = guna2TextBox.Text.Length;
                guna2TextBox.SelectionStart = length;
            }
        }

        private void txtThemSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

