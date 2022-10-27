namespace QLKhachSan.GUI.TaiKhoanGUI
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCachTim = new System.Windows.Forms.ComboBox();
            this.lblReset = new System.Windows.Forms.Label();
            this.btnFindTaiKhoan = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnAddTaiKhoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuyen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTaiKhoan,
            this.TenTaiKhoan,
            this.MatKhau,
            this.MaQuyen});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 62;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(980, 431);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "TÀI KHOẢN\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCachTim);
            this.panel2.Controls.Add(this.lblReset);
            this.panel2.Controls.Add(this.btnFindTaiKhoan);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 66);
            this.panel2.TabIndex = 14;
            // 
            // cmbCachTim
            // 
            this.cmbCachTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCachTim.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCachTim.FormattingEnabled = true;
            this.cmbCachTim.Items.AddRange(new object[] {
            "Cách tìm",
            "Mã Tài Khoản",
            "Tên Tài Khoản",
            "Mã Quyền"});
            this.cmbCachTim.Location = new System.Drawing.Point(351, 15);
            this.cmbCachTim.Name = "cmbCachTim";
            this.cmbCachTim.Size = new System.Drawing.Size(172, 36);
            this.cmbCachTim.TabIndex = 4;
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Image = ((System.Drawing.Image)(resources.GetObject("lblReset.Image")));
            this.lblReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReset.Location = new System.Drawing.Point(902, 0);
            this.lblReset.MinimumSize = new System.Drawing.Size(75, 77);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(75, 77);
            this.lblReset.TabIndex = 3;
            this.lblReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblReset_MouseClick);
            // 
            // btnFindTaiKhoan
            // 
            this.btnFindTaiKhoan.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnFindTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnFindTaiKhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindTaiKhoan.BackgroundImage")));
            this.btnFindTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnFindTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.btnFindTaiKhoan.Icon = ((System.Drawing.Image)(resources.GetObject("btnFindTaiKhoan.Icon")));
            this.btnFindTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.btnFindTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btnFindTaiKhoan.Name = "btnFindTaiKhoan";
            this.btnFindTaiKhoan.Size = new System.Drawing.Size(328, 65);
            this.btnFindTaiKhoan.TabIndex = 2;
            this.btnFindTaiKhoan.text = "";
            this.btnFindTaiKhoan.OnTextChange += new System.EventHandler(this.btnFindTaiKhoan_OnTextChange);
            // 
            // btnAddTaiKhoan
            // 
            this.btnAddTaiKhoan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddTaiKhoan.AutoSize = true;
            this.btnAddTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTaiKhoan.BorderRadius = 7;
            this.btnAddTaiKhoan.ButtonText = " Thêm mới";
            this.btnAddTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTaiKhoan.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTaiKhoan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddTaiKhoan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddTaiKhoan.Iconimage")));
            this.btnAddTaiKhoan.Iconimage_right = null;
            this.btnAddTaiKhoan.Iconimage_right_Selected = null;
            this.btnAddTaiKhoan.Iconimage_Selected = null;
            this.btnAddTaiKhoan.IconMarginLeft = 0;
            this.btnAddTaiKhoan.IconMarginRight = 0;
            this.btnAddTaiKhoan.IconRightVisible = true;
            this.btnAddTaiKhoan.IconRightZoom = 0D;
            this.btnAddTaiKhoan.IconVisible = true;
            this.btnAddTaiKhoan.IconZoom = 40D;
            this.btnAddTaiKhoan.IsTab = true;
            this.btnAddTaiKhoan.Location = new System.Drawing.Point(232, 18);
            this.btnAddTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddTaiKhoan.Name = "btnAddTaiKhoan";
            this.btnAddTaiKhoan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddTaiKhoan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddTaiKhoan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddTaiKhoan.selected = false;
            this.btnAddTaiKhoan.Size = new System.Drawing.Size(153, 63);
            this.btnAddTaiKhoan.TabIndex = 15;
            this.btnAddTaiKhoan.Text = " Thêm mới";
            this.btnAddTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTaiKhoan.Textcolor = System.Drawing.Color.White;
            this.btnAddTaiKhoan.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddTaiKhoan.Click += new System.EventHandler(this.btnAddTaiKhoan_Click);
            // 
            // btnQuyen
            // 
            this.btnQuyen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQuyen.AutoSize = true;
            this.btnQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuyen.BorderRadius = 7;
            this.btnQuyen.ButtonText = "Quản lý quyền";
            this.btnQuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuyen.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuyen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuyen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuyen.Iconimage")));
            this.btnQuyen.Iconimage_right = null;
            this.btnQuyen.Iconimage_right_Selected = null;
            this.btnQuyen.Iconimage_Selected = null;
            this.btnQuyen.IconMarginLeft = 0;
            this.btnQuyen.IconMarginRight = 0;
            this.btnQuyen.IconRightVisible = true;
            this.btnQuyen.IconRightZoom = 0D;
            this.btnQuyen.IconVisible = true;
            this.btnQuyen.IconZoom = 55D;
            this.btnQuyen.IsTab = true;
            this.btnQuyen.Location = new System.Drawing.Point(412, 15);
            this.btnQuyen.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuyen.Name = "btnQuyen";
            this.btnQuyen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnQuyen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnQuyen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuyen.selected = false;
            this.btnQuyen.Size = new System.Drawing.Size(181, 66);
            this.btnQuyen.TabIndex = 16;
            this.btnQuyen.Text = "Quản lý quyền";
            this.btnQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuyen.Textcolor = System.Drawing.Color.White;
            this.btnQuyen.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuyen.Click += new System.EventHandler(this.btnQuyen_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(18, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 530);
            this.panel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvTaiKhoan);
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 431);
            this.panel3.TabIndex = 15;
            // 
            // MaTaiKhoan
            // 
            this.MaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.MaTaiKhoan.HeaderText = "Mã Tài Khoản";
            this.MaTaiKhoan.MinimumWidth = 8;
            this.MaTaiKhoan.Name = "MaTaiKhoan";
            this.MaTaiKhoan.Width = 160;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.HeaderText = "Tên Tài Khoản";
            this.TenTaiKhoan.MinimumWidth = 8;
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.Width = 200;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 8;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 200;
            // 
            // MaQuyen
            // 
            this.MaQuyen.DataPropertyName = "MaQuyen";
            this.MaQuyen.HeaderText = "Mã Quyền";
            this.MaQuyen.MinimumWidth = 8;
            this.MaQuyen.Name = "MaQuyen";
            this.MaQuyen.Width = 155;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 660);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuyen);
            this.Controls.Add(this.btnAddTaiKhoan);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1016, 660);
            this.Name = "frmTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCachTim;
        private System.Windows.Forms.Label lblReset;
        private Bunifu.Framework.UI.BunifuTextbox btnFindTaiKhoan;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddTaiKhoan;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuyen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuyen;
    }
}