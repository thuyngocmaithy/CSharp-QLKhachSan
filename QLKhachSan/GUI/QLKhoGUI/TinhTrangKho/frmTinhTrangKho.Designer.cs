using QLKhachSan.GUI.QLKhoGUI.PNKho;

namespace QLKhachSan.GUI.QLKhoGUI.TinhTrangKho
{
    partial class frmTinhTrangKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinhTrangKho));
            this.dgvTinhTrangKho = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFindTinhTrangKho = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangKho)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTinhTrangKho
            // 
            this.dgvTinhTrangKho.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTinhTrangKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhTrangKho.Location = new System.Drawing.Point(1, 0);
            this.dgvTinhTrangKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTinhTrangKho.Name = "dgvTinhTrangKho";
            this.dgvTinhTrangKho.RowHeadersWidth = 62;
            this.dgvTinhTrangKho.RowTemplate.Height = 28;
            this.dgvTinhTrangKho.Size = new System.Drawing.Size(1105, 586);
            this.dgvTinhTrangKho.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTinhTrangKho);
            this.panel1.Location = new System.Drawing.Point(50, 220);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 589);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "TÌNH TRẠNG KHO";
            // 
            // btnFindTinhTrangKho
            // 
            this.btnFindTinhTrangKho.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnFindTinhTrangKho.BackColor = System.Drawing.Color.White;
            this.btnFindTinhTrangKho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindTinhTrangKho.BackgroundImage")));
            this.btnFindTinhTrangKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindTinhTrangKho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnFindTinhTrangKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(152)))));
            this.btnFindTinhTrangKho.Icon = ((System.Drawing.Image)(resources.GetObject("btnFindTinhTrangKho.Icon")));
            this.btnFindTinhTrangKho.Location = new System.Drawing.Point(50, 105);
            this.btnFindTinhTrangKho.Margin = new System.Windows.Forms.Padding(0);
            this.btnFindTinhTrangKho.Name = "btnFindTinhTrangKho";
            this.btnFindTinhTrangKho.Size = new System.Drawing.Size(328, 65);
            this.btnFindTinhTrangKho.TabIndex = 13;
            this.btnFindTinhTrangKho.text = "";
            this.btnFindTinhTrangKho.OnTextChange += new System.EventHandler(this.btnFindTinhTrangKho_OnTextChange);
            // 
            // frmTinhTrangKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 860);
            this.ControlBox = false;
            this.Controls.Add(this.btnFindTinhTrangKho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1015, 660);
            this.Name = "frmTinhTrangKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTinhTrangKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangKho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvTinhTrangKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox btnFindTinhTrangKho;
    }
}