using QLKhachSan.BUS;
using System;
using System.Windows.Forms;

namespace QLKhachSan.GUI.DatPhongGUI
{
    public partial class frmCardDatPhong : Form
    {
        string hoten, status, ngaynhanphong, ngaytraphong, phongdat, phone, maphieudatphong;
        PhieuDatPhongBUS phieuDatPhongBUS = new PhieuDatPhongBUS();
        CTPDP_LoaiPhongBUS CTPDP_LoaiPhongBUS = new CTPDP_LoaiPhongBUS();
        CTPDP_PhongBUS CTPDP_PhongBUS = new CTPDP_PhongBUS();
        private void nhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogDsPhongNhan dialogDsPhongNhan = new dialogDsPhongNhan(maphieudatphong);
            dialogDsPhongNhan.Show();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean xoa = true;
            if (!phieuDatPhongBUS.XoaPhieuDatPhong(maphieudatphong))
            {
                xoa = false;
            }
            if (!
            CTPDP_LoaiPhongBUS.XoaCTPDP_LoaiPhong(maphieudatphong))
            {
                xoa = false;
            }
            if (!CTPDP_PhongBUS.XoaCTPDP_Phong(maphieudatphong))
            {
                xoa = false;
            }
            if(xoa==true)
            {
                MessageBox.Show("Xóa thành công");
            }    
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dialogThemPhieuDatPhong dialogThemPhieuDatPhong = new dialogThemPhieuDatPhong("Sửa", maphieudatphong);
            dialogThemPhieuDatPhong.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(lblOption, 0, 0);
        }

        int soluongphong, stt;
        public frmCardDatPhong()
        {
            InitializeComponent();
        }

        public frmCardDatPhong(string maphieudatphong, int stt, string hoten, string status, string ngaynhanphong, string ngaytraphong, int soluongphong, string phongso, string phone)
        {
            InitializeComponent();
            this.maphieudatphong = maphieudatphong;
            this.stt = stt;
            this.hoten = hoten;
            this.status = status;
            this.ngaynhanphong = ngaynhanphong;
            this.ngaytraphong = ngaytraphong;
            this.soluongphong = soluongphong;
            this.phongdat = phongso;
            this.phone = phone;
        }

        private void frmCardDatPhong_Load(object sender, EventArgs e)
        {
            lblStt.Text = "#" + stt.ToString();
            lblHoTen.Text = "   " + hoten;
            lblPhone.Text = "   " + phone;
            lblPhongSo.Text = "   " + phongdat;
            lblSoLuongPhong.Text = "   " + soluongphong.ToString();
            lblTime.Text = "   " + ngaynhanphong + " - " + ngaytraphong;
            lblTrangThai.Text = "   " + status;

        }
    }
}
