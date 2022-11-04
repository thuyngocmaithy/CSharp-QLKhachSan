namespace QLKhachSan.GUI.TaiKhoanGUI.QuyenGUI
{
    partial class dialogSuaQuyen
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSuaTenQuyen = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSuaQuyen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(103, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "SỬA QUYỀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Quyền";
            // 
            // txtSuaTenQuyen
            // 
            this.txtSuaTenQuyen.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSuaTenQuyen.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.txtSuaTenQuyen.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSuaTenQuyen.BorderThickness = 3;
            this.txtSuaTenQuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuaTenQuyen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSuaTenQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSuaTenQuyen.isPassword = false;
            this.txtSuaTenQuyen.Location = new System.Drawing.Point(146, 123);
            this.txtSuaTenQuyen.Margin = new System.Windows.Forms.Padding(6);
            this.txtSuaTenQuyen.Name = "txtSuaTenQuyen";
            this.txtSuaTenQuyen.Size = new System.Drawing.Size(225, 47);
            this.txtSuaTenQuyen.TabIndex = 7;
            this.txtSuaTenQuyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSuaQuyen
            // 
            this.btnSuaQuyen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnSuaQuyen.AutoSize = true;
            this.btnSuaQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnSuaQuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaQuyen.BorderRadius = 7;
            this.btnSuaQuyen.ButtonText = "SỬA";
            this.btnSuaQuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaQuyen.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuaQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaQuyen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuaQuyen.Iconimage = null;
            this.btnSuaQuyen.Iconimage_right = null;
            this.btnSuaQuyen.Iconimage_right_Selected = null;
            this.btnSuaQuyen.Iconimage_Selected = null;
            this.btnSuaQuyen.IconMarginLeft = 0;
            this.btnSuaQuyen.IconMarginRight = 0;
            this.btnSuaQuyen.IconRightVisible = true;
            this.btnSuaQuyen.IconRightZoom = 0D;
            this.btnSuaQuyen.IconVisible = true;
            this.btnSuaQuyen.IconZoom = 50D;
            this.btnSuaQuyen.IsTab = true;
            this.btnSuaQuyen.Location = new System.Drawing.Point(69, 225);
            this.btnSuaQuyen.Margin = new System.Windows.Forms.Padding(8);
            this.btnSuaQuyen.Name = "btnSuaQuyen";
            this.btnSuaQuyen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnSuaQuyen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnSuaQuyen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuaQuyen.selected = false;
            this.btnSuaQuyen.Size = new System.Drawing.Size(113, 63);
            this.btnSuaQuyen.TabIndex = 11;
            this.btnSuaQuyen.Text = "SỬA";
            this.btnSuaQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuaQuyen.Textcolor = System.Drawing.Color.White;
            this.btnSuaQuyen.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaQuyen.Click += new System.EventHandler(this.btnSuaQuyen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(197, 225);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 63);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dialogSuaQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(398, 335);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSuaQuyen);
            this.Controls.Add(this.txtSuaTenQuyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "dialogSuaQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dialogSuaQuyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSuaTenQuyen;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuaQuyen;
        private System.Windows.Forms.Button btnClose;
    }
}