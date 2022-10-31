namespace QLKhachSan.GUI.QLKhoGUI.DieuChinhKho
{
    partial class dialogThemDieuChinhKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogThemDieuChinhKho));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvThemDieuChinhKho = new System.Windows.Forms.DataGridView();
            this.SLThucTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDieuChinh = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindThemDieuChinhKho = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnThemDieuChinhKho = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemDieuChinhKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvThemDieuChinhKho);
            this.panel3.Location = new System.Drawing.Point(49, 141);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 313);
            this.panel3.TabIndex = 42;
            // 
            // dgvThemDieuChinhKho
            // 
            this.dgvThemDieuChinhKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemDieuChinhKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SLThucTe});
            this.dgvThemDieuChinhKho.Location = new System.Drawing.Point(0, 3);
            this.dgvThemDieuChinhKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThemDieuChinhKho.Name = "dgvThemDieuChinhKho";
            this.dgvThemDieuChinhKho.RowHeadersWidth = 62;
            this.dgvThemDieuChinhKho.RowTemplate.Height = 28;
            this.dgvThemDieuChinhKho.Size = new System.Drawing.Size(818, 313);
            this.dgvThemDieuChinhKho.TabIndex = 0;
            // 
            // SLThucTe
            // 
            this.SLThucTe.DataPropertyName = "SLThucTe";
            this.SLThucTe.HeaderText = "Số lượng thực tế";
            this.SLThucTe.MinimumWidth = 6;
            this.SLThucTe.Name = "SLThucTe";
            this.SLThucTe.Width = 170;
            // 
            // dateDieuChinh
            // 
            this.dateDieuChinh.BackColor = System.Drawing.SystemColors.Window;
            this.dateDieuChinh.BorderRadius = 0;
            this.dateDieuChinh.ForeColor = System.Drawing.Color.Black;
            this.dateDieuChinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDieuChinh.FormatCustom = " dd/MM/yyyy HH:mm:ss";
            this.dateDieuChinh.Location = new System.Drawing.Point(188, 67);
            this.dateDieuChinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateDieuChinh.Name = "dateDieuChinh";
            this.dateDieuChinh.Size = new System.Drawing.Size(221, 51);
            this.dateDieuChinh.TabIndex = 47;
            this.dateDieuChinh.Value = new System.DateTime(2022, 10, 28, 1, 30, 16, 780);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Ngày điều chỉnh";
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Image = ((System.Drawing.Image)(resources.GetObject("lblReset.Image")));
            this.lblReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReset.Location = new System.Drawing.Point(795, 67);
            this.lblReset.MinimumSize = new System.Drawing.Size(53, 48);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(53, 48);
            this.lblReset.TabIndex = 41;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "THÊM ĐIỀU CHỈNH KHO";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(49, 141);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 313);
            this.panel1.TabIndex = 44;
            // 
            // btnFindThemDieuChinhKho
            // 
            this.btnFindThemDieuChinhKho.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnFindThemDieuChinhKho.BackColor = System.Drawing.Color.White;
            this.btnFindThemDieuChinhKho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindThemDieuChinhKho.BackgroundImage")));
            this.btnFindThemDieuChinhKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindThemDieuChinhKho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnFindThemDieuChinhKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.btnFindThemDieuChinhKho.Icon = ((System.Drawing.Image)(resources.GetObject("btnFindThemDieuChinhKho.Icon")));
            this.btnFindThemDieuChinhKho.Location = new System.Drawing.Point(447, 67);
            this.btnFindThemDieuChinhKho.Margin = new System.Windows.Forms.Padding(0);
            this.btnFindThemDieuChinhKho.Name = "btnFindThemDieuChinhKho";
            this.btnFindThemDieuChinhKho.Size = new System.Drawing.Size(292, 52);
            this.btnFindThemDieuChinhKho.TabIndex = 48;
            this.btnFindThemDieuChinhKho.text = "";
            this.btnFindThemDieuChinhKho.OnTextChange += new System.EventHandler(this.btnFindThemDieuChinhKho_OnTextChange);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(457, 467);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 55);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnThemDieuChinhKho
            // 
            this.btnThemDieuChinhKho.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThemDieuChinhKho.AutoSize = true;
            this.btnThemDieuChinhKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemDieuChinhKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemDieuChinhKho.BorderRadius = 7;
            this.btnThemDieuChinhKho.ButtonText = "THÊM";
            this.btnThemDieuChinhKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDieuChinhKho.DisabledColor = System.Drawing.Color.Gray;
            this.btnThemDieuChinhKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDieuChinhKho.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThemDieuChinhKho.Iconimage = null;
            this.btnThemDieuChinhKho.Iconimage_right = null;
            this.btnThemDieuChinhKho.Iconimage_right_Selected = null;
            this.btnThemDieuChinhKho.Iconimage_Selected = null;
            this.btnThemDieuChinhKho.IconMarginLeft = 0;
            this.btnThemDieuChinhKho.IconMarginRight = 0;
            this.btnThemDieuChinhKho.IconRightVisible = true;
            this.btnThemDieuChinhKho.IconRightZoom = 0D;
            this.btnThemDieuChinhKho.IconVisible = true;
            this.btnThemDieuChinhKho.IconZoom = 50D;
            this.btnThemDieuChinhKho.IsTab = true;
            this.btnThemDieuChinhKho.Location = new System.Drawing.Point(321, 467);
            this.btnThemDieuChinhKho.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnThemDieuChinhKho.Name = "btnThemDieuChinhKho";
            this.btnThemDieuChinhKho.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemDieuChinhKho.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThemDieuChinhKho.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThemDieuChinhKho.selected = false;
            this.btnThemDieuChinhKho.Size = new System.Drawing.Size(114, 55);
            this.btnThemDieuChinhKho.TabIndex = 50;
            this.btnThemDieuChinhKho.Text = "THÊM";
            this.btnThemDieuChinhKho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemDieuChinhKho.Textcolor = System.Drawing.Color.White;
            this.btnThemDieuChinhKho.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDieuChinhKho.Click += new System.EventHandler(this.btnThemDieuChinhKho_Click);
            // 
            // dialogThemDieuChinhKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 528);
            this.ControlBox = false;
            this.Controls.Add(this.btnThemDieuChinhKho);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFindThemDieuChinhKho);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dateDieuChinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(902, 528);
            this.Name = "dialogThemDieuChinhKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dialogThemDieuChinhKho_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemDieuChinhKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvThemDieuChinhKho;
        private Bunifu.Framework.UI.BunifuDatepicker dateDieuChinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox btnFindThemDieuChinhKho;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnThemDieuChinhKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLThucTe;
    }
}