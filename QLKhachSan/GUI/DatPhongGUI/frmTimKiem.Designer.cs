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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickerTuNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.datePickerDenNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.btnAddDatPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(50, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 438);
            this.panel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.lblFind);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(920, 103);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.datePickerTuNgay);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(259, 100);
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
            // datePickerTuNgay
            // 
            this.datePickerTuNgay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.datePickerTuNgay.BorderRadius = 10;
            this.datePickerTuNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerTuNgay.ForeColor = System.Drawing.Color.Black;
            this.datePickerTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerTuNgay.FormatCustom = null;
            this.datePickerTuNgay.Location = new System.Drawing.Point(4, 47);
            this.datePickerTuNgay.Margin = new System.Windows.Forms.Padding(4, 19, 4, 5);
            this.datePickerTuNgay.Name = "datePickerTuNgay";
            this.datePickerTuNgay.Size = new System.Drawing.Size(255, 45);
            this.datePickerTuNgay.TabIndex = 1;
            this.datePickerTuNgay.Value = new System.DateTime(2022, 10, 8, 22, 23, 26, 874);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.datePickerDenNgay);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(268, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(259, 100);
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
            // datePickerDenNgay
            // 
            this.datePickerDenNgay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.datePickerDenNgay.BorderRadius = 10;
            this.datePickerDenNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerDenNgay.ForeColor = System.Drawing.Color.Black;
            this.datePickerDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerDenNgay.FormatCustom = null;
            this.datePickerDenNgay.Location = new System.Drawing.Point(4, 47);
            this.datePickerDenNgay.Margin = new System.Windows.Forms.Padding(4, 19, 4, 5);
            this.datePickerDenNgay.Name = "datePickerDenNgay";
            this.datePickerDenNgay.Size = new System.Drawing.Size(255, 45);
            this.datePickerDenNgay.TabIndex = 1;
            this.datePickerDenNgay.Value = new System.DateTime(2022, 10, 8, 22, 23, 26, 874);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(533, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 4;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFind.Image = ((System.Drawing.Image)(resources.GetObject("lblFind.Image")));
            this.lblFind.Location = new System.Drawing.Point(539, 45);
            this.lblFind.Margin = new System.Windows.Forms.Padding(3, 45, 3, 0);
            this.lblFind.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(50, 50);
            this.lblFind.TabIndex = 5;
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
            this.btnAddDatPhong.TabIndex = 7;
            this.btnAddDatPhong.Text = " Thêm mới";
            this.btnAddDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDatPhong.Textcolor = System.Drawing.Color.White;
            this.btnAddDatPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddDatPhong.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "ĐẶT PHÒNG";
            // 
            // frmXemTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 660);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddDatPhong);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1015, 660);
            this.Name = "frmXemTheoNgay";
            this.panel1.ResumeLayout(false);
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker datePickerTuNgay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker datePickerDenNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFind;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddDatPhong;
        private System.Windows.Forms.Label label1;
    }
}