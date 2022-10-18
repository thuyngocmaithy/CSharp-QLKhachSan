using QLKhachSan.GUI.QLHeThongGUI.QLLoaiPhongGUI;

namespace QLKhachSan.GUI.QLHeThongGUI.QLPhongGUI
{
    partial class frmQLPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLLoaiPhong));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UuTienHienThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCachTim = new System.Windows.Forms.ComboBox();
            this.lblReset = new System.Windows.Forms.Label();
            this.btnFindLoaiPhong = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddDatPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvLoaiPhong);
            this.panel3.Location = new System.Drawing.Point(50, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(920, 391);
            this.panel3.TabIndex = 8;
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiPhong,
            this.TenLoaiPhong,
            this.UuTienHienThi});
            this.dgvLoaiPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.RowHeadersWidth = 62;
            this.dgvLoaiPhong.RowTemplate.Height = 28;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(920, 391);
            this.dgvLoaiPhong.TabIndex = 0;
            this.dgvLoaiPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiPhong_CellContentClick);
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.MaLoaiPhong.HeaderText = "Mã loại phòng";
            this.MaLoaiPhong.MinimumWidth = 8;
            this.MaLoaiPhong.Name = "MaLoaiPhong";
            this.MaLoaiPhong.Width = 200;
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.DataPropertyName = "TenLoaiPhong";
            this.TenLoaiPhong.HeaderText = "Tên loại phòng";
            this.TenLoaiPhong.MinimumWidth = 8;
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            this.TenLoaiPhong.Width = 291;
            // 
            // UuTienHienThi
            // 
            this.UuTienHienThi.DataPropertyName = "UuTienHienThi";
            this.UuTienHienThi.HeaderText = "Ưu tiên hiển thị";
            this.UuTienHienThi.MinimumWidth = 8;
            this.UuTienHienThi.Name = "UuTienHienThi";
            this.UuTienHienThi.Width = 165;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCachTim);
            this.panel2.Controls.Add(this.lblReset);
            this.panel2.Controls.Add(this.btnFindLoaiPhong);
            this.panel2.Location = new System.Drawing.Point(50, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 64);
            this.panel2.TabIndex = 11;
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
            this.lblReset.Image = ((System.Drawing.Image)(resources.GetObject("lblReset.Image")));
            this.lblReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReset.Location = new System.Drawing.Point(857, 5);
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
            this.btnFindLoaiPhong.OnTextChange += new System.EventHandler(this.btnFindLoaiPhong_OnTextChange);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(50, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 496);
            this.panel1.TabIndex = 10;
            // 
            // btnAddDatPhong
            // 
            this.btnAddDatPhong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddDatPhong.AutoSize = true;
            this.btnAddDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddDatPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDatPhong.BorderRadius = 7;
            this.btnAddDatPhong.ButtonText = " Thêm mới";
            this.btnAddDatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDatPhong.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDatPhong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddDatPhong.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddDatPhong.Iconimage")));
            this.btnAddDatPhong.Iconimage_right = null;
            this.btnAddDatPhong.Iconimage_right_Selected = null;
            this.btnAddDatPhong.Iconimage_Selected = null;
            this.btnAddDatPhong.IconMarginLeft = 0;
            this.btnAddDatPhong.IconMarginRight = 0;
            this.btnAddDatPhong.IconRightVisible = true;
            this.btnAddDatPhong.IconRightZoom = 0D;
            this.btnAddDatPhong.IconVisible = true;
            this.btnAddDatPhong.IconZoom = 40D;
            this.btnAddDatPhong.IsTab = true;
            this.btnAddDatPhong.Location = new System.Drawing.Point(225, 35);
            this.btnAddDatPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddDatPhong.Name = "btnAddDatPhong";
            this.btnAddDatPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddDatPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddDatPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddDatPhong.selected = false;
            this.btnAddDatPhong.Size = new System.Drawing.Size(153, 63);
            this.btnAddDatPhong.TabIndex = 9;
            this.btnAddDatPhong.Text = " Thêm mới";
            this.btnAddDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDatPhong.Textcolor = System.Drawing.Color.White;
            this.btnAddDatPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddDatPhong.Click += new System.EventHandler(this.btnAddDatPhong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "LOẠI PHÒNG";
            // 
            // frmQLLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 660);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddDatPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1015, 660);
            this.Name = "frmQLLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmQLPhong_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddDatPhong;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvLoaiPhong;
        private Bunifu.Framework.UI.BunifuTextbox btnFindLoaiPhong;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn UuTienHienThi;
        private System.Windows.Forms.ComboBox cmbCachTim;
    }
}