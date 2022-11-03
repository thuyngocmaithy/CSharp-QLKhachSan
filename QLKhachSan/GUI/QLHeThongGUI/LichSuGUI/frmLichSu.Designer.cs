namespace QLKhachSan.GUI.QLHeThongGUI.LichSuGUI
{
    partial class frmLichSu
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuatExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTuNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDenNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "LỊCH SỬ THUÊ PHÒNG";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnXuatExcel.AutoSize = true;
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnXuatExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuatExcel.BorderRadius = 7;
            this.btnXuatExcel.ButtonText = "Xuất Exel";
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXuatExcel.Iconimage = null;
            this.btnXuatExcel.Iconimage_right = null;
            this.btnXuatExcel.Iconimage_right_Selected = null;
            this.btnXuatExcel.Iconimage_Selected = null;
            this.btnXuatExcel.IconMarginLeft = 0;
            this.btnXuatExcel.IconMarginRight = 0;
            this.btnXuatExcel.IconRightVisible = true;
            this.btnXuatExcel.IconRightZoom = 0D;
            this.btnXuatExcel.IconVisible = true;
            this.btnXuatExcel.IconZoom = 40D;
            this.btnXuatExcel.IsTab = true;
            this.btnXuatExcel.Location = new System.Drawing.Point(236, 9);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnXuatExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnXuatExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXuatExcel.selected = false;
            this.btnXuatExcel.Size = new System.Drawing.Size(102, 43);
            this.btnXuatExcel.TabIndex = 14;
            this.btnXuatExcel.Text = "Xuất Exel";
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuatExcel.Textcolor = System.Drawing.Color.White;
            this.btnXuatExcel.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.BorderRadius = 7;
            this.btnTimKiem.ButtonText = "Tìm Kiếm";
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Iconimage = null;
            this.btnTimKiem.Iconimage_right = null;
            this.btnTimKiem.Iconimage_right_Selected = null;
            this.btnTimKiem.Iconimage_Selected = null;
            this.btnTimKiem.IconMarginLeft = 0;
            this.btnTimKiem.IconMarginRight = 0;
            this.btnTimKiem.IconRightVisible = true;
            this.btnTimKiem.IconRightZoom = 0D;
            this.btnTimKiem.IconVisible = true;
            this.btnTimKiem.IconZoom = 40D;
            this.btnTimKiem.IsTab = true;
            this.btnTimKiem.Location = new System.Drawing.Point(432, 76);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(107, 43);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLichSu);
            this.panel1.Location = new System.Drawing.Point(12, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 264);
            this.panel1.TabIndex = 20;
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phong,
            this.ThoiGianBatDau,
            this.ThoiGianKetThuc,
            this.NhanPhong,
            this.TraPhong});
            this.dgvLichSu.Location = new System.Drawing.Point(3, 3);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.RowHeadersWidth = 62;
            this.dgvLichSu.Size = new System.Drawing.Size(631, 261);
            this.dgvLichSu.TabIndex = 0;
            this.dgvLichSu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.dateTuNgay);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(25, 67);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(173, 52);
            this.flowLayoutPanel2.TabIndex = 21;
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
            this.dateTuNgay.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.dateDenNgay);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(236, 66);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(173, 52);
            this.flowLayoutPanel3.TabIndex = 22;
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
            this.dateDenNgay.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            // Phong
            // 
            this.Phong.DataPropertyName = "Phong";
            this.Phong.HeaderText = "Phòng";
            this.Phong.MinimumWidth = 8;
            this.Phong.Name = "Phong";
            this.Phong.Width = 150;
            // 
            // ThoiGianBatDau
            // 
            this.ThoiGianBatDau.DataPropertyName = "ThoiGianBatDau";
            this.ThoiGianBatDau.HeaderText = "Thời Gian Bắt Đầu";
            this.ThoiGianBatDau.MinimumWidth = 8;
            this.ThoiGianBatDau.Name = "ThoiGianBatDau";
            this.ThoiGianBatDau.Width = 130;
            // 
            // ThoiGianKetThuc
            // 
            this.ThoiGianKetThuc.DataPropertyName = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.HeaderText = "Thời Gian Kết Thúc";
            this.ThoiGianKetThuc.MinimumWidth = 8;
            this.ThoiGianKetThuc.Name = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.Width = 130;
            // 
            // NhanPhong
            // 
            this.NhanPhong.DataPropertyName = "TenTaiKhoan";
            this.NhanPhong.HeaderText = "Nhận Phòng";
            this.NhanPhong.MinimumWidth = 8;
            this.NhanPhong.Name = "NhanPhong";
            this.NhanPhong.Width = 150;
            // 
            // TraPhong
            // 
            this.TraPhong.DataPropertyName = "TenTaiKhoan";
            this.TraPhong.HeaderText = "Trả Phòng";
            this.TraPhong.MinimumWidth = 8;
            this.TraPhong.Name = "TraPhong";
            this.TraPhong.Width = 150;
            // 
            // frmLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 413);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.label3);
            this.Name = "frmLichSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLichSu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnXuatExcel;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker dateTuNgay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker dateDenNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraPhong;
    }
}