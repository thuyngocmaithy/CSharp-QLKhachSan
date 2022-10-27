using QLKhachSan.BUS;
using QLKhachSan.GUI.ThueTraPhongGUI;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLKhachSan.GUI.MainPageGUI
{
    public partial class frmMainPage : Form
    {
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        PhongBUS PhongBUS = new PhongBUS();
        int luotthuephong, sophongcho, sophongcandon, sophongdangthue;
        public frmMainPage()
        {
            InitializeComponent();

        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            lblLuotThuePhong.Text = tinhLuotThuePhong().ToString()+ " lượt";
            lblSoPhongCho.Text = tinhSoPhongCho().ToString()+ " phòng";
            lblSoPhongDangThue.Text = tinhSoPhongDangThue().ToString() + " phòng";
            lblSoPhongCanDon.Text = tinhSoPhongCanDon().ToString() + " phòng";
        }
        private int tinhLuotThuePhong()
        {
            foreach (DataRow dt in hoaDonBUS.GetHoaDon(
                "SELECT COUNT(*) AS LuotThue " +
                "FROM HoaDon " +
                "WHERE (FORMAT (ThoiGianBatDau, 'yyyy-MM-dd')  <=  FORMAT (getdate(), 'yyyy-MM-dd') " +
                "AND (ThoiGianKetThuc is null OR ThoiGianKetThuc = '')) " +
                "OR FORMAT (ThoiGianBatDau, 'yyyy-MM-dd')  =  FORMAT (getdate(), 'yyyy-MM-dd') ").Rows)
            {
                luotthuephong = int.Parse(dt["LuotThue"].ToString());
            }
            return luotthuephong;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            lblLuotThuePhong.Text = tinhLuotThuePhong().ToString() + " lượt";
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            pnlMainPage.Controls.Clear();
            frmThueTraPhong frmThueTraPhong = new frmThueTraPhong();
            frmThueTraPhong.TopLevel = false;
            frmThueTraPhong.AutoScroll = true;
            pnlMainPage.Controls.Add(frmThueTraPhong);
            frmThueTraPhong.Show();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            pnlMainPage.Controls.Clear();
            frmThueTraPhong frmThueTraPhong = new frmThueTraPhong();
            frmThueTraPhong.TopLevel = false;
            frmThueTraPhong.AutoScroll = true;
            pnlMainPage.Controls.Add(frmThueTraPhong);
            frmThueTraPhong.Show();
            frmThueTraPhong.HienPhongDangThue("", "");
        }

        private void btnDonPhong_Click(object sender, EventArgs e)
        {
            pnlMainPage.Controls.Clear();
            frmThueTraPhong frmThueTraPhong = new frmThueTraPhong();
            frmThueTraPhong.TopLevel = false;
            frmThueTraPhong.AutoScroll = true;
            pnlMainPage.Controls.Add(frmThueTraPhong);
            frmThueTraPhong.Show();
            frmThueTraPhong.HienPhongCanDon("", "");
        }

        private int tinhSoPhongCho()
        {
            foreach (DataRow dt in PhongBUS.GetPhong(
                "SELECT COUNT(*) AS SL " +
                "FROM Phong " +
                "WHERE TinhTrang = N'Phòng chờ'").Rows)
            {
                sophongcho = int.Parse(dt["SL"].ToString());
            }
            return sophongcho;
        }
        private int tinhSoPhongCanDon()
        {

            foreach (DataRow dt in PhongBUS.GetPhong(
              "SELECT COUNT(*) AS SL " +
              "FROM Phong " +
              "WHERE TinhTrang = N'Phòng cần dọn'").Rows)
            {
                sophongcandon = int.Parse(dt["SL"].ToString());
            }
                return sophongcandon;
        }
        private int tinhSoPhongDangThue()
        {
            foreach (DataRow dt in PhongBUS.GetPhong(
              "SELECT COUNT(*) AS SL " +
              "FROM Phong " +
              "WHERE TinhTrang = N'Phòng đang thuê'").Rows)
            {
                sophongdangthue = int.Parse(dt["SL"].ToString());
            }
            return sophongdangthue;
        }
    }
}
