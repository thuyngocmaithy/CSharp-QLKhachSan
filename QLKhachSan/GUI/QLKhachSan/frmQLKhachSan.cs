using QLKhachSan.GUI.DatPhongGUI;
using QLKhachSan.GUI.ThueTraPhongGUI;
using QLKhachSan.GUI.QLHeThongGUI;
using QLKhachSan.GUI.QLKhoGUI;
using QLKhachSan.GUI.QLThuChiGUI;
using QLKhachSan.GUI.TaiKhoanGUI;
using QLKhachSan.GUI.MainPageGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using java.lang;

namespace QLKhachSan.GUI.MainPageGUI
{
    public partial class frmQLKhachSan : Form
    {
        public frmQLKhachSan()
        {
            InitializeComponent();
        }

        bool mnuExpanded = false;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!bunifuTransition1.IsCompleted) return;
            if(pnlMainMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if(!mnuExpanded)
                {
                    mnuExpanded = true;
                    pnlMainMenu.Visible = false;
                    pnlMainMenu.Width = 324;
                    bunifuTransition1.Show(pnlMainMenu);
                    lblLogoResize.Visible = false;
                }    
            }    
            else
            {
                if(mnuExpanded)
                {
                    mnuExpanded=false;
                    pnlMainMenu.Visible = false;
                    pnlMainMenu.Width = 85;
                    bunifuTransition1.Show(pnlMainMenu);
                    lblLogoResize.Visible = true;
                }    
            }    
        }
        private void btnTrangChinh_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            frmMainPage frmMainPage = new frmMainPage();
            frmMainPage.TopLevel = false;
            frmMainPage.AutoScroll = true;
            pnlMain.Controls.Add(frmMainPage);
            frmMainPage.Show();

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            frmDatPhong frmDatPhong = new frmDatPhong();
            frmDatPhong.TopLevel = false;
            frmDatPhong.AutoScroll = true;
            pnlMain.Controls.Add(frmDatPhong);
            frmDatPhong.Show();
        }

        private void btnThueTraPhong_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            frmThueTraPhong frmThueTraPhong = new frmThueTraPhong();
            frmThueTraPhong.TopLevel = false;
            frmThueTraPhong.AutoScroll = true;
            pnlMain.Controls.Add(frmThueTraPhong);
            frmThueTraPhong.Show();
        }

        private void btnQLKho_Click(object sender, EventArgs e)
        {
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

        }

        private void btnQLHeThong_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            frmQLHeThong frmQLHeThong = new frmQLHeThong();
            frmQLHeThong.TopLevel = false;
            frmQLHeThong.AutoScroll = true;
            pnlMain.Controls.Add(frmQLHeThong);
            frmQLHeThong.Show();

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            frmTaiKhoan frmTaiKhoan = new frmTaiKhoan();
            frmTaiKhoan.TopLevel = false;
            frmTaiKhoan.AutoScroll = true;
            pnlMain.Controls.Add(frmTaiKhoan);
            frmTaiKhoan.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            pnlMain.Text = "Đăng xuất";

        }

    }
}
