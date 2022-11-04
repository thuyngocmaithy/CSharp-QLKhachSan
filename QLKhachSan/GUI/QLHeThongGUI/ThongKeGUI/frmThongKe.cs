using Guna.UI2.WinForms;
using QLKhachSan.BUS;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;


namespace QLKhachSan.GUI.QLHeThongGUI.ThongKeGUI
{
    public partial class frmThongKe : Form
    {


  


        public frmThongKe()
        {
            InitializeComponent();
        }
        private void HienThongKeDoanhThu()
        {
            pnlThongKe.Controls.Clear();
            frmThongKeDoanhThu frmThongKeDoanhThu = new frmThongKeDoanhThu();
            frmThongKeDoanhThu.TopLevel = false;
            frmThongKeDoanhThu.AutoScroll = true;
            pnlThongKe.Controls.Add(frmThongKeDoanhThu);
            frmThongKeDoanhThu.Show();
        }
        private void HienThongKeLoiNhuan()
        {
            pnlThongKe.Controls.Clear();
            frmThongKeLoiNhuan frmThongKeLoiNhuan = new frmThongKeLoiNhuan();
            frmThongKeLoiNhuan.TopLevel = false;
            frmThongKeLoiNhuan.AutoScroll = true;
            pnlThongKe.Controls.Add(frmThongKeLoiNhuan);
            frmThongKeLoiNhuan.Show();
        }
        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            HienThongKeDoanhThu();
        }

        private void btnThongKeLoiNhuan_Click(object sender, EventArgs e)
        {
            HienThongKeLoiNhuan();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            HienThongKeDoanhThu();
        }
    }
}