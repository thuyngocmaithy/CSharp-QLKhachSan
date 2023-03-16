using QLKhachSan.BUS;
using QLKhachSan.DTO;
using QLKhachSan.GUI.QLHeThongGUI.QLLoaiPhongGUI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.QLPhongGUI
{
    public partial class dialogSuaPhong : Form
    {
        PhongBUS phongBUS = new PhongBUS();
        string maphong, maloaiphong, tinhtrang, sokhachtoida, macachtinhtien, uutienhienthi;
        frmQLLoaiPhong frmQLLoaiPhong = new frmQLLoaiPhong();


        public dialogSuaPhong(string maphong, string maloaiphong, string trangthai, string sokhachtoida,
            string macachtinhtien, string uutienhienthi)
        {
            InitializeComponent();
            this.maphong = maphong;
            this.maloaiphong = maloaiphong;
            this.tinhtrang = trangthai;
            this.sokhachtoida = sokhachtoida;
            this.macachtinhtien = macachtinhtien;
            this.uutienhienthi = uutienhienthi;
        }

        private void dialogSuaPhong_Load(object sender, EventArgs e)
        {
            GetCachTinhTienToCmb();
            GetTinhTrangToCmb();
            GetLoaiPhongToCmb();
            cmbLoaiPhong.SelectedValue = maloaiphong;
            cmbTinhTrang.SelectedItem = tinhtrang;
            txtSuaSoKhachToiDa.Text = sokhachtoida;
            cmbCachTinhTien.SelectedValue = macachtinhtien;
            txtSuaUuTienHienThi.Text = uutienhienthi;
        }

        private void txtSuaSoKhachToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSuaUuTienHienThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            maloaiphong = cmbLoaiPhong.GetItemText(cmbLoaiPhong.SelectedValue);
            tinhtrang = cmbTinhTrang.GetItemText(cmbTinhTrang.SelectedItem);
            macachtinhtien = cmbCachTinhTien.GetItemText(cmbCachTinhTien.SelectedValue);
            if (maloaiphong != "Chọn loại phòng" && macachtinhtien != "Chọn cách tính tiền" && txtSuaSoKhachToiDa.Text != "")
            {
                int uutienhienthi = 1;
                // Tạo DTO
                if (txtSuaUuTienHienThi.Text == "")
                {
                    uutienhienthi = 1;
                }
                else
                    uutienhienthi = int.Parse(txtSuaUuTienHienThi.Text);
                PhongDTO p = new PhongDTO(maphong, maloaiphong, tinhtrang, int.Parse(txtSuaSoKhachToiDa.Text), macachtinhtien, uutienhienthi);


                // Sua
                if (phongBUS.SuaPhong(p))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập tên loại phòng");

            }
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
