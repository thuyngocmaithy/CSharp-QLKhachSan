namespace QLKhachSan.GUI.QLKhoGUI.PNKho
{
    partial class frmQLPNKho
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
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.lblReset = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTuNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDenNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblFind = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "PHIẾU NHẬP KHO";
            // 
            // btnAddPhieuNhapKho
            // 
            this.btnAddPhieuNhapKho.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
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
            this.btnAddPhieuNhapKho.Location = new System.Drawing.Point(293, 34);
            this.btnAddPhieuNhapKho.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPhieuNhapKho.Name = "btnAddPhieuNhapKho";
            this.btnAddPhieuNhapKho.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddPhieuNhapKho.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddPhieuNhapKho.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPhieuNhapKho.selected = false;
            this.btnAddPhieuNhapKho.Size = new System.Drawing.Size(150, 63);
            this.btnAddPhieuNhapKho.TabIndex = 13;
            this.btnAddPhieuNhapKho.Text = " Thêm mới";
            this.btnAddPhieuNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPhieuNhapKho.Textcolor = System.Drawing.Color.White;
            this.btnAddPhieuNhapKho.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddPhieuNhapKho.Click += new System.EventHandler(this.btnAddPhieuNhapKho_Click);
            // 
            // dgvKho
            // 
            this.dgvKho.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Location = new System.Drawing.Point(47, 247);
            this.dgvKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.RowHeadersWidth = 62;
            this.dgvKho.RowTemplate.Height = 28;
            this.dgvKho.Size = new System.Drawing.Size(1110, 555);
            this.dgvKho.TabIndex = 16;
            this.dgvKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKho_CellContentClick);
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Image = ((System.Drawing.Image)(resources.GetObject("lblReset.Image")));
            this.lblReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReset.Location = new System.Drawing.Point(1097, 161);
            this.lblReset.MinimumSize = new System.Drawing.Size(60, 60);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(60, 60);
            this.lblReset.TabIndex = 17;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.lblFind);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(47, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1036, 89);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.dateTuNgay);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(345, 80);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
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
            this.dateTuNgay.Location = new System.Drawing.Point(4, 33);
            this.dateTuNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(341, 45);
            this.dateTuNgay.TabIndex = 1;
            this.dateTuNgay.Value = new System.DateTime(2022, 10, 19, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(354, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.dateDenNgay);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(360, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(345, 80);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đến ngày";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dateDenNgay.BorderRadius = 10;
            this.dateDenNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDenNgay.ForeColor = System.Drawing.Color.Black;
            this.dateDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDenNgay.FormatCustom = "dd/MM/yyyy";
            this.dateDenNgay.Location = new System.Drawing.Point(4, 33);
            this.dateDenNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(340, 45);
            this.dateDenNgay.TabIndex = 1;
            this.dateDenNgay.Value = new System.DateTime(2022, 10, 8, 22, 23, 26, 874);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFind.Image = ((System.Drawing.Image)(resources.GetObject("lblFind.Image")));
            this.lblFind.Location = new System.Drawing.Point(711, 35);
            this.lblFind.Margin = new System.Windows.Forms.Padding(3, 35, 3, 0);
            this.lblFind.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(50, 50);
            this.lblFind.TabIndex = 5;
            this.lblFind.Click += new System.EventHandler(this.lblFind_Click);
            // 
            // frmQLPNKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 860);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.dgvKho);
            this.Controls.Add(this.btnAddPhieuNhapKho);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1215, 860);
            this.Name = "frmQLPNKho";
            this.Load += new System.EventHandler(this.frmPNKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvKho;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddPhieuNhapKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker dateTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker dateDenNgay;
        private System.Windows.Forms.Label lblFind;
    }
}