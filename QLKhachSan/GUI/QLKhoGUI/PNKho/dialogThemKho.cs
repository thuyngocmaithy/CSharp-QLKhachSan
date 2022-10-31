using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLKhoGUI.PNKho
{
    public partial class dialogThemKho : Form
    {
        KhoBUS KhoBUS = new KhoBUS();
        TaiKhoanBUS TaiKhoanBus = new TaiKhoanBUS();
        public dialogThemKho()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnThemKho_Click(object sender, EventArgs e)
        {

            if (txtThemGhiChu.Text != "" && dtThemThoiGianNhap.ToString() != "")
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
                KhoDTO k = new KhoDTO(ma, dtThemThoiGianNhap.Value.ToString("yyyy-MM-dd HH:mm:ss"), cmbThemMaTaiKhoan.Text, txtThemGhiChu.Text, uutienhienthi);
                //Thời gian là kiểu datetime  HH:MI:SS
                //M truyền vào kiểu object rồi sao thêm and sửa
                //TẠI SAO KHÔNG CÓ NÚT RELOAD???
                //RỒI THÊM SỬA SAO HIỆN RA
                /*                MessageBox.Show(dtThemThoiGianNhap.Value.ToString("yyyy-MM-dd HH:mm:ss"));*/

                MessageBox.Show(ma + "--" + dtThemThoiGianNhap.Value.ToString("yyyy-MM-dd HH:mm:ss") + "--" + cmbThemMaTaiKhoan.Text + "--" + txtThemGhiChu.Text + "--" + uutienhienthi);
                // Them
                if (KhoBUS.ThemKho(k))
                {
                    MessageBox.Show("Thêm thành công");
                    txtThemUuTienHienThi.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập ghi chú");

            }

        }

        private void dialogThemKho_Load(object sender, EventArgs e)
        {
            cmbThemMaTaiKhoan.DataSource = TaiKhoanBus.GetTaiKhoan();
            cmbThemMaTaiKhoan.DisplayMember = "TenTaiKhoan";
            cmbThemMaTaiKhoan.ValueMember = "MaTaiKhoan";

        }
    }
}
