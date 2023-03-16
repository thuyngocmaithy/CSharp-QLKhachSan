using Bunifu.Framework.UI;
using QLKhachSan.BUS;
using QLKhachSan.GUI.DatPhongGUI;
using QLKhachSan.GUI.MainPageGUI;
using QLKhachSan.GUI.QLHeThongGUI;
using QLKhachSan.GUI.QLKhoGUI;
using QLKhachSan.GUI.QLThuChiGUI;
using QLKhachSan.GUI.TaiKhoanGUI;
using QLKhachSan.GUI.ThueTraPhongGUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLKhachSan
{
    public partial class frmQLKhachSan : Form
    {
        ThietLapKhacBUS tlkBUS = new ThietLapKhacBUS();
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        QuyenBUS quyenBUS = new QuyenBUS();
        List<String> lsChucNang = new List<String>();
        string mataikhoan, maquyen;
        public frmQLKhachSan(string mataikhoan)
        {
            InitializeComponent();
            this.mataikhoan = mataikhoan;
        }

        bool showMenu = false;
        bool pnlPanel = true;
        private void btnTrangChinh_Click(object sender, EventArgs e)
        {
            pnlPanel = false;
            this.pnlMain.Controls.Clear();
            frmMainPage frmfrmMainPage = new frmMainPage(mataikhoan);
            frmfrmMainPage.TopLevel = false;
            frmfrmMainPage.AutoScroll = true;
            pnlMain.Controls.Add(frmfrmMainPage);
            frmfrmMainPage.Show();

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
            frmThueTraPhong frmThueTraPhong = new frmThueTraPhong(mataikhoan);
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
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
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
                pnlMainMenu.BringToFront();
                bunifuTransition1.Show(pnlMainMenu);
                 btnTrangChinh.Visible = true;

                foreach (String btn in lsChucNang)
                {
                    foreach (Control ctrl in this.pnlMainMenu.Controls)
                    {
                        if (ctrl is BunifuFlatButton)
                        {
                            if (ctrl.Name == btn)
                            {
                                ctrl.Visible = true;
                            }
                        }
                    }
                }
                btnLogout.Visible = true;
            }
            else
            {
                lblShowMenu.Left = 25;
                pnlMainMenu.Visible = false;
                pnlMainMenu.SendToBack();
                bunifuTransition1.Show(pnlMainMenu);
                btnTrangChinh.Visible = false;

                foreach (String btn in lsChucNang)
                {
                    foreach (Control ctrl in this.pnlMainMenu.Controls)
                    {
                        if (ctrl is BunifuFlatButton)
                        {
                            if (ctrl.Name == btn)
                            {
                                ctrl.Visible = false;
                            }
                        }
                    }
                }
                btnLogout.Visible = false;
            }
        }

        private void lblPanel_Click(object sender, EventArgs e)
        {

            if (pnlPanel == false)
            {
                foreach (DataRow tlk in tlkBUS.GetThietLapKhac().Rows)
                {
                    this.pnlMain.Controls.Clear();
                    pnlMain.BackgroundImage = Image.FromFile
                  (Path.GetFullPath(@"icon\" + tlk["Panel"].ToString()));
                    pnlPanel = true;
                }
            }
        }
        private void getDsChucNang()
        {

            foreach (DataRow dr in quyenBUS.GetQuyen(
                "SELECT TenChucNang " +
                "FROM Quyen_ChucNang, ChucNang " +
                "WHERE MaQuyen = '" + maquyen + "' " +
                "AND Quyen_ChucNang.MaChucNang = ChucNang.MaChucNang").Rows)
            {
                lsChucNang.Add(convertTenChucNang(dr["TenChucNang"].ToString()));
            }
        }
        public string convertTenChucNang(string s)
        {
            s = convertString.RemoveUnicode(s);
            s = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
            s = s.Replace(" ", "");
            s = s.Replace("-", "");
            s = string.Concat("btn" + s);
            return s;
        }


        private void frmQLKhachSan_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in taiKhoanBUS.GetTaiKhoan(
                "SELECT * " +
                "FROM TaiKhoan " +
                "WHERE MaTaiKhoan = '" + mataikhoan + "'").Rows)
            {
                txtTenTaiKhoan.Text = "Xin chào, " + dr["TenTaiKhoan"].ToString();
                maquyen = dr["MaQuyen"].ToString();
            }
            getDsChucNang();


            foreach (DataRow tlk in tlkBUS.GetThietLapKhac().Rows)
            {
                lblLogo.Image = Image.FromFile
                      (Path.GetFullPath(@"icon\" + tlk["Logo"].ToString()));
                pnlMain.BackgroundImage = Image.FromFile
                  (Path.GetFullPath(@"icon\" + tlk["Panel"].ToString()));
            }
        }


    }
}
