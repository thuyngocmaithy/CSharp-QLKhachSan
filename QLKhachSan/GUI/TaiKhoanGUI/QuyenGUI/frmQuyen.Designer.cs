namespace QLKhachSan.GUI.TaiKhoanGUI.QuyenGUI
{
    partial class frmQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuyen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCachTim = new System.Windows.Forms.ComboBox();
            this.btnFindQuyen = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvQuyen = new System.Windows.Forms.DataGridView();
            this.MaQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddQuyen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChonchucnang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(70, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 685);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbCachTim);
            this.panel3.Controls.Add(this.btnFindQuyen);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1075, 68);
            this.panel3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(1000, 0);
            this.label1.MinimumSize = new System.Drawing.Size(75, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 77);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCachTim
            // 
            this.cmbCachTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCachTim.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCachTim.FormattingEnabled = true;
            this.cmbCachTim.Items.AddRange(new object[] {
            "Cách tìm",
            "Mã Quyền",
            "Tên Quyền"});
            this.cmbCachTim.Location = new System.Drawing.Point(429, 17);
            this.cmbCachTim.Name = "cmbCachTim";
            this.cmbCachTim.Size = new System.Drawing.Size(244, 36);
            this.cmbCachTim.TabIndex = 4;
            // 
            // btnFindQuyen
            // 
            this.btnFindQuyen.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnFindQuyen.BackColor = System.Drawing.Color.White;
            this.btnFindQuyen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindQuyen.BackgroundImage")));
            this.btnFindQuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindQuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnFindQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.btnFindQuyen.Icon = ((System.Drawing.Image)(resources.GetObject("btnFindQuyen.Icon")));
            this.btnFindQuyen.Location = new System.Drawing.Point(0, 0);
            this.btnFindQuyen.Margin = new System.Windows.Forms.Padding(0);
            this.btnFindQuyen.Name = "btnFindQuyen";
            this.btnFindQuyen.Size = new System.Drawing.Size(397, 65);
            this.btnFindQuyen.TabIndex = 2;
            this.btnFindQuyen.text = "";
            this.btnFindQuyen.OnTextChange += new System.EventHandler(this.btnFindQuyen_OnTextChange);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQuyen);
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 593);
            this.panel2.TabIndex = 0;
            // 
            // dgvQuyen
            // 
            this.dgvQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQuyen,
            this.TenQuyen});
            this.dgvQuyen.Location = new System.Drawing.Point(0, 0);
            this.dgvQuyen.Margin = new System.Windows.Forms.Padding(0);
            this.dgvQuyen.Name = "dgvQuyen";
            this.dgvQuyen.RowHeadersWidth = 62;
            this.dgvQuyen.Size = new System.Drawing.Size(1075, 593);
            this.dgvQuyen.TabIndex = 2;
            this.dgvQuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuyen_CellClick);
            this.dgvQuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuyen_CellContentClick);
            // 
            // MaQuyen
            // 
            this.MaQuyen.DataPropertyName = "MaQuyen";
            this.MaQuyen.HeaderText = "Mã Quyền";
            this.MaQuyen.MinimumWidth = 8;
            this.MaQuyen.Name = "MaQuyen";
            this.MaQuyen.Width = 400;
            // 
            // TenQuyen
            // 
            this.TenQuyen.DataPropertyName = "TenQuyen";
            this.TenQuyen.HeaderText = "Tên Quyền";
            this.TenQuyen.MinimumWidth = 8;
            this.TenQuyen.Name = "TenQuyen";
            this.TenQuyen.Width = 400;
            // 
            // btnAddQuyen
            // 
            this.btnAddQuyen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddQuyen.AutoSize = true;
            this.btnAddQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddQuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddQuyen.BorderRadius = 7;
            this.btnAddQuyen.ButtonText = " Thêm mới";
            this.btnAddQuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuyen.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuyen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddQuyen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddQuyen.Iconimage")));
            this.btnAddQuyen.Iconimage_right = null;
            this.btnAddQuyen.Iconimage_right_Selected = null;
            this.btnAddQuyen.Iconimage_Selected = null;
            this.btnAddQuyen.IconMarginLeft = 0;
            this.btnAddQuyen.IconMarginRight = 0;
            this.btnAddQuyen.IconRightVisible = true;
            this.btnAddQuyen.IconRightZoom = 0D;
            this.btnAddQuyen.IconVisible = true;
            this.btnAddQuyen.IconZoom = 40D;
            this.btnAddQuyen.IsTab = true;
            this.btnAddQuyen.Location = new System.Drawing.Point(312, 32);
            this.btnAddQuyen.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddQuyen.Name = "btnAddQuyen";
            this.btnAddQuyen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddQuyen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddQuyen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddQuyen.selected = false;
            this.btnAddQuyen.Size = new System.Drawing.Size(150, 63);
            this.btnAddQuyen.TabIndex = 16;
            this.btnAddQuyen.Text = " Thêm mới";
            this.btnAddQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddQuyen.Textcolor = System.Drawing.Color.White;
            this.btnAddQuyen.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddQuyen.Click += new System.EventHandler(this.btnAddQuyen_Click);
            // 
            // btnChonchucnang
            // 
            this.btnChonchucnang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnChonchucnang.AutoSize = true;
            this.btnChonchucnang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnChonchucnang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChonchucnang.BorderRadius = 7;
            this.btnChonchucnang.ButtonText = "Chọn Chức Năng";
            this.btnChonchucnang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonchucnang.DisabledColor = System.Drawing.Color.Gray;
            this.btnChonchucnang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonchucnang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChonchucnang.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChonchucnang.Iconimage")));
            this.btnChonchucnang.Iconimage_right = null;
            this.btnChonchucnang.Iconimage_right_Selected = null;
            this.btnChonchucnang.Iconimage_Selected = null;
            this.btnChonchucnang.IconMarginLeft = 0;
            this.btnChonchucnang.IconMarginRight = 0;
            this.btnChonchucnang.IconRightVisible = true;
            this.btnChonchucnang.IconRightZoom = 0D;
            this.btnChonchucnang.IconVisible = true;
            this.btnChonchucnang.IconZoom = 40D;
            this.btnChonchucnang.IsTab = true;
            this.btnChonchucnang.Location = new System.Drawing.Point(475, 31);
            this.btnChonchucnang.Margin = new System.Windows.Forms.Padding(0);
            this.btnChonchucnang.Name = "btnChonchucnang";
            this.btnChonchucnang.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnChonchucnang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnChonchucnang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChonchucnang.selected = false;
            this.btnChonchucnang.Size = new System.Drawing.Size(197, 63);
            this.btnChonchucnang.TabIndex = 17;
            this.btnChonchucnang.Text = "Chọn Chức Năng";
            this.btnChonchucnang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonchucnang.Textcolor = System.Drawing.Color.White;
            this.btnChonchucnang.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonchucnang.Click += new System.EventHandler(this.btnChonchucnang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "QUẢN LÝ QUYỀN";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(689, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 64);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1209, 854);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChonchucnang);
            this.Controls.Add(this.btnAddQuyen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmQuyen_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbCachTim;
        private Bunifu.Framework.UI.BunifuTextbox btnFindQuyen;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddQuyen;
        private Bunifu.Framework.UI.BunifuFlatButton btnChonchucnang;
        private System.Windows.Forms.DataGridView dgvQuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuyen;
    }
}