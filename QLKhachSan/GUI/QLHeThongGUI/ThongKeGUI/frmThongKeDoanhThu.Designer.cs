namespace QLKhachSan.GUI.QLHeThongGUI.ThongKeGUI
{
    partial class frmThongKeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnDoanThu = new System.Windows.Forms.Panel();
            this.gunatxtDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn = new System.Windows.Forms.Panel();
            this.lblDV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PnThuePhong = new System.Windows.Forms.Panel();
            this.lblPhong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThongKe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThongKeAll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dateThongKe = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
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
            chartArea1.Name = "ChartArea";
            this.LineChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.LineChart.Legends.Add(legend1);
            this.LineChart.Location = new System.Drawing.Point(3, 4);
            this.LineChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LineChart.Name = "LineChart";
            series1.ChartArea = "ChartArea";
            series1.Legend = "Legend1";
            series1.LegendText = "Doanh thu";
            series1.MarkerSize = 1;
            series1.Name = "ChartDT";
            series2.ChartArea = "ChartArea";
            series2.Legend = "Legend1";
            series2.LegendText = "Dịch vụ";
            series2.Name = "ChartDV";
            this.LineChart.Series.Add(series1);
            this.LineChart.Series.Add(series2);
            this.LineChart.Size = new System.Drawing.Size(574, 412);
            this.LineChart.TabIndex = 0;
            this.LineChart.Text = "ChartBDD";
            title1.BackColor = System.Drawing.Color.White;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title1.Name = "titleLineChart";
            title1.Text = "Biểu Đồ Doanh Thu và Dịch Vụ";
            this.LineChart.Titles.Add(title1);
            // 
            // PieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Tháng";
            this.PieChart.Legends.Add(legend2);
            this.PieChart.Location = new System.Drawing.Point(583, 4);
            this.PieChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PieChart.Name = "PieChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "ChartDT";
            this.PieChart.Series.Add(series3);
            this.PieChart.Size = new System.Drawing.Size(574, 412);
            this.PieChart.TabIndex = 1;
            this.PieChart.Text = "ChartBDT";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title2.Name = "TitlePieChart";
            title2.Text = "Biểu Đồ Doanh Thu";
            this.PieChart.Titles.Add(title2);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 153);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1160, 143);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // pnDoanThu
            // 
            this.pnDoanThu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnDoanThu.Controls.Add(this.gunatxtDT);
            this.pnDoanThu.Controls.Add(this.label1);
            this.pnDoanThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDoanThu.Location = new System.Drawing.Point(3, 4);
            this.pnDoanThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnDoanThu.Name = "pnDoanThu";
            this.pnDoanThu.Size = new System.Drawing.Size(380, 135);
            this.pnDoanThu.TabIndex = 0;
            // 
            // gunatxtDT
            // 
            this.gunatxtDT.BackColor = System.Drawing.Color.Transparent;
            this.gunatxtDT.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.gunatxtDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunatxtDT.DefaultText = "";
            this.gunatxtDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunatxtDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunatxtDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunatxtDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunatxtDT.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.gunatxtDT.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.gunatxtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gunatxtDT.ForeColor = System.Drawing.Color.Black;
            this.gunatxtDT.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.gunatxtDT.Location = new System.Drawing.Point(0, 75);
            this.gunatxtDT.Margin = new System.Windows.Forms.Padding(4);
            this.gunatxtDT.Name = "gunatxtDT";
            this.gunatxtDT.PasswordChar = '\0';
            this.gunatxtDT.PlaceholderForeColor = System.Drawing.Color.Black;
            this.gunatxtDT.PlaceholderText = "";
            this.gunatxtDT.ReadOnly = true;
            this.gunatxtDT.SelectedText = "";
            this.gunatxtDT.Size = new System.Drawing.Size(331, 36);
            this.gunatxtDT.TabIndex = 1;
            this.gunatxtDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(1, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 36);
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
            this.pn.Location = new System.Drawing.Point(389, 4);
            this.pn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(380, 135);
            this.pn.TabIndex = 1;
            // 
            // lblDV
            // 
            this.lblDV.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblDV.BorderColor = System.Drawing.Color.DarkSalmon;
            this.lblDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDV.DefaultText = "";
            this.lblDV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblDV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblDV.FillColor = System.Drawing.Color.DarkSalmon;
            this.lblDV.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.lblDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDV.ForeColor = System.Drawing.Color.Black;
            this.lblDV.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.lblDV.Location = new System.Drawing.Point(0, 75);
            this.lblDV.Margin = new System.Windows.Forms.Padding(4);
            this.lblDV.Name = "lblDV";
            this.lblDV.PasswordChar = '\0';
            this.lblDV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.lblDV.PlaceholderText = "";
            this.lblDV.ReadOnly = true;
            this.lblDV.SelectedText = "";
            this.lblDV.Size = new System.Drawing.Size(331, 36);
            this.lblDV.TabIndex = 3;
            this.lblDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(-2, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 36);
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
            this.PnThuePhong.Location = new System.Drawing.Point(775, 4);
            this.PnThuePhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnThuePhong.Name = "PnThuePhong";
            this.PnThuePhong.Size = new System.Drawing.Size(382, 135);
            this.PnThuePhong.TabIndex = 2;
            // 
            // lblPhong
            // 
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(-5, 75);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(322, 36);
            this.lblPhong.TabIndex = 1;
            this.lblPhong.Text = "0 Phòng";
            this.lblPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(0, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lượt Thuê Phòng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 300);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 420);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThongKe.AutoSize = true;
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKe.BorderRadius = 7;
            this.btnThongKe.ButtonText = "Thống kê";
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.DisabledColor = System.Drawing.Color.Gray;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.btnThongKe.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThongKe.Iconimage = null;
            this.btnThongKe.Iconimage_right = null;
            this.btnThongKe.Iconimage_right_Selected = null;
            this.btnThongKe.Iconimage_Selected = null;
            this.btnThongKe.IconMarginLeft = 0;
            this.btnThongKe.IconMarginRight = 0;
            this.btnThongKe.IconRightVisible = true;
            this.btnThongKe.IconRightZoom = 0D;
            this.btnThongKe.IconVisible = true;
            this.btnThongKe.IconZoom = 50D;
            this.btnThongKe.IsTab = true;
            this.btnThongKe.Location = new System.Drawing.Point(479, 81);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThongKe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThongKe.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThongKe.selected = false;
            this.btnThongKe.Size = new System.Drawing.Size(145, 47);
            this.btnThongKe.TabIndex = 40;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThongKe.Textcolor = System.Drawing.Color.White;
            this.btnThongKe.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThongKeAll
            // 
            this.btnThongKeAll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThongKeAll.AutoSize = true;
            this.btnThongKeAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThongKeAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKeAll.BorderRadius = 7;
            this.btnThongKeAll.ButtonText = "Thống kê tất cả";
            this.btnThongKeAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeAll.DisabledColor = System.Drawing.Color.Gray;
            this.btnThongKeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.btnThongKeAll.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThongKeAll.Iconimage = null;
            this.btnThongKeAll.Iconimage_right = null;
            this.btnThongKeAll.Iconimage_right_Selected = null;
            this.btnThongKeAll.Iconimage_Selected = null;
            this.btnThongKeAll.IconMarginLeft = 0;
            this.btnThongKeAll.IconMarginRight = 0;
            this.btnThongKeAll.IconRightVisible = true;
            this.btnThongKeAll.IconRightZoom = 0D;
            this.btnThongKeAll.IconVisible = true;
            this.btnThongKeAll.IconZoom = 50D;
            this.btnThongKeAll.IsTab = true;
            this.btnThongKeAll.Location = new System.Drawing.Point(635, 80);
            this.btnThongKeAll.Margin = new System.Windows.Forms.Padding(6);
            this.btnThongKeAll.Name = "btnThongKeAll";
            this.btnThongKeAll.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnThongKeAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnThongKeAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThongKeAll.selected = false;
            this.btnThongKeAll.Size = new System.Drawing.Size(224, 48);
            this.btnThongKeAll.TabIndex = 41;
            this.btnThongKeAll.Text = "Thống kê tất cả";
            this.btnThongKeAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThongKeAll.Textcolor = System.Drawing.Color.White;
            this.btnThongKeAll.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeAll.Click += new System.EventHandler(this.btnThongKeAll_Click);
            // 
            // dateThongKe
            // 
            this.dateThongKe.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateThongKe.CustomFormat = "MM/yyyy";
            this.dateThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dateThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateThongKe.Location = new System.Drawing.Point(271, 81);
            this.dateThongKe.MinimumSize = new System.Drawing.Size(200, 50);
            this.dateThongKe.Name = "dateThongKe";
            this.dateThongKe.ShowUpDown = true;
            this.dateThongKe.Size = new System.Drawing.Size(200, 50);
            this.dateThongKe.TabIndex = 42;
            this.dateThongKe.Value = new System.DateTime(2022, 10, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 29);
            this.label4.TabIndex = 43;
            this.label4.Text = "THỐNG KÊ DOANH THU";
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 720);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateThongKe);
            this.Controls.Add(this.btnThongKeAll);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmThongKeDoanhThu";
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

        private System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnDoanThu;
        private Guna.UI2.WinForms.Guna2TextBox gunatxtDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnThuePhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateThongKe;
        private Bunifu.Framework.UI.BunifuFlatButton btnThongKeAll;
        private Bunifu.Framework.UI.BunifuFlatButton btnThongKe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox lblDV;
        private System.Windows.Forms.Label label4;
    }
}