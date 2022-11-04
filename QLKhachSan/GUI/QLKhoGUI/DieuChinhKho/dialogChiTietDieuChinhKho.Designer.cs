namespace QLKhachSan.GUI.QLKhoGUI.DieuChinhKho
{
    partial class dialogChiTietDieuChinhKho
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.dateNhan = new Bunifu.Framework.UI.BunifuDatepicker();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.timeNhan = new System.Windows.Forms.DateTimePicker();
            this.dgvCTDieuChinhKho = new System.Windows.Forms.DataGridView();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDieuChinhKho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(125, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU ĐIỀU CHỈNH KHO";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(200, 503);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 69);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.dateNhan);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(17, 93);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(244, 80);
            this.flowLayoutPanel2.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày nhập";
            // 
            // dateNhan
            // 
            this.dateNhan.AllowDrop = true;
            this.dateNhan.BackColor = System.Drawing.SystemColors.Window;
            this.dateNhan.BorderRadius = 10;
            this.dateNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNhan.ForeColor = System.Drawing.Color.Black;
            this.dateNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNhan.FormatCustom = "dd/MM/yyyy";
            this.dateNhan.Location = new System.Drawing.Point(4, 33);
            this.dateNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateNhan.Name = "dateNhan";
            this.dateNhan.Size = new System.Drawing.Size(240, 40);
            this.dateNhan.TabIndex = 1;
            this.dateNhan.Value = new System.DateTime(2022, 11, 1, 0, 0, 0, 0);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.timeNhan);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(308, 93);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(244, 80);
            this.flowLayoutPanel3.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giờ nhập";
            // 
            // timeNhan
            // 
            this.timeNhan.CustomFormat = "HH:mm";
            this.timeNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeNhan.Location = new System.Drawing.Point(3, 36);
            this.timeNhan.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.timeNhan.Name = "timeNhan";
            this.timeNhan.ShowUpDown = true;
            this.timeNhan.Size = new System.Drawing.Size(240, 39);
            this.timeNhan.TabIndex = 22;
            this.timeNhan.Value = new System.DateTime(2022, 10, 23, 1, 0, 1, 0);
            // 
            // dgvCTDieuChinhKho
            // 
            this.dgvCTDieuChinhKho.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCTDieuChinhKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDieuChinhKho.Location = new System.Drawing.Point(17, 268);
            this.dgvCTDieuChinhKho.Name = "dgvCTDieuChinhKho";
            this.dgvCTDieuChinhKho.RowHeadersWidth = 62;
            this.dgvCTDieuChinhKho.RowTemplate.Height = 28;
            this.dgvCTDieuChinhKho.Size = new System.Drawing.Size(535, 210);
            this.dgvCTDieuChinhKho.TabIndex = 30;
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.DarkGray;
            this.txtFind.Location = new System.Drawing.Point(17, 197);
            this.txtFind.MinimumSize = new System.Drawing.Size(535, 50);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(535, 39);
            this.txtFind.TabIndex = 31;
            this.txtFind.Text = "Tìm kiếm";
            this.txtFind.Click += new System.EventHandler(this.txtFind_Click);
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // dialogChiTietDieuChinhKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(575, 599);
            this.ControlBox = false;
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.dgvCTDieuChinhKho);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dialogChiTietDieuChinhKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dialogChiTietDieuChinhKho_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDieuChinhKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDatepicker dateNhan;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timeNhan;
        private System.Windows.Forms.DataGridView dgvCTDieuChinhKho;
        private System.Windows.Forms.TextBox txtFind;
    }
}