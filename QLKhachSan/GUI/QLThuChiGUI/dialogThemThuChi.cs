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
    }
}

