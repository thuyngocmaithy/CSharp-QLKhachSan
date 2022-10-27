using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace QLKhachSan.GUI.QLHeThongGUI.QLPhongGUI
{
    public partial class dialogThemPhong : Form

    { 
        DBConnect dBConnect = new DBConnect();
        LoaiPhongBUS loaiPhongBUS = new LoaiPhongBUS();
        PhongBUS phongBUS = new PhongBUS();
        public dialogThemPhong()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemLoaiPhong_Click(object sender, EventArgs e)
        {

            if (cmbLoaiPhong.Text != "" && cmbTinhTrang.Text != "" &&
                txtThemSoKhachToiDa.Text != "" && cmbCachTinhTien.Text != "" && txtThemUuTienHienThi.Text != "")
            {
                int uutienhienthi = 1;
                string ma = phongBUS.TaoMaPhong();
                // Tạo DTO
                if (txtThemUuTienHienThi.Text == "")
                {
                    uutienhienthi = 1;
                }
                else
                    uutienhienthi = int.Parse(txtThemUuTienHienThi.Text);
                string maloaiphong = cmbLoaiPhong.GetItemText(cmbLoaiPhong.SelectedValue);
                string tinhtrang = cmbTinhTrang.GetItemText(cmbTinhTrang.SelectedItem);
                string macachtinhtien = cmbCachTinhTien.GetItemText(cmbCachTinhTien.SelectedValue);
                PhongDTO p = new PhongDTO(ma, maloaiphong, tinhtrang, int.Parse(txtThemSoKhachToiDa.Text), macachtinhtien, uutienhienthi);             


                // Them
                if (phongBUS.ThemPhong(p))
                {
                    MessageBox.Show("Thêm thành công");
                    cmbLoaiPhong.ResetText();
                    cmbTinhTrang.ResetText();
                    txtThemSoKhachToiDa.ResetText();
                    cmbCachTinhTien.ResetText();
                    txtThemUuTienHienThi.ResetText();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");

            }

        }

        private void dialogThemPhong_Load(object sender, EventArgs e)
        {
            //Add Item Loại phòng
            GetLoaiPhongToCmb();
            //Add Item Tình trạng
            GetTinhTrangToCmb();
            cmbTinhTrang.SelectedItem = "Đã dọn phòng";

            //Add Item Cách tính tiền
            GetCachTinhTienToCmb();
        }
        public void GetLoaiPhongToCmb()

        {
            DBConnect db = new DBConnect();
            
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LoaiPhong", db.conn);
                DataTable dt = new DataTable();
                int i = da.Fill(dt);
                if (i > 0)
                {
                    DataRow row = dt.NewRow();
                    row["TenLoaiPhong"] = "Chọn loại phòng";
                    dt.Rows.InsertAt(row, 0);
                    cmbLoaiPhong.DataSource = dt;
                    cmbLoaiPhong.DisplayMember = "TenLoaiPhong";
                    cmbLoaiPhong.ValueMember = "MaLoaiPhong";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetTinhTrangToCmb()
        {
            cmbTinhTrang.Items.Add("Phòng chờ");
            cmbTinhTrang.Items.Add("Phòng đang thuê");
            cmbTinhTrang.Items.Add("Phòng chờ dọn");
        }
        public void GetCachTinhTienToCmb()
        {
            DBConnect db = new DBConnect();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CachTinhTien", db.conn);
                DataTable dt = new DataTable();
                int i = da.Fill(dt);
                if (i > 0)
                {
                    DataRow row = dt.NewRow();
                    row["TenCachTinhTien"] = "Chọn loại cách tính tiền";
                    dt.Rows.InsertAt(row, 0);
                    cmbCachTinhTien.DataSource = dt;
                    cmbCachTinhTien.DisplayMember = "TenCachTinhTien";
                    cmbCachTinhTien.ValueMember = "MaCachTinhTien";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
