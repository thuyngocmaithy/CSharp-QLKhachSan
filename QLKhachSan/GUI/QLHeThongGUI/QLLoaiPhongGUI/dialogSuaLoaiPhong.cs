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

namespace QLKhachSan.GUI.QLHeThongGUI.QLLoaiPhongGUI
{
    public partial class dialogSuaLoaiPhong : Form
    {
        LoaiPhongBUS loaiPhongBUS = new LoaiPhongBUS();
        string maloaiphong;
        public dialogSuaLoaiPhong(string maloaiphong)
        {
            InitializeComponent();
            this.maloaiphong = maloaiphong;
        }

        private void setText()
        {
            foreach(DataRow dr in loaiPhongBUS.GetLoaiPhong(
                "SELECT * " +
                "FROM LoaiPhong " +
                "WHERE MaLoaiPhong = '"+maloaiphong+"'").Rows)
            {
                txtSuaTenLoaiPhong.Text = dr["TenLoaiPhong"].ToString();
                txtSuaUuTienHienThi.Text = dr["UuTienHienThi"].ToString();
            }    
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaLoaiPhong_Click(object sender, EventArgs e)
        {

            if (txtSuaTenLoaiPhong.Text != "")
            {
                int uutienhienthi = 1;
                // Tạo DTO
                if (txtSuaUuTienHienThi.Text == "")
                {
                    uutienhienthi = 1;
                }
                else
                    uutienhienthi = int.Parse(txtSuaUuTienHienThi.Text);
                LoaiPhongDTO lp = new LoaiPhongDTO(maloaiphong, txtSuaTenLoaiPhong.Text, uutienhienthi);

                // Sua
                if (loaiPhongBUS.SuaLoaiPhong(lp))
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
                MessageBox.Show("Hãy nhập tên loại phòng");

            }

        }

        private void dialogSuaLoaiPhong_Load(object sender, EventArgs e)
        {
            setText();
        }

        private void txtSuaUuTienHienThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
