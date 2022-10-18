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
        frmQLLoaiPhong frmQLLoaiPhong = new frmQLLoaiPhong();
        public dialogSuaLoaiPhong(string maloaiphong)
        {
            InitializeComponent();
            this.maloaiphong = maloaiphong;
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

                // Them
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
    }
}
