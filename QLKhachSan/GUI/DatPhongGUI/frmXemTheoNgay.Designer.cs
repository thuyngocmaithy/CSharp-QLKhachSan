namespace QLKhachSan.GUI.DatPhongGUI
{
    partial class frmXemTheoNgay
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
            this.pnlFormDatPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.datePickerTuNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.SuspendLayout();
            // 
            // pnlFormDatPhong
            // 
            this.pnlFormDatPhong.AutoScroll = true;
            this.pnlFormDatPhong.Location = new System.Drawing.Point(3, 68);
            this.pnlFormDatPhong.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFormDatPhong.Name = "pnlFormDatPhong";
            this.pnlFormDatPhong.Size = new System.Drawing.Size(1072, 543);
            this.pnlFormDatPhong.TabIndex = 8;
            // 
            // datePickerTuNgay
            // 
            this.datePickerTuNgay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.datePickerTuNgay.BorderRadius = 10;
            this.datePickerTuNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerTuNgay.ForeColor = System.Drawing.Color.Black;
            this.datePickerTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerTuNgay.FormatCustom = "dd/MM/yyyy";
            this.datePickerTuNgay.Location = new System.Drawing.Point(13, 9);
            this.datePickerTuNgay.Margin = new System.Windows.Forms.Padding(4, 10, 4, 5);
            this.datePickerTuNgay.Name = "datePickerTuNgay";
            this.datePickerTuNgay.Size = new System.Drawing.Size(316, 45);
            this.datePickerTuNgay.TabIndex = 9;
            this.datePickerTuNgay.Value = new System.DateTime(2022, 10, 19, 0, 0, 0, 0);
            this.datePickerTuNgay.onValueChanged += new System.EventHandler(this.datePickerTuNgay_onValueChanged);
            // 
            // frmXemTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 620);
            this.ControlBox = false;
            this.Controls.Add(this.datePickerTuNgay);
            this.Controls.Add(this.pnlFormDatPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1084, 620);
            this.MinimumSize = new System.Drawing.Size(1084, 620);
            this.Name = "frmXemTheoNgay";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlFormDatPhong;
        private Bunifu.Framework.UI.BunifuDatepicker datePickerTuNgay;
    }
}