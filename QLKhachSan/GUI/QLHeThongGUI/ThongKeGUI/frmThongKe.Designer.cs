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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnDoanThu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn = new System.Windows.Forms.Panel();
            this.lblDV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnThuePhong = new System.Windows.Forms.Panel();
            this.lblPhong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gunatxtDT = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnDoanThu.SuspendLayout();
            this.pn.SuspendLayout();
            this.PnThuePhong.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LineChart
            // 
            chartArea9.Name = "ChartArea";
            this.LineChart.ChartAreas.Add(chartArea9);
            this.LineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend9.Name = "Legend1";
            this.LineChart.Legends.Add(legend9);
            this.LineChart.Location = new System.Drawing.Point(3, 3);
            this.LineChart.Name = "LineChart";
            series13.ChartArea = "ChartArea";
            series13.Legend = "Legend1";
            series13.LegendText = "Doanh thu";
            series13.MarkerSize = 1;
            series13.Name = "ChartDT";
            series14.ChartArea = "ChartArea";
            series14.Legend = "Legend1";
            series14.LegendText = "Dịch vụ";
            series14.Name = "ChartDV";
            this.LineChart.Series.Add(series13);
            this.LineChart.Series.Add(series14);
            this.LineChart.Size = new System.Drawing.Size(445, 304);
            this.LineChart.TabIndex = 0;
            this.LineChart.Text = "ChartBDD";
            title9.BackColor = System.Drawing.Color.White;
            title9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title9.Name = "titleLineChart";
            title9.Text = "Biểu Đồ Doanh Thu và Dịch Vụ";
            this.LineChart.Titles.Add(title9);
            // 
            // PieChart
            // 
            chartArea10.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea10);
            this.PieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            legend10.Title = "Tháng";
            this.PieChart.Legends.Add(legend10);
            this.PieChart.Location = new System.Drawing.Point(454, 3);
            this.PieChart.Name = "PieChart";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series15.IsValueShownAsLabel = true;
            series15.Legend = "Legend1";
            series15.Name = "ChartDT";
            this.PieChart.Series.Add(series15);
            this.PieChart.Size = new System.Drawing.Size(445, 304);
            this.PieChart.TabIndex = 1;
            this.PieChart.Text = "ChartBDT";
            title10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title10.Name = "TitlePieChart";
            title10.Text = "Biểu Đồ Doanh Thu";
            this.PieChart.Titles.Add(title10);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.pnDoanThu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.PnThuePhong, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(902, 129);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // pnDoanThu
            // 
            this.pnDoanThu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnDoanThu.Controls.Add(this.gunatxtDT);
            this.pnDoanThu.Controls.Add(this.label1);
            this.pnDoanThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDoanThu.Location = new System.Drawing.Point(3, 3);
            this.pnDoanThu.Name = "pnDoanThu";
            this.pnDoanThu.Size = new System.Drawing.Size(294, 123);
            this.pnDoanThu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh Thu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pn
            // 
            this.pn.BackColor = System.Drawing.Color.DarkSalmon;
            this.pn.Controls.Add(this.lblDV);
            this.pn.Controls.Add(this.label2);
            this.pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn.Location = new System.Drawing.Point(303, 3);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(294, 123);
            this.pn.TabIndex = 1;
            // 
            // lblDV
            // 
            this.lblDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDV.Location = new System.Drawing.Point(0, 60);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(294, 29);
            this.lblDV.TabIndex = 1;
            this.lblDV.Text = "0 VND";
            this.lblDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dịch Vụ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PnThuePhong
            // 
            this.PnThuePhong.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PnThuePhong.Controls.Add(this.lblPhong);
            this.PnThuePhong.Controls.Add(this.label3);
            this.PnThuePhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnThuePhong.Location = new System.Drawing.Point(603, 3);
            this.PnThuePhong.Name = "PnThuePhong";
            this.PnThuePhong.Size = new System.Drawing.Size(296, 123);
            this.PnThuePhong.TabIndex = 2;
            // 
            // lblPhong
            // 
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(5, 60);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(294, 29);
            this.lblPhong.TabIndex = 1;
            this.lblPhong.Text = "0 Phòng";
            this.lblPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(0, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lượt Thuê Phòng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbNam
            // 
            this.cmbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNam.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Items.AddRange(new object[] {
            "Cách tìm",
            "Tháng",
            "Năm"});
            this.cmbNam.Location = new System.Drawing.Point(426, 154);
            this.cmbNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(153, 31);
            this.cmbNam.TabIndex = 34;
            // 
            // cmbThang
            // 
            this.cmbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThang.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Items.AddRange(new object[] {
            "Chọn tháng",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbThang.Location = new System.Drawing.Point(153, 154);
            this.cmbThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(153, 31);
            this.cmbThang.TabIndex = 33;
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 7;
            this.btnReset.ButtonText = "";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReset.Iconimage")));
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = true;
            this.btnReset.IconZoom = 50D;
            this.btnReset.IsTab = true;
            this.btnReset.Location = new System.Drawing.Point(653, 141);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(55, 55);
            this.btnReset.TabIndex = 37;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.LineChart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PieChart, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 218);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 310);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // gunatxtDT
            // 
            this.gunatxtDT.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.gunatxtDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunatxtDT.DefaultText = "";
            this.gunatxtDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunatxtDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunatxtDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunatxtDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunatxtDT.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.gunatxtDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunatxtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gunatxtDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunatxtDT.Location = new System.Drawing.Point(0, 60);
            this.gunatxtDT.Name = "gunatxtDT";
            this.gunatxtDT.PasswordChar = '\0';
            this.gunatxtDT.PlaceholderText = "";
            this.gunatxtDT.ReadOnly = true;
            this.gunatxtDT.SelectedText = "";
            this.gunatxtDT.Size = new System.Drawing.Size(294, 29);
            this.gunatxtDT.TabIndex = 1;
            this.gunatxtDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(902, 528);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnDoanThu.ResumeLayout(false);
            this.pn.ResumeLayout(false);
            this.PnThuePhong.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnDoanThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnThuePhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.ComboBox cmbThang;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox gunatxtDT;
    }
}