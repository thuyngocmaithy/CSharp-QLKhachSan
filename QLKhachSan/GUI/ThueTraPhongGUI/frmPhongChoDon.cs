using QLKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    public partial class frmPhongChoDon : Form
    {
        FlowLayoutPanel pnlLoaiPhong, pnlPhong;
        Label lblTenLoaiPhong, lblTenPhong, lblTrangThai;
        Panel pnlTopPhong;
        Button btnOption;
        LoaiPhongBUS loaiPhongBUS = new LoaiPhongBUS();
        PhongBUS phongBUS = new PhongBUS();
        string sapxeptheo = "", valueFind = "";
        Boolean tanggiam = true;
        public frmPhongChoDon(string sapxeptheo, Boolean tanggiam, string valueFind)
        {
            InitializeComponent();
            this.sapxeptheo = sapxeptheo;
            this.tanggiam = tanggiam;
            this.valueFind = valueFind;
        }

        private void frmPhongChoDon_Load(object sender, EventArgs e)
        {
            loadPanelPhongChoDon();
        }
        private void loadPanelPhongChoDon()
        {
           
            foreach (DataRow data in loaiPhongBUS.GetLoaiPhong().Rows)
            {
                taoPanelLoaiPhong(data["MaLoaiPhong"].ToString(), data["TenLoaiPhong"].ToString());
                pnlPhongChoDon.Controls.Add(pnlLoaiPhong);
            }
        }
        private void taoPanelLoaiPhong(string maloaiphong, string tenloaiphong)
        {
            taoLabelTenLoaiPhong(maloaiphong, tenloaiphong);
            pnlLoaiPhong = new FlowLayoutPanel();
            this.pnlLoaiPhong.Controls.Add(this.lblTenLoaiPhong);
            pnlLoaiPhong.BorderStyle = BorderStyle.FixedSingle;
            this.pnlLoaiPhong.AutoScroll = true;
            this.pnlLoaiPhong.Location = new System.Drawing.Point(0, 0);
            this.pnlLoaiPhong.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlLoaiPhong.Name = "pnl" + maloaiphong;
            this.pnlLoaiPhong.Size = new System.Drawing.Size(870, 200);
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
                   "AND (TinhTrang = N'Phòng chờ dọn' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') " +
                   "ORDER BY MaPhong");
                    }
                    else// giảm
                    {
                        dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                   "AND (TinhTrang = N'Phòng chờ dọn' " +
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
                   "AND (TinhTrang = N'Phòng chờ dọn' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') " +
                   "ORDER BY UuTienHienThi");

                    }
                    else// giảm
                    {
                        dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                   "AND (TinhTrang = N'Phòng chờ dọn' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') " +
                   "ORDER BY UuTienHienThi DESC");
                    }
                }
                else
                {
                    dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                   "AND (TinhTrang = N'Phòng chờ dọn' " +
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
                   "AND (TinhTrang = N'Phòng chờ dọn' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') " +
                   "AND MaPhong LIKE '%" + valueFind + "%' " +
                   "ORDER BY MaPhong");
                    }
                    else// giảm
                    {
                        dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                   "AND (TinhTrang = N'Phòng chờ dọn' " +
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
                 "AND (TinhTrang = N'Phòng chờ dọn' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') " +
                   "AND MaPhong LIKE '%" + valueFind + "%' " +
                   "ORDER BY UuTienHienThi");

                    }
                    else// giảm
                    {
                        dtPhong = phongBUS.GetPhong("SELECT * FROM Phong " +
                   "WHERE MaLoaiPhong = '" + maloaiphong + "' " +
                  "AND (TinhTrang = N'Phòng chờ dọn' " +
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
                 "AND (TinhTrang = N'Phòng chờ dọn' " +
                   "OR TinhTrang = N'Phòng đang thuê - Cần dọn') ");



                }
            }
            foreach (DataRow data in dtPhong.Rows)
            {
                taoPanelPhong(data["MaPhong"].ToString(), data["TinhTrang"].ToString());
                this.pnlLoaiPhong.Controls.Add(this.pnlPhong);

            }
        }
        private void taoLabelTenLoaiPhong(string maloaiphong, string tenloaiphong)
        {
            lblTenLoaiPhong = new Label();
            this.lblTenLoaiPhong.AutoSize = true;
            this.lblTenLoaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.lblTenLoaiPhong.Location = new System.Drawing.Point(10, 10);
            this.lblTenLoaiPhong.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lblTenLoaiPhong.MinimumSize = new System.Drawing.Size(800, 50);
            this.lblTenLoaiPhong.Name = "lbl" + maloaiphong;
            this.lblTenLoaiPhong.Size = new System.Drawing.Size(800, 50);
            this.lblTenLoaiPhong.TabIndex = 0;
            this.lblTenLoaiPhong.Text = tenloaiphong;
        }
        private void taoPanelPhong(string maphong, string trangthai)
        {
            taoPanelTopPhong(maphong);
            taoLabelTrangThai(trangthai);
            pnlPhong = new FlowLayoutPanel();
            pnlPhong.BorderStyle = BorderStyle.FixedSingle;
            this.pnlPhong.Controls.Add(this.pnlTopPhong);
            this.pnlPhong.Controls.Add(this.lblTrangThai);
            this.pnlPhong.Location = new System.Drawing.Point(10, 63);
            this.pnlPhong.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnlPhong.Name = "pnl" + maphong;
            this.pnlPhong.Size = new System.Drawing.Size(200, 130);
            this.pnlPhong.TabIndex = 1;
        }
        private void taoPanelTopPhong(string maphong)
        {
            taoLabelTenPhong(maphong);
            taoButtonOption(maphong);
            pnlTopPhong = new Panel();
            this.pnlTopPhong.Controls.Add(this.btnOption);
            this.pnlTopPhong.Controls.Add(this.lblTenPhong);
            this.pnlTopPhong.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPhong.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTopPhong.Name = "pnlTop" + maphong;
            this.pnlTopPhong.Size = new System.Drawing.Size(200, 50);
            this.pnlTopPhong.TabIndex = 3;
        }
        private void taoLabelTenPhong(string maphong)
        {
            lblTenPhong = new Label();
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.lblTenPhong.Location = new System.Drawing.Point(5, 5);
            this.lblTenPhong.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblTenPhong.MinimumSize = new System.Drawing.Size(50, 30);
            this.lblTenPhong.Name = "lbl" + maphong;
            this.lblTenPhong.Size = new System.Drawing.Size(50, 32);
            this.lblTenPhong.TabIndex = 2;
            this.lblTenPhong.Text = maphong;
        }       
        private void taoButtonOption(string maphong)
        {
            btnOption = new Button();
            this.btnOption.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOption.Image = Image.FromFile
               (Path.GetFullPath(@"icon\single_choice_40px.png"));
            this.btnOption.Location = new System.Drawing.Point(150, 0);
            this.btnOption.Name = "btn" + maphong;
            this.btnOption.Size = new System.Drawing.Size(50, 50);
            this.btnOption.TabIndex = 3;
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(clickChonOption);

        }
        private void taoLabelTrangThai(string trangthai)
        {
            lblTrangThai = new Label();
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(3, 60);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTrangThai.Size = new System.Drawing.Size(144, 28);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = trangthai;
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));

        }
        private void clickChonOption(object sender, EventArgs e)
        {
            contextMenuStrip1.Show((Button)sender, 0, 0);
            contextMenuStrip1.Tag = ((Button)sender).Name;
        }
        private void donPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(DataRow dt in phongBUS.GetPhong(
                "SELECT TinhTrang " +
                "FROM Phong " +
                "WHERE MaPhong = '"+ contextMenuStrip1.Tag.ToString().Substring(3) + "'").Rows)
            {
                if (dt["TinhTrang"]=="Phòng chờ dọn")
                {
                    if (phongBUS.SuaPhong(contextMenuStrip1.Tag.ToString().Substring(3), "Phòng chờ"))
                    {
                        MessageBox.Show("Đã dọn phòng");
                        pnlPhongChoDon.Controls.Clear();
                        loadPanelPhongChoDon();
                    }
                    else
                        MessageBox.Show("Dọn phòng thất bại");
                } 
                else
                {
                    if (phongBUS.SuaPhong(contextMenuStrip1.Tag.ToString().Substring(3), "Phòng đang thuê"))
                    {
                        MessageBox.Show("Đã dọn phòng");
                        pnlPhongChoDon.Controls.Clear();
                        loadPanelPhongChoDon();
                    }
                    else
                        MessageBox.Show("Dọn phòng thất bại");
                }    
            }    

           
        }

    }
}
