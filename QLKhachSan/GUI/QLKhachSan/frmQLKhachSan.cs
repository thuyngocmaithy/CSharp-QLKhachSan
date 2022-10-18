using QLKhachSan.GUI.DatPhongGUI;
using QLKhachSan.GUI.QLHeThongGUI;
using QLKhachSan.GUI.QLKhoGUI;
using QLKhachSan.GUI.QLThuChiGUI;
using QLKhachSan.GUI.TaiKhoanGUI;
using QLKhachSan.GUI.ThueTraPhongGUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLKhachSan.GUI.MainPageGUI
{
    public partial class frmQLKhachSan : Form
    {
        public frmQLKhachSan()
        {
            InitializeComponent();
        }

        bool showMenu = false;
        bool pnlPanel = true;
        private void btnTrangChinh_Click(object sender, EventArgs e)
        {
            pnlPanel = false;
            this.pnlMain.Controls.Clear();
            frmMainPage frmMainPage = new frmMainPage();
            frmMainPage.TopLevel = false;
            frmMainPage.AutoScroll = true;
            pnlMain.Controls.Add(frmMainPage);
            frmMainPage.Show();

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            pnlPanel = false;
            this.pnlMain.Controls.Clear();
            frmDatPhong frmDatPhong = new frmDatPhong();
            frmDatPhong.TopLevel = false;
            frmDatPhong.AutoScroll = true;
            pnlMain.Controls.Add(frmDatPhong);
            frmDatPhong.Show();
        }

        private void btnThueTraPhong_Click(object sender, EventArgs e)
        {
            pnlPanel = false;
            this.pnlMain.Controls.Clear();
            frmThueTraPhong frmThueTraPhong = new frmThueTraPhong();
            frmThueTraPhong.TopLevel = false;
            frmThueTraPhong.AutoScroll = true;
            pnlMain.Controls.Add(frmThueTraPhong);
            frmThueTraPhong.Show();
        }

        private void btnQLKho_Click(object sender, EventArgs e)
        {
            pnlPanel = false;
            this.pnlMain.Controls.Clear();
            frmQLKho frmQLKho = new frmQLKho();
            frmQLKho.TopLevel = false;
            frmQLKho.AutoScroll = true;
            pnlMain.Controls.Add(frmQLKho);
            frmQLKho.Show();

        }

        private void btnQLThuChi_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            frmQLThuChi frmQLThuChi = new frmQLThuChi();
            frmQLThuChi.TopLevel = false;
            frmQLThuChi.AutoScroll = true;
            pnlMain.Controls.Add(frmQLThuChi);
            frmQLThuChi.Show();
            pnlPanel = false;

        }

        private void btnQLHeThong_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            frmQLHeThong frmQLHeThong = new frmQLHeThong();
            frmQLHeThong.TopLevel = false;
            frmQLHeThong.AutoScroll = true;
            pnlMain.Controls.Add(frmQLHeThong);
            pnlPanel = false;
            frmQLHeThong.Show();

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            frmTaiKhoan frmTaiKhoan = new frmTaiKhoan();
            frmTaiKhoan.TopLevel = false;
            frmTaiKhoan.AutoScroll = true;
            pnlMain.Controls.Add(frmTaiKhoan);
            pnlPanel = false;
            frmTaiKhoan.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

                Application.Exit();
         
        }
        int count = 0;
        private void lblShowMenu_Click(object sender, EventArgs e)
        {

            count++;
            if (count % 2 == 0)
            {
                showMenu = false;
            }
            else
            {
                showMenu = true;
            }
            if (!bunifuTransition1.IsCompleted) return;
            if (showMenu)
            {
                lblShowMenu.Left = 260;
                pnlMainMenu.Visible = false;
                pnlMainMenu.Width = 325;
                bunifuTransition1.Show(pnlMainMenu);
                btnDatPhong.Visible = true;
                btnLogout.Visible = true;
                btnQLHeThong.Visible = true;
                btnQLKho.Visible = true;
                btnQLThuChi.Visible = true;
                btnTaiKhoan.Visible = true;
                btnThueTraPhong.Visible = true;
                btnTrangChinh.Visible = true;
            }
            else
            {
                lblShowMenu.Left = 25;
                pnlMainMenu.Visible = false;
                pnlMainMenu.Width = 85;
                bunifuTransition1.Show(pnlMainMenu);
                btnDatPhong.Visible = false;
                btnLogout.Visible = false;
                btnQLHeThong.Visible = false;
                btnQLKho.Visible = false;
                btnQLThuChi.Visible = false;
                btnTaiKhoan.Visible = false;
                btnThueTraPhong.Visible = false;
                btnTrangChinh.Visible = false;
            }
        }

        private void lblPanel_Click(object sender, EventArgs e)
        {

            if (pnlPanel == false)
            {   
                this.pnlMain.Controls.Clear();
                pnlMain.BackgroundImage = Image.FromFile
                (System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal)
                + @"\github\csharp-qlkhachsan\icon\panel-design.png");
                pnlPanel = true;
            }

        }
    }
}
