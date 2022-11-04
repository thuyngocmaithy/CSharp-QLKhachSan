namespace QLKhachSan.GUI.TaiKhoanGUI.QuyenGUI
{
    partial class dialogThemQuyen
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
            this.txtTenQuyen = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemQuyen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(102, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "THÊM QUYỀN";
            // 
            // txtTenQuyen
            // 
            this.txtTenQuyen.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTenQuyen.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtTenQuyen.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTenQuyen.BorderThickness = 3;
            this.txtTenQuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenQuyen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenQuyen.isPassword = false;
            this.txtTenQuyen.Location = new System.Drawing.Point(135, 119);
            this.txtTenQuyen.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenQuyen.Name = "txtTenQuyen";
            this.txtTenQuyen.Size = new System.Drawing.Size(248, 47);
            this.txtTenQuyen.TabIndex = 9;
            this.txtTenQuyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Quyền";
            // 
            // btnThemQuyen
            // 
            this.btnThemQuyen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemQuyen.AutoSize = true;
            this.btnThemQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemQuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemQuyen.BorderRadius = 7;
            this.btnThemQuyen.ButtonText = "THÊM";
            this.btnThemQuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemQuyen.DisabledColor = System.Drawing.Color.Gray;
            this.btnThemQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemQuyen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThemQuyen.Iconimage = null;
            this.btnThemQuyen.Iconimage_right = null;
            this.btnThemQuyen.Iconimage_right_Selected = null;
            this.btnThemQuyen.Iconimage_Selected = null;
            this.btnThemQuyen.IconMarginLeft = 0;
            this.btnThemQuyen.IconMarginRight = 0;
            this.btnThemQuyen.IconRightVisible = true;
            this.btnThemQuyen.IconRightZoom = 0D;
            this.btnThemQuyen.IconVisible = true;
            this.btnThemQuyen.IconZoom = 50D;
            this.btnThemQuyen.IsTab = true;
            this.btnThemQuyen.Location = new System.Drawing.Point(203, 239);
            this.btnThemQuyen.Margin = new System.Windows.Forms.Padding(8);
            this.btnThemQuyen.Name = "btnThemQuyen";
            this.btnThemQuyen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThemQuyen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThemQuyen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThemQuyen.selected = false;
            this.btnThemQuyen.Size = new System.Drawing.Size(113, 63);
            this.btnThemQuyen.TabIndex = 13;
            this.btnThemQuyen.Text = "THÊM";
            this.btnThemQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemQuyen.Textcolor = System.Drawing.Color.White;
            this.btnThemQuyen.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemQuyen.Click += new System.EventHandler(this.btnThemQuyen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(79, 239);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 63);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dialogThemQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(398, 335);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnThemQuyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenQuyen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "dialogThemQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTenQuyen;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnThemQuyen;
        private System.Windows.Forms.Button btnClose;
    }
}