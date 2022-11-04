using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.QLCachtinhtienGUI
{
    partial class dialogSuaTinhTien
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
            this.txtTenCachTinh = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlThueTheoGio = new System.Windows.Forms.Panel();
            this.txtGia1Gio = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGiaNgayLe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaT7 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaCN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaT6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhuThu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaNgay = new Guna.UI2.WinForms.Guna2TextBox();
            this.timeTraPhong = new System.Windows.Forms.DateTimePicker();
            this.timeNhanPhong = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoPhutLamTron = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ModeThueTheoNgay = new System.Windows.Forms.CheckBox();
            this.pnlThueTheoGio.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenCachTinh
            // 
            this.txtTenCachTinh.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTenCachTinh.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtTenCachTinh.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTenCachTinh.BorderThickness = 3;
            this.txtTenCachTinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenCachTinh.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenCachTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenCachTinh.isPassword = false;
            this.txtTenCachTinh.Location = new System.Drawing.Point(157, 21);
            this.txtTenCachTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCachTinh.Name = "txtTenCachTinh";
            this.txtTenCachTinh.Size = new System.Drawing.Size(243, 44);
            this.txtTenCachTinh.TabIndex = 22;
            this.txtTenCachTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(15, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(135, 28);
            this.label21.TabIndex = 21;
            this.label21.Text = "Tên Cách tính";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(501, 792);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(117, 60);
            this.btnDong.TabIndex = 26;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.BorderRadius = 7;
            this.btnLuu.ButtonText = "LƯU";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.DisabledColor = System.Drawing.Color.Gray;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLuu.Iconimage = null;
            this.btnLuu.Iconimage_right = null;
            this.btnLuu.Iconimage_right_Selected = null;
            this.btnLuu.Iconimage_Selected = null;
            this.btnLuu.IconMarginLeft = 0;
            this.btnLuu.IconMarginRight = 0;
            this.btnLuu.IconRightVisible = true;
            this.btnLuu.IconRightZoom = 0D;
            this.btnLuu.IconVisible = true;
            this.btnLuu.IconZoom = 50D;
            this.btnLuu.IsTab = true;
            this.btnLuu.Location = new System.Drawing.Point(373, 792);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(8);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnLuu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(117, 63);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Textcolor = System.Drawing.Color.White;
            this.btnLuu.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pnlThueTheoGio
            // 
            this.pnlThueTheoGio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlThueTheoGio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThueTheoGio.Controls.Add(this.txtGia1Gio);
            this.pnlThueTheoGio.Controls.Add(this.label9);
            this.pnlThueTheoGio.Controls.Add(this.label26);
            this.pnlThueTheoGio.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.pnlThueTheoGio.Location = new System.Drawing.Point(20, 84);
            this.pnlThueTheoGio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlThueTheoGio.Name = "pnlThueTheoGio";
            this.pnlThueTheoGio.Size = new System.Drawing.Size(942, 117);
            this.pnlThueTheoGio.TabIndex = 27;
            // 
            // txtGia1Gio
            // 
            this.txtGia1Gio.BackColor = System.Drawing.Color.Transparent;
            this.txtGia1Gio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtGia1Gio.BorderThickness = 3;
            this.txtGia1Gio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia1Gio.DefaultText = "";
            this.txtGia1Gio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGia1Gio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGia1Gio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia1Gio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia1Gio.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGia1Gio.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtGia1Gio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGia1Gio.ForeColor = System.Drawing.Color.Black;
            this.txtGia1Gio.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtGia1Gio.Location = new System.Drawing.Point(254, 55);
            this.txtGia1Gio.MaxLength = 11;
            this.txtGia1Gio.Name = "txtGia1Gio";
            this.txtGia1Gio.PasswordChar = '\0';
            this.txtGia1Gio.PlaceholderText = "";
            this.txtGia1Gio.SelectedText = "";
            this.txtGia1Gio.Size = new System.Drawing.Size(179, 44);
            this.txtGia1Gio.TabIndex = 25;
            this.txtGia1Gio.TextChanged += new System.EventHandler(this.txtGia1Gio_TextChanged);
            this.txtGia1Gio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia1Gio_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 28);
            this.label9.TabIndex = 24;
            this.label9.Text = "Giá theo giờ:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(32, 71);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 28);
            this.label26.TabIndex = 1;
            this.label26.Text = "Giá 1 giờ";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.panel2);
            this.pnlBottom.Controls.Add(this.panel1);
            this.pnlBottom.Location = new System.Drawing.Point(20, 224);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(942, 548);
            this.pnlBottom.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtGiaNgayLe);
            this.panel2.Controls.Add(this.txtGiaT7);
            this.panel2.Controls.Add(this.txtGiaCN);
            this.panel2.Controls.Add(this.txtGiaT6);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 326);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 222);
            this.panel2.TabIndex = 19;
            // 
            // txtGiaNgayLe
            // 
            this.txtGiaNgayLe.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaNgayLe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtGiaNgayLe.BorderThickness = 3;
            this.txtGiaNgayLe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaNgayLe.DefaultText = "";
            this.txtGiaNgayLe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaNgayLe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaNgayLe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNgayLe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNgayLe.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGiaNgayLe.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtGiaNgayLe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaNgayLe.ForeColor = System.Drawing.Color.Black;
            this.txtGiaNgayLe.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtGiaNgayLe.Location = new System.Drawing.Point(695, 120);
            this.txtGiaNgayLe.MaxLength = 11;
            this.txtGiaNgayLe.Name = "txtGiaNgayLe";
            this.txtGiaNgayLe.PasswordChar = '\0';
            this.txtGiaNgayLe.PlaceholderText = "";
            this.txtGiaNgayLe.SelectedText = "";
            this.txtGiaNgayLe.Size = new System.Drawing.Size(179, 44);
            this.txtGiaNgayLe.TabIndex = 32;
            this.txtGiaNgayLe.TextChanged += new System.EventHandler(this.txtGiaNgayLe_TextChanged);
            this.txtGiaNgayLe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNgayLe_KeyPress);
            // 
            // txtGiaT7
            // 
            this.txtGiaT7.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaT7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtGiaT7.BorderThickness = 3;
            this.txtGiaT7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaT7.DefaultText = "";
            this.txtGiaT7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaT7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaT7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaT7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaT7.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGiaT7.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtGiaT7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaT7.ForeColor = System.Drawing.Color.Black;
            this.txtGiaT7.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtGiaT7.Location = new System.Drawing.Point(695, 58);
            this.txtGiaT7.MaxLength = 11;
            this.txtGiaT7.Name = "txtGiaT7";
            this.txtGiaT7.PasswordChar = '\0';
            this.txtGiaT7.PlaceholderText = "";
            this.txtGiaT7.SelectedText = "";
            this.txtGiaT7.Size = new System.Drawing.Size(179, 44);
            this.txtGiaT7.TabIndex = 31;
            this.txtGiaT7.TextChanged += new System.EventHandler(this.txtGiaT7_TextChanged);
            this.txtGiaT7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaT7_KeyPress);
            // 
            // txtGiaCN
            // 
            this.txtGiaCN.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaCN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtGiaCN.BorderThickness = 3;
            this.txtGiaCN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaCN.DefaultText = "";
            this.txtGiaCN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaCN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaCN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaCN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaCN.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGiaCN.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtGiaCN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaCN.ForeColor = System.Drawing.Color.Black;
            this.txtGiaCN.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtGiaCN.Location = new System.Drawing.Point(256, 120);
            this.txtGiaCN.MaxLength = 11;
            this.txtGiaCN.Name = "txtGiaCN";
            this.txtGiaCN.PasswordChar = '\0';
            this.txtGiaCN.PlaceholderText = "";
            this.txtGiaCN.SelectedText = "";
            this.txtGiaCN.Size = new System.Drawing.Size(179, 44);
            this.txtGiaCN.TabIndex = 30;
            this.txtGiaCN.TextChanged += new System.EventHandler(this.txtGiaCN_TextChanged);
            this.txtGiaCN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaCN_KeyPress);
            // 
            // txtGiaT6
            // 
            this.txtGiaT6.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaT6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtGiaT6.BorderThickness = 3;
            this.txtGiaT6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaT6.DefaultText = "";
            this.txtGiaT6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaT6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaT6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaT6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaT6.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGiaT6.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtGiaT6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaT6.ForeColor = System.Drawing.Color.Black;
            this.txtGiaT6.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtGiaT6.Location = new System.Drawing.Point(256, 58);
            this.txtGiaT6.MaxLength = 11;
            this.txtGiaT6.Name = "txtGiaT6";
            this.txtGiaT6.PasswordChar = '\0';
            this.txtGiaT6.PlaceholderText = "";
            this.txtGiaT6.SelectedText = "";
            this.txtGiaT6.Size = new System.Drawing.Size(179, 44);
            this.txtGiaT6.TabIndex = 29;
            this.txtGiaT6.TextChanged += new System.EventHandler(this.txtGiaT6_TextChanged);
            this.txtGiaT6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaT6_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(495, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 28);
            this.label17.TabIndex = 3;
            this.label17.Text = "Giá ngày lễ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(495, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 28);
            this.label19.TabIndex = 5;
            this.label19.Text = "Giá thứ 7";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(33, 189);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(311, 20);
            this.label20.TabIndex = 6;
            this.label20.Text = "* Không cần nhập nếu giống với giá thường";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(252, 28);
            this.label15.TabIndex = 1;
            this.label15.Text = "Giá cuối tuần và ngày lễ :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(32, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 28);
            this.label18.TabIndex = 4;
            this.label18.Text = "Giá thứ 6";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(32, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 28);
            this.label16.TabIndex = 2;
            this.label16.Text = "Giá chủ nhật";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPhuThu);
            this.panel1.Controls.Add(this.txtGiaNgay);
            this.panel1.Controls.Add(this.timeTraPhong);
            this.panel1.Controls.Add(this.timeNhanPhong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSoPhutLamTron);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 307);
            this.panel1.TabIndex = 18;
            // 
            // txtPhuThu
            // 
            this.txtPhuThu.BackColor = System.Drawing.Color.Transparent;
            this.txtPhuThu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtPhuThu.BorderThickness = 3;
            this.txtPhuThu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhuThu.DefaultText = "";
            this.txtPhuThu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhuThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhuThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhuThu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhuThu.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPhuThu.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtPhuThu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhuThu.ForeColor = System.Drawing.Color.Black;
            this.txtPhuThu.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtPhuThu.Location = new System.Drawing.Point(254, 185);
            this.txtPhuThu.MaxLength = 11;
            this.txtPhuThu.Name = "txtPhuThu";
            this.txtPhuThu.PasswordChar = '\0';
            this.txtPhuThu.PlaceholderText = "";
            this.txtPhuThu.SelectedText = "";
            this.txtPhuThu.Size = new System.Drawing.Size(179, 44);
            this.txtPhuThu.TabIndex = 28;
            this.txtPhuThu.TextChanged += new System.EventHandler(this.txtPhuThu_TextChanged);
            this.txtPhuThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhuThu_KeyPress);
            // 
            // txtGiaNgay
            // 
            this.txtGiaNgay.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaNgay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtGiaNgay.BorderThickness = 3;
            this.txtGiaNgay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaNgay.DefaultText = "";
            this.txtGiaNgay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNgay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNgay.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGiaNgay.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtGiaNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaNgay.ForeColor = System.Drawing.Color.Black;
            this.txtGiaNgay.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtGiaNgay.Location = new System.Drawing.Point(254, 50);
            this.txtGiaNgay.MaxLength = 11;
            this.txtGiaNgay.Name = "txtGiaNgay";
            this.txtGiaNgay.PasswordChar = '\0';
            this.txtGiaNgay.PlaceholderText = "";
            this.txtGiaNgay.SelectedText = "";
            this.txtGiaNgay.Size = new System.Drawing.Size(179, 44);
            this.txtGiaNgay.TabIndex = 27;
            this.txtGiaNgay.TextChanged += new System.EventHandler(this.txtGiaNgay_TextChanged);
            this.txtGiaNgay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNgay_KeyPress);
            // 
            // timeTraPhong
            // 
            this.timeTraPhong.CustomFormat = "HH:mm";
            this.timeTraPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeTraPhong.Location = new System.Drawing.Point(673, 122);
            this.timeTraPhong.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.timeTraPhong.Name = "timeTraPhong";
            this.timeTraPhong.ShowUpDown = true;
            this.timeTraPhong.Size = new System.Drawing.Size(180, 39);
            this.timeTraPhong.TabIndex = 26;
            this.timeTraPhong.Value = new System.DateTime(2022, 10, 29, 0, 0, 0, 0);
            // 
            // timeNhanPhong
            // 
            this.timeNhanPhong.CustomFormat = "HH:mm";
            this.timeNhanPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeNhanPhong.Location = new System.Drawing.Point(255, 125);
            this.timeNhanPhong.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.timeNhanPhong.Name = "timeNhanPhong";
            this.timeNhanPhong.ShowUpDown = true;
            this.timeNhanPhong.Size = new System.Drawing.Size(180, 39);
            this.timeNhanPhong.TabIndex = 25;
            this.timeNhanPhong.Value = new System.DateTime(2022, 10, 29, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 28);
            this.label7.TabIndex = 24;
            this.label7.Text = "Giá theo ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(495, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giờ Trả Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(32, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Giờ Nhận Phòng";
            // 
            // txtSoPhutLamTron
            // 
            this.txtSoPhutLamTron.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSoPhutLamTron.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtSoPhutLamTron.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSoPhutLamTron.BorderThickness = 3;
            this.txtSoPhutLamTron.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoPhutLamTron.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSoPhutLamTron.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoPhutLamTron.isPassword = false;
            this.txtSoPhutLamTron.Location = new System.Drawing.Point(253, 246);
            this.txtSoPhutLamTron.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoPhutLamTron.Name = "txtSoPhutLamTron";
            this.txtSoPhutLamTron.Size = new System.Drawing.Size(180, 45);
            this.txtSoPhutLamTron.TabIndex = 18;
            this.txtSoPhutLamTron.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoPhutLamTron.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoPhutLamTron_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(32, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(216, 28);
            this.label14.TabIndex = 7;
            this.label14.Text = "Số phút làm tròn 1 giờ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(32, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 28);
            this.label10.TabIndex = 3;
            this.label10.Text = "Phụ thu quá giờ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(32, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giá ngày";
            // 
            // ModeThueTheoNgay
            // 
            this.ModeThueTheoNgay.AutoSize = true;
            this.ModeThueTheoNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeThueTheoNgay.Location = new System.Drawing.Point(501, 33);
            this.ModeThueTheoNgay.Name = "ModeThueTheoNgay";
            this.ModeThueTheoNgay.Size = new System.Drawing.Size(213, 32);
            this.ModeThueTheoNgay.TabIndex = 30;
            this.ModeThueTheoNgay.Text = "Chỉ thuê theo ngày";
            this.ModeThueTheoNgay.UseVisualStyleBackColor = true;
            this.ModeThueTheoNgay.CheckedChanged += new System.EventHandler(this.ModeThueTheoNgay_CheckedChanged);
            // 
            // dialogSuaTinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(979, 867);
            this.ControlBox = false;
            this.Controls.Add(this.ModeThueTheoNgay);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlThueTheoGio);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenCachTinh);
            this.Controls.Add(this.label21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "dialogSuaTinhTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dialogSuaTinhTien_Load);
            this.pnlThueTheoGio.ResumeLayout(false);
            this.pnlThueTheoGio.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtTenCachTinh;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnDong;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private System.Windows.Forms.Panel pnlThueTheoGio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label26;
        private Guna.UI2.WinForms.Guna2TextBox txtGia1Gio;
        private Panel pnlBottom;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaNgayLe;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaT7;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaCN;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaT6;
        private Label label17;
        private Label label19;
        private Label label20;
        private Label label15;
        private Label label18;
        private Label label16;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPhuThu;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaNgay;
        private DateTimePicker timeTraPhong;
        private DateTimePicker timeNhanPhong;
        private Label label7;
        private Label label5;
        private Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSoPhutLamTron;
        private Label label14;
        private Label label10;
        private Label label8;
        private CheckBox ModeThueTheoNgay;
    }
}