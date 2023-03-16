using QLKhachSan.GUI.QLHeThongGUI.QLPhongGUI;

namespace QLKhachSan.GUI.QLThuChiGUI
{
    partial class frmQLThuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLThuChi));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvThuChi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCachTim = new System.Windows.Forms.ComboBox();
            this.lblReset = new System.Windows.Forms.Label();
            this.btnFindThuChi = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPhieuThuChi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.MaPhieuThuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuChi)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvThuChi);
            this.panel3.Location = new System.Drawing.Point(50, 234);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 591);
            this.panel3.TabIndex = 8;
            // 
            // dgvThuChi
            // 
            this.dgvThuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuThuChi,
            this.ThoiGian,
            this.LoaiHinh,
            this.SoTien,
            this.NoiDung});
            this.dgvThuChi.Location = new System.Drawing.Point(0, -2);
            this.dgvThuChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThuChi.Name = "dgvThuChi";
            this.dgvThuChi.RowHeadersWidth = 62;
            this.dgvThuChi.RowTemplate.Height = 28;
            this.dgvThuChi.Size = new System.Drawing.Size(1108, 591);
            this.dgvThuChi.TabIndex = 0;
            this.dgvThuChi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuChi_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCachTim);
            this.panel2.Controls.Add(this.lblReset);
            this.panel2.Controls.Add(this.btnFindThuChi);
            this.panel2.Location = new System.Drawing.Point(50, 129);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 64);
            this.panel2.TabIndex = 11;
            // 
            // cmbCachTim
            // 
            this.cmbCachTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCachTim.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCachTim.FormattingEnabled = true;
            this.cmbCachTim.Items.AddRange(new object[] {
            "Cách tìm",
            "Mã phiếu thu chi",
            "Thời gian",
            "Loại hình",
            "Nội dung"});
            this.cmbCachTim.Location = new System.Drawing.Point(352, 15);
            this.cmbCachTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCachTim.Name = "cmbCachTim";
            this.cmbCachTim.Size = new System.Drawing.Size(172, 36);
            this.cmbCachTim.TabIndex = 4;
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Image = ((System.Drawing.Image)(resources.GetObject("lblReset.Image")));
            this.lblReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReset.Location = new System.Drawing.Point(1031, 4);
            this.lblReset.MinimumSize = new System.Drawing.Size(60, 60);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(60, 60);
            this.lblReset.TabIndex = 3;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // btnFindThuChi
            // 
            this.btnFindThuChi.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnFindThuChi.BackColor = System.Drawing.Color.White;
            this.btnFindThuChi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindThuChi.BackgroundImage")));
            this.btnFindThuChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindThuChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnFindThuChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.btnFindThuChi.Icon = ((System.Drawing.Image)(resources.GetObject("btnFindThuChi.Icon")));
            this.btnFindThuChi.Location = new System.Drawing.Point(0, 0);
            this.btnFindThuChi.Margin = new System.Windows.Forms.Padding(0);
            this.btnFindThuChi.Name = "btnFindThuChi";
            this.btnFindThuChi.Size = new System.Drawing.Size(328, 65);
            this.btnFindThuChi.TabIndex = 2;
            this.btnFindThuChi.text = "";
            this.btnFindThuChi.OnTextChange += new System.EventHandler(this.btnFindThuChi_OnTextChange);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(50, 129);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 649);
            this.panel1.TabIndex = 10;
            // 
            // btnAddPhieuThuChi
            // 
            this.btnAddPhieuThuChi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddPhieuThuChi.AutoSize = true;
            this.btnAddPhieuThuChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddPhieuThuChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPhieuThuChi.BorderRadius = 7;
            this.btnAddPhieuThuChi.ButtonText = " Thêm mới";
            this.btnAddPhieuThuChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPhieuThuChi.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPhieuThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhieuThuChi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPhieuThuChi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPhieuThuChi.Iconimage")));
            this.btnAddPhieuThuChi.Iconimage_right = null;
            this.btnAddPhieuThuChi.Iconimage_right_Selected = null;
            this.btnAddPhieuThuChi.Iconimage_Selected = null;
            this.btnAddPhieuThuChi.IconMarginLeft = 0;
            this.btnAddPhieuThuChi.IconMarginRight = 0;
            this.btnAddPhieuThuChi.IconRightVisible = true;
            this.btnAddPhieuThuChi.IconRightZoom = 0D;
            this.btnAddPhieuThuChi.IconVisible = true;
            this.btnAddPhieuThuChi.IconZoom = 40D;
            this.btnAddPhieuThuChi.IsTab = true;
            this.btnAddPhieuThuChi.Location = new System.Drawing.Point(259, 27);
            this.btnAddPhieuThuChi.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPhieuThuChi.Name = "btnAddPhieuThuChi";
            this.btnAddPhieuThuChi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddPhieuThuChi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddPhieuThuChi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPhieuThuChi.selected = false;
            this.btnAddPhieuThuChi.Size = new System.Drawing.Size(168, 69);
            this.btnAddPhieuThuChi.TabIndex = 9;
            this.btnAddPhieuThuChi.Text = " Thêm mới";
            this.btnAddPhieuThuChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPhieuThuChi.Textcolor = System.Drawing.Color.White;
            this.btnAddPhieuThuChi.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddPhieuThuChi.Click += new System.EventHandler(this.btnAddPhieuThuChi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "PHIẾU THU CHI";
            // 
            // MaPhieuThuChi
            // 
            this.MaPhieuThuChi.DataPropertyName = "MaPhieuThuChi";
            this.MaPhieuThuChi.HeaderText = "Mã phiếu thu chi";
            this.MaPhieuThuChi.MinimumWidth = 6;
            this.MaPhieuThuChi.Name = "MaPhieuThuChi";
            this.MaPhieuThuChi.Width = 200;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Width = 170;
            // 
            // LoaiHinh
            // 
            this.LoaiHinh.DataPropertyName = "LoaiHinh";
            this.LoaiHinh.HeaderText = "Loại hình";
            this.LoaiHinh.MinimumWidth = 6;
            this.LoaiHinh.Name = "LoaiHinh";
            this.LoaiHinh.Width = 150;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.Width = 150;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Width = 170;
            // 
            // frmQLThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 860);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddPhieuThuChi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1215, 860);
            this.Name = "frmQLThuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmQLThuChi_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuChi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvThuChi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCachTim;
        private System.Windows.Forms.Label lblReset;
        private Bunifu.Framework.UI.BunifuTextbox btnFindThuChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddPhieuThuChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuThuChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
    }
}