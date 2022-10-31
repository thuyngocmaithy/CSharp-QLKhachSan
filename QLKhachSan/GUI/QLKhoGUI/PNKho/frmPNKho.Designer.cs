using QLKhachSan.GUI.QLThuChiGUI;

namespace QLKhachSan.GUI.QLKhoGUI.PNKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPNKho));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPNKho = new System.Windows.Forms.DataGridView();
            this.MaPNKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UuTienHienThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPNKho = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFindPNKho = new Bunifu.Framework.UI.BunifuTextbox();
            this.lblReset = new System.Windows.Forms.Label();
            this.cmbCachTim = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNKho)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPNKho);
            this.panel3.Location = new System.Drawing.Point(44, 187);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 313);
            this.panel3.TabIndex = 8;
            // 
            // dgvPNKho
            // 
            this.dgvPNKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPNKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPNKho,
            this.ThoiGianNhap,
            this.MaTaiKhoan,
            this.GhiChu,
            this.UuTienHienThi});
            this.dgvPNKho.Location = new System.Drawing.Point(0, 0);
            this.dgvPNKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPNKho.Name = "dgvPNKho";
            this.dgvPNKho.RowHeadersWidth = 62;
            this.dgvPNKho.RowTemplate.Height = 28;
            this.dgvPNKho.Size = new System.Drawing.Size(818, 313);
            this.dgvPNKho.TabIndex = 0;
            this.dgvPNKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPNKho_CellContentClick);
            // 
            // MaPNKho
            // 
            this.MaPNKho.DataPropertyName = "MaPNKho";
            this.MaPNKho.HeaderText = "Mã phiếu nhập kho";
            this.MaPNKho.MinimumWidth = 6;
            this.MaPNKho.Name = "MaPNKho";
            this.MaPNKho.Width = 150;
            // 
            // ThoiGianNhap
            // 
            this.ThoiGianNhap.DataPropertyName = "ThoiGianNhap";
            this.ThoiGianNhap.HeaderText = "Thời gian nhập";
            this.ThoiGianNhap.MinimumWidth = 6;
            this.ThoiGianNhap.Name = "ThoiGianNhap";
            this.ThoiGianNhap.Width = 125;
            // 
            // MaTaiKhoan
            // 
            this.MaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.MaTaiKhoan.HeaderText = "Mã tài khoản";
            this.MaTaiKhoan.MinimumWidth = 6;
            this.MaTaiKhoan.Name = "MaTaiKhoan";
            this.MaTaiKhoan.Width = 125;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 125;
            // 
            // UuTienHienThi
            // 
            this.UuTienHienThi.DataPropertyName = "UuTienHienThi";
            this.UuTienHienThi.HeaderText = "Ưu tiên hiển thị";
            this.UuTienHienThi.MinimumWidth = 6;
            this.UuTienHienThi.Name = "UuTienHienThi";
            this.UuTienHienThi.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(44, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 397);
            this.panel1.TabIndex = 10;
            // 
            // btnAddPNKho
            // 
            this.btnAddPNKho.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddPNKho.AutoSize = true;
            this.btnAddPNKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddPNKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPNKho.BorderRadius = 7;
            this.btnAddPNKho.ButtonText = " Thêm mới";
            this.btnAddPNKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPNKho.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPNKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPNKho.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPNKho.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPNKho.Iconimage")));
            this.btnAddPNKho.Iconimage_right = null;
            this.btnAddPNKho.Iconimage_right_Selected = null;
            this.btnAddPNKho.Iconimage_Selected = null;
            this.btnAddPNKho.IconMarginLeft = 0;
            this.btnAddPNKho.IconMarginRight = 0;
            this.btnAddPNKho.IconRightVisible = true;
            this.btnAddPNKho.IconRightZoom = 0D;
            this.btnAddPNKho.IconVisible = true;
            this.btnAddPNKho.IconZoom = 40D;
            this.btnAddPNKho.IsTab = true;
            this.btnAddPNKho.Location = new System.Drawing.Point(250, 29);
            this.btnAddPNKho.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPNKho.Name = "btnAddPNKho";
            this.btnAddPNKho.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddPNKho.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddPNKho.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPNKho.selected = false;
            this.btnAddPNKho.Size = new System.Drawing.Size(136, 55);
            this.btnAddPNKho.TabIndex = 9;
            this.btnAddPNKho.Text = " Thêm mới";
            this.btnAddPNKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPNKho.Textcolor = System.Drawing.Color.White;
            this.btnAddPNKho.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddPNKho.Click += new System.EventHandler(this.btnAddPNKho_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "PHIẾU NHẬP KHO";
            // 
            // btnFindPNKho
            // 
            this.btnFindPNKho.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnFindPNKho.BackColor = System.Drawing.Color.White;
            this.btnFindPNKho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindPNKho.BackgroundImage")));
            this.btnFindPNKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindPNKho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnFindPNKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.btnFindPNKho.Icon = ((System.Drawing.Image)(resources.GetObject("btnFindPNKho.Icon")));
            this.btnFindPNKho.Location = new System.Drawing.Point(0, 0);
            this.btnFindPNKho.Margin = new System.Windows.Forms.Padding(0);
            this.btnFindPNKho.Name = "btnFindPNKho";
            this.btnFindPNKho.Size = new System.Drawing.Size(292, 52);
            this.btnFindPNKho.TabIndex = 2;
            this.btnFindPNKho.text = "";
            this.btnFindPNKho.OnTextChange += new System.EventHandler(this.btnFindPNKho_OnTextChange);
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Image = ((System.Drawing.Image)(resources.GetObject("lblReset.Image")));
            this.lblReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReset.Location = new System.Drawing.Point(762, 4);
            this.lblReset.MinimumSize = new System.Drawing.Size(53, 48);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(53, 48);
            this.lblReset.TabIndex = 3;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // cmbCachTim
            // 
            this.cmbCachTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCachTim.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCachTim.FormattingEnabled = true;
            this.cmbCachTim.Items.AddRange(new object[] {
            "Cách tìm",
            "Mã phiếu nhập kho",
            "Thời gian nhập",
            "Mã tài khoản",
            "Ghi chú ",
            "Ưu tiên hiển thị"});
            this.cmbCachTim.Location = new System.Drawing.Point(313, 12);
            this.cmbCachTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCachTim.Name = "cmbCachTim";
            this.cmbCachTim.Size = new System.Drawing.Size(153, 31);
            this.cmbCachTim.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCachTim);
            this.panel2.Controls.Add(this.lblReset);
            this.panel2.Controls.Add(this.btnFindPNKho);
            this.panel2.Location = new System.Drawing.Point(44, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 51);
            this.panel2.TabIndex = 11;
            // 
            // frmPNKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 528);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddPNKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(902, 528);
            this.Name = "frmPNKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPNKho_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNKho)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvPNKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddPNKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPNKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UuTienHienThi;
        private Bunifu.Framework.UI.BunifuTextbox btnFindPNKho;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.ComboBox cmbCachTim;
        private System.Windows.Forms.Panel panel2;
    }
}