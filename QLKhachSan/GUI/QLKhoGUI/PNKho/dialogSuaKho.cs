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
using QLKhachSan.GUI.QLKhoGUI.PNKho;

namespace QLKhachSan.GUI.QLKhoGUI.PNKho
{
    public partial class dialogSuaKho : Form
    {
        KhoBUS KhoBUS = new KhoBUS();
        TaiKhoanBUS TaiKhoanBUS = new TaiKhoanBUS();
        string maphieunhapkho;
        frmPNKho frmQLKho = new frmPNKho();

        public dialogSuaKho(string maphieunhapkho)
        {
            InitializeComponent();
            this.maphieunhapkho = maphieunhapkho;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaKho_Click(object sender, EventArgs e)
        {
            if (txtSuaGhiChu.Text != "")
            {
                int uutienhienthi;

                if (txtSuaUuTienHienThi.Text == "")
                {
                    uutienhienthi = 1;
                }
                else
                    uutienhienthi = int.Parse(txtSuaUuTienHienThi.Text);
                KhoDTO k = new KhoDTO(maphieunhapkho, dtSuaThoiGianNhap.Value.ToString("yyyy-MM-dd HH:mm:ss"), cmbSuaMaTaiKhoan.SelectedValue.ToString(), txtSuaGhiChu.Text, uutienhienthi);
                MessageBox.Show(maphieunhapkho + "--" + dtSuaThoiGianNhap.Value.ToString("yyyy-MM-dd HH:mm:ss") + "--" + cmbSuaMaTaiKhoan.SelectedValue.ToString() + "--" + txtSuaGhiChu.Text + "--" + uutienhienthi);
                // =.= để sai thứ tự hỏi sao ko chạy !!!!!!!

                if (KhoBUS.SuaKho(k))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập ghi chú");
            }

        }

        private void dialogSuaKho_Load(object sender, EventArgs e)
        {
            cmbSuaMaTaiKhoan.DataSource = TaiKhoanBUS.GetTaiKhoan();
            cmbSuaMaTaiKhoan.DisplayMember = "TenTaiKhoan";
            cmbSuaMaTaiKhoan.ValueMember = "MaTaiKhoan";
        }
    }
}
