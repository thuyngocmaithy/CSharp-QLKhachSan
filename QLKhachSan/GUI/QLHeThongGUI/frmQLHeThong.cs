using QLKhachSan.GUI.QLHeThongGUI.QLLoaiPhongGUI;
using QLKhachSan.GUI.QLHeThongGUI.QLPhongGUI;
using QLKhachSan.GUI.QLHeThongGUI.ThietLapKhacGUI;
using System;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI
{
    public partial class frmQLHeThong : Form
    {
        public frmQLHeThong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmQLLoaiPhong frmQLLoaiPhong = new frmQLLoaiPhong();
            frmQLLoaiPhong.TopLevel = false;
            frmQLLoaiPhong.AutoScroll = true;
            this.Controls.Add(frmQLLoaiPhong);
            frmQLLoaiPhong.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmThietLapKhac frmThietLapKhac = new frmThietLapKhac();
            frmThietLapKhac.TopLevel = false;
            frmThietLapKhac.AutoScroll = true;
            this.Controls.Add(frmThietLapKhac);
            frmThietLapKhac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmQLPhong frmQLPhong = new frmQLPhong();
            frmQLPhong.TopLevel = false;
            frmQLPhong.AutoScroll = true;
            this.Controls.Add(frmQLPhong);
            frmQLPhong.Show();
        }
    }
}
