using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLKhoGUI
{
    public partial class dialogThemKho : Form
    {
        KhoBUS KhoBUS = new KhoBUS();
        public dialogThemKho()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {

            if (txtMaNhanVien.Text != "" && txtThemGhiChu.Text != "" && dtThemThoiGianNhap.ToString() !="")
            {
                int uutienhienthi = 1;
                string ma = KhoBUS.TaoMaPhieuNhapKho();
                // Tạo DTO
                if (txtThemUuTienHienThi.Text == "")
                {
                    uutienhienthi = 1;
                }
                else
                    uutienhienthi = int.Parse(txtThemUuTienHienThi.Text);
                KhoDTO k = new KhoDTO(ma, txtThemGhiChu.Text, txtMaNhanVien.Text, dtThemThoiGianNhap.Value.ToString("yyyy-MM-dd HH:MI:SS"), uutienhienthi);
                //Thời gian là kiểu datetime
                //M truyền vào kiểu object rồi sao thêm and sửa
                //TẠI SAO KHÔNG CÓ NÚT RELOAD???
                //RỒI THÊM SỬA SAO HIỆN RA
                MessageBox.Show(dtThemThoiGianNhap.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                // Them
                if (KhoBUS.ThemKho(k))
                {
                    MessageBox.Show("Thêm thành công");
                    txtMaNhanVien.Text = "";
                    txtThemUuTienHienThi.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");

            }

        }


    }
}
