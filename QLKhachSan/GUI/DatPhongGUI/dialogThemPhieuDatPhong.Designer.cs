namespace QLKhachSan.GUI.DatPhongGUI
{
    partial class dialogThemPhieuDatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogThemPhieuDatPhong));
            this.lblThemSua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateNgayNhan = new Bunifu.Framework.UI.BunifuDatepicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.dateNgayTra = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTienTraTruoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTrangThai = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThemPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnDsPhongChon = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCapNhatLoaiPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThemSua
            // 
            this.lblThemSua.AutoSize = true;
            this.lblThemSua.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemSua.ForeColor = System.Drawing.Color.Black;
            this.lblThemSua.Location = new System.Drawing.Point(274, 23);
            this.lblThemSua.Name = "lblThemSua";
            this.lblThemSua.Size = new System.Drawing.Size(158, 38);
            this.lblThemSua.TabIndex = 0;
            this.lblThemSua.Text = "THÊM MỚI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại";
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 7;
            this.btnThem.ButtonText = "THÊM";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledColor = System.Drawing.Color.Gray;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = null;
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 0;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = true;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = true;
            this.btnThem.IconZoom = 50D;
            this.btnThem.IsTab = true;
            this.btnThem.Location = new System.Drawing.Point(208, 825);
            this.btnThem.Margin = new System.Windows.Forms.Padding(8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(128, 63);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(340, 825);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 63);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.dateNgayNhan);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(17, 224);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(310, 80);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày nhận phòng";
            // 
            // dateNgayNhan
            // 
            this.dateNgayNhan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dateNgayNhan.BorderRadius = 10;
            this.dateNgayNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayNhan.ForeColor = System.Drawing.Color.Black;
            this.dateNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayNhan.FormatCustom = "dd/MM/yyyy";
            this.dateNgayNhan.Location = new System.Drawing.Point(4, 33);
            this.dateNgayNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateNgayNhan.Name = "dateNgayNhan";
            this.dateNgayNhan.Size = new System.Drawing.Size(300, 40);
            this.dateNgayNhan.TabIndex = 1;
            this.dateNgayNhan.Value = new System.DateTime(2022, 10, 19, 0, 0, 0, 0);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.bunifuDatepicker1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(259, 80);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày nhận phòng";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuDatepicker1.BorderRadius = 10;
            this.bunifuDatepicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDatepicker1.FormatCustom = "dd/MM/yyyy";
            this.bunifuDatepicker1.Location = new System.Drawing.Point(4, 33);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(255, 40);
            this.bunifuDatepicker1.TabIndex = 1;
            this.bunifuDatepicker1.Value = new System.DateTime(2022, 10, 19, 0, 0, 0, 0);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.dateNgayTra);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(373, 224);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(310, 80);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày trả phòng";
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dateNgayTra.BorderRadius = 10;
            this.dateNgayTra.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTra.ForeColor = System.Drawing.Color.Black;
            this.dateNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayTra.FormatCustom = "dd/MM/yyyy";
            this.dateNgayTra.Location = new System.Drawing.Point(4, 33);
            this.dateNgayTra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(300, 40);
            this.dateNgayTra.TabIndex = 1;
            this.dateNgayTra.Value = new System.DateTime(2022, 10, 19, 0, 0, 0, 0);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.Transparent;
            this.txtHoTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtHoTen.BorderRadius = 5;
            this.txtHoTen.BorderThickness = 3;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtHoTen.Location = new System.Drawing.Point(207, 92);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(475, 44);
            this.txtHoTen.TabIndex = 12;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BackColor = System.Drawing.Color.Transparent;
            this.txtSoDienThoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtSoDienThoai.BorderRadius = 5;
            this.txtSoDienThoai.BorderThickness = 3;
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai.DefaultText = "";
            this.txtSoDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSoDienThoai.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoDienThoai.ForeColor = System.Drawing.Color.Black;
            this.txtSoDienThoai.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSoDienThoai.Location = new System.Drawing.Point(208, 159);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PasswordChar = '\0';
            this.txtSoDienThoai.PlaceholderText = "";
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.Size = new System.Drawing.Size(475, 44);
            this.txtSoDienThoai.TabIndex = 13;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tiền trả trước";
            // 
            // txtTienTraTruoc
            // 
            this.txtTienTraTruoc.BackColor = System.Drawing.Color.Transparent;
            this.txtTienTraTruoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtTienTraTruoc.BorderRadius = 5;
            this.txtTienTraTruoc.BorderThickness = 3;
            this.txtTienTraTruoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienTraTruoc.DefaultText = "";
            this.txtTienTraTruoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTienTraTruoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTienTraTruoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienTraTruoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienTraTruoc.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTienTraTruoc.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtTienTraTruoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTienTraTruoc.ForeColor = System.Drawing.Color.Black;
            this.txtTienTraTruoc.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtTienTraTruoc.Location = new System.Drawing.Point(208, 310);
            this.txtTienTraTruoc.Name = "txtTienTraTruoc";
            this.txtTienTraTruoc.PasswordChar = '\0';
            this.txtTienTraTruoc.PlaceholderText = "";
            this.txtTienTraTruoc.SelectedText = "";
            this.txtTienTraTruoc.Size = new System.Drawing.Size(475, 44);
            this.txtTienTraTruoc.TabIndex = 15;
            this.txtTienTraTruoc.TextChanged += new System.EventHandler(this.txtTienTraTruoc_TextChanged);
            this.txtTienTraTruoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienTraTruoc_KeyPress);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.Transparent;
            this.txtGhiChu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtGhiChu.BorderRadius = 5;
            this.txtGhiChu.BorderThickness = 3;
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.DefaultText = "";
            this.txtGhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGhiChu.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.ForeColor = System.Drawing.Color.Black;
            this.txtGhiChu.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtGhiChu.Location = new System.Drawing.Point(208, 453);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.PlaceholderText = "";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(475, 44);
            this.txtGhiChu.TabIndex = 19;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.txtTrangThai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtTrangThai.BorderRadius = 5;
            this.txtTrangThai.BorderThickness = 3;
            this.txtTrangThai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrangThai.DefaultText = "";
            this.txtTrangThai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrangThai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTrangThai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrangThai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrangThai.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTrangThai.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrangThai.ForeColor = System.Drawing.Color.Black;
            this.txtTrangThai.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtTrangThai.Location = new System.Drawing.Point(207, 386);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.PasswordChar = '\0';
            this.txtTrangThai.PlaceholderText = "";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.SelectedText = "";
            this.txtTrangThai.Size = new System.Drawing.Size(475, 44);
            this.txtTrangThai.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 28);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ghi chú";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 28);
            this.label10.TabIndex = 16;
            this.label10.Text = "Trạng thái";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 533);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 28);
            this.label11.TabIndex = 20;
            this.label11.Text = "Phòng đặt";
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemPhong.AutoSize = true;
            this.btnThemPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemPhong.BorderRadius = 7;
            this.btnThemPhong.ButtonText = " Thêm phòng";
            this.btnThemPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemPhong.DisabledColor = System.Drawing.Color.Gray;
            this.btnThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThemPhong.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThemPhong.Iconimage")));
            this.btnThemPhong.Iconimage_right = null;
            this.btnThemPhong.Iconimage_right_Selected = null;
            this.btnThemPhong.Iconimage_Selected = null;
            this.btnThemPhong.IconMarginLeft = 0;
            this.btnThemPhong.IconMarginRight = 0;
            this.btnThemPhong.IconRightVisible = true;
            this.btnThemPhong.IconRightZoom = 0D;
            this.btnThemPhong.IconVisible = true;
            this.btnThemPhong.IconZoom = 40D;
            this.btnThemPhong.IsTab = true;
            this.btnThemPhong.Location = new System.Drawing.Point(206, 524);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThemPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThemPhong.selected = false;
            this.btnThemPhong.Size = new System.Drawing.Size(159, 50);
            this.btnThemPhong.TabIndex = 21;
            this.btnThemPhong.Text = " Thêm phòng";
            this.btnThemPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPhong.Textcolor = System.Drawing.Color.White;
            this.btnThemPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // pnDsPhongChon
            // 
            this.pnDsPhongChon.Location = new System.Drawing.Point(385, 524);
            this.pnDsPhongChon.Name = "pnDsPhongChon";
            this.pnDsPhongChon.Size = new System.Drawing.Size(297, 50);
            this.pnDsPhongChon.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 610);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 28);
            this.label12.TabIndex = 23;
            this.label12.Text = "Loại phòng đặt";
            // 
            // btnCapNhatLoaiPhong
            // 
            this.btnCapNhatLoaiPhong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnCapNhatLoaiPhong.AutoSize = true;
            this.btnCapNhatLoaiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnCapNhatLoaiPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapNhatLoaiPhong.BorderRadius = 7;
            this.btnCapNhatLoaiPhong.ButtonText = " Cập nhật theo phòng";
            this.btnCapNhatLoaiPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatLoaiPhong.DisabledColor = System.Drawing.Color.Gray;
            this.btnCapNhatLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiPhong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCapNhatLoaiPhong.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCapNhatLoaiPhong.Iconimage")));
            this.btnCapNhatLoaiPhong.Iconimage_right = null;
            this.btnCapNhatLoaiPhong.Iconimage_right_Selected = null;
            this.btnCapNhatLoaiPhong.Iconimage_Selected = null;
            this.btnCapNhatLoaiPhong.IconMarginLeft = 0;
            this.btnCapNhatLoaiPhong.IconMarginRight = 0;
            this.btnCapNhatLoaiPhong.IconRightVisible = true;
            this.btnCapNhatLoaiPhong.IconRightZoom = 0D;
            this.btnCapNhatLoaiPhong.IconVisible = true;
            this.btnCapNhatLoaiPhong.IconZoom = 45D;
            this.btnCapNhatLoaiPhong.IsTab = true;
            this.btnCapNhatLoaiPhong.Location = new System.Drawing.Point(208, 599);
            this.btnCapNhatLoaiPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btnCapNhatLoaiPhong.Name = "btnCapNhatLoaiPhong";
            this.btnCapNhatLoaiPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnCapNhatLoaiPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnCapNhatLoaiPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCapNhatLoaiPhong.selected = false;
            this.btnCapNhatLoaiPhong.Size = new System.Drawing.Size(224, 50);
            this.btnCapNhatLoaiPhong.TabIndex = 24;
            this.btnCapNhatLoaiPhong.Text = " Cập nhật theo phòng";
            this.btnCapNhatLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatLoaiPhong.Textcolor = System.Drawing.Color.White;
            this.btnCapNhatLoaiPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 0;
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenLoaiPhong,
            this.SLPhong});
            this.dgvLoaiPhong.Location = new System.Drawing.Point(17, 669);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.RowHeadersWidth = 62;
            this.dgvLoaiPhong.RowTemplate.Height = 28;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(666, 150);
            this.dgvLoaiPhong.TabIndex = 0;
            this.dgvLoaiPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvLoaiPhong_KeyPress);
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.DataPropertyName = "TenLoaiPhong";
            this.TenLoaiPhong.HeaderText = "Loại phòng";
            this.TenLoaiPhong.MinimumWidth = 8;
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            this.TenLoaiPhong.ReadOnly = true;
            this.TenLoaiPhong.Width = 300;
            // 
            // SLPhong
            // 
            this.SLPhong.DataPropertyName = "SLPhong";
            this.SLPhong.HeaderText = "Số lượng";
            this.SLPhong.MinimumWidth = 8;
            this.SLPhong.Name = "SLPhong";
            this.SLPhong.Width = 300;
            // 
            // dialogThemPhieuDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 894);
            this.ControlBox = false;
            this.Controls.Add(this.dgvLoaiPhong);
            this.Controls.Add(this.btnCapNhatLoaiPhong);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pnDsPhongChon);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTienTraTruoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblThemSua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(700, 900);
            this.Name = "dialogThemPhieuDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dialogThemPhieuDatPhong_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThemSua;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker dateNgayNhan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtTienTraTruoc;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
        private Guna.UI2.WinForms.Guna2TextBox txtTrangThai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuFlatButton btnThemPhong;
        private System.Windows.Forms.FlowLayoutPanel pnDsPhongChon;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuFlatButton btnCapNhatLoaiPhong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLPhong;
        private Bunifu.Framework.UI.BunifuDatepicker dateNgayTra;
    }
}