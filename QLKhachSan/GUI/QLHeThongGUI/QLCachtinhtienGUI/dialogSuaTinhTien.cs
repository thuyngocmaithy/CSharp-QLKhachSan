using Guna.UI2.WinForms;
using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.QLCachtinhtienGUI
{
    public partial class dialogSuaTinhTien : Form
    {
        CachtinhtienBUS cachtinhtienBUS = new CachtinhtienBUS();
        CachTinhTien_CachThueBUS CachTinhTien_CachThueBUS = new CachTinhTien_CachThueBUS();
        Boolean themthanhcong = true;
        Boolean suathanhcong = true;
        string trangthai;
        string macachtinhtien_Sua;
        public dialogSuaTinhTien(string trangthai, string macachtinhtien_Sua)
        {
            InitializeComponent();
            this.trangthai = trangthai;
            this.macachtinhtien_Sua = macachtinhtien_Sua;
        }
        private void dialogSuaTinhTien_Load(object sender, EventArgs e)
        {
            if (trangthai != "Thêm")
            {
                setTextEdit();
            }
            AddCommaToTextBox(txtGia1Gio);
            AddCommaToTextBox(txtGiaNgay);
            AddCommaToTextBox(txtPhuThu);
            AddCommaToTextBox(txtGiaT6);
            AddCommaToTextBox(txtGiaT7);
            AddCommaToTextBox(txtGiaCN);
            AddCommaToTextBox(txtGiaNgayLe);
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
        private void timeNhanPhong_ValueChanged(object sender, EventArgs e)
        {
            timeNhanPhong.CustomFormat = "HH:mm";
        }

        private void timeNhanPhong_MouseDown(object sender, MouseEventArgs e)
        {

            timeNhanPhong.CustomFormat = "HH:mm";
        }

        private void timeTraPhong_ValueChanged(object sender, EventArgs e)
        {
            timeTraPhong.CustomFormat = "HH:mm";
        }

        private void timeTraPhong_MouseDown(object sender, MouseEventArgs e)
        {

            timeTraPhong.CustomFormat = "HH:mm";
        }
        private void setTextEdit()
        {
            foreach (DataRow dtCtt in cachtinhtienBUS.GetCachTinhTien(
                    "SELECT * " +
                    "FROM CachTinhTien " +
                    "WHERE MaCachTinhTien = '" + macachtinhtien_Sua + "'").Rows)
            {
                txtTenCachTinh.Text = dtCtt["TenCachTinhTien"].ToString();
                txtPhuThu.Text = dtCtt["PhuThuQuaGio"].ToString();
                txtSoPhutLamTron.Text = dtCtt["SoPhutLamTronThanh1Gio"].ToString();
                string[] giangaycuoituanvangayle = dtCtt["GiaThueCuoiTuanVaNgayLe"].ToString().Split('-');
                txtGiaT6.Text = giangaycuoituanvangayle[0];
                txtGiaT7.Text = giangaycuoituanvangayle[1];
                txtGiaCN.Text = giangaycuoituanvangayle[2];
                txtGiaNgayLe.Text = giangaycuoituanvangayle[3];
                foreach (DataRow dtTt in CachTinhTien_CachThueBUS.GetCachTinhTien_CachThue(
                    "SELECT * " +
                    "FROM CachTinhTien_CachThue " +
                    "WHERE MaCachTinhTien = '" + dtCtt["MaCachTinhTien"].ToString() + "'").Rows)
                {
                    if (dtTt["MaCachThue"].ToString() == "CT001")
                    {
                        txtGia1Gio.Text = dtTt["GiaTheoCachThue"].ToString();
                    }
                    if (dtTt["MaCachThue"].ToString() == "CT002")
                    {
                        DateTime timenhanphong = DateTime.Parse(dtTt["GioNhanPhong"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                        timeNhanPhong.Value = timenhanphong;
                        DateTime timetraphong = DateTime.Parse(dtTt["GioTraPhong"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                        timeTraPhong.Value = timetraphong;
                        txtGiaNgay.Text = dtTt["GiaTheoCachThue"].ToString();
                    }
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string macachtinhtien = cachtinhtienBUS.TaoMaCachTinhtien();
            string tencachtinhtien = txtTenCachTinh.Text;
            string phuthu = txtPhuThu.Text;
            int sophutlamtron = int.Parse(txtSoPhutLamTron.Text);
            string giacuoituan_ngayle = txtGiaT6.Text + "-" + txtGiaT7.Text + "-" + txtGiaCN.Text + "-" + txtGiaNgayLe.Text;
            CachTinhTienDTO ctt = new CachTinhTienDTO(macachtinhtien, tencachtinhtien, giacuoituan_ngayle, phuthu , sophutlamtron);

            if (trangthai == "Thêm")
            {
                if (cachtinhtienBUS.ThemCachTinhTien(ctt))
                {
                    LuuCachTinhTien_CachThue(macachtinhtien);
                }
                else
                {
                    themthanhcong = false;
                //    MessageBox.Show("Lỗi 4");
                }
                if (themthanhcong)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {

                if (cachtinhtienBUS.SuaCachTinhtien(ctt))
                {
                    LuuCachTinhTien_CachThue(macachtinhtien);
                }
                else
                {
                    suathanhcong = false;
                }
                if (suathanhcong)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
        }

        private void LuuCachTinhTien_CachThue(string macachtinhtien)
        {
            string gia1gio = txtGia1Gio.Text;
            string giangay = txtGiaNgay.Text;
            string timenhanphong = timeNhanPhong.Value.ToString("HH:mm:ss");
            string timetraphong = timeTraPhong.Value.ToString("HH:mm:ss");

            if (gia1gio != "")
            {
                CachTinhTien_CachThueDTO tt1 = new CachTinhTien_CachThueDTO(macachtinhtien, "CT001", gia1gio, timenhanphong, timetraphong);
                CachTinhTien_CachThueDTO tt2 = new CachTinhTien_CachThueDTO(macachtinhtien, "CT002", giangay, timenhanphong, timetraphong);

                if (trangthai == "Thêm")
                {
                    if (!CachTinhTien_CachThueBUS.ThemCachTinhTien_CachThue(tt1))
                    {
                        themthanhcong = false;
                  //      MessageBox.Show("Lỗi 3");
                    }
                    if (!CachTinhTien_CachThueBUS.ThemCachTinhTien_CachThue(tt2))
                    {
                        themthanhcong = false;
                    //    MessageBox.Show("Lỗi 2");
                    }
                }
                else
                {
                    if (!CachTinhTien_CachThueBUS.SuaCachTinhTien_CachThue(tt1))
                    {
                        suathanhcong = false;
                    }
                    if (!CachTinhTien_CachThueBUS.SuaCachTinhTien_CachThue(tt2))
                    {
                        suathanhcong = false;
                    }
                }

            }
            else
            {
                CachTinhTien_CachThueDTO tt2 = new CachTinhTien_CachThueDTO(macachtinhtien, "CT002", giangay, timenhanphong, timetraphong);
                if (trangthai == "Thêm")
                {
                    if (!CachTinhTien_CachThueBUS.ThemCachTinhTien_CachThue(tt2))
                    {
                        themthanhcong = false;
                   //     MessageBox.Show("Lỗi 1");
                    }
                }
                else
                {
                    if (!CachTinhTien_CachThueBUS.SuaCachTinhTien_CachThue(tt2))
                    {
                        suathanhcong = false;
                    }
                }

            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModeThueTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (ModeThueTheoNgay.Checked == true)
            {
                pnlThueTheoGio.Visible = false;
                pnlBottom.Location = new System.Drawing.Point(20, 84);
            }
            else
            {
                pnlThueTheoGio.Visible = true;
                pnlBottom.Location = new System.Drawing.Point(20, 224);
            }
        }

        private void txtGia1Gio_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtGia1Gio);
        }

        private void txtGiaNgay_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtGiaNgay);
        }

        private void txtPhuThu_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtPhuThu);
        }

        private void txtGiaT6_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtGiaT6);
        }

        private void txtGiaT7_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtGiaT7);
        }

        private void txtGiaCN_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtGiaCN);
        }

        private void txtGiaNgayLe_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtGiaNgayLe);
        }

        private void txtGia1Gio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaNgay_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSoPhutLamTron_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaT6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaCN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaT7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaNgayLe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

 
    }
