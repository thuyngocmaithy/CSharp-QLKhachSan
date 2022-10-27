namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    partial class frmPhongChoDon
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
            this.pnlPhongChoDon = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.donPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPhongChoDon
            // 
            this.pnlPhongChoDon.AutoScroll = true;
            this.pnlPhongChoDon.BackColor = System.Drawing.Color.Transparent;
            this.pnlPhongChoDon.Location = new System.Drawing.Point(0, 0);
            this.pnlPhongChoDon.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPhongChoDon.Name = "pnlPhongChoDon";
            this.pnlPhongChoDon.Size = new System.Drawing.Size(900, 450);
            this.pnlPhongChoDon.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donPhongToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 69);
            // 
            // donPhongToolStripMenuItem
            // 
            this.donPhongToolStripMenuItem.Name = "donPhongToolStripMenuItem";
            this.donPhongToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.donPhongToolStripMenuItem.Text = "Dọn phòng";
            this.donPhongToolStripMenuItem.Click += new System.EventHandler(this.donPhongToolStripMenuItem_Click);
            // 
            // frmPhongChoDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPhongChoDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 450);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "frmPhongChoDon";
            this.Load += new System.EventHandler(this.frmPhongChoDon_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlPhongChoDon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donPhongToolStripMenuItem;
    }
}