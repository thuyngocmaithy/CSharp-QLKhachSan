using Bunifu.Framework.UI;

namespace QLKhachSan.GUI.QLKhachSan
{
    partial class frmQLKhachSan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLKhachSan));
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.lblShowMenu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnTaiKhoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLHeThong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLThuChi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLKho = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThueTraPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDatPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTrangChinh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMainMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.pnlMainMenu.Controls.Add(this.lblShowMenu);
            this.pnlMainMenu.Controls.Add(this.label2);
            this.pnlMainMenu.Controls.Add(this.btnLogout);
            this.pnlMainMenu.Controls.Add(this.lblLogo);
            this.pnlMainMenu.Controls.Add(this.btnTaiKhoan);
            this.pnlMainMenu.Controls.Add(this.btnQLHeThong);
            this.pnlMainMenu.Controls.Add(this.btnQLThuChi);
            this.pnlMainMenu.Controls.Add(this.btnQLKho);
            this.pnlMainMenu.Controls.Add(this.btnThueTraPhong);
            this.pnlMainMenu.Controls.Add(this.btnDatPhong);
            this.pnlMainMenu.Controls.Add(this.btnTrangChinh);
            this.bunifuTransition1.SetDecoration(this.pnlMainMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 26);
            this.pnlMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMainMenu.MaximumSize = new System.Drawing.Size(217, 429);
            this.pnlMainMenu.MinimumSize = new System.Drawing.Size(57, 429);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(57, 429);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // lblShowMenu
            // 
            this.lblShowMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lblShowMenu, BunifuAnimatorNS.DecorationType.None);
            this.lblShowMenu.Image = ((System.Drawing.Image)(resources.GetObject("lblShowMenu.Image")));
            this.lblShowMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblShowMenu.Location = new System.Drawing.Point(17, 14);
            this.lblShowMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowMenu.MaximumSize = new System.Drawing.Size(33, 32);
            this.lblShowMenu.MinimumSize = new System.Drawing.Size(33, 32);
            this.lblShowMenu.Name = "lblShowMenu";
            this.lblShowMenu.Size = new System.Drawing.Size(33, 32);
            this.lblShowMenu.TabIndex = 15;
            this.lblShowMenu.Click += new System.EventHandler(this.lblShowMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnLogout.AutoSize = true;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 7;
            this.btnLogout.ButtonText = "   Đăng xuất";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 50D;
            this.btnLogout.IsTab = true;
            this.btnLogout.Location = new System.Drawing.Point(9, 370);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(193, 43);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "   Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lblLogo, BunifuAnimatorNS.DecorationType.None);
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(40, 8);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.MaximumSize = new System.Drawing.Size(133, 39);
            this.lblLogo.MinimumSize = new System.Drawing.Size(133, 39);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(133, 39);
            this.lblLogo.TabIndex = 9;
            this.lblLogo.Click += new System.EventHandler(this.lblPanel_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnTaiKhoan.AutoSize = true;
            this.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaiKhoan.BorderRadius = 7;
            this.btnTaiKhoan.ButtonText = "   Tài khoản";
            this.btnTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnTaiKhoan, BunifuAnimatorNS.DecorationType.None);
            this.btnTaiKhoan.DisabledColor = System.Drawing.Color.Gray;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTaiKhoan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Iconimage")));
            this.btnTaiKhoan.Iconimage_right = null;
            this.btnTaiKhoan.Iconimage_right_Selected = null;
            this.btnTaiKhoan.Iconimage_Selected = null;
            this.btnTaiKhoan.IconMarginLeft = 0;
            this.btnTaiKhoan.IconMarginRight = 0;
            this.btnTaiKhoan.IconRightVisible = true;
            this.btnTaiKhoan.IconRightZoom = 0D;
            this.btnTaiKhoan.IconVisible = true;
            this.btnTaiKhoan.IconZoom = 50D;
            this.btnTaiKhoan.IsTab = true;
            this.btnTaiKhoan.Location = new System.Drawing.Point(9, 326);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnTaiKhoan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnTaiKhoan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTaiKhoan.selected = false;
            this.btnTaiKhoan.Size = new System.Drawing.Size(193, 43);
            this.btnTaiKhoan.TabIndex = 7;
            this.btnTaiKhoan.Text = "   Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Textcolor = System.Drawing.Color.White;
            this.btnTaiKhoan.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Visible = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnQLHeThong
            // 
            this.btnQLHeThong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQLHeThong.AutoSize = true;
            this.btnQLHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQLHeThong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLHeThong.BorderRadius = 7;
            this.btnQLHeThong.ButtonText = "   Quản lý hệ thống";
            this.btnQLHeThong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnQLHeThong, BunifuAnimatorNS.DecorationType.None);
            this.btnQLHeThong.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLHeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHeThong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLHeThong.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQLHeThong.Iconimage")));
            this.btnQLHeThong.Iconimage_right = null;
            this.btnQLHeThong.Iconimage_right_Selected = null;
            this.btnQLHeThong.Iconimage_Selected = null;
            this.btnQLHeThong.IconMarginLeft = 0;
            this.btnQLHeThong.IconMarginRight = 0;
            this.btnQLHeThong.IconRightVisible = true;
            this.btnQLHeThong.IconRightZoom = 0D;
            this.btnQLHeThong.IconVisible = true;
            this.btnQLHeThong.IconZoom = 50D;
            this.btnQLHeThong.IsTab = true;
            this.btnQLHeThong.Location = new System.Drawing.Point(9, 280);
            this.btnQLHeThong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQLHeThong.Name = "btnQLHeThong";
            this.btnQLHeThong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQLHeThong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQLHeThong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLHeThong.selected = false;
            this.btnQLHeThong.Size = new System.Drawing.Size(193, 43);
            this.btnQLHeThong.TabIndex = 6;
            this.btnQLHeThong.Text = "   Quản lý hệ thống";
            this.btnQLHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHeThong.Textcolor = System.Drawing.Color.White;
            this.btnQLHeThong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHeThong.Visible = false;
            this.btnQLHeThong.Click += new System.EventHandler(this.btnQLHeThong_Click);
            // 
            // btnQLThuChi
            // 
            this.btnQLThuChi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQLThuChi.AutoSize = true;
            this.btnQLThuChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQLThuChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLThuChi.BorderRadius = 7;
            this.btnQLThuChi.ButtonText = "   Quản lý thu - chi";
            this.btnQLThuChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnQLThuChi, BunifuAnimatorNS.DecorationType.None);
            this.btnQLThuChi.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLThuChi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLThuChi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQLThuChi.Iconimage")));
            this.btnQLThuChi.Iconimage_right = null;
            this.btnQLThuChi.Iconimage_right_Selected = null;
            this.btnQLThuChi.Iconimage_Selected = null;
            this.btnQLThuChi.IconMarginLeft = 0;
            this.btnQLThuChi.IconMarginRight = 0;
            this.btnQLThuChi.IconRightVisible = true;
            this.btnQLThuChi.IconRightZoom = 0D;
            this.btnQLThuChi.IconVisible = true;
            this.btnQLThuChi.IconZoom = 50D;
            this.btnQLThuChi.IsTab = true;
            this.btnQLThuChi.Location = new System.Drawing.Point(9, 234);
            this.btnQLThuChi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQLThuChi.Name = "btnQLThuChi";
            this.btnQLThuChi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQLThuChi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQLThuChi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLThuChi.selected = false;
            this.btnQLThuChi.Size = new System.Drawing.Size(193, 43);
            this.btnQLThuChi.TabIndex = 5;
            this.btnQLThuChi.Text = "   Quản lý thu - chi";
            this.btnQLThuChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLThuChi.Textcolor = System.Drawing.Color.White;
            this.btnQLThuChi.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLThuChi.Visible = false;
            this.btnQLThuChi.Click += new System.EventHandler(this.btnQLThuChi_Click);
            // 
            // btnQLKho
            // 
            this.btnQLKho.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQLKho.AutoSize = true;
            this.btnQLKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQLKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLKho.BorderRadius = 7;
            this.btnQLKho.ButtonText = "   Quản lý kho";
            this.btnQLKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnQLKho, BunifuAnimatorNS.DecorationType.None);
            this.btnQLKho.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKho.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLKho.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQLKho.Iconimage")));
            this.btnQLKho.Iconimage_right = null;
            this.btnQLKho.Iconimage_right_Selected = null;
            this.btnQLKho.Iconimage_Selected = null;
            this.btnQLKho.IconMarginLeft = 0;
            this.btnQLKho.IconMarginRight = 0;
            this.btnQLKho.IconRightVisible = true;
            this.btnQLKho.IconRightZoom = 0D;
            this.btnQLKho.IconVisible = true;
            this.btnQLKho.IconZoom = 50D;
            this.btnQLKho.IsTab = true;
            this.btnQLKho.Location = new System.Drawing.Point(9, 188);
            this.btnQLKho.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQLKho.Name = "btnQLKho";
            this.btnQLKho.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQLKho.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQLKho.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLKho.selected = false;
            this.btnQLKho.Size = new System.Drawing.Size(193, 43);
            this.btnQLKho.TabIndex = 4;
            this.btnQLKho.Text = "   Quản lý kho";
            this.btnQLKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKho.Textcolor = System.Drawing.Color.White;
            this.btnQLKho.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKho.Visible = false;
            this.btnQLKho.Click += new System.EventHandler(this.btnQLKho_Click);
            // 
            // btnThueTraPhong
            // 
            this.btnThueTraPhong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThueTraPhong.AutoSize = true;
            this.btnThueTraPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThueTraPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThueTraPhong.BorderRadius = 7;
            this.btnThueTraPhong.ButtonText = "   Thuê - trả phòng";
            this.btnThueTraPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnThueTraPhong, BunifuAnimatorNS.DecorationType.None);
            this.btnThueTraPhong.DisabledColor = System.Drawing.Color.Gray;
            this.btnThueTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThueTraPhong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThueTraPhong.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThueTraPhong.Iconimage")));
            this.btnThueTraPhong.Iconimage_right = null;
            this.btnThueTraPhong.Iconimage_right_Selected = null;
            this.btnThueTraPhong.Iconimage_Selected = null;
            this.btnThueTraPhong.IconMarginLeft = 0;
            this.btnThueTraPhong.IconMarginRight = 0;
            this.btnThueTraPhong.IconRightVisible = true;
            this.btnThueTraPhong.IconRightZoom = 0D;
            this.btnThueTraPhong.IconVisible = true;
            this.btnThueTraPhong.IconZoom = 50D;
            this.btnThueTraPhong.IsTab = true;
            this.btnThueTraPhong.Location = new System.Drawing.Point(9, 142);
            this.btnThueTraPhong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnThueTraPhong.Name = "btnThueTraPhong";
            this.btnThueTraPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThueTraPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThueTraPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThueTraPhong.selected = false;
            this.btnThueTraPhong.Size = new System.Drawing.Size(193, 43);
            this.btnThueTraPhong.TabIndex = 3;
            this.btnThueTraPhong.Text = "   Thuê - trả phòng";
            this.btnThueTraPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThueTraPhong.Textcolor = System.Drawing.Color.White;
            this.btnThueTraPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThueTraPhong.Visible = false;
            this.btnThueTraPhong.Click += new System.EventHandler(this.btnThueTraPhong_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnDatPhong.AutoSize = true;
            this.btnDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnDatPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatPhong.BorderRadius = 7;
            this.btnDatPhong.ButtonText = "   Đặt phòng";
            this.btnDatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnDatPhong, BunifuAnimatorNS.DecorationType.None);
            this.btnDatPhong.DisabledColor = System.Drawing.Color.Gray;
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDatPhong.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.Iconimage")));
            this.btnDatPhong.Iconimage_right = null;
            this.btnDatPhong.Iconimage_right_Selected = null;
            this.btnDatPhong.Iconimage_Selected = null;
            this.btnDatPhong.IconMarginLeft = 0;
            this.btnDatPhong.IconMarginRight = 0;
            this.btnDatPhong.IconRightVisible = true;
            this.btnDatPhong.IconRightZoom = 0D;
            this.btnDatPhong.IconVisible = true;
            this.btnDatPhong.IconZoom = 50D;
            this.btnDatPhong.IsTab = true;
            this.btnDatPhong.Location = new System.Drawing.Point(9, 98);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnDatPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnDatPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDatPhong.selected = false;
            this.btnDatPhong.Size = new System.Drawing.Size(193, 43);
            this.btnDatPhong.TabIndex = 2;
            this.btnDatPhong.Text = "   Đặt phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.Textcolor = System.Drawing.Color.White;
            this.btnDatPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Visible = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnTrangChinh
            // 
            this.btnTrangChinh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnTrangChinh.AutoSize = true;
            this.btnTrangChinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnTrangChinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrangChinh.BorderRadius = 7;
            this.btnTrangChinh.ButtonText = "   Trang chính";
            this.btnTrangChinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnTrangChinh, BunifuAnimatorNS.DecorationType.None);
            this.btnTrangChinh.DisabledColor = System.Drawing.Color.Gray;
            this.btnTrangChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChinh.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTrangChinh.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTrangChinh.Iconimage")));
            this.btnTrangChinh.Iconimage_right = null;
            this.btnTrangChinh.Iconimage_right_Selected = null;
            this.btnTrangChinh.Iconimage_Selected = null;
            this.btnTrangChinh.IconMarginLeft = 0;
            this.btnTrangChinh.IconMarginRight = 0;
            this.btnTrangChinh.IconRightVisible = true;
            this.btnTrangChinh.IconRightZoom = 0D;
            this.btnTrangChinh.IconVisible = true;
            this.btnTrangChinh.IconZoom = 50D;
            this.btnTrangChinh.IsTab = true;
            this.btnTrangChinh.Location = new System.Drawing.Point(9, 52);
            this.btnTrangChinh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnTrangChinh.Name = "btnTrangChinh";
            this.btnTrangChinh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnTrangChinh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnTrangChinh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTrangChinh.selected = false;
            this.btnTrangChinh.Size = new System.Drawing.Size(193, 43);
            this.btnTrangChinh.TabIndex = 1;
            this.btnTrangChinh.Text = "   Trang chính";
            this.btnTrangChinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChinh.Textcolor = System.Drawing.Color.White;
            this.btnTrangChinh.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChinh.Visible = false;
            this.btnTrangChinh.Click += new System.EventHandler(this.btnTrangChinh_Click);
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 2;
            this.bunifuTransition1.TimeStep = 0.05F;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.label3);
            this.bunifuTransition1.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHeader.MinimumSize = new System.Drawing.Size(733, 26);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(733, 26);
            this.pnlHeader.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(679, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimize.MinimumSize = new System.Drawing.Size(27, 26);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 26);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(706, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.MinimumSize = new System.Drawing.Size(27, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 26);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(35, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "QUẢN LÝ KHÁCH SẠN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MinimumSize = new System.Drawing.Size(33, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 32);
            this.label3.TabIndex = 1;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMain
            // 
            this.bunifuTransition1.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Location = new System.Drawing.Point(57, 26);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMain.MaximumSize = new System.Drawing.Size(677, 429);
            this.pnlMain.MinimumSize = new System.Drawing.Size(677, 429);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(677, 429);
            this.pnlMain.TabIndex = 0;
            // 
            // frmQLKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 455);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMain);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(733, 455);
            this.Name = "frmQLKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmQLKhachSan_Load);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private BunifuFlatButton btnTrangChinh;
        private BunifuFlatButton btnTaiKhoan;
        private BunifuFlatButton btnQLHeThong;
        private BunifuFlatButton btnQLThuChi;
        private BunifuFlatButton btnQLKho;
        private BunifuFlatButton btnThueTraPhong;
        private BunifuFlatButton btnDatPhong;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Timer MouseDetect;
        private BunifuFlatButton btnLogout;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblShowMenu;
        private System.Windows.Forms.Panel pnlMain;
    }
}