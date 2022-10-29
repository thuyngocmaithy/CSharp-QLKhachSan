namespace QLKhachSan.GUI.QLHeThongGUI
{
    partial class CachThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CachThue));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCachTim = new System.Windows.Forms.ComboBox();
            this.lblReset = new System.Windows.Forms.Label();
            this.btnFindLoaiPhong = new Bunifu.Framework.UI.BunifuTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaCachThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCachThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTheoCachThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioNhanPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 289);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "CÁCH THUÊ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCachTim);
            this.panel2.Controls.Add(this.lblReset);
            this.panel2.Controls.Add(this.btnFindLoaiPhong);
            this.panel2.Location = new System.Drawing.Point(3, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 60);
            this.panel2.TabIndex = 12;
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
            this.lblReset.Location = new System.Drawing.Point(485, 4);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCachThue,
            this.TenCachThue,
            this.GiaTheoCachThue,
            this.GioNhanPhong,
            this.GioTraPhong});
            this.dataGridView1.Location = new System.Drawing.Point(3, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // MaCachThue
            // 
            this.MaCachThue.HeaderText = "Mã Cách Thuê";
            this.MaCachThue.MinimumWidth = 6;
            this.MaCachThue.Name = "MaCachThue";
            this.MaCachThue.Width = 125;
            // 
            // TenCachThue
            // 
            this.TenCachThue.HeaderText = "Tên Cách Thuê";
            this.TenCachThue.MinimumWidth = 6;
            this.TenCachThue.Name = "TenCachThue";
            this.TenCachThue.Width = 140;
            // 
            // GiaTheoCachThue
            // 
            this.GiaTheoCachThue.HeaderText = "Giá Theo Cách Thuê";
            this.GiaTheoCachThue.MinimumWidth = 6;
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
            this.GioTraPhong.Width = 125;
            // 
            // CachThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 356);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "CachThue";
            this.Text = "CachThue";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCachThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCachThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTheoCachThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioNhanPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioTraPhong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCachTim;
        private System.Windows.Forms.Label lblReset;
        private Bunifu.Framework.UI.BunifuTextbox btnFindLoaiPhong;
    }
}