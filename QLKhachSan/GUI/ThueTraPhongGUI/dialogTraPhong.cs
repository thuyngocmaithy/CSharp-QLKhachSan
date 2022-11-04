using AmLich;
using Guna.UI2.WinForms;
using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    public partial class dialogTraPhong : Form
    {
        string mahoadon, maphong, thoigianbatdau, thoigianketthuc, macachthue, tientratruoc, ghichu;
        string tienphongsua, phuthusua, thugiamtrusua, tienmenusua;
        PhongBUS phongBUS = new PhongBUS();
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        HoaDon_MenuBUS hoaDon_MenuBUS = new HoaDon_MenuBUS();
        MenuBUS menuBUS = new MenuBUS();
        CachThueBUS cachThueBUS = new CachThueBUS();
        CachtinhtienBUS cachtinhtienBUS = new CachtinhtienBUS();
        List<string> lsMenuChon;
        Boolean suathanhcong = true;
        string macachtinhtien;
        int tienphuthu;
        int sophutlamtron1gio, daysThue = 0, hoursThue = 0, minutesThue = 0, tongthoigianthue = 0;
        int sogionhanphongsom = 0, sogiotraphongtre = 0;
        int songayT6 = 0, songayT7 = 0, songayCN = 0, songayle = 0;
        Boolean thuetheogio = true;
        Boolean menuChange = false;
        string trangthai;
        Boolean changeDate = false;
        string mataikhoan;
        public dialogTraPhong(string mahoadon, string trangthai, string mataikhoan)
        {
            InitializeComponent();
            this.mahoadon = mahoadon;
            this.trangthai = trangthai;
            this.mataikhoan = mataikhoan;
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadMenu()
        {
            dgvMenuTraPhong.DataSource = hoaDon_MenuBUS.GetHoaDon_Menu(
                "SELECT TenMenu, SL, Format((replace(convert(varchar, cast(REPLACE(mn.GiaBan,',','.') as money), 1), '.00', '') * SL), 'c', 'vi-VN') AS ThanhTien " +
                "FROM HoaDon_Menu hdmn, Menu mn " +
                "WHERE hdmn.MaMenu = mn.MaMenu " +
                "AND MaHoaDon = '" + mahoadon + "'");
        }

        public void setValue()
        {
            foreach (DataRow dt in hoaDonBUS.GetHoaDon(
                "SELECT * FROM HoaDon" +
                " WHERE MaHoaDon = '" + mahoadon + "'").Rows)
            {
                maphong = dt["MaPhong"].ToString();
                thoigianbatdau = dt["ThoiGianBatDau"].ToString();
                if (trangthai == "Sửa")
                {
                    thoigianketthuc = dt["ThoiGianKetThuc"].ToString();
                    tienphongsua = dt["TienPhong"].ToString();
                    phuthusua = dt["PhuThu"].ToString();
                    thugiamtrusua = dt["ThuGiamTruKhac"].ToString();
                    tienmenusua = dt["TienMenu"].ToString();

                }
                macachthue = dt["MaCachThue"].ToString();
                tientratruoc = dt["TraTruoc"].ToString();
                ghichu = dt["GhiChu"].ToString();
            }
        }



        public void setTextFormMacDinh()
        {
            setValue();
            DateTime datengaynhan = DateTime.Parse(thoigianbatdau, CultureInfo.CreateSpecificCulture("en-US"));
            dateNhanPhong.Value = datengaynhan;
            timeNhanPhong.Value = datengaynhan;
            DateTime datengaytra;
            if (trangthai == "Thêm")
            {
                datengaytra = DateTime.Now;

            }
            else
            {
                datengaytra = DateTime.Parse(thoigianketthuc, CultureInfo.CreateSpecificCulture("en-US"));

            }
            dateTraPhong.Value = datengaytra;
            timeTraPhong.Value = datengaytra;
            txtTienTraTruoc.Text = tientratruoc;
            cmbCachThue.SelectedValue = macachthue;
            txtGhiChu.Text = ghichu;
            changeDate = true;


        }
        public void getThoiGianThue()
        {
            getElementTienPhong();
            string strNgaynhan = dateNhanPhong.Value.ToString("yyyy-MM-dd") + " " + timeNhanPhong.Text + ":00";
            DateTime dateNgaynhan = DateTime.Parse(strNgaynhan, CultureInfo.CreateSpecificCulture("en-US"));

            string strNgaytra = dateTraPhong.Value.ToString("yyyy-MM-dd") + " " + timeTraPhong.Text + ":00";
            DateTime dateNgaytra = DateTime.Parse(strNgaytra, CultureInfo.CreateSpecificCulture("en-US"));

            TimeSpan diff = dateNgaytra - dateNgaynhan;
            daysThue = diff.Days;
            hoursThue = diff.Hours;
            minutesThue = diff.Minutes;
            if (minutesThue > sophutlamtron1gio)
            {
                hoursThue++;
            }
            if (hoursThue == 0 && daysThue == 0)
            {
                hoursThue = 1;
            }
        }
        public void setLabelThoiGianThue()
        {
            getThoiGianThue();
            lblThoiGianThue.Text = String.Format("{0} ngày {1} giờ", daysThue, hoursThue);
        }
        public void setLabelTrangThaiNhanPhong()
        {
            int gionhanphong = Int32.Parse(timeNhanPhong.Text.Split(':')[0]);
            int phutnhanphong = Int32.Parse(timeNhanPhong.Text.Split(':')[1]);

            int gioQD = 0;
            int phutQD = 0;
            foreach (DataRow dtGioQD in cachThueBUS.GetCachThue(
                "SELECT GioNhanPhong " +
                "FROM CachTinhTien_CachThue " +
                "WHERE MaCachThue = '" + macachthue + "' " +
                "AND MaCachTinhTien = '" + macachtinhtien + "'").Rows)
            {
                gioQD = Int32.Parse(dtGioQD["GioNhanPhong"].ToString().Split(':')[0]);
                phutQD = Int32.Parse(dtGioQD["GioNhanPhong"].ToString().Split(':')[1]);

            }
            int sogiosom = 0;
            if (gioQD - gionhanphong > 0)
            {
                sogiosom = gioQD - gionhanphong;
            }
            int sophutsom = 0;
            if (phutQD - phutnhanphong > 0)
            {
                sophutsom = phutQD - phutnhanphong;
            }
            lblTrangThaiNhanPhong.Text = "Nhận phòng sớm " + sogiosom + " giờ " + sophutsom + " phút";
            sogionhanphongsom = sogiosom;
            if (sophutsom > sophutlamtron1gio)
            {
                sogionhanphongsom++;
            }


        }
        public void setLabelTrangThaiTraPhong()
        {
            int giotraphong = Int32.Parse(timeTraPhong.Text.Split(':')[0]);
            int phuttraphong = Int32.Parse(timeTraPhong.Text.Split(':')[1]);

            int gioQD = 0;
            int phutQD = 0;
            foreach (DataRow dtGioQD in cachThueBUS.GetCachThue(
               "SELECT GioTraPhong " +
               "FROM CachTinhTien_CachThue " +
               "WHERE MaCachThue = '" + macachthue + "' " +
               "AND MaCachTinhTien = '" + macachtinhtien + "'").Rows)
            {
                gioQD = Int32.Parse(dtGioQD["GioTraPhong"].ToString().Split(':')[0]);
                phutQD = Int32.Parse(dtGioQD["GioTraPhong"].ToString().Split(':')[1]);

            }
            int sogiotre = 0;
            if (giotraphong - gioQD > 0)
            {
                sogiotre = giotraphong - gioQD;
            }
            int sophuttre = 0;
            if (phuttraphong - phutQD > 0)
            {
                sophuttre = phuttraphong - phutQD;
            }
            lblTrangThaiTraPhong.Text = "Trả phòng trễ " + sogiotre + " giờ " + sophuttre + " phút";
            sogiotraphongtre = sogiotre;
            if (sophuttre > sophutlamtron1gio)
            {
                sogiotraphongtre++;
            }


        }



        public void getElementTienPhong()
        {
            
            foreach (DataRow dt in phongBUS.GetPhong(
                "SELECT MaCachTinhTien " +
                "FROM Phong " +
                "WHERE MaPhong = '" + maphong + "'").Rows)
            {
                macachtinhtien = dt["MaCachTinhTien"].ToString();
                foreach (DataRow dtCachTinhTien in cachtinhtienBUS.GetCachTinhTien(
                    "SELECT * " +
                    "FROM CachTinhTien " +
                    "WHERE MaCachTinhTien = '" + macachtinhtien + "'").Rows)
                {
                    tienphuthu = int.Parse(dtCachTinhTien["PhuThuQuaGio"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                    sophutlamtron1gio = Int32.Parse(dtCachTinhTien["SoPhutLamTronThanh1Gio"].ToString());
                }
            }
        }
        public void testWeekendAndHoliday()
        {
            songayT6 = 0;
            songayT7 = 0;
            songayCN = 0;
            songayle = 0;
            DateTime datengaynhan = dateNhanPhong.Value;
            DateTime datengaytra = dateTraPhong.Value;

            for (DateTime i = datengaynhan; i <= datengaytra; i += TimeSpan.FromDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Friday)
                {
                    songayT6++;
                }
                if (i.DayOfWeek == DayOfWeek.Saturday)
                {
                    songayT7++;
                }
                if (i.DayOfWeek == DayOfWeek.Sunday)
                {
                    songayCN++;
                }
            }

            //KIỂM TRA NGÀY LỄ DƯƠNG LỊCH
            string[] leDuongLich = File.ReadAllLines(@"DanhSachNgayLeDuongLich.txt");
            for (DateTime i = datengaynhan; i <= datengaytra; i += TimeSpan.FromDays(1))
            {
                string date = i.ToString("dd/MM");
                
                foreach (string s in leDuongLich)
                {
                    if (date.Equals(s))
                    {
                        songayle++;
                    }
                }
            }
            //KIỂM TRA NGÀY LỄ ÂM LỊCH
            string[] leAmLich = File.ReadAllLines(@"DanhSachNgayLeAmLich.txt");
            for (DateTime i = datengaynhan; i <= datengaytra; i += TimeSpan.FromDays(1))
            {
                LunarDate ld = LunarYearTools.SolarToLunar(i);
                string date = ld.Day + "/" + ld.Month;

                foreach (string s in leAmLich)
                {
                    if (date.Equals(s))
                    {
                        songayle++;
                    }
                }
            }
        }
        public int tinhTienPhong()
        {
           
            int tienphong=0;
            int giatheocachthue = 0;
            foreach (DataRow dt in cachThueBUS.GetCachThue(
                "SELECT GiaTheoCachThue " +
                "FROM CachTinhTien_CachThue " +
                "WHERE MaCachThue = '" + macachthue + "' " +
                "AND MaCachTinhTien = '" + macachtinhtien + "'").Rows)
            {
                giatheocachthue = int.Parse(dt["GiaTheoCachThue"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
            }
            if(thuetheogio)
            {
                tienphong = (giatheocachthue * tongthoigianthue);
            }
            else
            {
                testWeekendAndHoliday();
              //  MessageBox.Show("T6:" + songayT6 + "-T7:" + songayT7 + "-CN:" + songayCN);
                tongthoigianthue = tongthoigianthue - songayT6 - songayT7 - songayCN - songayle;
                foreach (DataRow dt in cachtinhtienBUS.GetCachTinhTien(
               "SELECT GiaThueCuoiTuanVaNgayLe " +
               "FROM CachTinhTien " +
               "WHERE MaCachTinhTien = '" + macachtinhtien + "'").Rows)
                {                    
                    string[] giathuecuoituanvangayle = dt["GiaThueCuoiTuanVaNgayLe"].ToString().Split('-');
                    int giaT6 = int.Parse(giathuecuoituanvangayle[0], NumberStyles.AllowThousands, new CultureInfo("en-au"));
                    int giaT7 = int.Parse(giathuecuoituanvangayle[1], NumberStyles.AllowThousands, new CultureInfo("en-au"));
                    int giaCN = int.Parse(giathuecuoituanvangayle[2], NumberStyles.AllowThousands, new CultureInfo("en-au"));
                    int giangayle = int.Parse(giathuecuoituanvangayle[3], NumberStyles.AllowThousands, new CultureInfo("en-au"));
                    tienphong = (giatheocachthue * tongthoigianthue) + (giaT6 * songayT6) + (giaT7 * songayT7) + (giaCN * songayCN) + (giangayle * songayle);
                }
            }    
            return tienphong;

        }
        public DataTable GetDataTableFromDGV(DataGridView dataGridView1)
        {
            //Creating DataTable.
            DataTable dt = new DataTable();

            //Adding the Columns.
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            return dt;
        }




        public int tinhTienPhuThu()
        {
            int tongtienphuthu;
            tongtienphuthu = (tienphuthu * sogionhanphongsom) + (tienphuthu * sogiotraphongtre);
            //   MessageBox.Show("tienphuthu: " + tienphuthu + "\n" + "nhanphongsom:" + sogionhanphongsom + "\n" + "nhanphongtre:" + sogiotraphongtre);
            return tongtienphuthu;
        }

        public int tinhTienMenu()
        {
            int sl = 0;
            int dongia = 0;
            int giasp = 0;
            int tongtienmenu = 0;
            foreach (DataRow dt in hoaDon_MenuBUS.GetHoaDon_Menu(
                "SELECT * " +
                "FROM HoaDon_Menu " +
                "WHERE MaHoaDon = '" + mahoadon + "'").Rows)
            {
                sl = int.Parse(dt["SL"].ToString());
                foreach (DataRow dtMenu in menuBUS.GetMenu(
                     "SELECT GiaBan " +
                     "FROM Menu " +
                     "WHERE MaMenu = '" + dt["MaMenu"].ToString() + "'").Rows)
                {
                    dongia = int.Parse(dtMenu["GiaBan"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                    giasp = dongia * sl;
                }
                tongtienmenu += giasp;
            }
            return tongtienmenu;
        }

        public void dateNhanPhong_onValueChanged(object sender, EventArgs e)
        {

            if (changeDate)
            {
                if (dateNhanPhong.Value > dateTraPhong.Value)
                {
                    MessageBox.Show("Ngày nhận phòng không thể lớn hơn ngày trả phòng");
                    dateNhanPhong.Value = dateTraPhong.Value;                  
                }
                if(dateNhanPhong.Value.Day == dateTraPhong.Value.Day
               && dateNhanPhong.Value.Month == dateTraPhong.Value.Month
               && dateNhanPhong.Value.Year == dateTraPhong.Value.Year)
                {
                    if ((timeTraPhong.Value.Hour < timeNhanPhong.Value.Hour)
                     || (timeTraPhong.Value.Hour == timeNhanPhong.Value.Hour &&
                     timeTraPhong.Value.Minute < timeNhanPhong.Value.Minute))
                    {
                        MessageBox.Show("Thời gian nhận phòng không thể lớn hơn thời gian trả phòng");
                        timeNhanPhong.Value = timeTraPhong.Value;
                    }
                }    
                setTextChange();
            }

        }

        public void dateTraPhong_onValueChanged(object sender, EventArgs e)
        {

            if (changeDate)
            {
                if (dateTraPhong.Value < dateTraPhong.Value)
                {
                    MessageBox.Show("Ngày trả phòng không thể nhỏ hơn ngày nhận phòng");
                    dateTraPhong.Value = dateNhanPhong.Value;
                }
                if (dateNhanPhong.Value.Day == dateTraPhong.Value.Day
               && dateNhanPhong.Value.Month == dateTraPhong.Value.Month
               && dateNhanPhong.Value.Year == dateTraPhong.Value.Year)
                {
                    if ((timeTraPhong.Value.Hour < timeNhanPhong.Value.Hour)
                        || (timeTraPhong.Value.Hour == timeNhanPhong.Value.Hour &&
                        timeTraPhong.Value.Minute < timeNhanPhong.Value.Minute))
                    {
                        MessageBox.Show("Thời gian trả phòng không thể nhỏ hơn thời gian nhận phòng");
                        timeTraPhong.Value = timeNhanPhong.Value;
                    }
                }
                setTextChange();
            }
        }

        public void timeTraPhong_ValueChanged(object sender, EventArgs e)
        {
            timeTraPhong.CustomFormat = "HH:mm";
            if (changeDate)
            {
                  if (dateNhanPhong.Value.Day == dateTraPhong.Value.Day
                && dateNhanPhong.Value.Month == dateTraPhong.Value.Month
                && dateNhanPhong.Value.Year == dateTraPhong.Value.Year)
            {
                if ((timeTraPhong.Value.Hour < timeNhanPhong.Value.Hour)
                    || (timeTraPhong.Value.Hour == timeNhanPhong.Value.Hour &&
                    timeTraPhong.Value.Minute < timeNhanPhong.Value.Minute))
                {
                    MessageBox.Show("Thời gian trả phòng không thể nhỏ hơn thời gian nhận phòng");
                    timeTraPhong.Value = timeNhanPhong.Value;
                }
            }
                setTextChange();
            }
        }
        public void timeNhanPhong_ValueChanged(object sender, EventArgs e)
        {
            timeNhanPhong.CustomFormat = "HH:mm";
            if (changeDate)
            {
                 if (dateNhanPhong.Value.Day == dateTraPhong.Value.Day
                && dateNhanPhong.Value.Month == dateTraPhong.Value.Month
                && dateNhanPhong.Value.Year == dateTraPhong.Value.Year)
                {
                    if ((timeTraPhong.Value.Hour < timeNhanPhong.Value.Hour)
                        || (timeTraPhong.Value.Hour == timeNhanPhong.Value.Hour &&
                        timeTraPhong.Value.Minute < timeNhanPhong.Value.Minute))
                    {
                        MessageBox.Show("Thời gian nhận phòng không thể lớn hơn thời gian trả phòng");
                        timeNhanPhong.Value = timeTraPhong.Value;
                    }
                }
                setTextChange();
            }


        }

        private void txtTienPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtThuGiamTru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienTraTruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        public void timeNhanPhong_MouseDown(object sender, MouseEventArgs e)
        {

            timeNhanPhong.CustomFormat = "HH:mm";
            if (dateNhanPhong.Value.Day == dateTraPhong.Value.Day
                && dateNhanPhong.Value.Month == dateTraPhong.Value.Month
                && dateNhanPhong.Value.Year == dateTraPhong.Value.Year)
            {
                if ((timeTraPhong.Value.Hour < timeNhanPhong.Value.Hour)
                    || (timeTraPhong.Value.Hour == timeNhanPhong.Value.Hour &&
                    timeTraPhong.Value.Minute < timeNhanPhong.Value.Minute))
                {
                    MessageBox.Show("Thời gian nhận phòng không thể lớn hơn thời gian trả phòng");
                    timeNhanPhong.Value = timeTraPhong.Value;
                }
            }
            setTextChange();

        }
        public void txtTienPhong_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtTienPhong);
            tinhTongTien();
            txtTongTien.Text = tinhTongTien().ToString();
            AddCommaToTextBox(txtTongTien);
        }

        public void txtPhuThu_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtPhuThu);
            tinhTongTien();
            txtTongTien.Text = tinhTongTien().ToString();
            AddCommaToTextBox(txtTongTien);
        }



        public void txtTienTraTruoc_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtTienTraTruoc);
            tinhTongTien();
            txtTongTien.Text = tinhTongTien().ToString();
            AddCommaToTextBox(txtTongTien);
        }

        public void txtThuGiamTru_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtThuGiamTru);
            tinhTongTien();
            txtTongTien.Text = tinhTongTien().ToString();
            AddCommaToTextBox(txtTongTien);

        }

        public void txtTienMenu_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtTienMenu);
            tinhTongTien();
            txtTongTien.Text = tinhTongTien().ToString();
            AddCommaToTextBox(txtTongTien);
        }

        public void timeTraPhong_MouseDown(object sender, MouseEventArgs e)
        {
            timeTraPhong.CustomFormat = "HH:mm";

            if (dateNhanPhong.Value.Day == dateTraPhong.Value.Day
                && dateNhanPhong.Value.Month == dateTraPhong.Value.Month
                && dateNhanPhong.Value.Year == dateTraPhong.Value.Year)
            {
                if ((timeTraPhong.Value.Hour < timeNhanPhong.Value.Hour)
                    || (timeTraPhong.Value.Hour == timeNhanPhong.Value.Hour &&
                    timeTraPhong.Value.Minute < timeNhanPhong.Value.Minute))
                {
                    MessageBox.Show("Thời gian trả phòng không thể nhỏ hơn thời gian nhận phòng");
                    timeTraPhong.Value = timeNhanPhong.Value;
                }
            }

            setTextChange();

        }

        public void setTextChange()
        {

            setLabelThoiGianThue();
            setLabelTrangThaiNhanPhong();
            setLabelTrangThaiTraPhong();

            //HIỆN THỜI GIAN TÍNH TIỀN
            if (thuetheogio)
            {
                lblTrangThaiNhanPhong.Visible = false;
                lblTrangThaiTraPhong.Visible = false;
                tongthoigianthue = (daysThue * 24) + hoursThue;
                lblThoiGianTinhTien.Text = "Tiền phòng " + tongthoigianthue + " giờ";
            }
            else
            {
                lblTrangThaiNhanPhong.Visible = true;
                lblTrangThaiTraPhong.Visible = true;
                if (hoursThue > 12)
                {
                    tongthoigianthue = daysThue + 1;
                }
                else
                    tongthoigianthue = daysThue;
                lblThoiGianTinhTien.Text = "Tiền phòng " + tongthoigianthue + " ngày";
            }
            if (trangthai == "Thêm")
            {
                //setTienPhong
                txtTienPhong.Text = tinhTienPhong().ToString();
                //setTienPhuThu
                if (!thuetheogio)
                {
                    txtPhuThu.Text = tinhTienPhuThu().ToString();
                }
                else
                {
                    txtPhuThu.Text = "";
                }
                //setTienMenu 
                txtTienMenu.Text = tinhTienMenu().ToString();

            }
            else
            {
                txtTienPhong.Text = tienphongsua;
                txtPhuThu.Text = phuthusua;
                txtTienMenu.Text = tienmenusua;
            }

            //TongTien
            txtTongTien.Text = tinhTongTien().ToString();

            AddCommaToTextBox();
        }
        public int tinhTongTien()
        {
            int thugiamtrukhac = 0;
            if (txtThuGiamTru.Text != "")
            {
                thugiamtrukhac = int.Parse(txtThuGiamTru.Text, NumberStyles.AllowThousands, new CultureInfo("en-au"));
            }
            int tienphong = 0;
            if (txtTienPhong.Text != "")
            {
                tienphong = int.Parse(txtTienPhong.Text, NumberStyles.AllowThousands, new CultureInfo("en-au"));
            }
            int tienmenu = 0;
            if (txtTienMenu.Text != "")
            {
                tienmenu = int.Parse(txtTienMenu.Text, NumberStyles.AllowThousands, new CultureInfo("en-au"));

            }
            int tienphuthu = 0;
            if (txtPhuThu.Text != "")
            {
                tienphuthu = int.Parse(txtPhuThu.Text, NumberStyles.AllowThousands, new CultureInfo("en-au"));

            }
            int tientratruoc = 0;
            if (txtTienTraTruoc.Text != "")
            {
                tientratruoc = int.Parse(txtTienTraTruoc.Text, NumberStyles.AllowThousands, new CultureInfo("en-au"));

            }
            int tongtien = tienphong + tienmenu + tienphuthu + thugiamtrukhac - tientratruoc;
            return tongtien;
        }
        public void dialogTraPhong_Load(object sender, EventArgs e)
        {
            if (trangthai == "Thêm")
            {
                lblThemSua.Text = "TRẢ PHÒNG";
            }
            else
            {
                lblThemSua.Text = "CHỈNH SỬA";
            }

            LoadMenu();
            setTextFormMacDinh();
            loadCmbCachThue();
            setTextChange();
            dgvMenuTraPhong.AllowUserToAddRows = false;
            //Add btnDelete
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            dgvMenuTraPhong.Columns.Insert(3, btnUpdate);
            btnUpdate.HeaderText = "Update";
            btnUpdate.Width = 95;
            btnUpdate.Text = "Update";
            btnUpdate.UseColumnTextForButtonValue = true;
            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvMenuTraPhong.Columns.Insert(3, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 95;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;


        }
        public void AddCommaToTextBox()
        {
            AddCommaToTextBox(txtTienMenu);
            AddCommaToTextBox(txtTienTraTruoc);
            AddCommaToTextBox(txtTienPhong);
            AddCommaToTextBox(txtPhuThu);
            AddCommaToTextBox(txtTongTien);

        }
        public void loadCmbCachThue()
        {
            cmbCachThue.DataSource = cachThueBUS.GetCachThue(
                "SELECT TenCachThue " +
                "FROM Phong, CachTinhTien_CachThue, CachThue " +
                "WHERE Phong.MaCachTinhTien = CachTinhTien_CachThue.MaCachTinhTien " +
                "AND CachThue.MaCachThue = CachTinhTien_CachThue.MaCachThue " +
                "AND Phong.MaPhong = '" + maphong + "'");
            cmbCachThue.DisplayMember = "TenCachThue";
            cmbCachThue.ValueMember = "MaCachThue";

        }




        public void cmbCachThue_SelectedValueChanged(object sender, EventArgs e)
        {
            getThoiGianThue();
            if (cmbCachThue.SelectedValue.ToString() == "CT001")//Thuê theo giờ
            {
                lblTrangThaiNhanPhong.Visible = false;
                lblTrangThaiTraPhong.Visible = false;
                tongthoigianthue = (daysThue * 24) + hoursThue;
                lblThoiGianTinhTien.Text = "Tiền phòng " + tongthoigianthue + " giờ";
                thuetheogio = true;
                macachthue = "CT001";
                setTextChange();

            }
            else
            {
                thuetheogio = false;
                lblTrangThaiNhanPhong.Visible = true;
                lblTrangThaiTraPhong.Visible = true;
                setLabelTrangThaiNhanPhong();
                setLabelTrangThaiTraPhong();
                if (hoursThue > 12)
                {
                    tongthoigianthue = daysThue + 1;
                }
                else
                    tongthoigianthue = daysThue;
                lblThoiGianTinhTien.Text = "Tiền phòng " + tongthoigianthue + " ngày";
                macachthue = "CT002";
                setTextChange();
            }
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

        public void btnThemMenu_Click(object sender, EventArgs e)
        {
            Boolean themthanhcong = true;
            dialogDsMenu dialogDsMenu = new dialogDsMenu(mahoadon);
            if (dialogDsMenu.ShowDialog() == DialogResult.OK)
            {
                lsMenuChon = dialogDsMenu.LsMenu;
                foreach (var ls in lsMenuChon)
                {
                    HoaDon_MenuDTO hd_mn = new HoaDon_MenuDTO(ls, mahoadon, 1);
                    if (!hoaDon_MenuBUS.ThemHoaDon_Menu(hd_mn))
                    {
                        themthanhcong = false;
                    }
                }
                if (themthanhcong && lsMenuChon.Count != 0)
                {
                    MessageBox.Show("Thêm menu thành công");
                    LoadMenu();
                }
                else if (!themthanhcong && lsMenuChon.Count != 0)
                {
                    MessageBox.Show("Thêm menu thất bại");

                }
                if (lsMenuChon.Count != 0)
                {
                    txtTienMenu.Text = tinhTienMenu().ToString();
                    AddCommaToTextBox(txtTienMenu);
                }
            }
        }
        public void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow row = dgvMenuTraPhong.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa menu này?", row.Cells["TenMenu"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataRow dt in menuBUS.GetMenu(
                        "SELECT MaMenu " +
                        "FROM Menu " +
                        "WHERE TenMenu = N'" + row.Cells["TenMenu"].Value.ToString() + "'").Rows)
                    {
                        if (hoaDon_MenuBUS.XoaHoaDon_Menu(mahoadon, dt["MaMenu"].ToString()))
                        {
                            MessageBox.Show("Xóa thành công");
                            LoadMenu();
                            //SET TEXT MENU
                            txtTienMenu.Text = tinhTienMenu().ToString();

                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }

                }
            }
            else if (e.ColumnIndex == 4)
            {
                DataGridViewRow row = dgvMenuTraPhong.Rows[e.RowIndex];
                string mamenu = "";
                foreach (DataRow dt in menuBUS.GetMenu(
                        "SELECT MaMenu " +
                        "FROM Menu " +
                        "WHERE TenMenu = N'" + row.Cells["TenMenu"].Value.ToString() + "'").Rows)
                {
                    mamenu = dt["MaMenu"].ToString();

                }
                int sl = int.Parse(row.Cells["SL"].Value.ToString());
                HoaDon_MenuDTO hd_mn = new HoaDon_MenuDTO(mamenu, mahoadon, sl);
                if (hoaDon_MenuBUS.SuaHoaDon_Menu(hd_mn))
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadMenu();
                    txtTienMenu.Text = tinhTienMenu().ToString();
                    AddCommaToTextBox(txtTienMenu);

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }


        public void btnLuu_Click(object sender, EventArgs e)
        {
            string ngaynhanphong = dateNhanPhong.Value.ToString("yyyy-MM-dd");
            string timenhanphong = timeNhanPhong.Value.ToString("HH:mm:ss");
            string thoigiannhanphong = ngaynhanphong + " " + timenhanphong;
            string ngaytraphong = dateTraPhong.Value.ToString("yyyy-MM-dd");
            string timetraphong = timeTraPhong.Value.ToString("HH:mm:ss");
            string thoigiantraphong = ngaytraphong + " " + timetraphong;
            string tienphong = txtTienPhong.Text;
            string tienmenu = txtTienMenu.Text;
            string tienphuthu = txtPhuThu.Text;
            string tienthugiamtrukhac = txtThuGiamTru.Text;
            string tientratruoc = txtTienTraTruoc.Text;
            string ghichu = txtGhiChu.Text;
            string taikhoannhanphong="", taikhoantraphong="";
            foreach(DataRow dr in hoaDonBUS.GetHoaDon(
                "SELECT * " +
                "FROM HoaDon " +
                "WHERE MaHoaDon = '"+mahoadon+"'").Rows)
            {
                taikhoannhanphong = dr["TaiKhoanNhanPhong"].ToString();
            }                
            HoaDonDTO hd = new HoaDonDTO(mahoadon, maphong, thoigiannhanphong, thoigiantraphong, macachthue, tienphong, tienphuthu, tientratruoc, tienthugiamtrukhac, tienmenu, ghichu, taikhoannhanphong,mataikhoan);
            if (hoaDonBUS.SuaHoaDon(hd))
            {
                if (trangthai == "Thêm")
                {
                    MessageBox.Show("Trả phòng thành công");
                    phongBUS.SuaPhong(maphong, "Phòng chờ dọn");
                }
                else
                {

                    MessageBox.Show("Lưu thành công");
                }

            }
            else
                if (trangthai == "Thêm")
            {

                MessageBox.Show("Trả phòng thất bại");
            }
            else
                MessageBox.Show("Lưu thất bại");


        }
    }
}
