namespace QLKhachSan.GUI.QLKhoGUI
{
    partial class frmPNKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLPNKho));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPhieuNhapKho = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFindKho = new Bunifu.Framework.UI.BunifuTextbox();
            this.cmbCachTim = new System.Windows.Forms.ComboBox();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.MaPNKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UuTienHienThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReset = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "PHIẾU NHẬP KHO";
            // 
            // btnAddPhieuNhapKho
            // 
            this.btnAddPhieuNhapKho.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddPhieuNhapKho.AutoSize = true;
            this.btnAddPhieuNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddPhieuNhapKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPhieuNhapKho.BorderRadius = 7;
            this.btnAddPhieuNhapKho.ButtonText = " Thêm mới";
            this.btnAddPhieuNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPhieuNhapKho.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPhieuNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhieuNhapKho.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPhieuNhapKho.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPhieuNhapKho.Iconimage")));
            this.btnAddPhieuNhapKho.Iconimage_right = null;
            this.btnAddPhieuNhapKho.Iconimage_right_Selected = null;
            this.btnAddPhieuNhapKho.Iconimage_Selected = null;
            this.btnAddPhieuNhapKho.IconMarginLeft = 0;
            this.btnAddPhieuNhapKho.IconMarginRight = 0;
            this.btnAddPhieuNhapKho.IconRightVisible = true;
            this.btnAddPhieuNhapKho.IconRightZoom = 0D;
            this.btnAddPhieuNhapKho.IconVisible = true;
            this.btnAddPhieuNhapKho.IconZoom = 40D;
            this.btnAddPhieuNhapKho.IsTab = true;
            this.btnAddPhieuNhapKho.Location = new System.Drawing.Point(234, 28);
            this.btnAddPhieuNhapKho.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPhieuNhapKho.Name = "btnAddPhieuNhapKho";
            this.btnAddPhieuNhapKho.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddPhieuNhapKho.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddPhieuNhapKho.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPhieuNhapKho.selected = false;
            this.btnAddPhieuNhapKho.Size = new System.Drawing.Size(136, 55);
            this.btnAddPhieuNhapKho.TabIndex = 13;
            this.btnAddPhieuNhapKho.Text = " Thêm mới";
            this.btnAddPhieuNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPhieuNhapKho.Textcolor = System.Drawing.Color.White;
            this.btnAddPhieuNhapKho.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddPhieuNhapKho.Click += new System.EventHandler(this.btnAddPhieuNhapKho_Click);
            // 
            // btnFindKho
            // 
            this.btnFindKho.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnFindKho.BackColor = System.Drawing.Color.White;
            this.btnFindKho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindKho.BackgroundImage")));
            this.btnFindKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindKho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnFindKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.btnFindKho.Icon = ((System.Drawing.Image)(resources.GetObject("btnFindKho.Icon")));
            this.btnFindKho.Location = new System.Drawing.Point(42, 109);
            this.btnFindKho.Margin = new System.Windows.Forms.Padding(0);
            this.btnFindKho.Name = "btnFindKho";
            this.btnFindKho.Size = new System.Drawing.Size(292, 52);
            this.btnFindKho.TabIndex = 14;
            this.btnFindKho.text = "";
            this.btnFindKho.OnTextChange += new System.EventHandler(this.btnFindKho_OnTextChange);
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
            this.cmbCachTim.Location = new System.Drawing.Point(367, 120);
            this.cmbCachTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCachTim.Name = "cmbCachTim";
            this.cmbCachTim.Size = new System.Drawing.Size(153, 31);
            this.cmbCachTim.TabIndex = 15;
            // 
            // dgvKho
            // 
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPNKho,
            this.ThoiGianNhap,
            this.MaNhanVien,
            this.GhiChu,
            this.UuTienHienThi});
            this.dgvKho.Location = new System.Drawing.Point(42, 184);
            this.dgvKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.RowHeadersWidth = 62;
            this.dgvKho.RowTemplate.Height = 28;
            this.dgvKho.Size = new System.Drawing.Size(818, 313);
            this.dgvKho.TabIndex = 16;
            this.dgvKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKho_CellContentClick);
            // 
            // MaPNKho
            // 
            this.MaPNKho.DataPropertyName = "MaPNKho";
            this.MaPNKho.HeaderText = "Mã PN Kho";
            this.MaPNKho.MinimumWidth = 6;
            this.MaPNKho.Name = "MaPNKho";
            this.MaPNKho.Width = 125;
            // 
            // ThoiGianNhap
            // 
            this.ThoiGianNhap.DataPropertyName = "ThoiGianNhap";
            this.ThoiGianNhap.HeaderText = "Thời gian nhập";
            this.ThoiGianNhap.MinimumWidth = 6;
            this.ThoiGianNhap.Name = "ThoiGianNhap";
            this.ThoiGianNhap.Width = 140;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 125;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 8;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 165;
            // 
            // UuTienHienThi
            // 
            this.UuTienHienThi.DataPropertyName = "UuTienHienThi";
            this.UuTienHienThi.HeaderText = "Ưu tiên hiển thị";
            this.UuTienHienThi.MinimumWidth = 6;
            this.UuTienHienThi.Name = "UuTienHienThi";
            this.UuTienHienThi.Width = 130;
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Image = ((System.Drawing.Image)(resources.GetObject("lblReset.Image")));
            this.lblReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReset.Location = new System.Drawing.Point(807, 103);
            this.lblReset.MinimumSize = new System.Drawing.Size(53, 48);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(53, 48);
            this.lblReset.TabIndex = 17;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // frmQLKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 528);
            this.ControlBox = false;
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.dgvKho);
            this.Controls.Add(this.cmbCachTim);
            this.Controls.Add(this.btnFindKho);
            this.Controls.Add(this.btnAddPhieuNhapKho);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(902, 528);
            this.Name = "frmQLPNKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPNKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UuTienHienThi;
        private System.Windows.Forms.ComboBox cmbCachTim;
        private Bunifu.Framework.UI.BunifuTextbox btnFindKho;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddPhieuNhapKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReset;
    }
}