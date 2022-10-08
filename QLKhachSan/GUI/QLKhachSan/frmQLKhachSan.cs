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
            frmMainPage frmMainPage = new frmMainPage();
            frmMainPage.MdiParent = this;
            frmMainPage.Show();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            frmDatPhong frmDatPhong = new frmDatPhong();
            frmDatPhong.MdiParent = this;
            frmDatPhong.Show();
        }

        private void btnThueTraPhong_Click(object sender, EventArgs e)
        {
            frmThueTraPhong frmThueTraPhong = new frmThueTraPhong();
            frmThueTraPhong.MdiParent = this;
            frmThueTraPhong.Show();

        }

        private void btnQLKho_Click(object sender, EventArgs e)
        {
            frmQLKho frmQLKho = new frmQLKho();
            frmQLKho.MdiParent = this;
            frmQLKho.Show();

        }

        private void btnQLThuChi_Click(object sender, EventArgs e)
        {
            frmQLThuChi frmQLThuChi = new frmQLThuChi();
            frmQLThuChi.MdiParent = this;
            frmQLThuChi.Show();

        }

        private void btnQLHeThong_Click(object sender, EventArgs e)
        {
            frmQLHeThong frmQLHeThong = new frmQLHeThong();
            frmQLHeThong.MdiParent = this;
            frmQLHeThong.Show();

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frmTaiKhoan = new frmTaiKhoan();
            frmTaiKhoan.MdiParent = this;
            frmTaiKhoan.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Đăng xuất";

        }

    }
}
