using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.QLMenuGUI
{
    partial class dialogSuaMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.richTextBoxUutien = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.richTextBoxGiaban = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.richTextBoxGianhap = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.richTextBoxLoaiMenu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.richTextBoxTenMenu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.richTextBoxUutien);
            this.panel1.Controls.Add(this.richTextBoxGiaban);
            this.panel1.Controls.Add(this.richTextBoxGianhap);
            this.panel1.Controls.Add(this.richTextBoxLoaiMenu);
            this.panel1.Controls.Add(this.richTextBoxTenMenu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(494, 609);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(255, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 63);
            this.button2.TabIndex = 29;
            this.button2.Text = "ĐÓNG";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.BorderRadius = 7;
            this.button1.ButtonText = "SỬA";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DisabledColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Iconcolor = System.Drawing.Color.Transparent;
            this.button1.Iconimage = null;
            this.button1.Iconimage_right = null;
            this.button1.Iconimage_right_Selected = null;
            this.button1.Iconimage_Selected = null;
            this.button1.IconMarginLeft = 0;
            this.button1.IconMarginRight = 0;
            this.button1.IconRightVisible = true;
            this.button1.IconRightZoom = 0D;
            this.button1.IconVisible = true;
            this.button1.IconZoom = 50D;
            this.button1.IsTab = true;
            this.button1.Location = new System.Drawing.Point(104, 519);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.button1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.button1.OnHoverTextColor = System.Drawing.Color.White;
            this.button1.selected = false;
            this.button1.Size = new System.Drawing.Size(128, 63);
            this.button1.TabIndex = 28;
            this.button1.Text = "SỬA";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Textcolor = System.Drawing.Color.White;
            this.button1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxUutien
            // 
            this.richTextBoxUutien.BorderColorFocused = System.Drawing.Color.Blue;
            this.richTextBoxUutien.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.richTextBoxUutien.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.richTextBoxUutien.BorderThickness = 3;
            this.richTextBoxUutien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxUutien.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxUutien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxUutien.isPassword = false;
            this.richTextBoxUutien.Location = new System.Drawing.Point(198, 435);
            this.richTextBoxUutien.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxUutien.Name = "richTextBoxUutien";
            this.richTextBoxUutien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBoxUutien.Size = new System.Drawing.Size(274, 44);
            this.richTextBoxUutien.TabIndex = 27;
            this.richTextBoxUutien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // richTextBoxGiaban
            // 
            this.richTextBoxGiaban.BorderColorFocused = System.Drawing.Color.Blue;
            this.richTextBoxGiaban.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.richTextBoxGiaban.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.richTextBoxGiaban.BorderThickness = 3;
            this.richTextBoxGiaban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxGiaban.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxGiaban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxGiaban.isPassword = false;
            this.richTextBoxGiaban.Location = new System.Drawing.Point(198, 349);
            this.richTextBoxGiaban.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxGiaban.Name = "richTextBoxGiaban";
            this.richTextBoxGiaban.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBoxGiaban.Size = new System.Drawing.Size(274, 44);
            this.richTextBoxGiaban.TabIndex = 26;
            this.richTextBoxGiaban.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // richTextBoxGianhap
            // 
            this.richTextBoxGianhap.BorderColorFocused = System.Drawing.Color.Blue;
            this.richTextBoxGianhap.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.richTextBoxGianhap.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.richTextBoxGianhap.BorderThickness = 3;
            this.richTextBoxGianhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxGianhap.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxGianhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxGianhap.isPassword = false;
            this.richTextBoxGianhap.Location = new System.Drawing.Point(198, 264);
            this.richTextBoxGianhap.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxGianhap.Name = "richTextBoxGianhap";
            this.richTextBoxGianhap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBoxGianhap.Size = new System.Drawing.Size(274, 44);
            this.richTextBoxGianhap.TabIndex = 25;
            this.richTextBoxGianhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // richTextBoxLoaiMenu
            // 
            this.richTextBoxLoaiMenu.BorderColorFocused = System.Drawing.Color.Blue;
            this.richTextBoxLoaiMenu.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.richTextBoxLoaiMenu.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.richTextBoxLoaiMenu.BorderThickness = 3;
            this.richTextBoxLoaiMenu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxLoaiMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLoaiMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxLoaiMenu.isPassword = false;
            this.richTextBoxLoaiMenu.Location = new System.Drawing.Point(198, 182);
            this.richTextBoxLoaiMenu.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxLoaiMenu.Name = "richTextBoxLoaiMenu";
            this.richTextBoxLoaiMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBoxLoaiMenu.Size = new System.Drawing.Size(274, 44);
            this.richTextBoxLoaiMenu.TabIndex = 24;
            this.richTextBoxLoaiMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // richTextBoxTenMenu
            // 
            this.richTextBoxTenMenu.BorderColorFocused = System.Drawing.Color.Blue;
            this.richTextBoxTenMenu.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.richTextBoxTenMenu.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.richTextBoxTenMenu.BorderThickness = 3;
            this.richTextBoxTenMenu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxTenMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTenMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxTenMenu.isPassword = false;
            this.richTextBoxTenMenu.Location = new System.Drawing.Point(198, 100);
            this.richTextBoxTenMenu.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxTenMenu.Name = "richTextBoxTenMenu";
            this.richTextBoxTenMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBoxTenMenu.Size = new System.Drawing.Size(274, 44);
            this.richTextBoxTenMenu.TabIndex = 23;
            this.richTextBoxTenMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(174, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sửa Menu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(37, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(37, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loại Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(37, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Độ ưu tiên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(37, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Menu";
            // 
            // dialogSuaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 609);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "dialogSuaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dialogSuaMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox richTextBoxUutien;
        private Bunifu.Framework.UI.BunifuMetroTextbox richTextBoxGiaban;
        private Bunifu.Framework.UI.BunifuMetroTextbox richTextBoxGianhap;
        private Bunifu.Framework.UI.BunifuMetroTextbox richTextBoxLoaiMenu;
        private Bunifu.Framework.UI.BunifuMetroTextbox richTextBoxTenMenu;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuFlatButton button1;
    }
}