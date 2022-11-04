using Bunifu.Framework.UI;
using Guna.UI2.WinForms;
using QLKhachSan.BUS;
using QLKhachSan.DTO;
using QLKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace QLKhachSan.GUI.DatPhongGUI
{
    public partial class dialogThemPhieuDatPhong : Form
    {
        CheckError checkError = new CheckError();
        Boolean themthanhcong = true;
        Boolean suathanhcong = true;
        BunifuFlatButton btnPhongChon;
        LoaiPhongBUS loaiPhongBUS = new LoaiPhongBUS();
        PhieuDatPhongBUS phieuDatPhongBUS = new PhieuDatPhongBUS();
        CTPDP_LoaiPhongBUS CTPDP_LoaiPhongBUS = new CTPDP_LoaiPhongBUS();
        CTPDP_PhongBUS CTPDP_PhongBUS = new CTPDP_PhongBUS();
        List<string> lsPhongChon;
        string maphieudatphong, maphieudatphongsua;
        string trangthai;
        public dialogThemPhieuDatPhong(string trangthai)
        {
            InitializeComponent();
            this.trangthai = trangthai;
        }
        public dialogThemPhieuDatPhong(string trangthai, string maphieudatphong)
        {
            InitializeComponent();
            this.trangthai = trangthai;
            this.maphieudatphongsua = maphieudatphong;
        }
        private void SetLsPhongChon()
        {
            lsPhongChon = new List<string>();
            foreach (DataRow data in CTPDP_PhongBUS.GetCTPDP_Phong(
                "SELECT * FROM CTPhieuDatPhong_Phong" +
                " WHERE MaPhieuDatPhong = '" + maphieudatphongsua + "'").Rows)
            {

                lsPhongChon.Add(data["MaPhong"].ToString());
            }
        }
        private void setTextFormEdit()
        {
            foreach (DataRow dt in phieuDatPhongBUS.GetPhieuDatPhong(
                "SELECT * FROM PhieuDatPhong" +
                " WHERE MaPhieuDatPhong = '" + maphieudatphongsua + "'").Rows)
            {
                txtHoTen.Text = dt["HoTenKhachHang"].ToString();
                txtSoDienThoai.Text = dt["SoDienThoai"].ToString();
                txtTienTraTruoc.Text = dt["TienTraTruoc"].ToString();
                txtGhiChu.Text = dt["GhiChu"].ToString();
                txtTrangThai.Text = dt["TrangThai"].ToString();
                DateTime datengaynhan = DateTime.Parse(dt["NgayNhanPhong"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                dateNgayNhan.Value = datengaynhan;
                DateTime datengaytra = DateTime.Parse(dt["NgayTraPhong"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                dateNgayTra.Value = datengaytra;
            }
            SetLsPhongChon();
            foreach (var ls in lsPhongChon)
            {
                taoButtonPhongChon(ls);
            }
            dgvLoaiPhong.DataSource = CTPDP_LoaiPhongBUS.GetCTPDP_LoaiPhong(
"SELECT TenLoaiPhong, SLPhong" +
" FROM LoaiPhong AS lp" +
" LEFT OUTER JOIN(SELECT * FROM CTPhieuDatPhong_LoaiPhong WHERE MaPhieuDatPhong = '" + maphieudatphongsua + "') as ct" +
" ON lp.MaLoaiPhong = ct.MaLoaiPhong");

        }
        public void AddCommaToTextBox(Guna2TextBox guna2TextBox)
        {
            string value = guna2TextBox.Text.Replace(",", "")
                .Replace("đ", "").Replace(".", "").TrimStart('0');
            MessageBox.Show(value);
            decimal ul;
            if (decimal.TryParse(value, out ul))
            {
                guna2TextBox.Text = string.Format("{0:#,###}", ul);
                var length = guna2TextBox.Text.Length;
                guna2TextBox.SelectionStart = length;
            }
        }
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            dialogDsPhong dialogDsPhong = new dialogDsPhong();
            if (dialogDsPhong.ShowDialog() == DialogResult.OK)
            {
                lsPhongChon = dialogDsPhong.LsPhong;
                foreach (var ls in lsPhongChon)
                {
                    taoButtonPhongChon(ls);
                }
            }

        }
        private void taoButtonPhongChon(string name)
        {
            btnPhongChon = new BunifuFlatButton();
            this.btnPhongChon.Activecolor = System.Drawing.Color.White;
            this.btnPhongChon.AutoSize = false;
            this.btnPhongChon.BackColor = System.Drawing.Color.White;
            this.btnPhongChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhongChon.BorderRadius = 7;
            this.btnPhongChon.ButtonText = name;
            this.btnPhongChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhongChon.DisabledColor = System.Drawing.Color.Gray;
            this.btnPhongChon.Font = new System.Drawing.Font("Segoe UI Black", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongChon.ForeColor = System.Drawing.Color.White;
            this.btnPhongChon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPhongChon.Iconimage = null;
            this.btnPhongChon.Iconimage_right = System.Drawing.Image.FromFile(Path.GetFullPath(@"icon\close_black_26px.png"));
            this.btnPhongChon.Iconimage_right_Selected = null;
            this.btnPhongChon.Iconimage_Selected = null;
            this.btnPhongChon.IconMarginLeft = 0;
            this.btnPhongChon.IconMarginRight = 0;
            this.btnPhongChon.IconRightVisible = true;
            this.btnPhongChon.IconRightZoom = 0D;
            this.btnPhongChon.IconVisible = true;
            this.btnPhongChon.IconZoom = 35D;
            this.btnPhongChon.IsTab = true;
            this.btnPhongChon.Location = new System.Drawing.Point(0, 0);
            this.btnPhongChon.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnPhongChon.MaximumSize = new System.Drawing.Size(96, 45);
            this.btnPhongChon.MinimumSize = new System.Drawing.Size(96, 45);
            this.btnPhongChon.Name = name;
            this.btnPhongChon.Normalcolor = System.Drawing.Color.White;
            this.btnPhongChon.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnPhongChon.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnPhongChon.selected = false;
            this.btnPhongChon.Size = new System.Drawing.Size(96, 45);
            this.btnPhongChon.TabIndex = 20;
            this.btnPhongChon.Text = name;
            this.btnPhongChon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhongChon.Textcolor = System.Drawing.Color.Black;
            this.btnPhongChon.TextFont = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            pnDsPhongChon.Controls.Add(btnPhongChon);
        }

        private void dialogThemPhieuDatPhong_Load(object sender, EventArgs e)
        {
            //SET LABEL
            if (trangthai == "Thêm")
            {
                lblThemSua.Text = "THÊM MỚI";
                txtTrangThai.Text = "Chưa nhận phòng";
                dgvLoaiPhong.DataSource = loaiPhongBUS.GetLoaiPhong("SELECT TenLoaiPhong FROM LoaiPhong");
                dgvLoaiPhong.AllowUserToAddRows = false;
            }
            else
            {
                lblThemSua.Text = "THAY ĐỔI";
                setTextFormEdit();

            }


        }
        private void themPhieuDatPhong_LoaiPhong()
        {
            foreach (DataRow data in loaiPhongBUS.GetLoaiPhong().Rows)
            {
                DataTable dtLoaiPhong = GetDataTableFromDGV(dgvLoaiPhong);
                foreach (DataRow dt in dtLoaiPhong.Rows)
                {
                    if (dt["TenLoaiPhong"].ToString() == data["TenLoaiPhong"].ToString())
                    {
                        int sl = 0;
                        if (dt["SLPhong"].ToString() != "")
                        {
                            sl = Int32.Parse(dt["SLPhong"].ToString());
                        }
                        string mactpdp_lp = CTPDP_LoaiPhongBUS.TaoMaCTPhieuDatPhong_LoaiPhong();
                        string maloaiphong = data["MaLoaiPhong"].ToString();
                        if (trangthai == "Thêm")
                        {
                            CTPDP_LoaiPhongDTO cTPDP_LoaiPhongDTO = new CTPDP_LoaiPhongDTO(maphieudatphong, mactpdp_lp, maloaiphong, sl);
                            if (!CTPDP_LoaiPhongBUS.ThemCTPDP_LoaiPhong(cTPDP_LoaiPhongDTO))
                            {
                                themthanhcong = false;
                            }
                        }
                        else
                        {
                            CTPDP_LoaiPhongDTO cTPDP_LoaiPhongDTO = new CTPDP_LoaiPhongDTO(mactpdp_lp, maphieudatphongsua, maloaiphong, sl);
                            if (!CTPDP_LoaiPhongBUS.SuaCTPDP_LoaiPhong(cTPDP_LoaiPhongDTO))
                            {
                                MessageBox.Show("Sửa tb loại phòng");
                                suathanhcong = false;
                            }
                        }
                    }

                }

            }
        }

        private void themPhieuDatPhong_Phong()
        {

            foreach (var data in lsPhongChon)
            {
                string mactpdp_p = CTPDP_PhongBUS.TaoMaCTPhieuDatPhong_Phong();
                if (trangthai == "Thêm")
                {
                    CTPDP_PhongDTO cTPDP_PhongDTO = new CTPDP_PhongDTO(mactpdp_p, maphieudatphong, data);
                    if (!CTPDP_PhongBUS.ThemCTPDP_Phong(cTPDP_PhongDTO))
                    {
                        themthanhcong = false;
                    }
                }
                else
                {
                    CTPDP_PhongDTO cTPDP_PhongDTO = new CTPDP_PhongDTO(mactpdp_p, maphieudatphongsua, data);
                    CTPDP_PhongBUS.XoaCTPDP_Phong(maphieudatphongsua);

                    if (!CTPDP_PhongBUS.ThemCTPDP_Phong(cTPDP_PhongDTO))
                    {
                        suathanhcong = false;
                    }
                }
            }
        }
        private void themPhieuDatPhong()
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Hãy nhập tên khách hàng");
            }
            else if (txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Hãy nhập số điện thoại");
            }
            else if (!checkError.check_Phone(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng");
            }
            else
            {


                maphieudatphong = phieuDatPhongBUS.TaoMaPhieuDatPhong();
                string hoten = txtHoTen.Text;
                string sdt = txtSoDienThoai.Text;
                string ngaynhanphong = dateNgayNhan.Value.ToString("yyyy-MM-dd");
                string ngaytraphong = dateNgayTra.Value.ToString("yyyy-MM-dd");
                string tientratruoc = txtTienTraTruoc.Text;
                string trangthainhanphong = "Chưa nhận phòng";
                string ghichu = txtGhiChu.Text;

                // Them
                if (trangthai=="Thêm")
                {
                    PhieuDatPhongDTO pdp = new PhieuDatPhongDTO(maphieudatphong, hoten, sdt, ngaynhanphong, ngaytraphong, tientratruoc, ghichu, trangthainhanphong);

                    if (phieuDatPhongBUS.ThemPhieuDatPhong(pdp))
                    {

                        themPhieuDatPhong_LoaiPhong();
                        themPhieuDatPhong_Phong();
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
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else
                {
                    PhieuDatPhongDTO pdp = new PhieuDatPhongDTO(maphieudatphongsua, hoten, sdt, ngaynhanphong, ngaytraphong, tientratruoc, ghichu, trangthainhanphong);
                    if (phieuDatPhongBUS.SuaPhieuDatPhong(pdp))
                    {

                        themPhieuDatPhong_LoaiPhong();
                        themPhieuDatPhong_Phong();
                        if (suathanhcong)
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
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            themPhieuDatPhong();
            // test();
        }
        private DataTable GetDataTableFromDGV(DataGridView dg)
        {
            DataTable ExportDataTable = new DataTable();
            foreach (DataGridViewColumn col in dg.Columns)
            {
                ExportDataTable.Columns.Add(col.Name);
            }
            foreach (DataGridViewRow row in dg.Rows)
            {
                DataRow dRow = ExportDataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                ExportDataTable.Rows.Add(dRow);
            }
            return ExportDataTable;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvLoaiPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienTraTruoc_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtTienTraTruoc);

        }

    }
}
