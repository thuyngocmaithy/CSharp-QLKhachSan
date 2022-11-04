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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSu));
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuatExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.DateBatDau = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.DateKetThuc = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnTimKiem = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "LỊCH SỬ THUÊ PHÒNG";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
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
            this.btnXuatExcel.Location = new System.Drawing.Point(368, 29);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnXuatExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnXuatExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXuatExcel.selected = false;
            this.btnXuatExcel.Size = new System.Drawing.Size(153, 66);
            this.btnXuatExcel.TabIndex = 14;
            this.btnXuatExcel.Text = "Xuất Exel";
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuatExcel.Textcolor = System.Drawing.Color.White;
            this.btnXuatExcel.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLichSu);
            this.panel1.Location = new System.Drawing.Point(52, 226);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 558);
            this.panel1.TabIndex = 20;
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Location = new System.Drawing.Point(-1, 0);
            this.dgvLichSu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.RowHeadersWidth = 62;
            this.dgvLichSu.Size = new System.Drawing.Size(1093, 553);
            this.dgvLichSu.TabIndex = 0;
            this.dgvLichSu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichSu_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.btnTimKiem);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(51, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1093, 89);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.DateBatDau);
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
            // DateBatDau
            // 
            this.DateBatDau.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DateBatDau.BorderRadius = 10;
            this.DateBatDau.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBatDau.ForeColor = System.Drawing.Color.Black;
            this.DateBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateBatDau.FormatCustom = "dd/MM/yyyy";
            this.DateBatDau.Location = new System.Drawing.Point(4, 33);
            this.DateBatDau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateBatDau.Name = "DateBatDau";
            this.DateBatDau.Size = new System.Drawing.Size(341, 45);
            this.DateBatDau.TabIndex = 1;
            this.DateBatDau.Value = new System.DateTime(2022, 10, 19, 0, 0, 0, 0);
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
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.DateKetThuc);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(360, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(345, 80);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đến ngày";
            // 
            // DateKetThuc
            // 
            this.DateKetThuc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DateKetThuc.BorderRadius = 10;
            this.DateKetThuc.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateKetThuc.ForeColor = System.Drawing.Color.Black;
            this.DateKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateKetThuc.FormatCustom = "dd/MM/yyyy";
            this.DateKetThuc.Location = new System.Drawing.Point(4, 33);
            this.DateKetThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateKetThuc.Name = "DateKetThuc";
            this.DateKetThuc.Size = new System.Drawing.Size(341, 45);
            this.DateKetThuc.TabIndex = 1;
            this.DateKetThuc.Value = new System.DateTime(2022, 10, 8, 22, 23, 26, 874);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(711, 35);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 35, 3, 0);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(50, 50);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Image = ((System.Drawing.Image)(resources.GetObject("lblReset.Image")));
            this.lblReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReset.Location = new System.Drawing.Point(551, 35);
            this.lblReset.MinimumSize = new System.Drawing.Size(60, 60);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(60, 60);
            this.lblReset.TabIndex = 6;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // frmLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 854);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1215, 860);
            this.Name = "frmLichSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLichSu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
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

        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnXuatExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker DateBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDatepicker DateKetThuc;
        private System.Windows.Forms.Label btnTimKiem;
        private System.Windows.Forms.Label lblReset;
    }
}