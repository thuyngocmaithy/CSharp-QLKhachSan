using Bunifu.Framework.UI;

namespace QLKhachSan.GUI.MainPageGUI
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLKhachSan));
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblLogoResize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaiKhoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLHeThong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLThuChi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLKho = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThueTraPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDatPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTrangChinh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.pnlMainMenu.Controls.Add(this.label2);
            this.pnlMainMenu.Controls.Add(this.btnLogout);
            this.pnlMainMenu.Controls.Add(this.lblLogoResize);
            this.pnlMainMenu.Controls.Add(this.label1);
            this.pnlMainMenu.Controls.Add(this.btnTaiKhoan);
            this.pnlMainMenu.Controls.Add(this.btnQLHeThong);
            this.pnlMainMenu.Controls.Add(this.btnQLThuChi);
            this.pnlMainMenu.Controls.Add(this.btnQLKho);
            this.pnlMainMenu.Controls.Add(this.btnThueTraPhong);
            this.pnlMainMenu.Controls.Add(this.btnDatPhong);
            this.pnlMainMenu.Controls.Add(this.btnTrangChinh);
            this.bunifuTransition1.SetDecoration(this.pnlMainMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(85, 644);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(38, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
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
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(13, 564);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = true;
            this.btnLogout.Size = new System.Drawing.Size(289, 63);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "   Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLogoResize
            // 
            this.lblLogoResize.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblLogoResize, BunifuAnimatorNS.DecorationType.None);
            this.lblLogoResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoResize.Image = ((System.Drawing.Image)(resources.GetObject("lblLogoResize.Image")));
            this.lblLogoResize.Location = new System.Drawing.Point(-25, 12);
            this.lblLogoResize.MinimumSize = new System.Drawing.Size(200, 60);
            this.lblLogoResize.Name = "lblLogoResize";
            this.lblLogoResize.Size = new System.Drawing.Size(200, 60);
            this.lblLogoResize.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(60, 12);
            this.label1.MinimumSize = new System.Drawing.Size(200, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 60);
            this.label1.TabIndex = 9;
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
            this.btnTaiKhoan.IsTab = false;
            this.btnTaiKhoan.Location = new System.Drawing.Point(13, 502);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(8);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnTaiKhoan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnTaiKhoan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTaiKhoan.selected = true;
            this.btnTaiKhoan.Size = new System.Drawing.Size(289, 63);
            this.btnTaiKhoan.TabIndex = 7;
            this.btnTaiKhoan.Text = "   Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Textcolor = System.Drawing.Color.White;
            this.btnTaiKhoan.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnQLHeThong.IsTab = false;
            this.btnQLHeThong.Location = new System.Drawing.Point(13, 431);
            this.btnQLHeThong.Margin = new System.Windows.Forms.Padding(8);
            this.btnQLHeThong.Name = "btnQLHeThong";
            this.btnQLHeThong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQLHeThong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQLHeThong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLHeThong.selected = true;
            this.btnQLHeThong.Size = new System.Drawing.Size(289, 63);
            this.btnQLHeThong.TabIndex = 6;
            this.btnQLHeThong.Text = "   Quản lý hệ thống";
            this.btnQLHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHeThong.Textcolor = System.Drawing.Color.White;
            this.btnQLHeThong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnQLThuChi.IsTab = false;
            this.btnQLThuChi.Location = new System.Drawing.Point(13, 360);
            this.btnQLThuChi.Margin = new System.Windows.Forms.Padding(8);
            this.btnQLThuChi.Name = "btnQLThuChi";
            this.btnQLThuChi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQLThuChi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQLThuChi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLThuChi.selected = true;
            this.btnQLThuChi.Size = new System.Drawing.Size(289, 63);
            this.btnQLThuChi.TabIndex = 5;
            this.btnQLThuChi.Text = "   Quản lý thu - chi";
            this.btnQLThuChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLThuChi.Textcolor = System.Drawing.Color.White;
            this.btnQLThuChi.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnQLKho.IsTab = false;
            this.btnQLKho.Location = new System.Drawing.Point(13, 289);
            this.btnQLKho.Margin = new System.Windows.Forms.Padding(8);
            this.btnQLKho.Name = "btnQLKho";
            this.btnQLKho.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQLKho.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQLKho.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLKho.selected = true;
            this.btnQLKho.Size = new System.Drawing.Size(289, 63);
            this.btnQLKho.TabIndex = 4;
            this.btnQLKho.Text = "   Quản lý kho";
            this.btnQLKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKho.Textcolor = System.Drawing.Color.White;
            this.btnQLKho.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnThueTraPhong.IsTab = false;
            this.btnThueTraPhong.Location = new System.Drawing.Point(13, 218);
            this.btnThueTraPhong.Margin = new System.Windows.Forms.Padding(8);
            this.btnThueTraPhong.Name = "btnThueTraPhong";
            this.btnThueTraPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThueTraPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThueTraPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThueTraPhong.selected = true;
            this.btnThueTraPhong.Size = new System.Drawing.Size(289, 63);
            this.btnThueTraPhong.TabIndex = 3;
            this.btnThueTraPhong.Text = "   Thuê - trả phòng";
            this.btnThueTraPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThueTraPhong.Textcolor = System.Drawing.Color.White;
            this.btnThueTraPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDatPhong.IsTab = false;
            this.btnDatPhong.Location = new System.Drawing.Point(13, 151);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(8);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnDatPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnDatPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDatPhong.selected = true;
            this.btnDatPhong.Size = new System.Drawing.Size(289, 63);
            this.btnDatPhong.TabIndex = 2;
            this.btnDatPhong.Text = "   Đặt phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.Textcolor = System.Drawing.Color.White;
            this.btnDatPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnTrangChinh.IsTab = false;
            this.btnTrangChinh.Location = new System.Drawing.Point(13, 80);
            this.btnTrangChinh.Margin = new System.Windows.Forms.Padding(8);
            this.btnTrangChinh.Name = "btnTrangChinh";
            this.btnTrangChinh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnTrangChinh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnTrangChinh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTrangChinh.selected = true;
            this.btnTrangChinh.Size = new System.Drawing.Size(289, 63);
            this.btnTrangChinh.TabIndex = 1;
            this.btnTrangChinh.Text = "   Trang chính";
            this.btnTrangChinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChinh.Textcolor = System.Drawing.Color.White;
            this.btnTrangChinh.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChinh.Click += new System.EventHandler(this.btnTrangChinh_Click);
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation4;
            // 
            // pnlMain
            // 
            this.bunifuTransition1.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Location = new System.Drawing.Point(82, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(996, 644);
            this.pnlMain.TabIndex = 0;
            // 
            // frmQLKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.pnlMain);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.IsMdiContainer = true;
            this.Name = "frmQLKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chính";
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer MouseDetect;
        private System.Windows.Forms.Label lblLogoResize;
        private BunifuFlatButton btnLogout;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel pnlMain;
    }
}