using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.QLLoaiPhongGUI
{
    public partial class dialogThemLoaiPhong : Form
    {
        LoaiPhongBUS LoaiPhongBUS = new LoaiPhongBUS();
        public dialogThemLoaiPhong()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemLoaiPhong_Click(object sender, EventArgs e)
        {

            if (txtThemTenLoaiPhong.Text != "")
            {
                int uutienhienthi = 1;
                string ma = LoaiPhongBUS.TaoMaLoaiPhong();
                // Tạo DTO
                if (txtThemUuTienHienThi.Text == "")
                {
                    uutienhienthi = 1;
                }
                else
                    uutienhienthi = int.Parse(txtThemUuTienHienThi.Text);
                LoaiPhongDTO lp = new LoaiPhongDTO(ma, txtThemTenLoaiPhong.Text, uutienhienthi);

                // Them
                if (LoaiPhongBUS.ThemLoaiPhong(lp))
                {
                    MessageBox.Show("Thêm thành công");
                    txtThemTenLoaiPhong.Text = "";
                    txtThemUuTienHienThi.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập tên loại phòng");

            }
            
        }
    }
}
