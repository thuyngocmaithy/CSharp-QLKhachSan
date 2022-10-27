using System;
using System.Windows.Forms;

namespace QLKhachSan.GUI.DatPhongGUI
{
    public partial class frmDatPhong : Form
    {

        public frmDatPhong()
        {
            InitializeComponent();
        }
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            this.pnlDatPhong.Controls.Clear();
            frmXemTheoNgay frmXemTheoNgay = new frmXemTheoNgay();
            frmXemTheoNgay.TopLevel = false;
            frmXemTheoNgay.AutoScroll = true;
            pnlDatPhong.Controls.Add(frmXemTheoNgay);
            frmXemTheoNgay.Show();
        }

        private void btnXemTheoNgay_Click(object sender, EventArgs e)
        {
            this.pnlDatPhong.Controls.Clear();
            frmXemTheoNgay frmXemTheoNgay = new frmXemTheoNgay();
            frmXemTheoNgay.TopLevel = false;
            frmXemTheoNgay.AutoScroll = true;
            pnlDatPhong.Controls.Add(frmXemTheoNgay);
            frmXemTheoNgay.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            this.pnlDatPhong.Controls.Clear();
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.TopLevel = false;
            frmTimKiem.AutoScroll = false;
            pnlDatPhong.Controls.Add(frmTimKiem);
            frmTimKiem.Show();

        }

        private void btnAddDatPhong_Click(object sender, EventArgs e)
        {
            dialogThemPhieuDatPhong dialogThemPhieuDatPhong = new dialogThemPhieuDatPhong("Thêm");
            dialogThemPhieuDatPhong.Show();
        }
    }
}