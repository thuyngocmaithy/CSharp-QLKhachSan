using QLKhachSan.GUI.QLHeThongGUI.QLPhongGUI;

namespace QLKhachSan.GUI.QLHeThongGUI.QLPhongGUI
{
    partial class frmQLPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLPhong));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCachTim = new System.Windows.Forms.ComboBox();
            this.lblReset = new System.Windows.Forms.Label();
            this.btnFindPhong = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPhong);
            this.panel3.Location = new System.Drawing.Point(50, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1103, 562);
            this.panel3.TabIndex = 8;
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 62;
            this.dgvPhong.RowTemplate.Height = 28;
            this.dgvPhong.Size = new System.Drawing.Size(1103, 565);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);
            this.dgvPhong.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCachTim);
            this.panel2.Controls.Add(this.lblReset);
            this.panel2.Controls.Add(this.btnFindPhong);
            this.panel2.Location = new System.Drawing.Point(50, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 64);
            this.panel2.TabIndex = 11;
            // 
            // cmbCachTim
            // 
            this.cmbCachTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCachTim.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCachTim.FormattingEnabled = true;
            this.cmbCachTim.Items.AddRange(new object[] {
            "Cách tìm",
            "Mã phòng",
            "Loại phòng",
            "Tình trạng",
            "Số khách tối đa",
            "Cách tính tiền",
            "Ưu tiên hiển thị"});
            this.cmbCachTim.Location = new System.Drawing.Point(438, 15);
            this.cmbCachTim.Name = "cmbCachTim";
            this.cmbCachTim.Size = new System.Drawing.Size(251, 36);
            this.cmbCachTim.TabIndex = 4;
            this.cmbCachTim.SelectedIndexChanged += new System.EventHandler(this.cmbCachTim_SelectedIndexChanged);
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Image = ((System.Drawing.Image)(resources.GetObject("lblReset.Image")));
            this.lblReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReset.Location = new System.Drawing.Point(1043, 4);
            this.lblReset.MinimumSize = new System.Drawing.Size(60, 60);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(60, 60);
            this.lblReset.TabIndex = 3;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // btnFindPhong
            // 
            this.btnFindPhong.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnFindPhong.BackColor = System.Drawing.Color.White;
            this.btnFindPhong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindPhong.BackgroundImage")));
            this.btnFindPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnFindPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.btnFindPhong.Icon = ((System.Drawing.Image)(resources.GetObject("btnFindPhong.Icon")));
            this.btnFindPhong.Location = new System.Drawing.Point(0, 0);
            this.btnFindPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btnFindPhong.Name = "btnFindPhong";
            this.btnFindPhong.Size = new System.Drawing.Size(416, 65);
            this.btnFindPhong.TabIndex = 2;
            this.btnFindPhong.text = "";
            this.btnFindPhong.OnTextChange += new System.EventHandler(this.btnFindPhong_OnTextChange);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(50, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 670);
            this.panel1.TabIndex = 10;
            // 
            // btnAddPhong
            // 
            this.btnAddPhong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddPhong.AutoSize = true;
            this.btnAddPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPhong.BorderRadius = 7;
            this.btnAddPhong.ButtonText = " Thêm mới";
            this.btnAddPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPhong.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPhong.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPhong.Iconimage")));
            this.btnAddPhong.Iconimage_right = null;
            this.btnAddPhong.Iconimage_right_Selected = null;
            this.btnAddPhong.Iconimage_Selected = null;
            this.btnAddPhong.IconMarginLeft = 0;
            this.btnAddPhong.IconMarginRight = 0;
            this.btnAddPhong.IconRightVisible = true;
            this.btnAddPhong.IconRightZoom = 0D;
            this.btnAddPhong.IconVisible = true;
            this.btnAddPhong.IconZoom = 40D;
            this.btnAddPhong.IsTab = true;
            this.btnAddPhong.Location = new System.Drawing.Point(225, 35);
            this.btnAddPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPhong.Name = "btnAddPhong";
            this.btnAddPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnAddPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnAddPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPhong.selected = false;
            this.btnAddPhong.Size = new System.Drawing.Size(153, 63);
            this.btnAddPhong.TabIndex = 9;
            this.btnAddPhong.Text = " Thêm mới";
            this.btnAddPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPhong.Textcolor = System.Drawing.Color.White;
            this.btnAddPhong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddPhong.Click += new System.EventHandler(this.btnAddDatPhong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "LOẠI PHÒNG";
            // 
            // frmQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 860);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1215, 860);
            this.Name = "frmQLPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmQLPhong_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddPhong;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvPhong;
        private Bunifu.Framework.UI.BunifuTextbox btnFindPhong;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.ComboBox cmbCachTim;
    }
}