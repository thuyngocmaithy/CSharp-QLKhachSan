namespace QLKhachSan.GUI.QLThuChiGUI
{
    partial class dialogThemThuChi
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
            this.btnThemThuChi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLoaiHinh = new System.Windows.Forms.ComboBox();
            this.dtThemThoiGian = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtThemSoTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtThemNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(126, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM THU CHI";
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
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số tiền";
            // 
            // btnThemThuChi
            // 
            this.btnThemThuChi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThemThuChi.AutoSize = true;
            this.btnThemThuChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemThuChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemThuChi.BorderRadius = 7;
            this.btnThemThuChi.ButtonText = "THÊM";
            this.btnThemThuChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemThuChi.DisabledColor = System.Drawing.Color.Gray;
            this.btnThemThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThuChi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThemThuChi.Iconimage = null;
            this.btnThemThuChi.Iconimage_right = null;
            this.btnThemThuChi.Iconimage_right_Selected = null;
            this.btnThemThuChi.Iconimage_Selected = null;
            this.btnThemThuChi.IconMarginLeft = 0;
            this.btnThemThuChi.IconMarginRight = 0;
            this.btnThemThuChi.IconRightVisible = true;
            this.btnThemThuChi.IconRightZoom = 0D;
            this.btnThemThuChi.IconVisible = true;
            this.btnThemThuChi.IconZoom = 50D;
            this.btnThemThuChi.IsTab = true;
            this.btnThemThuChi.Location = new System.Drawing.Point(104, 438);
            this.btnThemThuChi.Margin = new System.Windows.Forms.Padding(8);
            this.btnThemThuChi.Name = "btnThemThuChi";
            this.btnThemThuChi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemThuChi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThemThuChi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThemThuChi.selected = false;
            this.btnThemThuChi.Size = new System.Drawing.Size(128, 69);
            this.btnThemThuChi.TabIndex = 5;
            this.btnThemThuChi.Text = "THÊM";
            this.btnThemThuChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemThuChi.Textcolor = System.Drawing.Color.White;
            this.btnThemThuChi.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThuChi.Click += new System.EventHandler(this.btnThemThuChi_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(243, 438);
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
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loại hình";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nội dung";
            // 
            // cmbLoaiHinh
            // 
            this.cmbLoaiHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiHinh.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiHinh.FormattingEnabled = true;
            this.cmbLoaiHinh.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cmbLoaiHinh.Location = new System.Drawing.Point(182, 189);
            this.cmbLoaiHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLoaiHinh.MinimumSize = new System.Drawing.Size(274, 0);
            this.cmbLoaiHinh.Name = "cmbLoaiHinh";
            this.cmbLoaiHinh.Size = new System.Drawing.Size(274, 44);
            this.cmbLoaiHinh.TabIndex = 22;
            // 
            // dtThemThoiGian
            // 
            this.dtThemThoiGian.BackColor = System.Drawing.SystemColors.Window;
            this.dtThemThoiGian.BorderRadius = 0;
            this.dtThemThoiGian.ForeColor = System.Drawing.Color.Black;
            this.dtThemThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThemThoiGian.FormatCustom = " dd/MM/yyyy HH:mm:ss";
            this.dtThemThoiGian.Location = new System.Drawing.Point(182, 99);
            this.dtThemThoiGian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtThemThoiGian.Name = "dtThemThoiGian";
            this.dtThemThoiGian.Size = new System.Drawing.Size(274, 48);
            this.dtThemThoiGian.TabIndex = 25;
            this.dtThemThoiGian.Value = new System.DateTime(2022, 10, 28, 1, 30, 16, 780);
            // 
            // txtThemSoTien
            // 
            this.txtThemSoTien.BackColor = System.Drawing.Color.Transparent;
            this.txtThemSoTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtThemSoTien.BorderThickness = 3;
            this.txtThemSoTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThemSoTien.DefaultText = "";
            this.txtThemSoTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThemSoTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThemSoTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThemSoTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThemSoTien.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtThemSoTien.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtThemSoTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThemSoTien.ForeColor = System.Drawing.Color.Black;
            this.txtThemSoTien.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtThemSoTien.Location = new System.Drawing.Point(182, 264);
            this.txtThemSoTien.MaxLength = 11;
            this.txtThemSoTien.Name = "txtThemSoTien";
            this.txtThemSoTien.PasswordChar = '\0';
            this.txtThemSoTien.PlaceholderText = "";
            this.txtThemSoTien.SelectedText = "";
            this.txtThemSoTien.Size = new System.Drawing.Size(274, 44);
            this.txtThemSoTien.TabIndex = 31;
            this.txtThemSoTien.TextChanged += new System.EventHandler(this.txtThemSoTien_TextChanged);
            this.txtThemSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThemSoTien_KeyPress);
            // 
            // txtThemNoiDung
            // 
            this.txtThemNoiDung.BackColor = System.Drawing.Color.Transparent;
            this.txtThemNoiDung.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtThemNoiDung.BorderThickness = 3;
            this.txtThemNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThemNoiDung.DefaultText = "";
            this.txtThemNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThemNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThemNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThemNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThemNoiDung.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtThemNoiDung.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtThemNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThemNoiDung.ForeColor = System.Drawing.Color.Black;
            this.txtThemNoiDung.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtThemNoiDung.Location = new System.Drawing.Point(182, 343);
            this.txtThemNoiDung.MaxLength = 11;
            this.txtThemNoiDung.Name = "txtThemNoiDung";
            this.txtThemNoiDung.PasswordChar = '\0';
            this.txtThemNoiDung.PlaceholderText = "";
            this.txtThemNoiDung.SelectedText = "";
            this.txtThemNoiDung.Size = new System.Drawing.Size(274, 44);
            this.txtThemNoiDung.TabIndex = 32;
            // 
            // dialogThemThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 528);
            this.ControlBox = false;
            this.Controls.Add(this.txtThemNoiDung);
            this.Controls.Add(this.txtThemSoTien);
            this.Controls.Add(this.dtThemThoiGian);
            this.Controls.Add(this.cmbLoaiHinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnThemThuChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dialogThemThuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dialogThemThuChi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnThemThuChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoaiHinh;
        private Bunifu.Framework.UI.BunifuDatepicker dtThemThoiGian;
        private Guna.UI2.WinForms.Guna2TextBox txtThemSoTien;
        private Guna.UI2.WinForms.Guna2TextBox txtThemNoiDung;
    }
}