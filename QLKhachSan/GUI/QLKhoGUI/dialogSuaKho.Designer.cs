namespace QLKhachSan.GUI.QLKhoGUI
{
    partial class dialogSuaKho
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
            this.btnSuaKho = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSuaUuTienHienThi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuaGhiChu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtSuaThoiGianNhap = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cmbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SỬA PHIẾU NHẬP KHO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời gian nhập";
            // 
            // btnSuaKho
            // 
            this.btnSuaKho.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnSuaKho.AutoSize = true;
            this.btnSuaKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnSuaKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaKho.BorderRadius = 7;
            this.btnSuaKho.ButtonText = "SỬA";
            this.btnSuaKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaKho.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKho.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuaKho.Iconimage = null;
            this.btnSuaKho.Iconimage_right = null;
            this.btnSuaKho.Iconimage_right_Selected = null;
            this.btnSuaKho.Iconimage_Selected = null;
            this.btnSuaKho.IconMarginLeft = 0;
            this.btnSuaKho.IconMarginRight = 0;
            this.btnSuaKho.IconRightVisible = true;
            this.btnSuaKho.IconRightZoom = 0D;
            this.btnSuaKho.IconVisible = true;
            this.btnSuaKho.IconZoom = 50D;
            this.btnSuaKho.IsTab = true;
            this.btnSuaKho.Location = new System.Drawing.Point(89, 409);
            this.btnSuaKho.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSuaKho.Name = "btnSuaKho";
            this.btnSuaKho.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnSuaKho.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnSuaKho.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuaKho.selected = false;
            this.btnSuaKho.Size = new System.Drawing.Size(114, 55);
            this.btnSuaKho.TabIndex = 5;
            this.btnSuaKho.Text = "SỬA";
            this.btnSuaKho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuaKho.Textcolor = System.Drawing.Color.White;
            this.btnSuaKho.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKho.Click += new System.EventHandler(this.btnSuaKho_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(233, 409);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 50);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSuaUuTienHienThi
            // 
            this.txtSuaUuTienHienThi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSuaUuTienHienThi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtSuaUuTienHienThi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSuaUuTienHienThi.BorderThickness = 3;
            this.txtSuaUuTienHienThi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuaUuTienHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSuaUuTienHienThi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuaUuTienHienThi.isPassword = false;
            this.txtSuaUuTienHienThi.Location = new System.Drawing.Point(178, 322);
            this.txtSuaUuTienHienThi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSuaUuTienHienThi.Name = "txtSuaUuTienHienThi";
            this.txtSuaUuTienHienThi.Size = new System.Drawing.Size(215, 28);
            this.txtSuaUuTienHienThi.TabIndex = 12;
            this.txtSuaUuTienHienThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ưu tiên hiển thị";
            // 
            // txtSuaGhiChu
            // 
            this.txtSuaGhiChu.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSuaGhiChu.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtSuaGhiChu.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSuaGhiChu.BorderThickness = 3;
            this.txtSuaGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuaGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSuaGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuaGhiChu.isPassword = false;
            this.txtSuaGhiChu.Location = new System.Drawing.Point(178, 246);
            this.txtSuaGhiChu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSuaGhiChu.Name = "txtSuaGhiChu";
            this.txtSuaGhiChu.Size = new System.Drawing.Size(215, 28);
            this.txtSuaGhiChu.TabIndex = 10;
            this.txtSuaGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ghi chú";
            // 
            // dtSuaThoiGianNhap
            // 
            this.dtSuaThoiGianNhap.BackColor = System.Drawing.Color.Transparent;
            this.dtSuaThoiGianNhap.BorderRadius = 0;
            this.dtSuaThoiGianNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtSuaThoiGianNhap.ForeColor = System.Drawing.Color.Black;
            this.dtSuaThoiGianNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSuaThoiGianNhap.FormatCustom = "dd/MM/yyyy HH:mm:ss";
            this.dtSuaThoiGianNhap.Location = new System.Drawing.Point(178, 183);
            this.dtSuaThoiGianNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtSuaThoiGianNhap.Name = "dtSuaThoiGianNhap";
            this.dtSuaThoiGianNhap.Size = new System.Drawing.Size(215, 40);
            this.dtSuaThoiGianNhap.TabIndex = 13;
            this.dtSuaThoiGianNhap.Value = new System.DateTime(2022, 10, 14, 8, 17, 35, 167);
            // 
            // cmbMaNhanVien
            // 
            this.cmbMaNhanVien.FormattingEnabled = true;
            this.cmbMaNhanVien.Location = new System.Drawing.Point(178, 116);
            this.cmbMaNhanVien.Name = "cmbMaNhanVien";
            this.cmbMaNhanVien.Size = new System.Drawing.Size(215, 24);
            this.cmbMaNhanVien.TabIndex = 14;
            // 
            // dialogSuaKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(425, 502);
            this.ControlBox = false;
            this.Controls.Add(this.cmbMaNhanVien);
            this.Controls.Add(this.dtSuaThoiGianNhap);
            this.Controls.Add(this.txtSuaUuTienHienThi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSuaGhiChu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSuaKho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dialogSuaKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuaKho;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSuaUuTienHienThi;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSuaGhiChu;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDatepicker dtSuaThoiGianNhap;
        private System.Windows.Forms.ComboBox cmbMaNhanVien;
    }

}