using QLKhachSan.GUI.QLHeThongGUI.QLLoaiPhongGUI;
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
    }
}
