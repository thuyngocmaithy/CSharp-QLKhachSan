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
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLKhachSan));
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMainMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblShowMenu = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTrangChinh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDatPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThueTraPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyKho = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyThuChi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuanLyHeThong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTaiKhoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlHeader.SuspendLayout();
            this.pnlMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation5;
            this.bunifuTransition1.Interval = 2;
            this.bunifuTransition1.TimeStep = 0.05F;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.txtTenTaiKhoan);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.label3);
            this.bunifuTransition1.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.MinimumSize = new System.Drawing.Size(1100, 40);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1300, 40);
            this.pnlHeader.TabIndex = 2;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.Black;
            this.txtTenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.txtTenTaiKhoan, BunifuAnimatorNS.DecorationType.None);
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtTenTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(714, 9);
            this.txtTenTaiKhoan.MinimumSize = new System.Drawing.Size(500, 23);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(500, 23);
            this.txtTenTaiKhoan.TabIndex = 6;
            this.txtTenTaiKhoan.Text = "Xin chào, Admin";
            this.txtTenTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1220, 0);
            this.btnMinimize.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
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
            this.btnClose.Location = new System.Drawing.Point(1260, 0);
            this.btnClose.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
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
            this.label4.Location = new System.Drawing.Point(53, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
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
            this.label3.MinimumSize = new System.Drawing.Size(50, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 50);
            this.label3.TabIndex = 1;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Location = new System.Drawing.Point(85, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1215, 860);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.pnlMainMenu.Controls.Add(this.panel1);
            this.pnlMainMenu.Controls.Add(this.label5);
            this.pnlMainMenu.Controls.Add(this.btnTrangChinh);
            this.pnlMainMenu.Controls.Add(this.btnDatPhong);
            this.pnlMainMenu.Controls.Add(this.btnThueTraPhong);
            this.pnlMainMenu.Controls.Add(this.btnQuanLyKho);
            this.pnlMainMenu.Controls.Add(this.btnQuanLyThuChi);
            this.pnlMainMenu.Controls.Add(this.btnQuanLyHeThong);
            this.pnlMainMenu.Controls.Add(this.btnTaiKhoan);
            this.pnlMainMenu.Controls.Add(this.btnLogout);
            this.bunifuTransition1.SetDecoration(this.pnlMainMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMainMenu.MaximumSize = new System.Drawing.Size(325, 860);
            this.pnlMainMenu.MinimumSize = new System.Drawing.Size(85, 860);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(325, 860);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.lblShowMenu);
            this.panel1.Controls.Add(this.lblLogo);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblShowMenu
            // 
            this.lblShowMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lblShowMenu, BunifuAnimatorNS.DecorationType.None);
            this.lblShowMenu.Image = ((System.Drawing.Image)(resources.GetObject("lblShowMenu.Image")));
            this.lblShowMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblShowMenu.Location = new System.Drawing.Point(15, 10);
            this.lblShowMenu.Margin = new System.Windows.Forms.Padding(0);
            this.lblShowMenu.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblShowMenu.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblShowMenu.Name = "lblShowMenu";
            this.lblShowMenu.Size = new System.Drawing.Size(50, 50);
            this.lblShowMenu.TabIndex = 25;
            this.lblShowMenu.Click += new System.EventHandler(this.lblShowMenu_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lblLogo, BunifuAnimatorNS.DecorationType.None);
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(75, 0);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(16, 10, 0, 0);
            this.lblLogo.MaximumSize = new System.Drawing.Size(200, 60);
            this.lblLogo.MinimumSize = new System.Drawing.Size(200, 60);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(200, 60);
            this.lblLogo.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 24;
            // 
            // btnTrangChinh
            // 
            this.btnTrangChinh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
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
            this.btnTrangChinh.Location = new System.Drawing.Point(11, 76);
            this.btnTrangChinh.Margin = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.btnTrangChinh.Name = "btnTrangChinh";
            this.btnTrangChinh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnTrangChinh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnTrangChinh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTrangChinh.selected = false;
            this.btnTrangChinh.Size = new System.Drawing.Size(289, 63);
            this.btnTrangChinh.TabIndex = 16;
            this.btnTrangChinh.Text = "   Trang chính";
            this.btnTrangChinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChinh.Textcolor = System.Drawing.Color.White;
            this.btnTrangChinh.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChinh.Visible = false;
            this.btnTrangChinh.Click += new System.EventHandler(this.btnTrangChinh_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
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
            this.btnDatPhong.Location = new System.Drawing.Point(10, 149);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnDatPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnDatPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDatPhong.selected = false;
            this.btnDatPhong.Size = new System.Drawing.Size(289, 63);
            this.btnDatPhong.TabIndex = 17;
            this.btnDatPhong.Text = "   Đặt phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.Textcolor = System.Drawing.Color.White;
            this.btnDatPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Visible = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnThueTraPhong
            // 
            this.btnThueTraPhong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThueTraPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThueTraPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThueTraPhong.BorderRadius = 7;
            this.btnThueTraPhong.ButtonText = "   Thuê - Trả phòng";
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
            this.btnThueTraPhong.Location = new System.Drawing.Point(10, 222);
            this.btnThueTraPhong.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnThueTraPhong.Name = "btnThueTraPhong";
            this.btnThueTraPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThueTraPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThueTraPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThueTraPhong.selected = false;
            this.btnThueTraPhong.Size = new System.Drawing.Size(289, 63);
            this.btnThueTraPhong.TabIndex = 18;
            this.btnThueTraPhong.Text = "   Thuê - Trả phòng";
            this.btnThueTraPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThueTraPhong.Textcolor = System.Drawing.Color.White;
            this.btnThueTraPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThueTraPhong.Visible = false;
            this.btnThueTraPhong.Click += new System.EventHandler(this.btnThueTraPhong_Click);
            // 
            // btnQuanLyKho
            // 
            this.btnQuanLyKho.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQuanLyKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQuanLyKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyKho.BorderRadius = 7;
            this.btnQuanLyKho.ButtonText = "   Quản lý kho";
            this.btnQuanLyKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnQuanLyKho, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyKho.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKho.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyKho.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyKho.Iconimage")));
            this.btnQuanLyKho.Iconimage_right = null;
            this.btnQuanLyKho.Iconimage_right_Selected = null;
            this.btnQuanLyKho.Iconimage_Selected = null;
            this.btnQuanLyKho.IconMarginLeft = 0;
            this.btnQuanLyKho.IconMarginRight = 0;
            this.btnQuanLyKho.IconRightVisible = true;
            this.btnQuanLyKho.IconRightZoom = 0D;
            this.btnQuanLyKho.IconVisible = true;
            this.btnQuanLyKho.IconZoom = 50D;
            this.btnQuanLyKho.IsTab = true;
            this.btnQuanLyKho.Location = new System.Drawing.Point(10, 295);
            this.btnQuanLyKho.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnQuanLyKho.Name = "btnQuanLyKho";
            this.btnQuanLyKho.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQuanLyKho.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQuanLyKho.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyKho.selected = false;
            this.btnQuanLyKho.Size = new System.Drawing.Size(289, 63);
            this.btnQuanLyKho.TabIndex = 19;
            this.btnQuanLyKho.Text = "   Quản lý kho";
            this.btnQuanLyKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKho.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyKho.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKho.Visible = false;
            this.btnQuanLyKho.Click += new System.EventHandler(this.btnQLKho_Click);
            // 
            // btnQuanLyThuChi
            // 
            this.btnQuanLyThuChi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQuanLyThuChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQuanLyThuChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyThuChi.BorderRadius = 7;
            this.btnQuanLyThuChi.ButtonText = "   Quản lý thu chi";
            this.btnQuanLyThuChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnQuanLyThuChi, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyThuChi.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyThuChi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyThuChi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyThuChi.Iconimage")));
            this.btnQuanLyThuChi.Iconimage_right = null;
            this.btnQuanLyThuChi.Iconimage_right_Selected = null;
            this.btnQuanLyThuChi.Iconimage_Selected = null;
            this.btnQuanLyThuChi.IconMarginLeft = 0;
            this.btnQuanLyThuChi.IconMarginRight = 0;
            this.btnQuanLyThuChi.IconRightVisible = true;
            this.btnQuanLyThuChi.IconRightZoom = 0D;
            this.btnQuanLyThuChi.IconVisible = true;
            this.btnQuanLyThuChi.IconZoom = 50D;
            this.btnQuanLyThuChi.IsTab = true;
            this.btnQuanLyThuChi.Location = new System.Drawing.Point(10, 368);
            this.btnQuanLyThuChi.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnQuanLyThuChi.Name = "btnQuanLyThuChi";
            this.btnQuanLyThuChi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQuanLyThuChi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQuanLyThuChi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyThuChi.selected = false;
            this.btnQuanLyThuChi.Size = new System.Drawing.Size(289, 63);
            this.btnQuanLyThuChi.TabIndex = 20;
            this.btnQuanLyThuChi.Text = "   Quản lý thu chi";
            this.btnQuanLyThuChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyThuChi.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyThuChi.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyThuChi.Visible = false;
            this.btnQuanLyThuChi.Click += new System.EventHandler(this.btnQLThuChi_Click);
            // 
            // btnQuanLyHeThong
            // 
            this.btnQuanLyHeThong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQuanLyHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQuanLyHeThong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyHeThong.BorderRadius = 7;
            this.btnQuanLyHeThong.ButtonText = "   Quản lý hệ thống";
            this.btnQuanLyHeThong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnQuanLyHeThong, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyHeThong.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuanLyHeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyHeThong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuanLyHeThong.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyHeThong.Iconimage")));
            this.btnQuanLyHeThong.Iconimage_right = null;
            this.btnQuanLyHeThong.Iconimage_right_Selected = null;
            this.btnQuanLyHeThong.Iconimage_Selected = null;
            this.btnQuanLyHeThong.IconMarginLeft = 0;
            this.btnQuanLyHeThong.IconMarginRight = 0;
            this.btnQuanLyHeThong.IconRightVisible = true;
            this.btnQuanLyHeThong.IconRightZoom = 0D;
            this.btnQuanLyHeThong.IconVisible = true;
            this.btnQuanLyHeThong.IconZoom = 50D;
            this.btnQuanLyHeThong.IsTab = true;
            this.btnQuanLyHeThong.Location = new System.Drawing.Point(10, 441);
            this.btnQuanLyHeThong.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnQuanLyHeThong.Name = "btnQuanLyHeThong";
            this.btnQuanLyHeThong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQuanLyHeThong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQuanLyHeThong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuanLyHeThong.selected = false;
            this.btnQuanLyHeThong.Size = new System.Drawing.Size(289, 63);
            this.btnQuanLyHeThong.TabIndex = 21;
            this.btnQuanLyHeThong.Text = "   Quản lý hệ thống";
            this.btnQuanLyHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyHeThong.Textcolor = System.Drawing.Color.White;
            this.btnQuanLyHeThong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyHeThong.Visible = false;
            this.btnQuanLyHeThong.Click += new System.EventHandler(this.btnQLHeThong_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
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
            this.btnTaiKhoan.Location = new System.Drawing.Point(10, 514);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnTaiKhoan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnTaiKhoan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTaiKhoan.selected = false;
            this.btnTaiKhoan.Size = new System.Drawing.Size(289, 63);
            this.btnTaiKhoan.TabIndex = 22;
            this.btnTaiKhoan.Text = "   Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Textcolor = System.Drawing.Color.White;
            this.btnTaiKhoan.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Visible = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
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
            this.btnLogout.Location = new System.Drawing.Point(10, 587);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(289, 63);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.Text = "   Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmQLKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.ControlBox = false;
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMainMenu);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1300, 900);
            this.MinimumSize = new System.Drawing.Size(1300, 900);
            this.Name = "frmQLKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmQLKhachSan_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer MouseDetect;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.FlowLayoutPanel pnlMainMenu;
        private System.Windows.Forms.Label label5;
        private BunifuFlatButton btnTrangChinh;
        private BunifuFlatButton btnDatPhong;
        private BunifuFlatButton btnThueTraPhong;
        private BunifuFlatButton btnQuanLyKho;
        private BunifuFlatButton btnQuanLyThuChi;
        private BunifuFlatButton btnQuanLyHeThong;
        private BunifuFlatButton btnTaiKhoan;
        private BunifuFlatButton btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblShowMenu;
        private System.Windows.Forms.Label lblLogo;
    }
}