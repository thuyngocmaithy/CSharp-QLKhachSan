namespace QLKhachSan.GUI.QLHeThongGUI.ThietLapKhacGUI
{
    partial class frmThietLapKhac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThietLapKhac));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxPanel = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtSDT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDiaChi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTenKhachSan = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtSuaSDT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuaDiaChi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSuaTenKhachSan = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblPanel = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPanel)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(364, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "THIẾT LẬP KHÁC";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.lblLogo);
            this.bunifuGradientPanel2.Controls.Add(this.lblPanel);
            this.bunifuGradientPanel2.Controls.Add(this.pictureBoxLogo);
            this.bunifuGradientPanel2.Controls.Add(this.picBoxPanel);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(453, 75);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(421, 372);
            this.bunifuGradientPanel2.TabIndex = 15;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(22, 259);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(378, 91);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // picBoxPanel
            // 
            this.picBoxPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxPanel.Location = new System.Drawing.Point(22, 48);
            this.picBoxPanel.Name = "picBoxPanel";
            this.picBoxPanel.Size = new System.Drawing.Size(378, 148);
            this.picBoxPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPanel.TabIndex = 0;
            this.picBoxPanel.TabStop = false;
            this.picBoxPanel.DoubleClick += new System.EventHandler(this.picBoxPanel_DoubleClick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txtSDT);
            this.bunifuGradientPanel1.Controls.Add(this.txtDiaChi);
            this.bunifuGradientPanel1.Controls.Add(this.txtTenKhachSan);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuDatepicker);
            this.bunifuGradientPanel1.Controls.Add(this.txtSuaSDT);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.txtSuaDiaChi);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.txtSuaTenKhachSan);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(31, 75);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(416, 372);
            this.bunifuGradientPanel1.TabIndex = 14;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSDT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtSDT.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSDT.BorderThickness = 3;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSDT.isPassword = false;
            this.txtSDT.Location = new System.Drawing.Point(158, 216);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(241, 36);
            this.txtSDT.TabIndex = 30;
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDiaChi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtDiaChi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtDiaChi.BorderThickness = 3;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChi.isPassword = false;
            this.txtDiaChi.Location = new System.Drawing.Point(158, 127);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(241, 36);
            this.txtDiaChi.TabIndex = 29;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTenKhachSan
            // 
            this.txtTenKhachSan.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTenKhachSan.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtTenKhachSan.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTenKhachSan.BorderThickness = 3;
            this.txtTenKhachSan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhachSan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenKhachSan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenKhachSan.isPassword = false;
            this.txtTenKhachSan.Location = new System.Drawing.Point(158, 37);
            this.txtTenKhachSan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenKhachSan.Name = "txtTenKhachSan";
            this.txtTenKhachSan.Size = new System.Drawing.Size(241, 36);
            this.txtTenKhachSan.TabIndex = 28;
            this.txtTenKhachSan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Thời gian";
            // 
            // bunifuDatepicker
            // 
            this.bunifuDatepicker.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatepicker.BorderRadius = 5;
            this.bunifuDatepicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuDatepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatepicker.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker.FormatCustom = "dd/MM/yyyy";
            this.bunifuDatepicker.Location = new System.Drawing.Point(155, 297);
            this.bunifuDatepicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker.Name = "bunifuDatepicker";
            this.bunifuDatepicker.Size = new System.Drawing.Size(241, 37);
            this.bunifuDatepicker.TabIndex = 26;
            this.bunifuDatepicker.Value = new System.DateTime(2022, 10, 17, 0, 0, 0, 0);
            // 
            // txtSuaSDT
            // 
            this.txtSuaSDT.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSuaSDT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtSuaSDT.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSuaSDT.BorderThickness = 3;
            this.txtSuaSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuaSDT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSuaSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuaSDT.isPassword = false;
            this.txtSuaSDT.Location = new System.Drawing.Point(158, 216);
            this.txtSuaSDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSuaSDT.Name = "txtSuaSDT";
            this.txtSuaSDT.Size = new System.Drawing.Size(238, 36);
            this.txtSuaSDT.TabIndex = 25;
            this.txtSuaSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Số điện thoại";
            // 
            // txtSuaDiaChi
            // 
            this.txtSuaDiaChi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSuaDiaChi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtSuaDiaChi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSuaDiaChi.BorderThickness = 3;
            this.txtSuaDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuaDiaChi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSuaDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuaDiaChi.isPassword = false;
            this.txtSuaDiaChi.Location = new System.Drawing.Point(158, 127);
            this.txtSuaDiaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSuaDiaChi.Name = "txtSuaDiaChi";
            this.txtSuaDiaChi.Size = new System.Drawing.Size(238, 36);
            this.txtSuaDiaChi.TabIndex = 23;
            this.txtSuaDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Địa chỉ";
            // 
            // txtSuaTenKhachSan
            // 
            this.txtSuaTenKhachSan.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSuaTenKhachSan.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtSuaTenKhachSan.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSuaTenKhachSan.BorderThickness = 3;
            this.txtSuaTenKhachSan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuaTenKhachSan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSuaTenKhachSan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuaTenKhachSan.isPassword = false;
            this.txtSuaTenKhachSan.Location = new System.Drawing.Point(158, 37);
            this.txtSuaTenKhachSan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSuaTenKhachSan.Name = "txtSuaTenKhachSan";
            this.txtSuaTenKhachSan.Size = new System.Drawing.Size(238, 36);
            this.txtSuaTenKhachSan.TabIndex = 21;
            this.txtSuaTenKhachSan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên khách sạn";
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 7;
            this.btnSave.ButtonText = "Lưu";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 40D;
            this.btnSave.IsTab = true;
            this.btnSave.Location = new System.Drawing.Point(397, 464);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(100, 55);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPanel
            // 
            this.lblPanel.AutoSize = true;
            this.lblPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel.Location = new System.Drawing.Point(19, 22);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(94, 20);
            this.lblPanel.TabIndex = 2;
            this.lblPanel.Text = "Ảnh Panel";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(20, 227);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(88, 20);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "Ảnh Logo";
            // 
            // frmThietLapKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 528);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(902, 528);
            this.Name = "frmThietLapKhac";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmThietLapKhac_Load);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPanel)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSuaSDT;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSuaDiaChi;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSuaTenKhachSan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSDT;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDiaChi;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTenKhachSan;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picBoxPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblPanel;
    }
}