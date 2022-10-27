using Guna.UI2.WinForms;
using QLKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLKhachSan.GUI.QLHeThongGUI.ThongKeGUI
{
    public partial class frmThongKe : Form
    {

        ThongKeBUS thongKeBUS = new ThongKeBUS();
        HoaDonBUS hoaDonBUS = new HoaDonBUS();


        public frmThongKe()
        {
            InitializeComponent();
        }

        private void lblReset_Click(object sender, EventArgs e)
        {

        }


        // ========================================= Tính tổng Doanh Thu ======================================================

        private int tinhTongTien()
        {
            int thugiamtrukhac = 0, giam = 0, tienphong = 0, tienmenu = 0, tienphuthu = 0, tientratruoc = 0, tongtien = 0, allTongTien = 0;

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
                
                tongtien = tienphong + tienmenu + tienphuthu + thugiamtrukhac - tientratruoc;
                allTongTien += tongtien;
            }
            AddCommaToTextBox(gunatxtDT);
            return allTongTien;
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

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            gunatxtDT.Text = tinhTongTien() + "  VNĐ";

            

            //Notes: TongTien = phong+menu+phuthu+thugiamtrukhac-tratruoc

            /* string tongDT = "";
             foreach (DataRow dt in hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\" FROM HoaDon").Rows)
             {
                 tongDT = dt["Doanh Thu"].ToString();
                 txtDT.Text = tongDT + "  VNĐ";
             }*/



            //========================================= LINE CHART: Biểu đồ đường ===================================================

            /*            LineChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) " +
                            "                                    AS \"Dịch Vụ\", MONTH(ThoiGianKetThuc) AS \"Tháng\"\r\nFROM HoaDon\r\n" +
                            "                                    GROUP BY MONTH(ThoiGianKetThuc)");

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

                        PieChart.DataSource = hoaDonBUS.GetHoaDon("SELECT DISTINCT SUM(CAST(TongTien AS int)) AS \"Doanh Thu\", SUM(CAST(TienMenu AS int)) " +
                                                                  "AS \"Dịch Vụ\", MONTH(ThoiGianKetThuc) AS \"Tháng\"\r\nFROM HoaDon\r\nGROUP BY MONTH(ThoiGianKetThuc)");

                        PieChart.Series["ChartDT"].XValueMember = "Tháng";          //Title
                        PieChart.Series["ChartDT"].YValueMembers = "Doanh Thu";     //Biểu đồ


                        //Hiển thị % biểu đồ
                        PieChart.Series["ChartDT"].Label = "#PERCENT{0.00 %}";
                        PieChart.Series["ChartDT"].LegendText = "#VALX";
                    }*/



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
    }
}