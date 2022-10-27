namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    partial class frmPhongDangThue
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
            this.pnlPhongDangThue = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yêuCầuDọnPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPhongDangThue
            // 
            this.pnlPhongDangThue.AutoScroll = true;
            this.pnlPhongDangThue.BackColor = System.Drawing.Color.Transparent;
            this.pnlPhongDangThue.Location = new System.Drawing.Point(0, 0);
            this.pnlPhongDangThue.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPhongDangThue.Name = "pnlPhongDangThue";
            this.pnlPhongDangThue.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlPhongDangThue.Size = new System.Drawing.Size(900, 450);
            this.pnlPhongDangThue.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.traPhongToolStripMenuItem,
            this.yêuCầuDọnPhòngToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 165);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.editToolStripMenuItem.Text = "Chỉnh sửa";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // traPhongToolStripMenuItem
            // 
            this.traPhongToolStripMenuItem.Name = "traPhongToolStripMenuItem";
            this.traPhongToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.traPhongToolStripMenuItem.Text = "Trả phòng";
            this.traPhongToolStripMenuItem.Click += new System.EventHandler(this.traPhongToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.deleteToolStripMenuItem.Text = "Xóa";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // yêuCầuDọnPhòngToolStripMenuItem
            // 
            this.yêuCầuDọnPhòngToolStripMenuItem.Name = "yêuCầuDọnPhòngToolStripMenuItem";
            this.yêuCầuDọnPhòngToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.yêuCầuDọnPhòngToolStripMenuItem.Text = "Yêu cầu dọn phòng";
            this.yêuCầuDọnPhòngToolStripMenuItem.Click += new System.EventHandler(this.yêuCầuDọnPhòngToolStripMenuItem_Click);
            // 
            // frmPhongDangThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPhongDangThue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 450);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "frmPhongDangThue";
            this.Load += new System.EventHandler(this.frmPhongDangThue_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel pnlPhongDangThue;
        private System.Windows.Forms.ToolStripMenuItem traPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yêuCầuDọnPhòngToolStripMenuItem;
    }
}