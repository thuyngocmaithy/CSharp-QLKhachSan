using QLKhachSan.GUI.QLKhoGUI.PNKho;

namespace QLKhachSan.GUI.QLKhoGUI.DieuChinhKho
{
    partial class frmDieuChinhKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDieuChinhKho));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDieuChinhKho = new System.Windows.Forms.DataGridView();
            this.MaDieuChinhKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianDieuChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSLDieuChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGiaDieuChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findDate = new System.Windows.Forms.Label();
            this.dateDenNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTuNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddDieuChinhKho = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuChinhKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDieuChinhKho);
            this.panel3.Location = new System.Drawing.Point(45, 187);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 313);
            this.panel3.TabIndex = 42;
            // 
            // dgvDieuChinhKho
            // 
            this.dgvDieuChinhKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDieuChinhKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDieuChinhKho,
            this.ThoiGianDieuChinh,
            this.TongSLDieuChinh,
            this.TongGiaDieuChinh});
            this.dgvDieuChinhKho.Location = new System.Drawing.Point(0, 0);
            this.dgvDieuChinhKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDieuChinhKho.Name = "dgvDieuChinhKho";
            this.dgvDieuChinhKho.RowHeadersWidth = 62;
            this.dgvDieuChinhKho.RowTemplate.Height = 28;
            this.dgvDieuChinhKho.Size = new System.Drawing.Size(818, 313);
            this.dgvDieuChinhKho.TabIndex = 0;
            this.dgvDieuChinhKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDieuChinhKho_CellContentClick);
            // 
            // MaDieuChinhKho
            // 
            this.MaDieuChinhKho.DataPropertyName = "MaDieuChinhKho";
            this.MaDieuChinhKho.HeaderText = "Mã điều chỉnh kho";
            this.MaDieuChinhKho.MinimumWidth = 6;
            this.MaDieuChinhKho.Name = "MaDieuChinhKho";
            this.MaDieuChinhKho.Width = 150;
            // 
            // ThoiGianDieuChinh
            // 
            this.ThoiGianDieuChinh.DataPropertyName = "ThoiGianDieuChinh";
            this.ThoiGianDieuChinh.HeaderText = "Thời gian điều chỉnh";
            this.ThoiGianDieuChinh.MinimumWidth = 6;
            this.ThoiGianDieuChinh.Name = "ThoiGianDieuChinh";
            this.ThoiGianDieuChinh.Width = 170;
            // 
            // TongSLDieuChinh
            // 
            this.TongSLDieuChinh.DataPropertyName = "TongSLDieuChinh";
            this.TongSLDieuChinh.HeaderText = "Tổng số lượng điều chỉnh";
            this.TongSLDieuChinh.MinimumWidth = 6;
            this.TongSLDieuChinh.Name = "TongSLDieuChinh";
            this.TongSLDieuChinh.Width = 195;
            // 
            // TongGiaDieuChinh
            // 
            this.TongGiaDieuChinh.DataPropertyName = "TongGiaDieuChinh";
            this.TongGiaDieuChinh.HeaderText = "Tổng giá điều chỉnh";
            this.TongGiaDieuChinh.MinimumWidth = 6;
            this.TongGiaDieuChinh.Name = "TongGiaDieuChinh";
            this.TongGiaDieuChinh.Width = 170;
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
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "ĐIỀU CHỈNH KHO";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(45, 187);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 313);
            this.panel1.TabIndex = 44;
            // 
            // btnAddDieuChinhKho
            // 
            this.btnAddDieuChinhKho.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddDieuChinhKho.AutoSize = true;
            this.btnAddDieuChinhKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddDieuChinhKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDieuChinhKho.BorderRadius = 7;
            this.btnAddDieuChinhKho.ButtonText = " Thêm mới";
            this.btnAddDieuChinhKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDieuChinhKho.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddDieuChinhKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDieuChinhKho.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddDieuChinhKho.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddDieuChinhKho.Iconimage")));
            this.btnAddDieuChinhKho.Iconimage_right = null;
            this.btnAddDieuChinhKho.Iconimage_right_Selected = null;
            this.btnAddDieuChinhKho.Iconimage_Selected = null;
            this.btnAddDieuChinhKho.IconMarginLeft = 0;
            this.btnAddDieuChinhKho.IconMarginRight = 0;
            this.btnAddDieuChinhKho.IconRightVisible = true;
            this.btnAddDieuChinhKho.IconRightZoom = 0D;
            this.btnAddDieuChinhKho.IconVisible = true;
            this.btnAddDieuChinhKho.IconZoom = 40D;
            this.btnAddDieuChinhKho.IsTab = true;
            this.btnAddDieuChinhKho.Location = new System.Drawing.Point(251, 29);
            this.btnAddDieuChinhKho.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddDieuChinhKho.Name = "btnAddDieuChinhKho";
            this.btnAddDieuChinhKho.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddDieuChinhKho.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddDieuChinhKho.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddDieuChinhKho.selected = false;
            this.btnAddDieuChinhKho.Size = new System.Drawing.Size(136, 55);
            this.btnAddDieuChinhKho.TabIndex = 43;
            this.btnAddDieuChinhKho.Text = " Thêm mới";
            this.btnAddDieuChinhKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDieuChinhKho.Textcolor = System.Drawing.Color.White;
            this.btnAddDieuChinhKho.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddDieuChinhKho.Click += new System.EventHandler(this.btnAddDieuChinhKho_Click);
            // 
            // frmDieuChinhKho
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
            this.Controls.Add(this.btnAddDieuChinhKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(902, 528);
            this.Name = "frmDieuChinhKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDieuChinhKho_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuChinhKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvDieuChinhKho;
        private System.Windows.Forms.Label findDate;
        private Bunifu.Framework.UI.BunifuDatepicker dateDenNgay;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker dateTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddDieuChinhKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDieuChinhKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDieuChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSLDieuChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGiaDieuChinh;
    }
}