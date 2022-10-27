using QLKhachSan.GUI.DatPhongGUI;

namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    partial class dialogDsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogDsMenu));
            this.menuMenu = new System.Windows.Forms.MenuStrip();
            this.tấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuChon = new System.Windows.Forms.Button();
            this.menuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMenu
            // 
            this.menuMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tấtCảToolStripMenuItem});
            this.menuMenu.Location = new System.Drawing.Point(0, 0);
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(794, 33);
            this.menuMenu.TabIndex = 0;
            this.menuMenu.Text = "menuStrip1";
            // 
            // tấtCảToolStripMenuItem
            // 
            this.tấtCảToolStripMenuItem.Name = "tấtCảToolStripMenuItem";
            this.tấtCảToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.tấtCảToolStripMenuItem.Text = "Tất cả";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 51);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(794, 397);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnMenuChon
            // 
            this.btnMenuChon.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMenuChon.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuChon.Image")));
            this.btnMenuChon.Location = new System.Drawing.Point(748, 0);
            this.btnMenuChon.Name = "btnMenuChon";
            this.btnMenuChon.Size = new System.Drawing.Size(46, 37);
            this.btnMenuChon.TabIndex = 0;
            this.btnMenuChon.UseVisualStyleBackColor = true;
            this.btnMenuChon.Click += new System.EventHandler(this.btnMenuChon_Click);
            // 
            // dialogDsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 449);
            this.ControlBox = false;
            this.Controls.Add(this.btnMenuChon);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.menuMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "dialogDsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dialogDsMenu_Load);
            this.menuMenu.ResumeLayout(false);
            this.menuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlMenu;
        private System.Windows.Forms.MenuStrip menuMenu;
        private System.Windows.Forms.ToolStripMenuItem tấtCảToolStripMenuItem;
        private System.Windows.Forms.Button btnMenuChon;
    }
}