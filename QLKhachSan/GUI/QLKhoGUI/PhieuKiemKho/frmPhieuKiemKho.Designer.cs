using QLKhachSan.GUI.QLKhoGUI.DieuChinhKho;

namespace QLKhachSan.GUI.QLKhoGUI.PhieuKiemKho
{
    partial class frmPhieuKiemKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuKiemKho));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPhieuKiemKho = new System.Windows.Forms.DataGridView();
            this.dateDenNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTuNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPhieuKiemKho = new Bunifu.Framework.UI.BunifuFlatButton();
            this.findDate = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
            this.MaPhieuKiemKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianTaoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoaTaoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKiemKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPhieuKiemKho);
            this.panel3.Location = new System.Drawing.Point(45, 187);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 313);
            this.panel3.TabIndex = 42;
            // 
            // dgvPhieuKiemKho
            // 
            this.dgvPhieuKiemKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuKiemKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuKiemKho,
            this.ThoiGianTaoPhieu,
            this.TaiKhoaTaoPhieu});
            this.dgvPhieuKiemKho.Location = new System.Drawing.Point(0, 0);
            this.dgvPhieuKiemKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPhieuKiemKho.Name = "dgvPhieuKiemKho";
            this.dgvPhieuKiemKho.RowHeadersWidth = 62;
            this.dgvPhieuKiemKho.RowTemplate.Height = 28;
            this.dgvPhieuKiemKho.Size = new System.Drawing.Size(818, 313);
            this.dgvPhieuKiemKho.TabIndex = 0;
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.BackColor = System.Drawing.SystemColors.Window;
            this.dateDenNgay.BorderRadius = 0;
            this.dateDenNgay.ForeColor = System.Drawing.Color.Black;
            this.dateDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDenNgay.FormatCustom = " dd/MM/yyyy HH:mm:ss";
            this.dateDenNgay.Location = new System.Drawing.Point(459, 107);
            this.dateDenNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(221, 51);
            this.dateDenNgay.TabIndex = 49;
            this.dateDenNgay.Value = new System.DateTime(2022, 10, 28, 1, 30, 16, 780);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Đến ngày";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.BackColor = System.Drawing.SystemColors.Window;
            this.dateTuNgay.BorderRadius = 0;
            this.dateTuNgay.ForeColor = System.Drawing.Color.Black;
            this.dateTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTuNgay.FormatCustom = " dd/MM/yyyy HH:mm:ss";
            this.dateTuNgay.Location = new System.Drawing.Point(118, 107);
            this.dateTuNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(221, 51);
            this.dateTuNgay.TabIndex = 47;
            this.dateTuNgay.Value = new System.DateTime(2022, 10, 28, 1, 30, 16, 780);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "KIỂM KHO";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(45, 187);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 313);
            this.panel1.TabIndex = 44;
            // 
            // btnAddPhieuKiemKho
            // 
            this.btnAddPhieuKiemKho.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddPhieuKiemKho.AutoSize = true;
            this.btnAddPhieuKiemKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddPhieuKiemKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPhieuKiemKho.BorderRadius = 7;
            this.btnAddPhieuKiemKho.ButtonText = " Thêm mới";
            this.btnAddPhieuKiemKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPhieuKiemKho.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPhieuKiemKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhieuKiemKho.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPhieuKiemKho.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPhieuKiemKho.Iconimage")));
            this.btnAddPhieuKiemKho.Iconimage_right = null;
            this.btnAddPhieuKiemKho.Iconimage_right_Selected = null;
            this.btnAddPhieuKiemKho.Iconimage_Selected = null;
            this.btnAddPhieuKiemKho.IconMarginLeft = 0;
            this.btnAddPhieuKiemKho.IconMarginRight = 0;
            this.btnAddPhieuKiemKho.IconRightVisible = true;
            this.btnAddPhieuKiemKho.IconRightZoom = 0D;
            this.btnAddPhieuKiemKho.IconVisible = true;
            this.btnAddPhieuKiemKho.IconZoom = 40D;
            this.btnAddPhieuKiemKho.IsTab = true;
            this.btnAddPhieuKiemKho.Location = new System.Drawing.Point(175, 29);
            this.btnAddPhieuKiemKho.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPhieuKiemKho.Name = "btnAddPhieuKiemKho";
            this.btnAddPhieuKiemKho.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddPhieuKiemKho.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddPhieuKiemKho.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPhieuKiemKho.selected = false;
            this.btnAddPhieuKiemKho.Size = new System.Drawing.Size(136, 55);
            this.btnAddPhieuKiemKho.TabIndex = 43;
            this.btnAddPhieuKiemKho.Text = " Thêm mới";
            this.btnAddPhieuKiemKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPhieuKiemKho.Textcolor = System.Drawing.Color.White;
            this.btnAddPhieuKiemKho.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // findDate
            // 
            this.findDate.AutoSize = true;
            this.findDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findDate.Image = ((System.Drawing.Image)(resources.GetObject("findDate.Image")));
            this.findDate.Location = new System.Drawing.Point(720, 107);
            this.findDate.MinimumSize = new System.Drawing.Size(50, 50);
            this.findDate.Name = "findDate";
            this.findDate.Size = new System.Drawing.Size(50, 50);
            this.findDate.TabIndex = 50;
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Image = ((System.Drawing.Image)(resources.GetObject("lblReset.Image")));
            this.lblReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReset.Location = new System.Drawing.Point(424, 29);
            this.lblReset.MinimumSize = new System.Drawing.Size(53, 48);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(53, 48);
            this.lblReset.TabIndex = 41;
            // 
            // MaPhieuKiemKho
            // 
            this.MaPhieuKiemKho.DataPropertyName = "MaPhieuKiemKho";
            this.MaPhieuKiemKho.HeaderText = "Mã phiếu kiểm kho";
            this.MaPhieuKiemKho.MinimumWidth = 6;
            this.MaPhieuKiemKho.Name = "MaPhieuKiemKho";
            this.MaPhieuKiemKho.Width = 190;
            // 
            // ThoiGianTaoPhieu
            // 
            this.ThoiGianTaoPhieu.DataPropertyName = "ThoiGianTaoPhieu";
            this.ThoiGianTaoPhieu.HeaderText = "Thời gian tạo phiếu";
            this.ThoiGianTaoPhieu.MinimumWidth = 6;
            this.ThoiGianTaoPhieu.Name = "ThoiGianTaoPhieu";
            this.ThoiGianTaoPhieu.Width = 190;
            // 
            // TaiKhoaTaoPhieu
            // 
            this.TaiKhoaTaoPhieu.DataPropertyName = "TaiKhoanTaoPhieu";
            this.TaiKhoaTaoPhieu.HeaderText = "Tài khoản tạo phiếu";
            this.TaiKhoaTaoPhieu.MinimumWidth = 6;
            this.TaiKhoaTaoPhieu.Name = "TaiKhoaTaoPhieu";
            this.TaiKhoaTaoPhieu.Width = 180;
            // 
            // frmPhieuKiemKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 528);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.findDate);
            this.Controls.Add(this.dateDenNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTuNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddPhieuKiemKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(902, 528);
            this.Name = "frmPhieuKiemKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPhieuKiemKho_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKiemKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvPhieuKiemKho;
        private Bunifu.Framework.UI.BunifuDatepicker dateDenNgay;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker dateTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddPhieuKiemKho;
        private System.Windows.Forms.Label findDate;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuKiemKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianTaoPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoaTaoPhieu;
    }
}