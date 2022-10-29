namespace QLKhachSan.GUI.QLHeThongGUI.QLCachtinhtienGUI
{
    partial class frmCachtinhtien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCachtinhtien));
            this.dataGridTinhtien = new System.Windows.Forms.DataGridView();
            this.MaCachTinhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCachTinhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia1Gio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuThuQuaGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCachTim = new System.Windows.Forms.ComboBox();
            this.lblReset = new System.Windows.Forms.Label();
            this.btnFindLoaiPhong = new Bunifu.Framework.UI.BunifuTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTinhtien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridTinhtien
            // 
            this.dataGridTinhtien.AllowUserToOrderColumns = true;
            this.dataGridTinhtien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTinhtien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCachTinhTien,
            this.TenCachTinhTien,
            this.Gia1Gio,
            this.GiaNgay,
            this.PhuThuQuaGio});
            this.dataGridTinhtien.Location = new System.Drawing.Point(0, 0);
            this.dataGridTinhtien.Name = "dataGridTinhtien";
            this.dataGridTinhtien.RowHeadersWidth = 51;
            this.dataGridTinhtien.RowTemplate.Height = 24;
            this.dataGridTinhtien.Size = new System.Drawing.Size(965, 391);
            this.dataGridTinhtien.TabIndex = 0;
            this.dataGridTinhtien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTinhtien_CellContentClick);
            // 
            // MaCachTinhTien
            // 
            this.MaCachTinhTien.DataPropertyName = "MaCachTinhTien";
            this.MaCachTinhTien.HeaderText = "Mã";
            this.MaCachTinhTien.MinimumWidth = 8;
            this.MaCachTinhTien.Name = "MaCachTinhTien";
            this.MaCachTinhTien.Width = 150;
            // 
            // TenCachTinhTien
            // 
            this.TenCachTinhTien.DataPropertyName = "TenCachTinhTien";
            this.TenCachTinhTien.HeaderText = "Cách tính tiền";
            this.TenCachTinhTien.MinimumWidth = 8;
            this.TenCachTinhTien.Name = "TenCachTinhTien";
            this.TenCachTinhTien.Width = 150;
            // 
            // Gia1Gio
            // 
            this.Gia1Gio.DataPropertyName = "Gia1Gio";
            this.Gia1Gio.HeaderText = "Giá 1 giờ";
            this.Gia1Gio.MinimumWidth = 8;
            this.Gia1Gio.Name = "Gia1Gio";
            this.Gia1Gio.Width = 150;
            // 
            // GiaNgay
            // 
            this.GiaNgay.DataPropertyName = "GiaNgay";
            this.GiaNgay.HeaderText = "Giá ngày";
            this.GiaNgay.MinimumWidth = 8;
            this.GiaNgay.Name = "GiaNgay";
            this.GiaNgay.Width = 150;
            // 
            // PhuThuQuaGio
            // 
            this.PhuThuQuaGio.DataPropertyName = "PhuThuQuaGio";
            this.PhuThuQuaGio.HeaderText = "Phụ thu quá giờ";
            this.PhuThuQuaGio.MinimumWidth = 8;
            this.PhuThuQuaGio.Name = "PhuThuQuaGio";
            this.PhuThuQuaGio.Width = 160;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridTinhtien);
            this.panel3.Location = new System.Drawing.Point(27, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 391);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCachTim);
            this.panel2.Controls.Add(this.lblReset);
            this.panel2.Controls.Add(this.btnFindLoaiPhong);
            this.panel2.Location = new System.Drawing.Point(27, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 64);
            this.panel2.TabIndex = 16;
            // 
            // cmbCachTim
            // 
            this.cmbCachTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCachTim.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCachTim.FormattingEnabled = true;
            this.cmbCachTim.Items.AddRange(new object[] {
            "Cách tìm",
            "Mã loại phòng",
            "Tên loại phòng",
            "Ưu tiên hiển thị"});
            this.cmbCachTim.Location = new System.Drawing.Point(352, 15);
            this.cmbCachTim.Name = "cmbCachTim";
            this.cmbCachTim.Size = new System.Drawing.Size(172, 36);
            this.cmbCachTim.TabIndex = 4;
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblReset.Image = ((System.Drawing.Image)(resources.GetObject("lblReset.Image")));
            this.lblReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReset.Location = new System.Drawing.Point(905, 0);
            this.lblReset.MinimumSize = new System.Drawing.Size(60, 60);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(60, 60);
            this.lblReset.TabIndex = 3;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // btnFindLoaiPhong
            // 
            this.btnFindLoaiPhong.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnFindLoaiPhong.BackColor = System.Drawing.Color.White;
            this.btnFindLoaiPhong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindLoaiPhong.BackgroundImage")));
            this.btnFindLoaiPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindLoaiPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnFindLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.btnFindLoaiPhong.Icon = ((System.Drawing.Image)(resources.GetObject("btnFindLoaiPhong.Icon")));
            this.btnFindLoaiPhong.Location = new System.Drawing.Point(0, 0);
            this.btnFindLoaiPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btnFindLoaiPhong.Name = "btnFindLoaiPhong";
            this.btnFindLoaiPhong.Size = new System.Drawing.Size(328, 65);
            this.btnFindLoaiPhong.TabIndex = 2;
            this.btnFindLoaiPhong.text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "CÁCH TÍNH TIỀN";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(27, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(965, 496);
            this.panel4.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 7;
            this.btnThem.ButtonText = " Thêm mới";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledColor = System.Drawing.Color.Gray;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThem.Iconimage")));
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 0;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = true;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = true;
            this.btnThem.IconZoom = 40D;
            this.btnThem.IsTab = true;
            this.btnThem.Location = new System.Drawing.Point(243, 27);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(153, 63);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = " Thêm mới";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmCachtinhtien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 660);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1015, 660);
            this.Name = "frmCachtinhtien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCachtinhtien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTinhtien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTinhtien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCachTim;
        private System.Windows.Forms.Label lblReset;
        private Bunifu.Framework.UI.BunifuTextbox btnFindLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCachTinhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCachTinhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia1Gio;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuThuQuaGio;
    }
}