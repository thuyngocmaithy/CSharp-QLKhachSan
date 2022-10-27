namespace QLKhachSan.GUI.DatPhongGUI
{
    partial class frmDatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDatPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDatPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXemTheoNgay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐẶT PHÒNG";
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
            this.btnAddDatPhong.Location = new System.Drawing.Point(220, 20);
            this.btnAddDatPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddDatPhong.Name = "btnAddDatPhong";
            this.btnAddDatPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddDatPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddDatPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddDatPhong.selected = false;
            this.btnAddDatPhong.Size = new System.Drawing.Size(153, 63);
            this.btnAddDatPhong.TabIndex = 2;
            this.btnAddDatPhong.Text = " Thêm mới";
            this.btnAddDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDatPhong.Textcolor = System.Drawing.Color.White;
            this.btnAddDatPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddDatPhong.Click += new System.EventHandler(this.btnAddDatPhong_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlDatPhong);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(45, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 513);
            this.panel1.TabIndex = 5;
            // 
            // pnlDatPhong
            // 
            this.pnlDatPhong.Location = new System.Drawing.Point(0, 71);
            this.pnlDatPhong.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDatPhong.MinimumSize = new System.Drawing.Size(920, 450);
            this.pnlDatPhong.Name = "pnlDatPhong";
            this.pnlDatPhong.Size = new System.Drawing.Size(920, 450);
            this.pnlDatPhong.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.btnXemTheoNgay);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 50);
            this.panel2.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(112)))), ((int)(((byte)(166)))));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.BorderRadius = 7;
            this.btnTimKiem.ButtonText = "Tìm kiếm";
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Iconimage = null;
            this.btnTimKiem.Iconimage_right = null;
            this.btnTimKiem.Iconimage_right_Selected = null;
            this.btnTimKiem.Iconimage_Selected = null;
            this.btnTimKiem.IconMarginLeft = 0;
            this.btnTimKiem.IconMarginRight = 0;
            this.btnTimKiem.IconRightVisible = true;
            this.btnTimKiem.IconRightZoom = 0D;
            this.btnTimKiem.IconVisible = true;
            this.btnTimKiem.IconZoom = 40D;
            this.btnTimKiem.IsTab = true;
            this.btnTimKiem.Location = new System.Drawing.Point(470, 0);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(112)))), ((int)(((byte)(166)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(450, 50);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXemTheoNgay
            // 
            this.btnXemTheoNgay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(112)))), ((int)(((byte)(166)))));
            this.btnXemTheoNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnXemTheoNgay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXemTheoNgay.BorderRadius = 7;
            this.btnXemTheoNgay.ButtonText = "Xem theo ngày";
            this.btnXemTheoNgay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemTheoNgay.DisabledColor = System.Drawing.Color.Gray;
            this.btnXemTheoNgay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXemTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTheoNgay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXemTheoNgay.Iconimage = null;
            this.btnXemTheoNgay.Iconimage_right = null;
            this.btnXemTheoNgay.Iconimage_right_Selected = null;
            this.btnXemTheoNgay.Iconimage_Selected = null;
            this.btnXemTheoNgay.IconMarginLeft = 0;
            this.btnXemTheoNgay.IconMarginRight = 0;
            this.btnXemTheoNgay.IconRightVisible = true;
            this.btnXemTheoNgay.IconRightZoom = 0D;
            this.btnXemTheoNgay.IconVisible = true;
            this.btnXemTheoNgay.IconZoom = 40D;
            this.btnXemTheoNgay.IsTab = true;
            this.btnXemTheoNgay.Location = new System.Drawing.Point(0, 0);
            this.btnXemTheoNgay.Margin = new System.Windows.Forms.Padding(0);
            this.btnXemTheoNgay.Name = "btnXemTheoNgay";
            this.btnXemTheoNgay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnXemTheoNgay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(112)))), ((int)(((byte)(166)))));
            this.btnXemTheoNgay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXemTheoNgay.selected = false;
            this.btnXemTheoNgay.Size = new System.Drawing.Size(450, 50);
            this.btnXemTheoNgay.TabIndex = 7;
            this.btnXemTheoNgay.Text = "Xem theo ngày";
            this.btnXemTheoNgay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemTheoNgay.Textcolor = System.Drawing.Color.White;
            this.btnXemTheoNgay.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemTheoNgay.Click += new System.EventHandler(this.btnXemTheoNgay_Click);
            // 
            // frmDatPhong
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
            this.Name = "frmDatPhong";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddDatPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnXemTheoNgay;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private System.Windows.Forms.FlowLayoutPanel pnlDatPhong;
    }
}