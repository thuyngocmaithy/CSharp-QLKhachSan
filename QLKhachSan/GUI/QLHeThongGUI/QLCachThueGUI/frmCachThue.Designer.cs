namespace QLKhachSan.GUI.QLHeThongGUI.QLCachThueGUI
{
    partial class frmCachThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCachThue));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCachTim = new System.Windows.Forms.ComboBox();
            this.lblReset = new System.Windows.Forms.Label();
            this.btnFindLoaiPhong = new Bunifu.Framework.UI.BunifuTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddDatPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MaCachThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTheoCachThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioNhanPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvLoaiPhong);
            this.panel3.Location = new System.Drawing.Point(-7, 148);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 313);
            this.panel3.TabIndex = 13;
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCachThue,
            this.TenLoaiPhong,
            this.GiaTheoCachThue,
            this.GioNhanPhong,
            this.GioTraPhong});
            this.dgvLoaiPhong.Location = new System.Drawing.Point(19, -2);
            this.dgvLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.RowHeadersWidth = 62;
            this.dgvLoaiPhong.RowTemplate.Height = 28;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(762, 313);
            this.dgvLoaiPhong.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCachTim);
            this.panel2.Controls.Add(this.lblReset);
            this.panel2.Controls.Add(this.btnFindLoaiPhong);
            this.panel2.Location = new System.Drawing.Point(12, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 51);
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
            this.cmbCachTim.Location = new System.Drawing.Point(313, 12);
            this.cmbCachTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCachTim.Name = "cmbCachTim";
            this.cmbCachTim.Size = new System.Drawing.Size(153, 31);
            this.cmbCachTim.TabIndex = 4;
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Image = ((System.Drawing.Image)(resources.GetObject("lblReset.Image")));
            this.lblReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReset.Location = new System.Drawing.Point(533, 0);
            this.lblReset.MinimumSize = new System.Drawing.Size(53, 48);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(53, 48);
            this.lblReset.TabIndex = 3;
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
            this.btnFindLoaiPhong.Size = new System.Drawing.Size(292, 52);
            this.btnFindLoaiPhong.TabIndex = 2;
            this.btnFindLoaiPhong.text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "CÁCH THUÊ";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-7, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 397);
            this.panel1.TabIndex = 15;
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
            this.btnAddDatPhong.Location = new System.Drawing.Point(219, 7);
            this.btnAddDatPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddDatPhong.Name = "btnAddDatPhong";
            this.btnAddDatPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddDatPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddDatPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddDatPhong.selected = false;
            this.btnAddDatPhong.Size = new System.Drawing.Size(136, 55);
            this.btnAddDatPhong.TabIndex = 14;
            this.btnAddDatPhong.Text = " Thêm mới";
            this.btnAddDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDatPhong.Textcolor = System.Drawing.Color.White;
            this.btnAddDatPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // MaCachThue
            // 
            this.MaCachThue.DataPropertyName = "MaCachThue";
            this.MaCachThue.HeaderText = "Mã Cách Thuê";
            this.MaCachThue.MinimumWidth = 8;
            this.MaCachThue.Name = "MaCachThue";
            this.MaCachThue.Width = 130;
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.DataPropertyName = "TenLoaiPhong";
            this.TenLoaiPhong.HeaderText = "Tên Cách Thuê";
            this.TenLoaiPhong.MinimumWidth = 8;
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            this.TenLoaiPhong.Width = 140;
            // 
            // GiaTheoCachThue
            // 
            this.GiaTheoCachThue.DataPropertyName = "GiaTheoCachThue";
            this.GiaTheoCachThue.HeaderText = "Giá Theo Cách Thuê";
            this.GiaTheoCachThue.MinimumWidth = 8;
            this.GiaTheoCachThue.Name = "GiaTheoCachThue";
            this.GiaTheoCachThue.Width = 140;
            // 
            // GioNhanPhong
            // 
            this.GioNhanPhong.HeaderText = "Giờ Nhận Phòng";
            this.GioNhanPhong.MinimumWidth = 6;
            this.GioNhanPhong.Name = "GioNhanPhong";
            this.GioNhanPhong.Width = 140;
            // 
            // GioTraPhong
            // 
            this.GioTraPhong.HeaderText = "Giờ Trả Phòng";
            this.GioTraPhong.MinimumWidth = 6;
            this.GioTraPhong.Name = "GioTraPhong";
            this.GioTraPhong.Width = 140;
            // 
            // frmCachThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddDatPhong);
            this.Name = "frmCachThue";
            this.Text = "frmCachThue";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCachTim;
        private System.Windows.Forms.Label lblReset;
        private Bunifu.Framework.UI.BunifuTextbox btnFindLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCachThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTheoCachThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioNhanPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioTraPhong;
    }
}