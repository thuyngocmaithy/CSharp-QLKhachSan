using System;

namespace QLKhachSan.GUI.QLHeThongGUI.ThongKeGUI
{
    partial class frmThongKe
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
            this.pnlThongKe = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThongKeDoanhThu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThongKeLoiNhuan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlThongKe);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(49, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 722);
            this.panel1.TabIndex = 10;
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.Location = new System.Drawing.Point(0, 65);
            this.pnlThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(1117, 657);
            this.pnlThongKe.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThongKeDoanhThu);
            this.panel2.Controls.Add(this.btnThongKeLoiNhuan);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 50);
            this.panel2.TabIndex = 6;
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(112)))), ((int)(((byte)(166)))));
            this.btnThongKeDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnThongKeDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKeDoanhThu.BorderRadius = 7;
            this.btnThongKeDoanhThu.ButtonText = "THỐNG KÊ DOANH THU";
            this.btnThongKeDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeDoanhThu.DisabledColor = System.Drawing.Color.Gray;
            this.btnThongKeDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeDoanhThu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThongKeDoanhThu.Iconimage = null;
            this.btnThongKeDoanhThu.Iconimage_right = null;
            this.btnThongKeDoanhThu.Iconimage_right_Selected = null;
            this.btnThongKeDoanhThu.Iconimage_Selected = null;
            this.btnThongKeDoanhThu.IconMarginLeft = 0;
            this.btnThongKeDoanhThu.IconMarginRight = 0;
            this.btnThongKeDoanhThu.IconRightVisible = true;
            this.btnThongKeDoanhThu.IconRightZoom = 0D;
            this.btnThongKeDoanhThu.IconVisible = true;
            this.btnThongKeDoanhThu.IconZoom = 40D;
            this.btnThongKeDoanhThu.IsTab = true;
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(83, 0);
            this.btnThongKeDoanhThu.Margin = new System.Windows.Forms.Padding(0);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnThongKeDoanhThu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThongKeDoanhThu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThongKeDoanhThu.selected = false;
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(470, 50);
            this.btnThongKeDoanhThu.TabIndex = 12;
            this.btnThongKeDoanhThu.Text = "THỐNG KÊ DOANH THU";
            this.btnThongKeDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThongKeDoanhThu.Textcolor = System.Drawing.Color.White;
            this.btnThongKeDoanhThu.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKeDoanhThu.Click += new System.EventHandler(this.btnThongKeDoanhThu_Click);
            // 
            // btnThongKeLoiNhuan
            // 
            this.btnThongKeLoiNhuan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(112)))), ((int)(((byte)(166)))));
            this.btnThongKeLoiNhuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnThongKeLoiNhuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKeLoiNhuan.BorderRadius = 7;
            this.btnThongKeLoiNhuan.ButtonText = "THỐNG KÊ LỢI NHUẬN";
            this.btnThongKeLoiNhuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeLoiNhuan.DisabledColor = System.Drawing.Color.Gray;
            this.btnThongKeLoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeLoiNhuan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThongKeLoiNhuan.Iconimage = null;
            this.btnThongKeLoiNhuan.Iconimage_right = null;
            this.btnThongKeLoiNhuan.Iconimage_right_Selected = null;
            this.btnThongKeLoiNhuan.Iconimage_Selected = null;
            this.btnThongKeLoiNhuan.IconMarginLeft = 0;
            this.btnThongKeLoiNhuan.IconMarginRight = 0;
            this.btnThongKeLoiNhuan.IconRightVisible = true;
            this.btnThongKeLoiNhuan.IconRightZoom = 0D;
            this.btnThongKeLoiNhuan.IconVisible = true;
            this.btnThongKeLoiNhuan.IconZoom = 40D;
            this.btnThongKeLoiNhuan.IsTab = true;
            this.btnThongKeLoiNhuan.Location = new System.Drawing.Point(594, 0);
            this.btnThongKeLoiNhuan.Margin = new System.Windows.Forms.Padding(0);
            this.btnThongKeLoiNhuan.Name = "btnThongKeLoiNhuan";
            this.btnThongKeLoiNhuan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(160)))));
            this.btnThongKeLoiNhuan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThongKeLoiNhuan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThongKeLoiNhuan.selected = false;
            this.btnThongKeLoiNhuan.Size = new System.Drawing.Size(470, 50);
            this.btnThongKeLoiNhuan.TabIndex = 10;
            this.btnThongKeLoiNhuan.Text = "THỐNG KÊ LỢI NHUẬN";
            this.btnThongKeLoiNhuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThongKeLoiNhuan.Textcolor = System.Drawing.Color.White;
            this.btnThongKeLoiNhuan.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKeLoiNhuan.Click += new System.EventHandler(this.btnThongKeLoiNhuan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "THỐNG KÊ";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 860);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1215, 860);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlThongKe;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnThongKeDoanhThu;
        private Bunifu.Framework.UI.BunifuFlatButton btnThongKeLoiNhuan;
        private System.Windows.Forms.Label label1;
    }
}