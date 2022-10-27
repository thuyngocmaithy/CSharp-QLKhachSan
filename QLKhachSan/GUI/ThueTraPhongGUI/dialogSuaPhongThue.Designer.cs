using QLKhachSan.GUI.DatPhongGUI;

namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    partial class dialogSuaPhongThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogSuaPhongThue));
            this.lblThemSua = new System.Windows.Forms.Label();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateNhanPhong = new Bunifu.Framework.UI.BunifuDatepicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.timeNhanPhong = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTienTraTruoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThemMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.TenMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThemSua
            // 
            this.lblThemSua.AutoSize = true;
            this.lblThemSua.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemSua.ForeColor = System.Drawing.Color.Black;
            this.lblThemSua.Location = new System.Drawing.Point(274, 23);
            this.lblThemSua.Name = "lblThemSua";
            this.lblThemSua.Size = new System.Drawing.Size(168, 38);
            this.lblThemSua.TabIndex = 0;
            this.lblThemSua.Text = "CHỈNH SỬA";
            // 
            // btnLuu
            // 
            this.btnLuu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.BorderRadius = 7;
            this.btnLuu.ButtonText = "LƯU";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.DisabledColor = System.Drawing.Color.Gray;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLuu.Iconimage = null;
            this.btnLuu.Iconimage_right = null;
            this.btnLuu.Iconimage_right_Selected = null;
            this.btnLuu.Iconimage_Selected = null;
            this.btnLuu.IconMarginLeft = 0;
            this.btnLuu.IconMarginRight = 0;
            this.btnLuu.IconRightVisible = true;
            this.btnLuu.IconRightZoom = 0D;
            this.btnLuu.IconVisible = true;
            this.btnLuu.IconZoom = 50D;
            this.btnLuu.IsTab = true;
            this.btnLuu.Location = new System.Drawing.Point(209, 592);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(8);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnLuu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(128, 63);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Textcolor = System.Drawing.Color.White;
            this.btnLuu.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(341, 592);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 63);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.dateNhanPhong);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(17, 83);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(310, 80);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày nhận phòng";
            // 
            // dateNhanPhong
            // 
            this.dateNhanPhong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dateNhanPhong.BorderRadius = 10;
            this.dateNhanPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNhanPhong.ForeColor = System.Drawing.Color.Black;
            this.dateNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNhanPhong.FormatCustom = "dd/MM/yyyy";
            this.dateNhanPhong.Location = new System.Drawing.Point(4, 33);
            this.dateNhanPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateNhanPhong.Name = "dateNhanPhong";
            this.dateNhanPhong.Size = new System.Drawing.Size(300, 40);
            this.dateNhanPhong.TabIndex = 1;
            this.dateNhanPhong.Value = new System.DateTime(2022, 10, 19, 0, 0, 0, 0);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.bunifuDatepicker1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(259, 80);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày nhận phòng";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuDatepicker1.BorderRadius = 10;
            this.bunifuDatepicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDatepicker1.FormatCustom = "dd/MM/yyyy";
            this.bunifuDatepicker1.Location = new System.Drawing.Point(4, 33);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(255, 40);
            this.bunifuDatepicker1.TabIndex = 1;
            this.bunifuDatepicker1.Value = new System.DateTime(2022, 10, 19, 0, 0, 0, 0);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.timeNhanPhong);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(372, 83);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(310, 80);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giờ nhận phòng";
            // 
            // timeNhanPhong
            // 
            this.timeNhanPhong.CustomFormat = "HH:mm";
            this.timeNhanPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeNhanPhong.Location = new System.Drawing.Point(3, 36);
            this.timeNhanPhong.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.timeNhanPhong.Name = "timeNhanPhong";
            this.timeNhanPhong.ShowUpDown = true;
            this.timeNhanPhong.Size = new System.Drawing.Size(300, 39);
            this.timeNhanPhong.TabIndex = 22;
            this.timeNhanPhong.Value = new System.DateTime(2022, 10, 23, 1, 0, 1, 0);
            this.timeNhanPhong.ValueChanged += new System.EventHandler(this.timeNhanPhong_ValueChanged);
            this.timeNhanPhong.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeNhanPhong_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tiền trả trước";
            // 
            // txtTienTraTruoc
            // 
            this.txtTienTraTruoc.BackColor = System.Drawing.Color.Transparent;
            this.txtTienTraTruoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtTienTraTruoc.BorderRadius = 5;
            this.txtTienTraTruoc.BorderThickness = 3;
            this.txtTienTraTruoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienTraTruoc.DefaultText = "";
            this.txtTienTraTruoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTienTraTruoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTienTraTruoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienTraTruoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienTraTruoc.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTienTraTruoc.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtTienTraTruoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTienTraTruoc.ForeColor = System.Drawing.Color.Black;
            this.txtTienTraTruoc.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtTienTraTruoc.Location = new System.Drawing.Point(209, 193);
            this.txtTienTraTruoc.MaxLength = 11;
            this.txtTienTraTruoc.Name = "txtTienTraTruoc";
            this.txtTienTraTruoc.PasswordChar = '\0';
            this.txtTienTraTruoc.PlaceholderText = "";
            this.txtTienTraTruoc.SelectedText = "";
            this.txtTienTraTruoc.Size = new System.Drawing.Size(475, 44);
            this.txtTienTraTruoc.TabIndex = 15;
            this.txtTienTraTruoc.TextChanged += new System.EventHandler(this.txtTienTraTruoc_TextChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.Transparent;
            this.txtGhiChu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtGhiChu.BorderRadius = 5;
            this.txtGhiChu.BorderThickness = 3;
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.DefaultText = "";
            this.txtGhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGhiChu.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.ForeColor = System.Drawing.Color.Black;
            this.txtGhiChu.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtGhiChu.Location = new System.Drawing.Point(209, 267);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.PlaceholderText = "";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(475, 44);
            this.txtGhiChu.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 28);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ghi chú";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 28);
            this.label11.TabIndex = 20;
            this.label11.Text = "Menu sử dụng";
            // 
            // btnThemMenu
            // 
            this.btnThemMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemMenu.AutoSize = true;
            this.btnThemMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemMenu.BorderRadius = 7;
            this.btnThemMenu.ButtonText = " Thêm menu";
            this.btnThemMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnThemMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThemMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThemMenu.Iconimage")));
            this.btnThemMenu.Iconimage_right = null;
            this.btnThemMenu.Iconimage_right_Selected = null;
            this.btnThemMenu.Iconimage_Selected = null;
            this.btnThemMenu.IconMarginLeft = 0;
            this.btnThemMenu.IconMarginRight = 0;
            this.btnThemMenu.IconRightVisible = true;
            this.btnThemMenu.IconRightZoom = 0D;
            this.btnThemMenu.IconVisible = true;
            this.btnThemMenu.IconZoom = 40D;
            this.btnThemMenu.IsTab = true;
            this.btnThemMenu.Location = new System.Drawing.Point(209, 344);
            this.btnThemMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemMenu.Name = "btnThemMenu";
            this.btnThemMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThemMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThemMenu.selected = false;
            this.btnThemMenu.Size = new System.Drawing.Size(159, 50);
            this.btnThemMenu.TabIndex = 21;
            this.btnThemMenu.Text = " Thêm menu";
            this.btnThemMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMenu.Textcolor = System.Drawing.Color.White;
            this.btnThemMenu.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemMenu.Click += new System.EventHandler(this.btnThemMenu_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 0;
            // 
            // dgvMenu
            // 
            this.dgvMenu.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMenu,
            this.SL,
            this.ThanhTien});
            this.dgvMenu.Location = new System.Drawing.Point(16, 422);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 62;
            this.dgvMenu.RowTemplate.Height = 28;
            this.dgvMenu.Size = new System.Drawing.Size(666, 150);
            this.dgvMenu.TabIndex = 0;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // TenMenu
            // 
            this.TenMenu.DataPropertyName = "TenMenu";
            this.TenMenu.HeaderText = "Tên menu";
            this.TenMenu.MinimumWidth = 8;
            this.TenMenu.Name = "TenMenu";
            this.TenMenu.ReadOnly = true;
            this.TenMenu.Width = 180;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 8;
            this.SL.Name = "SL";
            this.SL.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 170;
            // 
            // dialogSuaPhongThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 683);
            this.ControlBox = false;
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.btnThemMenu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTienTraTruoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.lblThemSua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "dialogSuaPhongThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dialogSuaPhongThue_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnThemMenu;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtTienTraTruoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker dateNhanPhong;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private System.Windows.Forms.Label lblThemSua;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DateTimePicker timeNhanPhong;
    }
}