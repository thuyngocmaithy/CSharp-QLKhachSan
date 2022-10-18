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

namespace QLKhachSan.GUI.QLKhoGUI
{
    public partial class dialogSuaKho : Form
    {
        KhoBUS KhoBUS = new KhoBUS();
        string maphieunhapkho;
        frmQLKho frmQLKho = new frmQLKho();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
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
            if (cmbMaNhanVien.Text != "" && txtSuaGhiChu.Text != "" && dtSuaThoiGianNhap.ToString() != "")
            {
                int uutienhienthi;
                if (txtSuaUuTienHienThi.Text == "")
                {
                    uutienhienthi = 1;
                }
                else
                    uutienhienthi = int.Parse(txtSuaUuTienHienThi.Text);
                KhoDTO k = new KhoDTO(maphieunhapkho, txtSuaGhiChu.Text, cmbMaNhanVien.SelectedValue.ToString(), dtSuaThoiGianNhap.Value.ToString("yyyy-MM-dd HH:MI:SS"), uutienhienthi);

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
            cmbMaNhanVien.DataSource = nhanVienBUS.GetNhanVien();
            cmbMaNhanVien.DisplayMember = "TenNhanVien";
            cmbMaNhanVien.ValueMember = "MaNhanVien";
        }

    }
    
}
