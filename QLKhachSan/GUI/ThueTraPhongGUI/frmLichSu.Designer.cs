namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    partial class frmLichSu
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
            this.pnlLichSu = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChinhSuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InHoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLichSu
            // 
            this.pnlLichSu.AutoScroll = true;
            this.pnlLichSu.BackColor = System.Drawing.Color.Transparent;
            this.pnlLichSu.Location = new System.Drawing.Point(0, 0);
            this.pnlLichSu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLichSu.Name = "pnlLichSu";
            this.pnlLichSu.Size = new System.Drawing.Size(1100, 650);
            this.pnlLichSu.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChinhSuaToolStripMenuItem,
            this.InHoaDonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 68);
            // 
            // ChinhSuaToolStripMenuItem
            // 
            this.ChinhSuaToolStripMenuItem.Name = "ChinhSuaToolStripMenuItem";
            this.ChinhSuaToolStripMenuItem.Size = new System.Drawing.Size(171, 32);
            this.ChinhSuaToolStripMenuItem.Text = "Chỉnh sửa";
            this.ChinhSuaToolStripMenuItem.Click += new System.EventHandler(this.ChinhSuaToolStripMenuItem_Click);
            // 
            // InHoaDonToolStripMenuItem
            // 
            this.InHoaDonToolStripMenuItem.Name = "InHoaDonToolStripMenuItem";
            this.InHoaDonToolStripMenuItem.Size = new System.Drawing.Size(171, 32);
            this.InHoaDonToolStripMenuItem.Text = "In hóa đơn";
            this.InHoaDonToolStripMenuItem.Click += new System.EventHandler(this.InHoaDonToolStripMenuItem_Click);
            // 
            // frmLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLichSu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "frmLichSu";
            this.Load += new System.EventHandler(this.dialogLichSu_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlLichSu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ChinhSuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InHoaDonToolStripMenuItem;
    }
}