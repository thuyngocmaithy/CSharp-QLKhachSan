namespace QLKhachSan.GUI.DatPhongGUI
{
    partial class frmCardDatPhong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardDatPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStt = new System.Windows.Forms.TextBox();
            this.lblOption = new System.Windows.Forms.Label();
            this.lblHoTen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTrangThai = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTime = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblSoLuongPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblPhongSo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblPhone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậnPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblStt);
            this.panel1.Controls.Add(this.lblOption);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(430, 50);
            this.panel1.MinimumSize = new System.Drawing.Size(430, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 50);
            this.panel1.TabIndex = 0;
            // 
            // lblStt
            // 
            this.lblStt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblStt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStt.Location = new System.Drawing.Point(3, 5);
            this.lblStt.MinimumSize = new System.Drawing.Size(70, 40);
            this.lblStt.Name = "lblStt";
            this.lblStt.Size = new System.Drawing.Size(70, 37);
            this.lblStt.TabIndex = 3;
            this.lblStt.Text = "#1";
            this.lblStt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOption.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblOption.Image = ((System.Drawing.Image)(resources.GetObject("lblOption.Image")));
            this.lblOption.Location = new System.Drawing.Point(378, 0);
            this.lblOption.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(50, 50);
            this.lblOption.TabIndex = 2;
            this.lblOption.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.Activecolor = System.Drawing.Color.Empty;
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHoTen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblHoTen.BorderRadius = 0;
            this.lblHoTen.ButtonText = "    TNMT";
            this.lblHoTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHoTen.DisabledColor = System.Drawing.Color.Gray;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Iconcolor = System.Drawing.Color.Transparent;
            this.lblHoTen.Iconimage = ((System.Drawing.Image)(resources.GetObject("lblHoTen.Iconimage")));
            this.lblHoTen.Iconimage_right = null;
            this.lblHoTen.Iconimage_right_Selected = null;
            this.lblHoTen.Iconimage_Selected = null;
            this.lblHoTen.IconMarginLeft = 0;
            this.lblHoTen.IconMarginRight = 0;
            this.lblHoTen.IconRightVisible = true;
            this.lblHoTen.IconRightZoom = 0D;
            this.lblHoTen.IconVisible = true;
            this.lblHoTen.IconZoom = 45D;
            this.lblHoTen.IsTab = true;
            this.lblHoTen.Location = new System.Drawing.Point(-1, 53);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(0);
            this.lblHoTen.MinimumSize = new System.Drawing.Size(400, 50);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHoTen.OnHovercolor = System.Drawing.Color.Empty;
            this.lblHoTen.OnHoverTextColor = System.Drawing.Color.Empty;
            this.lblHoTen.selected = false;
            this.lblHoTen.Size = new System.Drawing.Size(400, 63);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "    TNMT";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHoTen.Textcolor = System.Drawing.Color.Black;
            this.lblHoTen.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Activecolor = System.Drawing.Color.Empty;
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTrangThai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblTrangThai.BorderRadius = 0;
            this.lblTrangThai.ButtonText = "    Chưa nhận phòng";
            this.lblTrangThai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTrangThai.DisabledColor = System.Drawing.Color.Gray;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Iconcolor = System.Drawing.Color.Transparent;
            this.lblTrangThai.Iconimage = ((System.Drawing.Image)(resources.GetObject("lblTrangThai.Iconimage")));
            this.lblTrangThai.Iconimage_right = null;
            this.lblTrangThai.Iconimage_right_Selected = null;
            this.lblTrangThai.Iconimage_Selected = null;
            this.lblTrangThai.IconMarginLeft = 0;
            this.lblTrangThai.IconMarginRight = 0;
            this.lblTrangThai.IconRightVisible = true;
            this.lblTrangThai.IconRightZoom = 0D;
            this.lblTrangThai.IconVisible = true;
            this.lblTrangThai.IconZoom = 45D;
            this.lblTrangThai.IsTab = true;
            this.lblTrangThai.Location = new System.Drawing.Point(0, 100);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(0);
            this.lblTrangThai.MinimumSize = new System.Drawing.Size(400, 50);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTrangThai.OnHovercolor = System.Drawing.Color.Empty;
            this.lblTrangThai.OnHoverTextColor = System.Drawing.Color.Empty;
            this.lblTrangThai.selected = false;
            this.lblTrangThai.Size = new System.Drawing.Size(400, 63);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = "    Chưa nhận phòng";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTrangThai.Textcolor = System.Drawing.Color.Black;
            this.lblTrangThai.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // lblTime
            // 
            this.lblTime.Activecolor = System.Drawing.Color.Empty;
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblTime.BorderRadius = 0;
            this.lblTime.ButtonText = "    1/10/2022";
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTime.DisabledColor = System.Drawing.Color.Gray;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Iconcolor = System.Drawing.Color.Transparent;
            this.lblTime.Iconimage = ((System.Drawing.Image)(resources.GetObject("lblTime.Iconimage")));
            this.lblTime.Iconimage_right = null;
            this.lblTime.Iconimage_right_Selected = null;
            this.lblTime.Iconimage_Selected = null;
            this.lblTime.IconMarginLeft = 0;
            this.lblTime.IconMarginRight = 0;
            this.lblTime.IconRightVisible = true;
            this.lblTime.IconRightZoom = 0D;
            this.lblTime.IconVisible = true;
            this.lblTime.IconZoom = 45D;
            this.lblTime.IsTab = true;
            this.lblTime.Location = new System.Drawing.Point(-1, 145);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.MinimumSize = new System.Drawing.Size(400, 50);
            this.lblTime.Name = "lblTime";
            this.lblTime.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTime.OnHovercolor = System.Drawing.Color.Empty;
            this.lblTime.OnHoverTextColor = System.Drawing.Color.Empty;
            this.lblTime.selected = false;
            this.lblTime.Size = new System.Drawing.Size(441, 63);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "    1/10/2022";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTime.Textcolor = System.Drawing.Color.Black;
            this.lblTime.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // lblSoLuongPhong
            // 
            this.lblSoLuongPhong.Activecolor = System.Drawing.Color.Empty;
            this.lblSoLuongPhong.AutoSize = true;
            this.lblSoLuongPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoLuongPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblSoLuongPhong.BorderRadius = 0;
            this.lblSoLuongPhong.ButtonText = "    1";
            this.lblSoLuongPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSoLuongPhong.DisabledColor = System.Drawing.Color.Gray;
            this.lblSoLuongPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongPhong.Iconcolor = System.Drawing.Color.Transparent;
            this.lblSoLuongPhong.Iconimage = ((System.Drawing.Image)(resources.GetObject("lblSoLuongPhong.Iconimage")));
            this.lblSoLuongPhong.Iconimage_right = null;
            this.lblSoLuongPhong.Iconimage_right_Selected = null;
            this.lblSoLuongPhong.Iconimage_Selected = null;
            this.lblSoLuongPhong.IconMarginLeft = 0;
            this.lblSoLuongPhong.IconMarginRight = 0;
            this.lblSoLuongPhong.IconRightVisible = true;
            this.lblSoLuongPhong.IconRightZoom = 0D;
            this.lblSoLuongPhong.IconVisible = true;
            this.lblSoLuongPhong.IconZoom = 45D;
            this.lblSoLuongPhong.IsTab = true;
            this.lblSoLuongPhong.Location = new System.Drawing.Point(0, 190);
            this.lblSoLuongPhong.Margin = new System.Windows.Forms.Padding(0);
            this.lblSoLuongPhong.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblSoLuongPhong.Name = "lblSoLuongPhong";
            this.lblSoLuongPhong.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoLuongPhong.OnHovercolor = System.Drawing.Color.Empty;
            this.lblSoLuongPhong.OnHoverTextColor = System.Drawing.Color.Empty;
            this.lblSoLuongPhong.selected = false;
            this.lblSoLuongPhong.Size = new System.Drawing.Size(200, 63);
            this.lblSoLuongPhong.TabIndex = 6;
            this.lblSoLuongPhong.Text = "    1";
            this.lblSoLuongPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSoLuongPhong.Textcolor = System.Drawing.Color.Black;
            this.lblSoLuongPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // lblPhongSo
            // 
            this.lblPhongSo.Activecolor = System.Drawing.Color.Empty;
            this.lblPhongSo.AutoSize = true;
            this.lblPhongSo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPhongSo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblPhongSo.BorderRadius = 0;
            this.lblPhongSo.ButtonText = "    1";
            this.lblPhongSo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPhongSo.DisabledColor = System.Drawing.Color.Gray;
            this.lblPhongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongSo.Iconcolor = System.Drawing.Color.Transparent;
            this.lblPhongSo.Iconimage = ((System.Drawing.Image)(resources.GetObject("lblPhongSo.Iconimage")));
            this.lblPhongSo.Iconimage_right = null;
            this.lblPhongSo.Iconimage_right_Selected = null;
            this.lblPhongSo.Iconimage_Selected = null;
            this.lblPhongSo.IconMarginLeft = 0;
            this.lblPhongSo.IconMarginRight = 0;
            this.lblPhongSo.IconRightVisible = true;
            this.lblPhongSo.IconRightZoom = 0D;
            this.lblPhongSo.IconVisible = true;
            this.lblPhongSo.IconZoom = 45D;
            this.lblPhongSo.IsTab = true;
            this.lblPhongSo.Location = new System.Drawing.Point(0, 237);
            this.lblPhongSo.Margin = new System.Windows.Forms.Padding(0);
            this.lblPhongSo.MinimumSize = new System.Drawing.Size(400, 50);
            this.lblPhongSo.Name = "lblPhongSo";
            this.lblPhongSo.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPhongSo.OnHovercolor = System.Drawing.Color.Empty;
            this.lblPhongSo.OnHoverTextColor = System.Drawing.Color.Empty;
            this.lblPhongSo.selected = false;
            this.lblPhongSo.Size = new System.Drawing.Size(400, 63);
            this.lblPhongSo.TabIndex = 7;
            this.lblPhongSo.Text = "    1";
            this.lblPhongSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhongSo.Textcolor = System.Drawing.Color.Black;
            this.lblPhongSo.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // lblPhone
            // 
            this.lblPhone.Activecolor = System.Drawing.Color.Empty;
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblPhone.BorderRadius = 0;
            this.lblPhone.ButtonText = "    0900900900";
            this.lblPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPhone.DisabledColor = System.Drawing.Color.Gray;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Iconcolor = System.Drawing.Color.Transparent;
            this.lblPhone.Iconimage = ((System.Drawing.Image)(resources.GetObject("lblPhone.Iconimage")));
            this.lblPhone.Iconimage_right = null;
            this.lblPhone.Iconimage_right_Selected = null;
            this.lblPhone.Iconimage_Selected = null;
            this.lblPhone.IconMarginLeft = 0;
            this.lblPhone.IconMarginRight = 0;
            this.lblPhone.IconRightVisible = true;
            this.lblPhone.IconRightZoom = 0D;
            this.lblPhone.IconVisible = true;
            this.lblPhone.IconZoom = 45D;
            this.lblPhone.IsTab = true;
            this.lblPhone.Location = new System.Drawing.Point(213, 190);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(0);
            this.lblPhone.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPhone.OnHovercolor = System.Drawing.Color.Empty;
            this.lblPhone.OnHoverTextColor = System.Drawing.Color.Empty;
            this.lblPhone.selected = false;
            this.lblPhone.Size = new System.Drawing.Size(219, 63);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "    0900900900";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Textcolor = System.Drawing.Color.Black;
            this.lblPhone.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaToolStripMenuItem,
            this.nhậnPhòngToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 100);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            this.chỉnhSửaToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaToolStripMenuItem_Click);
            // 
            // nhậnPhòngToolStripMenuItem
            // 
            this.nhậnPhòngToolStripMenuItem.Name = "nhậnPhòngToolStripMenuItem";
            this.nhậnPhòngToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.nhậnPhòngToolStripMenuItem.Text = "Nhận phòng";
            this.nhậnPhòngToolStripMenuItem.Click += new System.EventHandler(this.nhậnPhòngToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // frmCardDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 300);
            this.ControlBox = false;
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblPhongSo);
            this.Controls.Add(this.lblSoLuongPhong);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(430, 300);
            this.MinimumSize = new System.Drawing.Size(430, 300);
            this.Name = "frmCardDatPhong";
            this.Load += new System.EventHandler(this.frmCardDatPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lblStt;
        private System.Windows.Forms.Label lblOption;
        private Bunifu.Framework.UI.BunifuFlatButton lblHoTen;
        private Bunifu.Framework.UI.BunifuFlatButton lblTrangThai;
        private Bunifu.Framework.UI.BunifuFlatButton lblTime;
        private Bunifu.Framework.UI.BunifuFlatButton lblSoLuongPhong;
        private Bunifu.Framework.UI.BunifuFlatButton lblPhongSo;
        private Bunifu.Framework.UI.BunifuFlatButton lblPhone;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậnPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}