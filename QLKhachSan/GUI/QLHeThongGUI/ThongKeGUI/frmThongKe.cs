using Guna.UI2.WinForms;
using QLKhachSan.BUS;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;


namespace QLKhachSan.GUI.QLHeThongGUI.ThongKeGUI
{
    public partial class frmThongKe : Form
    {


        HoaDonBUS hoaDonBUS = new HoaDonBUS();


        public frmThongKe()
        {
            InitializeComponent();
        }


        // ========================================= Tính tổng Doanh Thu ======================================================
        private DataTable hoaDonAll()
        {
            return hoaDonBUS.GetHoaDon();
        }
        private DataTable hoaDonThang(string thang, string nam)
        {
            return hoaDonBUS.GetHoaDon(
                "SELECT * " +
                "FROM HoaDon " +
                "WHERE MONTH(ThoiGianKetThuc) = '" + thang + "' " +
                "AND YEAR(ThoiGianKetThuc) = '" + nam + "'");
        }
        private int tinhTongTien(DataTable dtHoaDon)
        {
            int thugiamtrukhac = 0, giam = 0, tienphong = 0, tienmenu = 0, tienphuthu = 0, tientratruoc = 0, tongtien = 0, allTongTien = 0;

            foreach (DataRow dt in dtHoaDon.Rows)
            {
                if (dt["TienPhong"].ToString() != "")
                {
                    tienphong = int.Parse(dt["TienPhong"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                }

                if (dt["TienMenu"].ToString() != "")
                {
                    tienmenu = int.Parse(dt["TienMenu"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                }

                if (dt["PhuThu"].ToString() != "")
                {
                    tienphuthu = int.Parse(dt["PhuThu"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                }

                if (dt["ThuGiamTruKhac"].ToString() != "")
                {
                    giam = int.Parse(dt["ThuGiamTruKhac"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                }

                if (dt["TraTruoc"].ToString() != "")
                {
                    tientratruoc = int.Parse(dt["TraTruoc"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                }

                tongtien = tienphong + tienmenu + tienphuthu + thugiamtrukhac - tientratruoc;
                allTongTien += tongtien;

            }
            return allTongTien;
        }
        private int tinhDichVu(DataTable dtHoaDon)
        {
            int tienmenu = 0;
            int allTienMenu = 0;
            foreach (DataRow dt in dtHoaDon.Rows)
            {


                if (dt["TienMenu"].ToString() != "")
                {
                    tienmenu = int.Parse(dt["TienMenu"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                }

                allTienMenu += tienmenu;

            }
            return tienmenu;
        }
        private DataTable getDoanhThuAll()
        {

            DataTable dtDoanhThu = new DataTable("Doanh Thu");
            dtDoanhThu.Columns.Add("Doanh Thu");
            dtDoanhThu.Columns.Add("Dịch Vụ");
            dtDoanhThu.Columns.Add("Tháng");
            foreach (DataRow dt in hoaDonBUS.GetHoaDon(
                "SELECT SUM(CAST( REPLACE(TienPhong,',','') AS INT)+CAST( REPLACE(TienMenu,',','') AS INT) " +
                "+CAST( REPLACE(ThuGiamTruKhac,',','') AS INT) +CAST( REPLACE(PhuThu,',','') AS INT) " +
                "-CAST( REPLACE(TraTruoc,',','') AS INT)) AS 'Doanh Thu', MONTH(ThoiGianKetThuc) AS 'Tháng', " +
                "SUM(CAST(REPLACE(TienMenu,',','') AS int)) AS 'Dịch Vụ' " +
                "FROM HoaDon " +
                "GROUP BY MONTH(ThoiGianKetThuc)").Rows)
            {

                dtDoanhThu.Rows.Add(dt["Doanh Thu"].ToString(), dt["Dịch Vụ"].ToString(), dt["Tháng"].ToString());
            }
            return dtDoanhThu;
        }
        private DataTable getDoanhThuThang(string thang, string nam)
        {
            DataTable dtDoanhThu = new DataTable("Doanh Thu");
            dtDoanhThu.Columns.Add("Doanh Thu");
            dtDoanhThu.Columns.Add("Dịch Vụ");
            dtDoanhThu.Columns.Add("Tháng");
            foreach (DataRow dt in hoaDonBUS.GetHoaDon(
                "SELECT SUM(CAST( REPLACE(TienPhong,',','') AS INT) + CAST( REPLACE(TienMenu,',','') AS INT) " +
                "+ CAST(REPLACE(ThuGiamTruKhac, ',', '') AS INT) + CAST(REPLACE(PhuThu, ',', '') AS INT) " +
                "- CAST(REPLACE(TraTruoc, ',', '') AS INT)) AS 'Doanh Thu', " +
                "SUM(CAST(REPLACE(TienMenu, ',', '') AS int)) AS 'Dịch Vụ',  " +
                "CONCAT(MONTH(ThoiGianKetThuc), '/', YEAR(ThoiGianKetThuc)) AS 'Thời gian' " +
                "FROM HoaDon " +
                "WHERE MONTH(ThoiGianKetThuc)= '" + thang + "' " +
                "AND YEAR(ThoiGianKetThuc) = '" + nam + "' " +
                "GROUP BY MONTH(ThoiGianKetThuc), YEAR(ThoiGianKetThuc)").Rows)
            {
                dtDoanhThu.Rows.Add(dt["Doanh Thu"].ToString(), dt["Dịch Vụ"].ToString(), dt["Thời gian"].ToString());
            }
            return dtDoanhThu;
        }


        public void AddCommaToTextBox(Guna2TextBox guna2TextBox)
        {
            string value = guna2TextBox.Text.Replace(",", "")
                .Replace("đ", "").Replace(".", "").TrimStart('0');
            decimal ul;
            if (decimal.TryParse(value, out ul))
            {
                guna2TextBox.Text = string.Format("{0:#,###}", ul);
                var length = guna2TextBox.Text.Length;
                guna2TextBox.SelectionStart = length;
            }
        }
        private void setLabelAll()
        {
            gunatxtDT.Text = tinhTongTien(hoaDonAll()).ToString();
            AddCommaToTextBox(gunatxtDT);
            gunatxtDT.Text += " VNĐ";


            lblDV.Text = tinhDichVu(hoaDonAll()).ToString();
            AddCommaToTextBox(lblDV);
            lblDV.Text += " VNĐ";

            foreach (DataRow dt in hoaDonBUS.GetHoaDon(
                "SELECT COUNT(*) AS 'SL' " +
                "FROM HoaDon").Rows)
            {
                lblPhong.Text = dt["SL"].ToString() + " Phòng";
            }
        }
        private void setLabelThang(string thang, string nam)
        {
            gunatxtDT.Text = tinhTongTien(hoaDonThang(thang, nam)).ToString();
            AddCommaToTextBox(gunatxtDT);
            gunatxtDT.Text += " VNĐ";


            lblDV.Text = tinhDichVu(hoaDonThang(thang, nam)).ToString();
            AddCommaToTextBox(lblDV);
            lblDV.Text += " VNĐ";

            foreach (DataRow dt in hoaDonBUS.GetHoaDon(
                "SELECT COUNT(*) AS 'SL' " +
                "FROM HoaDon " +
                "WHERE MONTH(ThoiGianKetThuc) = '" + thang + "' " +
                "AND YEAR(ThoiGianKetThuc) = '" + nam + "'").Rows)
            {

            }
        }
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            setLabelAll();
            /*int thugiamtrukhac = 0, giam = 0, tienphong = 0, tienmenu = 0, tienphuthu = 0, tientratruoc = 0, tongtien = 0, allTongTien = 0;
            int thang = 0;
            DataTable dtDoanhThu = new DataTable();
            foreach (DataRow dt in hoaDonBUS.GetHoaDon().Rows)
            {
                if (dt["TienPhong"].ToString() != "")
                {
                    tienphong = int.Parse(dt["TienPhong"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                }

                if (dt["TienMenu"].ToString() != "")
                {
                    tienmenu = int.Parse(dt["TienMenu"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                }

                if (dt["PhuThu"].ToString() != "")
                {
                    tienphuthu = int.Parse(dt["PhuThu"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                }

                if (dt["ThuGiamTruKhac"].ToString() != "")
                {
                    giam = int.Parse(dt["ThuGiamTruKhac"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                }

                if (dt["TraTruoc"].ToString() != "")
                {
                    tientratruoc = int.Parse(dt["TraTruoc"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                }

                if (hoaDonBUS.GetHoaDon("SELECT DISTINCT MONTH(ThoiGianKetThuc) AS \"Tháng\" FROM HoaDon GROUP BY MONTH(ThoiGianKetThuc)").ToString() != "")
                {
                    thang = int.Parse(hoaDonBUS.GetHoaDon("SELECT DISTINCT MONTH(ThoiGianKetThuc) AS \"Tháng\" FROM HoaDon GROUP BY MONTH(ThoiGianKetThuc)").ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                }

                tongtien = tienphong + tienmenu + tienphuthu + thugiamtrukhac - tientratruoc;
                *//*                thang = int.Parse(hoaDonBUS.GetHoaDon("SELECT DISTINCT MONTH(ThoiGianKetThuc) AS \"Tháng\" FROM HoaDon GROUP BY MONTH(ThoiGianKetThuc)").ToString());
                *//*
                dtDoanhThu.Columns.Add("Doanh Thu");
                dtDoanhThu.Columns.Add("Tháng");
                dtDoanhThu.Rows.Add(tongtien, thang);
                *//*dtDoanhThu.Rows.Add(thang);*//*

            }*/


            //Notes: TongTien = phong+menu+phuthu+thugiamtrukhac-tratruoc

            /* string tongDT = "";
             foreach (DataRow dt in hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\" FROM HoaDon").Rows)
             {
                 tongDT = dt["Doanh Thu"].ToString();
                 txtDT.Text = tongDT + "  VNĐ";
             }*/



            //========================================= LINE CHART: Biểu đồ đường ===================================================

            /*LineChart.DataSource = dtDoanhThu;*/
            LineChart.DataSource = getDoanhThuAll();


            /*LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) " +
                "                                    AS \"Dịch Vụ\", MONTH(ThoiGianKetThuc) AS \"Tháng\"\r\nFROM HoaDon\r\n" +
            "                                    GROUP BY MONTH(ThoiGianKetThuc)");*/

            LineChart.Series["ChartDT"].IsValueShownAsLabel = true;
            LineChart.Series["ChartDV"].IsValueShownAsLabel = true;

            LineChart.ChartAreas["ChartArea"].AxisY.Title = "Doanh Thu";
            LineChart.ChartAreas["ChartArea"].AxisX.Title = "Tháng";

            LineChart.ChartAreas["ChartArea"].AxisX.Maximum = 12;
            LineChart.ChartAreas["ChartArea"].AxisX.Minimum = 0;

            LineChart.Series["ChartDT"].XValueMember = "Tháng";
            LineChart.Series["ChartDT"].YValueMembers = "Doanh Thu";

            LineChart.Series["ChartDV"].XValueMember = "Tháng";
            LineChart.Series["ChartDV"].YValueMembers = "Dịch Vụ";



            //========================================= PIE CHART: Biểu đồ tròn ======================================================

            /*PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) " +
                                                      "AS \"Dịch Vụ\", MONTH(ThoiGianKetThuc) AS \"Tháng\"\r\nFROM HoaDon\r\nGROUP BY MONTH(ThoiGianKetThuc)");
            */
            PieChart.DataSource = getDoanhThuAll();
            PieChart.Series["ChartDT"].XValueMember = "Tháng";          //Title
            PieChart.Series["ChartDT"].YValueMembers = "Doanh Thu";     //Biểu đồ


            //Hiển thị % biểu đồ
            PieChart.Series["ChartDT"].Label = "#PERCENT{0.00 %}";
            PieChart.Series["ChartDT"].LegendText = "#VALX";




            /*private void btnReset_Click(object sender, EventArgs e)
            {
                if (cmbThang.Text == "Tháng 1")
                {
                    LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '1'%" + btnReset + "%' ");

                    PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '1'%" + btnReset + "%' ");
                }
                if (cmbThang.Text == "Tháng 2")
                {
                    LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '2'%" + btnReset + "%' ");

                    PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '2'%" + btnReset + "%' ");
                }
                if (cmbThang.Text == "Tháng 3")
                {
                    LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '3'%" + btnReset + "%' ");

                    PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '3'%" + btnReset + "%' ");
                }
                if (cmbThang.Text == "Tháng 4")
                {
                    LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '4'%" + btnReset + "%' ");

                    PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '4'%" + btnReset + "%' ");
                }
                if (cmbThang.Text == "Tháng 5")
                {
                    LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '5'%" + btnReset + "%' ");

                    PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '5'%" + btnReset + "%' ");
                }
                if (cmbThang.Text == "Tháng 6")
                {
                    LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '6'%" + btnReset + "%' ");

                    PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '6'%" + btnReset + "%' ");
                }
                if (cmbThang.Text == "Tháng 7")
                {
                    LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '7'%" + btnReset + "%' ");

                    PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '7'%" + btnReset + "%' ");
                }
                if (cmbThang.Text == "Tháng 8")
                {
                    LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '8'%" + btnReset + "%' ");

                    PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '8'%" + btnReset + "%' ");
                }
                if (cmbThang.Text == "Tháng 9")
                {
                    LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '9'%" + btnReset + "%' ");

                    PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '3'%" + btnReset + "%' ");
                }
                if (cmbThang.Text == "Tháng 10")
                {
                    LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '10'%" + btnReset + "%' ");

                    PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '10'%" + btnReset + "%' ");
                }
                if (cmbThang.Text == "Tháng 11")
                {
                    LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '11'%" + btnReset + "%' ");

                    PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '11'%" + btnReset + "%' ");
                }
                if (cmbThang.Text == "Tháng 12")
                {
                    LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '12'%" + btnReset + "%' ");

                    PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) AS \"Dịch Vụ\", " +
                        "                                        (MONTH(ThoiGianKetThuc)) AS MONTH\r\nFROM HoaDon\r\nWHERE MONTH(ThoiGianKetThuc) = '12'%" + btnReset + "%' ");
                }
                if (cmbThang.Text == "Chọn tháng")
                {
                    MessageBox.Show("Bạn chưa chọn tháng");
                }
            }*/
        }

        private void btnThongKeAll_Click(object sender, EventArgs e)
        {
            setLabelAll();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string thoigian = dateThongKe.Value.ToString("MM/yyyy");
            setLabelThang(thoigian.Split('/')[0], thoigian.Split('/')[1]);
        }
    }
}