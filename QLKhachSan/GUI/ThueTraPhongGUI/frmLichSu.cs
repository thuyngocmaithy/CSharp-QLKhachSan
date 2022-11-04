
using Guna.UI2.WinForms;
using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    public partial class frmLichSu : Form
    {
        FlowLayoutPanel pnlPhong, pnlBottomPhong;
        Panel pnlTopPhong;
        Label lblTenPhong, lblSoGioThue;
        Guna2TextBox lblTongTien;
        Button btnOption, btnSoGioThue, btnTongTien;
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        ThietLapKhacBUS thietLapKhacBUS = new ThietLapKhacBUS();
        string sapxeptheo = "", valueFind = "";
        Boolean tanggiam = true;
        public frmLichSu(string sapxeptheo, Boolean tanggiam, string valueFind)
        {
            InitializeComponent();
            this.sapxeptheo = sapxeptheo;
            this.tanggiam = tanggiam;
            this.valueFind = valueFind;
        }
        private void dialogLichSu_Load(object sender, EventArgs e)
        {
            DataTable dtHoaDon = new DataTable();
            if (valueFind == "")
            {
                if (sapxeptheo == "Xếp theo tên")
                {
                    if (tanggiam == true)//tăng
                    {
                        dtHoaDon = hoaDonBUS.GetHoaDon("SELECT * FROM HoaDon " +
                   "ORDER BY MaPhong");
                    }
                    else// giảm
                    {
                        dtHoaDon = hoaDonBUS.GetHoaDon("SELECT * FROM HoaDon " +
                   "ORDER BY MaPhong DESC");
                    }
                }
                else if (sapxeptheo == "Xếp theo độ ưu tiên")
                {
                    if (tanggiam == true)//tăng
                    {
                        dtHoaDon = hoaDonBUS.GetHoaDon("SELECT * FROM HoaDon " +
                   "ORDER BY UuTienHienThi");

                    }
                    else// giảm
                    {
                        dtHoaDon = hoaDonBUS.GetHoaDon("SELECT * FROM HoaDon " +
                   "ORDER BY UuTienHienThi DESC");
                    }
                }
                else
                {
                    dtHoaDon = hoaDonBUS.GetHoaDon();

                }
            }
            else
            {
                if (sapxeptheo == "Xếp theo tên")
                {
                    if (tanggiam == true)//tăng
                    {
                        dtHoaDon = hoaDonBUS.GetHoaDon("SELECT * FROM HoaDon " +
                   "WHERE MaPhong LIKE '%" + valueFind + "%' " +
                   "ORDER BY MaPhong");
                    }
                    else// giảm
                    {
                        dtHoaDon = hoaDonBUS.GetHoaDon("SELECT * FROM HoaDon " +
                   "WHERE MaPhong LIKE '%" + valueFind + "%' " +
                   "ORDER BY MaPhong DESC");
                    }
                }
                else if (sapxeptheo == "Xếp theo độ ưu tiên")
                {
                    if (tanggiam == true)//tăng
                    {
                        dtHoaDon = hoaDonBUS.GetHoaDon("SELECT * FROM HoaDon " +
                  "WHERE MaPhong LIKE '%" + valueFind + "%' " +
                   "ORDER BY UuTienHienThi");

                    }
                    else// giảm
                    {
                        dtHoaDon = hoaDonBUS.GetHoaDon("SELECT * FROM HoaDon " +
                   "WHERE MaPhong LIKE '%" + valueFind + "%' " +
                   "ORDER BY UuTienHienThi DESC");
                    }
                }
                else
                {
                    dtHoaDon = hoaDonBUS.GetHoaDon("SELECT * FROM HoaDon " +
                   "WHERE MaPhong LIKE '%" + valueFind + "%'");


                }
            }
            foreach (DataRow dt in dtHoaDon.Rows)
            {
                if (dt["ThoiGianKetThuc"].ToString() != "" && dt["ThoiGianKetThuc"].ToString() != null)
                {
                    int tienphong = int.Parse(dt["TienPhong"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));
                    int tienphuthu = 0;
                    if (dt["PhuThu"].ToString() != "")
                    {
                        tienphuthu = int.Parse(dt["PhuThu"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));

                    }
                    int tientratruoc = 0;
                    if (dt["TraTruoc"].ToString() != "")
                    {
                        tientratruoc = int.Parse(dt["TraTruoc"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));

                    }
                    int thugiamtrukhac = 0;
                    if (dt["ThuGiamTruKhac"].ToString() != "")
                    {
                        thugiamtrukhac = int.Parse(dt["ThuGiamTruKhac"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));

                    }
                    int tienmenu = 0;
                    if (dt["TienMenu"].ToString() != "")
                    {
                        tienmenu = int.Parse(dt["TienMenu"].ToString(), NumberStyles.AllowThousands, new CultureInfo("en-au"));

                    }
                    int tongtien = tienphong + tienphuthu - tientratruoc + thugiamtrukhac + tienmenu;
                    taoPanelPhong(dt["MaHoaDon"].ToString(), dt["MaPhong"].ToString(), dt["ThoiGianKetThuc"].ToString(), tongtien.ToString());
                    pnlLichSu.Controls.Add(pnlPhong);

                }
            }
        }
        private void taoPanelPhong(string mahoadon, string maphong, string thoigianketthuc, string tongtien)
        {
            pnlPhong = new FlowLayoutPanel();
            taoPanelTopPhong(mahoadon, maphong);
            taoPanelBottomPhong(mahoadon, thoigianketthuc, tongtien);
            this.pnlPhong.Controls.Add(this.pnlTopPhong);
            this.pnlPhong.Controls.Add(this.pnlBottomPhong);
            this.pnlPhong.BorderStyle = BorderStyle.FixedSingle;
            this.pnlPhong.Location = new System.Drawing.Point(3, 3);
            this.pnlPhong.Name = "flowLayoutPanel1";
            this.pnlPhong.Size = new System.Drawing.Size(200, 130);
            this.pnlPhong.TabIndex = 0;
            this.pnlPhong.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);

        }
        private void taoPanelTopPhong(string mahoadon, string maphong)
        {
            pnlTopPhong = new Panel();
            taoButtonOption(mahoadon);
            taoLabelTenPhong(mahoadon, maphong);
            this.pnlTopPhong.Controls.Add(this.btnOption);
            this.pnlTopPhong.Controls.Add(this.lblTenPhong);
            this.pnlTopPhong.BorderStyle = BorderStyle.FixedSingle;

            this.pnlTopPhong.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPhong.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTopPhong.Name = "panel1";
            this.pnlTopPhong.Size = new System.Drawing.Size(200, 50);
            this.pnlTopPhong.TabIndex = 0;
        }
        private void taoLabelTenPhong(string mahoadon, string maphong)
        {
            lblTenPhong = new Label();
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTenPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.lblTenPhong.Location = new System.Drawing.Point(0, 0);
            this.lblTenPhong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenPhong.Name = "lblTenPhong" + mahoadon;
            this.lblTenPhong.Size = new System.Drawing.Size(76, 32);
            this.lblTenPhong.TabIndex = 0;
            this.lblTenPhong.Text = maphong;
        }
        private void taoButtonOption(string mahoadon)
        {
            btnOption = new Button();
            this.btnOption.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOption.Image = Image.FromFile
                  (Path.GetFullPath(@"icon\single_choice_40px.png"));
            this.btnOption.Location = new System.Drawing.Point(150, 0);
            this.btnOption.Margin = new System.Windows.Forms.Padding(0);
            this.btnOption.Name = "btn" + mahoadon;
            this.btnOption.Size = new System.Drawing.Size(50, 50);
            this.btnOption.TabIndex = 1;
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(clickChonOption);

        }



        private void taoButtonSoGioThue()
        {
            btnSoGioThue = new Button();
            this.btnSoGioThue.Image = Image.FromFile
                  (Path.GetFullPath(@"icon\left_2_25px.png"));
            this.btnSoGioThue.Location = new System.Drawing.Point(3, 3);
            this.btnSoGioThue.Name = "button2";
            this.btnSoGioThue.Size = new System.Drawing.Size(48, 34);
            this.btnSoGioThue.TabIndex = 1;
            this.btnSoGioThue.UseVisualStyleBackColor = true;
        }
        private void taoLabelSoGioThue(string mahoadon, string thoigianketthuc)
        {
            lblSoGioThue = new Label();
            this.lblSoGioThue.AutoSize = true;
            this.lblSoGioThue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoGioThue.Location = new System.Drawing.Point(57, 3);
            this.lblSoGioThue.Name = "lblSoGioThue" + mahoadon;
            this.lblSoGioThue.Size = new System.Drawing.Size(111, 28);
            this.lblSoGioThue.TabIndex = 1;
            DateTime now = DateTime.Now;
            DateTime dateThoigianketthuc = DateTime.Parse(thoigianketthuc, CultureInfo.CreateSpecificCulture("en-US"));

            TimeSpan diff = now - dateThoigianketthuc;
            if (diff.Days > 0)
            {
                this.lblSoGioThue.Text = diff.Days + " ngày trước";
            }
            else
            {
                this.lblSoGioThue.Text = diff.Hours + " giờ trước";

            }
        }
        private void taoPanelBottomPhong(string mahoadon, string thoigianketthuc, string tongtien)
        {
            pnlBottomPhong = new FlowLayoutPanel();
            taoLabelTongTien(mahoadon, tongtien);
            taoButtonTongTien();
            taoLabelSoGioThue(mahoadon, thoigianketthuc);
            taoButtonSoGioThue();
            this.pnlBottomPhong.Controls.Add(this.btnSoGioThue);
            this.pnlBottomPhong.Controls.Add(this.lblSoGioThue);
            this.pnlBottomPhong.Controls.Add(this.btnTongTien);

            this.pnlBottomPhong.Controls.Add(this.lblTongTien);
            this.pnlBottomPhong.BorderStyle = BorderStyle.FixedSingle;

            this.pnlBottomPhong.Location = new System.Drawing.Point(0, 50);
            this.pnlBottomPhong.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottomPhong.Name = "pnlBottom" + mahoadon;
            this.pnlBottomPhong.Size = new System.Drawing.Size(200, 80);
            this.pnlBottomPhong.TabIndex = 1;
        }

        private void ChinhSuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(DataRow dr in hoaDonBUS.GetHoaDon(
                "SELECT * " +
                "FROM HoaDon " +
                "WHERE MaHoaDon = '"+ contextMenuStrip1.Tag.ToString().Substring(3) + "'").Rows)
            {
                dialogTraPhong dialogTraPhong = new dialogTraPhong(contextMenuStrip1.Tag.ToString().Substring(3), "Sửa", dr["TaiKhoanTraPhong"].ToString());
                dialogTraPhong.Show();
            }
           
        }

        private void InHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            foreach (DataRow dt in hoaDonBUS.GetHoaDon(
                "SELECT * " +
                "FROM HoaDon " +
                "WHERE MaHoaDon = '" + contextMenuStrip1.Tag.ToString().Substring(3) + "'").Rows)
            {
                hd = new HoaDonDTO(dt["MaHoaDon"].ToString(), dt["MaPhong"].ToString(), dt["ThoiGianBatDau"].ToString()
                    , dt["ThoiGianKetThuc"].ToString(), dt["MaCachThue"].ToString(), dt["TienPhong"].ToString()
                    , dt["PhuThu"].ToString(), dt["TraTruoc"].ToString(), dt["ThuGiamTruKhac"].ToString()
                    , dt["TienMenu"].ToString(), dt["GhiChu"].ToString()
                    , dt["TaiKhoanNhanPhong"].ToString(),dt["TaiKhoanTraPhong"].ToString());
            }
            ThietLapKhacDTO tlk = new ThietLapKhacDTO();
            foreach (DataRow dt in thietLapKhacBUS.GetThietLapKhac().Rows)
            {
                tlk = new ThietLapKhacDTO(dt["TenKhachSan"].ToString(), dt["DiaChi"].ToString(), dt["SDT"].ToString()
            , dt["ThoiGian"].ToString(), dt["Logo"].ToString(), dt["Panel"].ToString());
            }
            printPDFHoaDon printPDFHoaDon = new printPDFHoaDon(hd, tlk);
            printPDFHoaDon.print();
            //printPDFHoaDon.test();
        }

        private void taoButtonTongTien()
        {
            btnTongTien = new Button();
            this.btnTongTien.Image = Image.FromFile
                  (Path.GetFullPath(@"icon\money_25px.png"));
            this.btnTongTien.Location = new System.Drawing.Point(3, 43);
            this.btnTongTien.Name = "button3";
            this.btnTongTien.Size = new System.Drawing.Size(48, 34);
            this.btnTongTien.TabIndex = 3;
            this.btnTongTien.UseVisualStyleBackColor = true;
        }
        private void taoLabelTongTien(string mahoadon, string tongtien)
        {
            lblTongTien = new Guna2TextBox();
            this.lblTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTongTien.DefaultText = "";
            this.lblTongTien.DisabledState.BorderColor = Color.White;
            this.lblTongTien.DisabledState.FillColor = Color.White;
            this.lblTongTien.DisabledState.ForeColor = Color.Black;
            this.lblTongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblTongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTongTien.Location = new System.Drawing.Point(80, 43);
            this.lblTongTien.Name = "lblTongTien" + mahoadon;
            this.lblTongTien.PasswordChar = '\0';
            this.lblTongTien.PlaceholderText = "";
            this.lblTongTien.SelectedText = "";
            this.lblTongTien.Size = new System.Drawing.Size(100, 34);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = tongtien;
            this.lblTongTien.Enabled = false;
            AddCommaToTextBox(lblTongTien);

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
        private void clickChonOption(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(((Button)sender), 0, 0);
            contextMenuStrip1.Tag = ((Button)sender).Name;
        }
    }
}
