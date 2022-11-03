namespace QLKhachSan.GUI.TaiKhoanGUI.QuyenGUI
{
    partial class dialogChonChucNang
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
            this.btnChonChucNang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvChonChucNang = new System.Windows.Forms.DataGridView();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonChucNang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(117, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHỌN CHỨC NĂNG";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(223, 401);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 44);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChonChucNang
            // 
            this.btnChonChucNang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnChonChucNang.AutoSize = true;
            this.btnChonChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnChonChucNang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChonChucNang.BorderRadius = 7;
            this.btnChonChucNang.ButtonText = "LƯU";
            this.btnChonChucNang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonChucNang.DisabledColor = System.Drawing.Color.Gray;
            this.btnChonChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonChucNang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChonChucNang.Iconimage = null;
            this.btnChonChucNang.Iconimage_right = null;
            this.btnChonChucNang.Iconimage_right_Selected = null;
            this.btnChonChucNang.Iconimage_Selected = null;
            this.btnChonChucNang.IconMarginLeft = 0;
            this.btnChonChucNang.IconMarginRight = 0;
            this.btnChonChucNang.IconRightVisible = true;
            this.btnChonChucNang.IconRightZoom = 0D;
            this.btnChonChucNang.IconVisible = true;
            this.btnChonChucNang.IconZoom = 50D;
            this.btnChonChucNang.IsTab = true;
            this.btnChonChucNang.Location = new System.Drawing.Point(133, 402);
            this.btnChonChucNang.Margin = new System.Windows.Forms.Padding(5);
            this.btnChonChucNang.Name = "btnChonChucNang";
            this.btnChonChucNang.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnChonChucNang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnChonChucNang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChonChucNang.selected = false;
            this.btnChonChucNang.Size = new System.Drawing.Size(85, 43);
            this.btnChonChucNang.TabIndex = 16;
            this.btnChonChucNang.Text = "LƯU";
            this.btnChonChucNang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChonChucNang.Textcolor = System.Drawing.Color.White;
            this.btnChonChucNang.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonChucNang.Click += new System.EventHandler(this.btnChonChucNang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvChonChucNang);
            this.panel1.Location = new System.Drawing.Point(28, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 331);
            this.panel1.TabIndex = 17;
            // 
            // dgvChonChucNang
            // 
            this.dgvChonChucNang.AllowUserToAddRows = false;
            this.dgvChonChucNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonChucNang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.MaChucNang,
            this.TenChucNang});
            this.dgvChonChucNang.Location = new System.Drawing.Point(4, 4);
            this.dgvChonChucNang.Name = "dgvChonChucNang";
            this.dgvChonChucNang.Size = new System.Drawing.Size(358, 325);
            this.dgvChonChucNang.TabIndex = 0;
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            // 
            // MaChucNang
            // 
            this.MaChucNang.DataPropertyName = "MaChucNang";
            this.MaChucNang.HeaderText = "Mã Chức Năng";
            this.MaChucNang.Name = "MaChucNang";
            // 
            // TenChucNang
            // 
            this.TenChucNang.DataPropertyName = "TenChucNang";
            this.TenChucNang.HeaderText = "Tên Chức Năng";
            this.TenChucNang.Name = "TenChucNang";
            // 
            // dialogChonChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(415, 458);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChonChucNang);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "dialogChonChucNang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dialogChonChucNang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonChucNang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnChonChucNang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvChonChucNang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucNang;
    }
}