namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    partial class frmPhongCho
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
            this.pnlPhongCho = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NhanPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YCDonPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPhongCho
            // 
            this.pnlPhongCho.AutoScroll = true;
            this.pnlPhongCho.BackColor = System.Drawing.Color.Transparent;
            this.pnlPhongCho.Location = new System.Drawing.Point(0, 0);
            this.pnlPhongCho.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPhongCho.Name = "pnlPhongCho";
            this.pnlPhongCho.Size = new System.Drawing.Size(1100, 650);
            this.pnlPhongCho.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NhanPhongToolStripMenuItem,
            this.YCDonPhongToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(239, 68);
            // 
            // NhanPhongToolStripMenuItem
            // 
            this.NhanPhongToolStripMenuItem.Name = "NhanPhongToolStripMenuItem";
            this.NhanPhongToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.NhanPhongToolStripMenuItem.Text = "Nhận phòng";
            this.NhanPhongToolStripMenuItem.Click += new System.EventHandler(this.NhanPhongToolStripMenuItem_Click);
            // 
            // YCDonPhongToolStripMenuItem
            // 
            this.YCDonPhongToolStripMenuItem.Name = "YCDonPhongToolStripMenuItem";
            this.YCDonPhongToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.YCDonPhongToolStripMenuItem.Text = "Yêu cầu dọn phòng";
            this.YCDonPhongToolStripMenuItem.Click += new System.EventHandler(this.YCDonPhongToolStripMenuItem_Click);
            // 
            // frmPhongCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPhongCho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "frmPhongCho";
            this.Load += new System.EventHandler(this.frmPhongCho_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnlPhongCho;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NhanPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem YCDonPhongToolStripMenuItem;
    }
}