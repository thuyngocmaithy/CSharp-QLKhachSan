namespace QLKhachSan.GUI.DatPhongGUI
{
    partial class frmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTuNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDenNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblFind = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.dgvFindDonDatPhong = new System.Windows.Forms.DataGridView();
            this.MaPhieuDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhanPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienTraTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindDonDatPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.lblFind);
            this.flowLayoutPanel1.Controls.Add(this.txtFind);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(613, 91);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.dateTuNgay);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(173, 52);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dateTuNgay.BorderRadius = 10;
            this.dateTuNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTuNgay.ForeColor = System.Drawing.Color.Black;
            this.dateTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTuNgay.FormatCustom = "dd/MM/yyyy";
            this.dateTuNgay.Location = new System.Drawing.Point(3, 22);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(170, 29);
            this.dateTuNgay.TabIndex = 1;
            this.dateTuNgay.Value = new System.DateTime(2022, 10, 19, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(179, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.dateDenNgay);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(183, 2);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(173, 52);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đến ngày";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dateDenNgay.BorderRadius = 10;
            this.dateDenNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDenNgay.ForeColor = System.Drawing.Color.Black;
            this.dateDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDenNgay.FormatCustom = "dd/MM/yyyy";
            this.dateDenNgay.Location = new System.Drawing.Point(3, 22);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(170, 29);
            this.dateDenNgay.TabIndex = 1;
            this.dateDenNgay.Value = new System.DateTime(2022, 10, 8, 22, 23, 26, 874);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFind.Image = ((System.Drawing.Image)(resources.GetObject("lblFind.Image")));
            this.lblFind.Location = new System.Drawing.Point(360, 23);
            this.lblFind.Margin = new System.Windows.Forms.Padding(2, 23, 2, 0);
            this.lblFind.MinimumSize = new System.Drawing.Size(33, 32);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(33, 32);
            this.lblFind.TabIndex = 5;
            this.lblFind.Click += new System.EventHandler(this.lblFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.DarkGray;
            this.txtFind.Location = new System.Drawing.Point(2, 58);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFind.MinimumSize = new System.Drawing.Size(615, 50);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(615, 29);
            this.txtFind.TabIndex = 6;
            this.txtFind.Text = "Tìm kiếm";
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // dgvFindDonDatPhong
            // 
            this.dgvFindDonDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindDonDatPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuDatPhong,
            this.HoTenKhachHang,
            this.SoDienThoai,
            this.NgayNhanPhong,
            this.NgayTraPhong,
            this.TienTraTruoc,
            this.GhiChu,
            this.TrangThai});
            this.dgvFindDonDatPhong.Location = new System.Drawing.Point(0, 94);
            this.dgvFindDonDatPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFindDonDatPhong.Name = "dgvFindDonDatPhong";
            this.dgvFindDonDatPhong.RowHeadersWidth = 62;
            this.dgvFindDonDatPhong.RowTemplate.Height = 28;
            this.dgvFindDonDatPhong.Size = new System.Drawing.Size(613, 198);
            this.dgvFindDonDatPhong.TabIndex = 10;
            // 
            // MaPhieuDatPhong
            // 
            this.MaPhieuDatPhong.DataPropertyName = "MaPhieuDatPhong";
            this.MaPhieuDatPhong.HeaderText = "Mã phiếu";
            this.MaPhieuDatPhong.MinimumWidth = 8;
            this.MaPhieuDatPhong.Name = "MaPhieuDatPhong";
            this.MaPhieuDatPhong.Width = 110;
            // 
            // HoTenKhachHang
            // 
            this.HoTenKhachHang.DataPropertyName = "HoTenKhachHang";
            this.HoTenKhachHang.HeaderText = "Khách hàng";
            this.HoTenKhachHang.MinimumWidth = 8;
            this.HoTenKhachHang.Name = "HoTenKhachHang";
            this.HoTenKhachHang.Width = 150;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 8;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 150;
            // 
            // NgayNhanPhong
            // 
            this.NgayNhanPhong.DataPropertyName = "NgayNhanPhong";
            this.NgayNhanPhong.HeaderText = "Nhận phòng";
            this.NgayNhanPhong.MinimumWidth = 8;
            this.NgayNhanPhong.Name = "NgayNhanPhong";
            this.NgayNhanPhong.Width = 150;
            // 
            // NgayTraPhong
            // 
            this.NgayTraPhong.DataPropertyName = "NgayTraPhong";
            this.NgayTraPhong.HeaderText = "Trả phòng";
            this.NgayTraPhong.MinimumWidth = 8;
            this.NgayTraPhong.Name = "NgayTraPhong";
            this.NgayTraPhong.Width = 150;
            // 
            // TienTraTruoc
            // 
            this.TienTraTruoc.DataPropertyName = "TienTraTruoc";
            this.TienTraTruoc.HeaderText = "Tiền trả trước";
            this.TienTraTruoc.MinimumWidth = 8;
            this.TienTraTruoc.Name = "TienTraTruoc";
            this.TienTraTruoc.Width = 150;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 8;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 150;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 292);
            this.ControlBox = false;
            this.Controls.Add(this.dgvFindDonDatPhong);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(613, 292);
            this.MinimumSize = new System.Drawing.Size(613, 292);
            this.Name = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindDonDatPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker dateTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker dateDenNgay;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DataGridView dgvFindDonDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhanPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienTraTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}