using QLKhachSan.BUS;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    public partial class frmPhongDangThue : Form
    {
        FlowLayoutPanel pnlLoaiPhong, pnlPhong, pnlBottomPhong;
        Panel pnlTopPhong;
        Label lblLoaiPhong, lblTenPhong, lblTime, lblNote;
        Button btnOption, btnYCDonPhong, btnTime, btnNote;
        LoaiPhongBUS loaiPhongBUS = new LoaiPhongBUS();
        PhongBUS phongBUS = new PhongBUS();
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        string sapxeptheo = "", valueFind = "";
        Boolean tanggiam = true;
        public frmPhongDangThue(string sapxeptheo, Boolean tanggiam, string valueFind)
        {
            InitializeComponent();
            this.sapxeptheo = sapxeptheo;
            this.tanggiam = tanggiam;
            this.valueFind = valueFind;
        }
        private void frmPhongDangThue_Load(object sender, System.EventArgs e)
        {
            LoadPhongDangThue();
        }
        private void LoadPhongDangThue()
        {
            foreach (DataRow data in loaiPhongBUS.GetLoaiPhong().Rows)
            {
                taoPanelLoaiPhong(data["MaLoaiPhong"].ToString(), data["TenLoaiPhong"].ToString());
                pnlPhongDangThue.Controls.Add(pnlLoaiPhong);
            }
        }
        private void taoPanelLoaiPhong(string maloaiphong, string tenloaiphong)
        {
            taoLabelLoaiPhong(maloaiphong, tenloaiphong);
            this.pnlLoaiPhong = new FlowLayoutPanel();
            this.pnlLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoaiPhong.Controls.Add(this.lblLoaiPhong);
            this.pnlLoaiPhong.Location = new System.Drawing.Point(0, 0);
            this.pnlLoaiPhong.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlLoaiPhong.Name = "pnl" + maloaiphong;
            this.pnlLoaiPhong.Size = new System.Drawing.Size(870, 242);
            this.pnlLoaiPhong.TabIndex = 0;
            DataTable dtPhong = new DataTable();
            if (valueFind == "")
            {
                if (sapxeptheo == "Xếp theo tên")
                {
                    if (tanggiam == true)//tăng
                    {
                        dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                   "AND (TinhTrang = N'Phòng đang thuê' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') " +
                   "ORDER BY MaPhong");
                    }
                    else// giảm
                    {
                        dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                   "AND (TinhTrang = N'Phòng đang thuê' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') " +
                   "ORDER BY MaPhong DESC");
                    }
                }
                else if (sapxeptheo == "Xếp theo độ ưu tiên")
                {
                    if (tanggiam == true)//tăng
                    {
                        dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                  "AND (TinhTrang = N'Phòng đang thuê' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') " +
                   "ORDER BY UuTienHienThi");

                    }
                    else// giảm
                    {
                        dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                   "AND (TinhTrang = N'Phòng đang thuê' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') " +
                   "ORDER BY UuTienHienThi DESC");
                    }
                }
                else
                {
                    dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                  "AND (TinhTrang = N'Phòng đang thuê' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') ");


                }
            }
            else
            {
                if (sapxeptheo == "Xếp theo tên")
                {
                    if (tanggiam == true)//tăng
                    {
                        dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                   "AND (TinhTrang = N'Phòng đang thuê' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') " +
                   "AND MaPhong LIKE '%" + valueFind + "%' " +
                   "ORDER BY MaPhong");
                    }
                    else// giảm
                    {
                        dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                   "AND (TinhTrang = N'Phòng đang thuê' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') " +
                   "AND MaPhong LIKE '%" + valueFind + "%' " +
                   "ORDER BY MaPhong DESC");
                    }
                }
                else if (sapxeptheo == "Xếp theo độ ưu tiên")
                {
                    if (tanggiam == true)//tăng
                    {
                        dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                  "AND (TinhTrang = N'Phòng đang thuê' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') " +
                   "AND MaPhong LIKE '%" + valueFind + "%' " +
                   "ORDER BY UuTienHienThi");

                    }
                    else// giảm
                    {
                        dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                   "AND (TinhTrang = N'Phòng đang thuê' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') " +
                   "AND MaPhong LIKE '%" + valueFind + "%' " +
                   "ORDER BY UuTienHienThi DESC");
                    }
                }
                else
                {
                    dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                   "AND MaPhong LIKE '%" + valueFind + "%' " +
                   "AND (TinhTrang = N'Phòng đang thuê' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') ");



                }
            }
            foreach (DataRow data in dtPhong.Rows)
            {
                foreach (DataRow dataHD in phongBUS.GetPhong("SELECT * FROM HoaDon " +
                    "WHERE MaPhong = '" + data["MaPhong"].ToString() + "' " +
                    "AND (ThoiGianKetThuc IS NULL OR ThoiGianKetThuc = '')").Rows)
                {
                    DateTime dtBatDau = DateTime.Parse(dataHD["ThoiGianBatDau"].ToString(), new CultureInfo("en-CA"));
                    taoPanelPhong(data["MaPhong"].ToString(), dataHD["MaHoaDon"].ToString(),
                        dtBatDau.ToString("yyyy-MM-dd HH:mm:ss"), dataHD["GhiChu"].ToString());
                    this.pnlLoaiPhong.Controls.Add(this.pnlPhong);
                }
            }
        }
        private void taoLabelLoaiPhong(string maloaiphong, string tenloaiphong)
        {
            this.lblLoaiPhong = new Label();
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.lblLoaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(10, 10);
            this.lblLoaiPhong.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lblLoaiPhong.MinimumSize = new System.Drawing.Size(800, 50);
            this.lblLoaiPhong.Name = "lbl" + maloaiphong;
            this.lblLoaiPhong.Size = new System.Drawing.Size(800, 50);
            this.lblLoaiPhong.TabIndex = 0;
            this.lblLoaiPhong.Text = tenloaiphong;
        }
        private void taoPanelPhong(string maphong, string mahoadon, string thoigianbatdau, string ghichu)
        {
            taoPanelBottomPhong(maphong, thoigianbatdau, ghichu);
            taoPanelTopPhong(maphong, mahoadon);
            this.pnlPhong = new FlowLayoutPanel();
            this.pnlPhong.Controls.Add(this.pnlTopPhong);
            this.pnlPhong.Controls.Add(this.pnlBottomPhong);
            this.pnlPhong.Location = new System.Drawing.Point(10, 63);
            this.pnlPhong.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnlPhong.Name = "pnl" + maphong;
            this.pnlPhong.Size = new System.Drawing.Size(255, 150);
            this.pnlPhong.TabIndex = 1;
        }
        private void taoPanelTopPhong(string maphong, string mahoadon)
        {
            taoLabelTenPhong(maphong);
            taoBtnOption(mahoadon);
            taoBtnYCDonPhong(maphong);

            this.pnlTopPhong = new Panel();
            this.pnlTopPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopPhong.Controls.Add(this.btnYCDonPhong);
            this.pnlTopPhong.Controls.Add(this.btnOption);
            this.pnlTopPhong.Controls.Add(this.lblTenPhong);
            this.pnlTopPhong.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPhong.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTopPhong.Name = "pnlTop" + maphong;
            this.pnlTopPhong.Size = new System.Drawing.Size(255, 50);
            this.pnlTopPhong.TabIndex = 0;

        }



        private void taoLabelTenPhong(string maphong)
        {
            this.lblTenPhong = new Label();
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTenPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.lblTenPhong.Location = new System.Drawing.Point(0, 0);
            this.lblTenPhong.Margin = new System.Windows.Forms.Padding(7, 7, 0, 0);
            this.lblTenPhong.Name = "lbl" + maphong;
            this.lblTenPhong.Size = new System.Drawing.Size(79, 32);
            this.lblTenPhong.TabIndex = 0;
            this.lblTenPhong.Text = maphong;
        }
        private void taoBtnOption(string mahoadon)
        {
            this.btnOption = new Button();
            this.btnOption.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOption.Image = Image.FromFile
                (Path.GetFullPath(@"icon\single_choice_40px.png"));
            this.btnOption.Location = new System.Drawing.Point(203, 0);
            this.btnOption.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnOption.Name = "btn" + mahoadon;
            this.btnOption.Size = new System.Drawing.Size(50, 50);
            this.btnOption.TabIndex = 1;
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(clickChonOption);

        }


        private void taoBtnYCDonPhong(string maphong)
        {
            this.btnYCDonPhong = new Button();
            this.btnYCDonPhong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnYCDonPhong.Image = Image.FromFile
                (Path.GetFullPath(@"icon\requirement_red_30px.png"));
            this.btnYCDonPhong.Location = new System.Drawing.Point(153, 0);
            this.btnYCDonPhong.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnYCDonPhong.Name = "btnYCDP" + maphong;
            this.btnYCDonPhong.Size = new System.Drawing.Size(50, 50);
            this.btnYCDonPhong.TabIndex = 2;
            this.btnYCDonPhong.UseVisualStyleBackColor = true;
            foreach (DataRow dt in phongBUS.GetPhong(
               "SELECT TinhTrang " +
               "FROM Phong " +
               "WHERE MaPhong = '" + maphong + "'").Rows)
            {
                if (dt["TinhTrang"].ToString() == "Phòng đang thuê - Cần dọn")
                {
                    btnYCDonPhong.Visible = true;
                }
                else
                {
                    btnYCDonPhong.Visible = false;
                }
            }
        }

        private void yêuCầuDọnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string maphong = "";
            foreach (DataRow dt in hoaDonBUS.GetHoaDon(
                "SELECT MaPhong " +
                "FROM HoaDon " +
                "WHERE MaHoaDon = '" + contextMenuStrip1.Tag.ToString().Substring(3) + "'").Rows)
            {
                maphong = dt["MaPhong"].ToString();
            }
            if (phongBUS.SuaPhong(maphong, "Phòng đang thuê - Cần dọn"))
            {
                MessageBox.Show("Yêu cầu dọn phòng thành công");
                pnlPhongDangThue.Controls.Clear();
                LoadPhongDangThue();
            }
            else
            {
                MessageBox.Show("Yêu cầu dọn phòng thất bại");
            }
        }

        private void taoPanelBottomPhong(string maphong, string time, string note)
        {
            taoButtonTime();
            taoLabelTime(maphong, time);
            taoButtonNote();
            taoLabelNote(maphong, note);
            this.pnlBottomPhong = new FlowLayoutPanel();
            this.pnlBottomPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottomPhong.Controls.Add(this.btnTime);
            this.pnlBottomPhong.Controls.Add(this.lblTime);
            this.pnlBottomPhong.Controls.Add(this.btnNote);
            this.pnlBottomPhong.Controls.Add(this.lblNote);
            this.pnlBottomPhong.Location = new System.Drawing.Point(0, 50);
            this.pnlBottomPhong.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottomPhong.Name = "pnlBottom" + maphong;
            this.pnlBottomPhong.Size = new System.Drawing.Size(255, 100);
            this.pnlBottomPhong.TabIndex = 1;
        }
        private void taoButtonTime()
        {
            this.btnTime = new Button();
            this.btnTime.Image = Image.FromFile
                  (Path.GetFullPath(@"icon\time_30px.png"));
            this.btnTime.Location = new System.Drawing.Point(3, 10);
            this.btnTime.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnTime.Name = "button3";
            this.btnTime.Size = new System.Drawing.Size(30, 30);
            this.btnTime.TabIndex = 0;
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Enabled = false;
        }
        private void taoLabelTime(string maphong, string thoigianbatdau)
        {
            this.lblTime = new Label();
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(46, 10);
            this.lblTime.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblTime.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblTime.Name = "lblTime" + maphong;
            this.lblTime.Size = new System.Drawing.Size(200, 28);
            this.lblTime.TabIndex = 1;
            DateTime now = DateTime.Now;

           DateTime dateBatDau = DateTime.Parse(thoigianbatdau, CultureInfo.CreateSpecificCulture("en-US"));
           TimeSpan diff = now-dateBatDau;
            if (diff.Days > 0)
            {
                this.lblTime.Text = diff.Days + " ngày " + diff.Hours + " giờ";
            }
            else if (diff.Hours > 0)
            {
                this.lblTime.Text = diff.Hours + " giờ" + diff.Minutes + " phút";

            }
            else
            {
                this.lblTime.Text = diff.Minutes + " phút";
            }
          //  this.lblTime.Text = thoigianbatdau;
            //Lấy thoigianhientai - thoigianbatdau
        }
        private void taoButtonNote()
        {
            this.btnNote = new Button();
            this.btnNote.Image = Image.FromFile
                  (Path.GetFullPath(@"icon\note_25px.png"));
            this.btnNote.Location = new System.Drawing.Point(3, 75);
            this.btnNote.Name = "button5";
            this.btnNote.Size = new System.Drawing.Size(30, 30);
            this.btnNote.TabIndex = 4;
            this.btnNote.Enabled = false;
            this.btnNote.UseVisualStyleBackColor = true;
        }
        private void taoLabelNote(string maphong, string note)
        {
            this.lblNote = new Label();
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(46, 75);
            this.lblNote.Margin = new System.Windows.Forms.Padding(10, 3, 3, 0);
            this.lblNote.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblNote.Name = "lblNote" + maphong;
            this.lblNote.Size = new System.Drawing.Size(200, 28);
            this.lblNote.TabIndex = 5;
            if (note == "" || note == null)
            {
                this.lblNote.Text = "Không có ghi chú";
            }
            else
            {
                this.lblNote.Text = note;
            }
        }
        private void clickChonOption(object sender, EventArgs e)
        {
            contextMenuStrip1.Show((Button)sender, 0, 0);
            contextMenuStrip1.Tag = ((Button)sender).Name;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogSuaPhongThue dialogSuaPhongThue = new dialogSuaPhongThue(contextMenuStrip1.Tag.ToString().Substring(3));
            dialogSuaPhongThue.Show();

        }
        private void traPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogTraPhong dialogTraPhong = new dialogTraPhong(contextMenuStrip1.Tag.ToString().Substring(3), "Thêm");
            dialogTraPhong.Show();
            pnlPhongDangThue.Controls.Clear();
            LoadPhongDangThue();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hoaDonBUS.XoaHoaDon(contextMenuStrip1.Tag.ToString().Substring(3)))
            {
                MessageBox.Show("Xóa thành công");
                pnlPhongDangThue.Controls.Clear();
                LoadPhongDangThue();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        MenuBUS menuBUS = new MenuBUS();
        HoaDon_MenuBUS hoaDon_MenuBUS = new HoaDon_MenuBUS();
        


    }

}
