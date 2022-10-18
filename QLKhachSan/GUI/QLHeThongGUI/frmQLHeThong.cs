using QLKhachSan.BUS;
using QLKhachSan.DTO;
using QLKhachSan.GUI.QLHeThongGUI.QLLoaiPhongGUI;
using QLKhachSan.GUI.QLHeThongGUI.QLPhongGUI;
using QLKhachSan.GUI.QLHeThongGUI.ThietLapKhacGUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QLKhachSan.GUI.QLHeThongGUI
{
    public partial class frmQLHeThong : Form
    {
        Button btnChucNang;
        CTChucNangBUS CTChucNangBUS= new CTChucNangBUS();
        public frmQLHeThong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmQLLoaiPhong frmQLLoaiPhong = new frmQLLoaiPhong();
            frmQLLoaiPhong.TopLevel = false;
            frmQLLoaiPhong.AutoScroll = true;
            this.Controls.Add(frmQLLoaiPhong);
            frmQLLoaiPhong.Show();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmQLPhong frmQLPhong = new frmQLPhong();
            frmQLPhong.TopLevel = false;
            frmQLPhong.AutoScroll = true;
            this.Controls.Add(frmQLPhong);
            frmQLPhong.Show();
        }


        private void frmQLHeThong_Load(object sender, EventArgs e)
        {

            int vttrai = 0;//giá trị trái ban đầu của button (left)
            int vttren = 0;//giá trị trái ban đầu của button (top)
            foreach (DataRow ctcn in CTChucNangBUS.GetCTChucNang().Rows)                      
            {
                this.btnChucNang = new Button(); //(2) new mới đối tượng,
                pnChucNangHeThong.Controls.Add(btnChucNang); //(3) thêm vào Control của form hiện tại,
                btnChucNang.Left = vttrai; //(4) thông tin vị trí trái (Left)
                btnChucNang.Top = vttren;//(4)thông tin vị trí trên (Top)
                this.btnChucNang.Name = "btn" + ctcn["MaCTCN"].ToString(); //(5) tên button mới
                                                    //(6) Kích thước button mới
                this.btnChucNang.Size = new System.Drawing.Size(350, 75);
                string tenctcn = ctcn["TenCTCN"].ToString();
                this.btnChucNang.Tag = tenctcn;
                btnChucNang.Text = tenctcn;
                btnChucNang.Margin = new Padding(10, 30, 20, 30);
                //vttren = vttren + 35; //Moi button cach nhau 10
                //(chiều cao =20 + khoảng cách =10)
                this.btnChucNang.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnChucNang.Cursor = System.Windows.Forms.Cursors.Hand;
                this.btnChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
                this.btnChucNang.ForeColor = Color.White;
                this.btnChucNang.Click += new System.EventHandler(clickBtnChucNang);


            }
        }
        private void clickBtnChucNang(object sender, EventArgs e)
        {
            switch(((Button)sender).Tag.ToString())
            {
                case "Loại phòng":
                    this.Controls.Clear();
                    frmQLLoaiPhong frmQLLoaiPhong = new frmQLLoaiPhong();
                    frmQLLoaiPhong.TopLevel = false;
                    frmQLLoaiPhong.AutoScroll = true;
                    this.Controls.Add(frmQLLoaiPhong);
                    frmQLLoaiPhong.Show();
                    break;
                case "Phòng":
                    this.Controls.Clear();
                    frmQLPhong frmQLPhong = new frmQLPhong();
                    frmQLPhong.TopLevel = false;
                    frmQLPhong.AutoScroll = true;
                    this.Controls.Add(frmQLPhong);
                    frmQLPhong.Show();
                    break;
                case "Thiết lập khác":
                    this.Controls.Clear();
                    frmThietLapKhac frmThietLapKhac = new frmThietLapKhac();
                    frmThietLapKhac.TopLevel = false;
                    frmThietLapKhac.AutoScroll = true;
                    this.Controls.Add(frmThietLapKhac);
                    frmThietLapKhac.Show();
                    break;

            }    
        }


    }
}
