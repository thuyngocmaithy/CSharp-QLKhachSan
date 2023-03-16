namespace QLKhachSan.GUI.QLHeThongGUI.QLPhongGUI
{
    partial class dialogThemPhong
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
            this.txtThemSoKhachToiDa = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThemUuTienHienThi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cmbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cmbCachTinhTien = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(126, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng";
            // 
            // txtThemSoKhachToiDa
            // 
            this.txtThemSoKhachToiDa.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtThemSoKhachToiDa.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtThemSoKhachToiDa.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtThemSoKhachToiDa.BorderThickness = 3;
            this.txtThemSoKhachToiDa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThemSoKhachToiDa.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtThemSoKhachToiDa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtThemSoKhachToiDa.isPassword = false;
            this.txtThemSoKhachToiDa.Location = new System.Drawing.Point(182, 216);
            this.txtThemSoKhachToiDa.Margin = new System.Windows.Forms.Padding(4);
            this.txtThemSoKhachToiDa.Name = "txtThemSoKhachToiDa";
            this.txtThemSoKhachToiDa.Size = new System.Drawing.Size(274, 44);
            this.txtThemSoKhachToiDa.TabIndex = 4;
            this.txtThemSoKhachToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtThemSoKhachToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThemSoKhachToiDa_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số khách tối đa";
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemPhong.AutoSize = true;
            this.btnThemPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemPhong.BorderRadius = 7;
            this.btnThemPhong.ButtonText = "THÊM";
            this.btnThemPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemPhong.DisabledColor = System.Drawing.Color.Gray;
            this.btnThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThemPhong.Iconimage = null;
            this.btnThemPhong.Iconimage_right = null;
            this.btnThemPhong.Iconimage_right_Selected = null;
            this.btnThemPhong.Iconimage_Selected = null;
            this.btnThemPhong.IconMarginLeft = 0;
            this.btnThemPhong.IconMarginRight = 0;
            this.btnThemPhong.IconRightVisible = true;
            this.btnThemPhong.IconRightZoom = 0D;
            this.btnThemPhong.IconVisible = true;
            this.btnThemPhong.IconZoom = 50D;
            this.btnThemPhong.IsTab = true;
            this.btnThemPhong.Location = new System.Drawing.Point(87, 433);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(8);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThemPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThemPhong.selected = false;
            this.btnThemPhong.Size = new System.Drawing.Size(128, 63);
            this.btnThemPhong.TabIndex = 5;
            this.btnThemPhong.Text = "THÊM";
            this.btnThemPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemPhong.Textcolor = System.Drawing.Color.White;
            this.btnThemPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemLoaiPhong_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(249, 433);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 63);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cách tính tiền";
            // 
            // txtThemUuTienHienThi
            // 
            this.txtThemUuTienHienThi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtThemUuTienHienThi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtThemUuTienHienThi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtThemUuTienHienThi.BorderThickness = 3;
            this.txtThemUuTienHienThi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThemUuTienHienThi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtThemUuTienHienThi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtThemUuTienHienThi.isPassword = false;
            this.txtThemUuTienHienThi.Location = new System.Drawing.Point(182, 354);
            this.txtThemUuTienHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.txtThemUuTienHienThi.Name = "txtThemUuTienHienThi";
            this.txtThemUuTienHienThi.Size = new System.Drawing.Size(274, 44);
            this.txtThemUuTienHienThi.TabIndex = 14;
            this.txtThemUuTienHienThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtThemUuTienHienThi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThemUuTienHienThi_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ưu tiên hiển thị";
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(182, 81);
            this.cmbLoaiPhong.MinimumSize = new System.Drawing.Size(274, 0);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(274, 44);
            this.cmbLoaiPhong.TabIndex = 19;
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTinhTrang.FormattingEnabled = true;
            this.cmbTinhTrang.Location = new System.Drawing.Point(182, 151);
            this.cmbTinhTrang.MinimumSize = new System.Drawing.Size(274, 0);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(274, 44);
            this.cmbTinhTrang.TabIndex = 20;
            // 
            // cmbCachTinhTien
            // 
            this.cmbCachTinhTien.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCachTinhTien.FormattingEnabled = true;
            this.cmbCachTinhTien.Location = new System.Drawing.Point(182, 285);
            this.cmbCachTinhTien.MinimumSize = new System.Drawing.Size(274, 0);
            this.cmbCachTinhTien.Name = "cmbCachTinhTien";
            this.cmbCachTinhTien.Size = new System.Drawing.Size(274, 44);
            this.cmbCachTinhTien.TabIndex = 21;
            // 
            // dialogThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 544);
            this.ControlBox = false;
            this.Controls.Add(this.cmbCachTinhTien);
            this.Controls.Add(this.cmbTinhTrang);
            this.Controls.Add(this.cmbLoaiPhong);
            this.Controls.Add(this.txtThemUuTienHienThi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.txtThemSoKhachToiDa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "dialogThemPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dialogThemPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtThemSoKhachToiDa;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnThemPhong;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtThemUuTienHienThi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.ComboBox cmbTinhTrang;
        private System.Windows.Forms.ComboBox cmbCachTinhTien;
    }
}