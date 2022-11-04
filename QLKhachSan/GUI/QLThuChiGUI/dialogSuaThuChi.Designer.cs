namespace QLKhachSan.GUI.QLThuChiGUI
{
    partial class dialogSuaThuChi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSuaThuChi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSuaLoaiHinh = new System.Windows.Forms.ComboBox();
            this.dtSuaThoiGian = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtSuaSoTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSuaNoiDung = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(126, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "SỬA THU CHI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số tiền";
            // 
            // btnSuaThuChi
            // 
            this.btnSuaThuChi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnSuaThuChi.AutoSize = true;
            this.btnSuaThuChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnSuaThuChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaThuChi.BorderRadius = 7;
            this.btnSuaThuChi.ButtonText = "SỬA";
            this.btnSuaThuChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaThuChi.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuaThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThuChi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuaThuChi.Iconimage = null;
            this.btnSuaThuChi.Iconimage_right = null;
            this.btnSuaThuChi.Iconimage_right_Selected = null;
            this.btnSuaThuChi.Iconimage_Selected = null;
            this.btnSuaThuChi.IconMarginLeft = 0;
            this.btnSuaThuChi.IconMarginRight = 0;
            this.btnSuaThuChi.IconRightVisible = true;
            this.btnSuaThuChi.IconRightZoom = 0D;
            this.btnSuaThuChi.IconVisible = true;
            this.btnSuaThuChi.IconZoom = 50D;
            this.btnSuaThuChi.IsTab = true;
            this.btnSuaThuChi.Location = new System.Drawing.Point(97, 423);
            this.btnSuaThuChi.Margin = new System.Windows.Forms.Padding(8);
            this.btnSuaThuChi.Name = "btnSuaThuChi";
            this.btnSuaThuChi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnSuaThuChi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnSuaThuChi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuaThuChi.selected = false;
            this.btnSuaThuChi.Size = new System.Drawing.Size(128, 69);
            this.btnSuaThuChi.TabIndex = 5;
            this.btnSuaThuChi.Text = "SỬA";
            this.btnSuaThuChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuaThuChi.Textcolor = System.Drawing.Color.White;
            this.btnSuaThuChi.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThuChi.Click += new System.EventHandler(this.btnSuaThuChi_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(236, 423);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 69);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loại hình";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nội dung";
            // 
            // cmbSuaLoaiHinh
            // 
            this.cmbSuaLoaiHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuaLoaiHinh.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSuaLoaiHinh.FormattingEnabled = true;
            this.cmbSuaLoaiHinh.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cmbSuaLoaiHinh.Location = new System.Drawing.Point(182, 179);
            this.cmbSuaLoaiHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSuaLoaiHinh.MinimumSize = new System.Drawing.Size(274, 0);
            this.cmbSuaLoaiHinh.Name = "cmbSuaLoaiHinh";
            this.cmbSuaLoaiHinh.Size = new System.Drawing.Size(274, 44);
            this.cmbSuaLoaiHinh.TabIndex = 22;
            // 
            // dtSuaThoiGian
            // 
            this.dtSuaThoiGian.BackColor = System.Drawing.SystemColors.Control;
            this.dtSuaThoiGian.BorderRadius = 0;
            this.dtSuaThoiGian.ForeColor = System.Drawing.Color.Black;
            this.dtSuaThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSuaThoiGian.FormatCustom = " dd/MM/yyyy HH:mm:ss";
            this.dtSuaThoiGian.Location = new System.Drawing.Point(182, 99);
            this.dtSuaThoiGian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtSuaThoiGian.Name = "dtSuaThoiGian";
            this.dtSuaThoiGian.Size = new System.Drawing.Size(274, 48);
            this.dtSuaThoiGian.TabIndex = 25;
            this.dtSuaThoiGian.Value = new System.DateTime(2022, 10, 28, 1, 30, 16, 780);
            // 
            // txtSuaSoTien
            // 
            this.txtSuaSoTien.BackColor = System.Drawing.Color.Transparent;
            this.txtSuaSoTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtSuaSoTien.BorderThickness = 3;
            this.txtSuaSoTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuaSoTien.DefaultText = "";
            this.txtSuaSoTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSuaSoTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSuaSoTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSuaSoTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSuaSoTien.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSuaSoTien.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSuaSoTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSuaSoTien.ForeColor = System.Drawing.Color.Black;
            this.txtSuaSoTien.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSuaSoTien.Location = new System.Drawing.Point(182, 257);
            this.txtSuaSoTien.MaxLength = 11;
            this.txtSuaSoTien.Name = "txtSuaSoTien";
            this.txtSuaSoTien.PasswordChar = '\0';
            this.txtSuaSoTien.PlaceholderText = "";
            this.txtSuaSoTien.SelectedText = "";
            this.txtSuaSoTien.Size = new System.Drawing.Size(274, 44);
            this.txtSuaSoTien.TabIndex = 33;
            this.txtSuaSoTien.TextChanged += new System.EventHandler(this.txtSuaSoTien_TextChanged);
            this.txtSuaSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuaSoTien_KeyPress);
            // 
            // txtSuaNoiDung
            // 
            this.txtSuaNoiDung.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSuaNoiDung.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtSuaNoiDung.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSuaNoiDung.BorderThickness = 3;
            this.txtSuaNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuaNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSuaNoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuaNoiDung.isPassword = false;
            this.txtSuaNoiDung.Location = new System.Drawing.Point(182, 338);
            this.txtSuaNoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuaNoiDung.Name = "txtSuaNoiDung";
            this.txtSuaNoiDung.Size = new System.Drawing.Size(274, 45);
            this.txtSuaNoiDung.TabIndex = 24;
            this.txtSuaNoiDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dialogSuaThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 528);
            this.ControlBox = false;
            this.Controls.Add(this.txtSuaSoTien);
            this.Controls.Add(this.dtSuaThoiGian);
            this.Controls.Add(this.txtSuaNoiDung);
            this.Controls.Add(this.cmbSuaLoaiHinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSuaThuChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dialogSuaThuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dialogSuaThuChi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker dtSuaThoiGian;
        private System.Windows.Forms.ComboBox cmbSuaLoaiHinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuaThuChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSuaSoTien;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSuaNoiDung;
    }
}