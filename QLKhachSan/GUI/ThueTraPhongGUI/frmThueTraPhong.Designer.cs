using QLKhachSan.GUI.DatPhongGUI;

namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    partial class frmThueTraPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThueTraPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlThueTraPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPhongCanDon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPhongCho = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPhongDangThue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLichSu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbSapXep = new System.Windows.Forms.ComboBox();
            this.btnTangGiam = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THUÊ TRẢ PHÒNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlThueTraPhong);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(45, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 729);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlThueTraPhong
            // 
            this.pnlThueTraPhong.Location = new System.Drawing.Point(0, 83);
            this.pnlThueTraPhong.Margin = new System.Windows.Forms.Padding(0);
            this.pnlThueTraPhong.MinimumSize = new System.Drawing.Size(920, 450);
            this.pnlThueTraPhong.Name = "pnlThueTraPhong";
            this.pnlThueTraPhong.Size = new System.Drawing.Size(1118, 646);
            this.pnlThueTraPhong.TabIndex = 7;
            this.pnlThueTraPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThueTraPhong_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPhongCanDon);
            this.panel2.Controls.Add(this.btnPhongCho);
            this.panel2.Controls.Add(this.btnPhongDangThue);
            this.panel2.Controls.Add(this.btnLichSu);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 50);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnPhongCanDon
            // 
            this.btnPhongCanDon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(112)))), ((int)(((byte)(166)))));
            this.btnPhongCanDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnPhongCanDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhongCanDon.BorderRadius = 7;
            this.btnPhongCanDon.ButtonText = "Phòng cần dọn";
            this.btnPhongCanDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhongCanDon.DisabledColor = System.Drawing.Color.Gray;
            this.btnPhongCanDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongCanDon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPhongCanDon.Iconimage = null;
            this.btnPhongCanDon.Iconimage_right = null;
            this.btnPhongCanDon.Iconimage_right_Selected = null;
            this.btnPhongCanDon.Iconimage_Selected = null;
            this.btnPhongCanDon.IconMarginLeft = 0;
            this.btnPhongCanDon.IconMarginRight = 0;
            this.btnPhongCanDon.IconRightVisible = true;
            this.btnPhongCanDon.IconRightZoom = 0D;
            this.btnPhongCanDon.IconVisible = true;
            this.btnPhongCanDon.IconZoom = 40D;
            this.btnPhongCanDon.IsTab = true;
            this.btnPhongCanDon.Location = new System.Drawing.Point(568, 0);
            this.btnPhongCanDon.Margin = new System.Windows.Forms.Padding(0);
            this.btnPhongCanDon.Name = "btnPhongCanDon";
            this.btnPhongCanDon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnPhongCanDon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnPhongCanDon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPhongCanDon.selected = false;
            this.btnPhongCanDon.Size = new System.Drawing.Size(260, 50);
            this.btnPhongCanDon.TabIndex = 13;
            this.btnPhongCanDon.Text = "Phòng cần dọn";
            this.btnPhongCanDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhongCanDon.Textcolor = System.Drawing.Color.White;
            this.btnPhongCanDon.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPhongCanDon.Click += new System.EventHandler(this.btnPhongCanDon_Click);
            // 
            // btnPhongCho
            // 
            this.btnPhongCho.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(112)))), ((int)(((byte)(166)))));
            this.btnPhongCho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnPhongCho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhongCho.BorderRadius = 7;
            this.btnPhongCho.ButtonText = "Phòng chờ";
            this.btnPhongCho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhongCho.DisabledColor = System.Drawing.Color.Gray;
            this.btnPhongCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongCho.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPhongCho.Iconimage = null;
            this.btnPhongCho.Iconimage_right = null;
            this.btnPhongCho.Iconimage_right_Selected = null;
            this.btnPhongCho.Iconimage_Selected = null;
            this.btnPhongCho.IconMarginLeft = 0;
            this.btnPhongCho.IconMarginRight = 0;
            this.btnPhongCho.IconRightVisible = true;
            this.btnPhongCho.IconRightZoom = 0D;
            this.btnPhongCho.IconVisible = true;
            this.btnPhongCho.IconZoom = 40D;
            this.btnPhongCho.IsTab = true;
            this.btnPhongCho.Location = new System.Drawing.Point(0, 0);
            this.btnPhongCho.Margin = new System.Windows.Forms.Padding(0);
            this.btnPhongCho.Name = "btnPhongCho";
            this.btnPhongCho.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnPhongCho.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnPhongCho.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPhongCho.selected = false;
            this.btnPhongCho.Size = new System.Drawing.Size(260, 50);
            this.btnPhongCho.TabIndex = 12;
            this.btnPhongCho.Text = "Phòng chờ";
            this.btnPhongCho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhongCho.Textcolor = System.Drawing.Color.White;
            this.btnPhongCho.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPhongCho.Click += new System.EventHandler(this.btnPhongCho_Click);
            // 
            // btnPhongDangThue
            // 
            this.btnPhongDangThue.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(112)))), ((int)(((byte)(166)))));
            this.btnPhongDangThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnPhongDangThue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhongDangThue.BorderRadius = 7;
            this.btnPhongDangThue.ButtonText = "Phòng đang thuê";
            this.btnPhongDangThue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhongDangThue.DisabledColor = System.Drawing.Color.Gray;
            this.btnPhongDangThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongDangThue.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPhongDangThue.Iconimage = null;
            this.btnPhongDangThue.Iconimage_right = null;
            this.btnPhongDangThue.Iconimage_right_Selected = null;
            this.btnPhongDangThue.Iconimage_Selected = null;
            this.btnPhongDangThue.IconMarginLeft = 0;
            this.btnPhongDangThue.IconMarginRight = 0;
            this.btnPhongDangThue.IconRightVisible = true;
            this.btnPhongDangThue.IconRightZoom = 0D;
            this.btnPhongDangThue.IconVisible = true;
            this.btnPhongDangThue.IconZoom = 40D;
            this.btnPhongDangThue.IsTab = true;
            this.btnPhongDangThue.Location = new System.Drawing.Point(283, 0);
            this.btnPhongDangThue.Margin = new System.Windows.Forms.Padding(0);
            this.btnPhongDangThue.Name = "btnPhongDangThue";
            this.btnPhongDangThue.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnPhongDangThue.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnPhongDangThue.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPhongDangThue.selected = false;
            this.btnPhongDangThue.Size = new System.Drawing.Size(260, 50);
            this.btnPhongDangThue.TabIndex = 10;
            this.btnPhongDangThue.Text = "Phòng đang thuê";
            this.btnPhongDangThue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhongDangThue.Textcolor = System.Drawing.Color.White;
            this.btnPhongDangThue.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPhongDangThue.Click += new System.EventHandler(this.btnPhongDangThue_Click);
            // 
            // btnLichSu
            // 
            this.btnLichSu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(112)))), ((int)(((byte)(166)))));
            this.btnLichSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnLichSu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLichSu.BorderRadius = 7;
            this.btnLichSu.ButtonText = "Lịch sử";
            this.btnLichSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichSu.DisabledColor = System.Drawing.Color.Gray;
            this.btnLichSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLichSu.Iconimage = null;
            this.btnLichSu.Iconimage_right = null;
            this.btnLichSu.Iconimage_right_Selected = null;
            this.btnLichSu.Iconimage_Selected = null;
            this.btnLichSu.IconMarginLeft = 0;
            this.btnLichSu.IconMarginRight = 0;
            this.btnLichSu.IconRightVisible = true;
            this.btnLichSu.IconRightZoom = 0D;
            this.btnLichSu.IconVisible = true;
            this.btnLichSu.IconZoom = 40D;
            this.btnLichSu.IsTab = true;
            this.btnLichSu.Location = new System.Drawing.Point(851, 0);
            this.btnLichSu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnLichSu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnLichSu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLichSu.selected = false;
            this.btnLichSu.Size = new System.Drawing.Size(260, 50);
            this.btnLichSu.TabIndex = 9;
            this.btnLichSu.Text = "Lịch sử";
            this.btnLichSu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLichSu.Textcolor = System.Drawing.Color.White;
            this.btnLichSu.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // cmbSapXep
            // 
            this.cmbSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSapXep.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSapXep.FormattingEnabled = true;
            this.cmbSapXep.Items.AddRange(new object[] {
            "Xếp theo tên",
            "Xếp theo độ ưu tiên"});
            this.cmbSapXep.Location = new System.Drawing.Point(343, 33);
            this.cmbSapXep.MinimumSize = new System.Drawing.Size(236, 0);
            this.cmbSapXep.Name = "cmbSapXep";
            this.cmbSapXep.Size = new System.Drawing.Size(236, 36);
            this.cmbSapXep.TabIndex = 6;
            this.cmbSapXep.SelectedIndexChanged += new System.EventHandler(this.cmbSapXep_SelectedIndexChanged);
            // 
            // btnTangGiam
            // 
            this.btnTangGiam.Image = ((System.Drawing.Image)(resources.GetObject("btnTangGiam.Image")));
            this.btnTangGiam.Location = new System.Drawing.Point(297, 33);
            this.btnTangGiam.Name = "btnTangGiam";
            this.btnTangGiam.Size = new System.Drawing.Size(40, 36);
            this.btnTangGiam.TabIndex = 7;
            this.btnTangGiam.UseVisualStyleBackColor = true;
            this.btnTangGiam.Click += new System.EventHandler(this.btnTangGiam_Click);
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.DarkGray;
            this.txtFind.Location = new System.Drawing.Point(597, 30);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(566, 39);
            this.txtFind.TabIndex = 8;
            this.txtFind.Text = "Tìm kiếm";
            this.txtFind.Click += new System.EventHandler(this.txtFind_Click);
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // frmThueTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 860);
            this.ControlBox = false;
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnTangGiam);
            this.Controls.Add(this.cmbSapXep);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1215, 860);
            this.Name = "frmThueTraPhong";
            this.Load += new System.EventHandler(this.frmThueTraPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlThueTraPhong;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnLichSu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSapXep;
        private System.Windows.Forms.Button btnTangGiam;
        private Bunifu.Framework.UI.BunifuFlatButton btnPhongDangThue;
        private System.Windows.Forms.TextBox txtFind;
        private Bunifu.Framework.UI.BunifuFlatButton btnPhongCanDon;
        private Bunifu.Framework.UI.BunifuFlatButton btnPhongCho;
    }
}