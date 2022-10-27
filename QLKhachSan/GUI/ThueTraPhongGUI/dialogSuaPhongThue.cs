using Guna.UI2.WinForms;
using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    public partial class dialogSuaPhongThue : Form
    {
        string mahoadon;
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        HoaDon_MenuBUS hoaDon_MenuBUS = new HoaDon_MenuBUS();
        MenuBUS menuBUS = new MenuBUS();
        List<string> lsMenuChon;
        Boolean suathanhcong = true;
        public dialogSuaPhongThue(string mahoadon)
        {
            InitializeComponent();
            this.mahoadon = mahoadon;
        }
        private void dialogSuaPhongThue_Load(object sender, EventArgs e)
        {
            LoadMenu();
            dgvMenu.AllowUserToAddRows = false;
            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvMenu.Columns.Insert(3, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 100;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            setTextFormEdit();

        }
        public void LoadMenu()
        {
            dgvMenu.DataSource = hoaDon_MenuBUS.GetHoaDon_Menu(
                "SELECT TenMenu, SL, Format((replace(convert(varchar, cast(REPLACE(mn.GiaBan,',','.') as money), 1), '.00', '') * SL), 'c', 'vi-VN') AS ThanhTien " +
                "FROM HoaDon_Menu hdmn, Menu mn " +
                "WHERE hdmn.MaMenu = mn.MaMenu " +
                "AND MaHoaDon = '" + mahoadon + "'");
        }

        private void setTextFormEdit()
        {
            foreach (DataRow dt in hoaDonBUS.GetHoaDon(
                "SELECT * FROM HoaDon" +
                " WHERE MaHoaDon = '" + mahoadon + "'").Rows)
            {
                DateTime datengaynhan = DateTime.Parse(dt["ThoiGianBatDau"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                dateNhanPhong.Value = datengaynhan;
                timeNhanPhong.Value = datengaynhan;
                txtTienTraTruoc.Text = dt["TraTruoc"].ToString();
                txtGhiChu.Text = dt["GhiChu"].ToString();
            }
            LoadMenu();

        }

        private void timeNhanPhong_ValueChanged(object sender, EventArgs e)
        {
            timeNhanPhong.CustomFormat = "HH:mm";
        }

        private void timeNhanPhong_MouseDown(object sender, MouseEventArgs e)
        {

            timeNhanPhong.CustomFormat = "HH:mm";
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
        private void txtTienTraTruoc_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtTienTraTruoc);
        }

        private void btnThemMenu_Click(object sender, EventArgs e)
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
            }


        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow row = dgvMenu.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa menu này?", row.Cells["TenMenu"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataRow dt in menuBUS.GetMenu(
                        "SELECT MaMenu " +
                        "FROM Menu " +
                        "WHERE TenMenu = N'" + row.Cells["TenMenu"].Value.ToString() + "'").Rows)
                        if (hoaDon_MenuBUS.XoaHoaDon_Menu(mahoadon, dt["MaMenu"].ToString()))
                        {
                            MessageBox.Show("Xóa thành công");
                            LoadMenu();

                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string ngaynhanphong = dateNhanPhong.Value.ToString("yyyy-MM-dd");
            string timenhanphong = timeNhanPhong.Value.ToString("HH:mm:ss");
            string tientratruoc = txtTienTraTruoc.Text;
            string ghichu = txtGhiChu.Text;
            string thoigiannhanphong = ngaynhanphong + " " + timenhanphong;
            HoaDonDTO hd = new HoaDonDTO(mahoadon, thoigiannhanphong, tientratruoc, ghichu);
            if (!hoaDonBUS.SuaHoaDon(hd))
            {
                suathanhcong = false;
            }
            themHoaDon_Menu();
            if (suathanhcong)
            {
                MessageBox.Show("Lưu thành công");
            }
            else
                MessageBox.Show("Lưu thất bại");
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
        private void themHoaDon_Menu()
        {
            if (hoaDon_MenuBUS.XoaHoaDon_Menu())
            {
                foreach (DataRow data in menuBUS.GetMenu().Rows)
                {
                    DataTable dtMenu_HoaDon = GetDataTableFromDGV(dgvMenu);
                    foreach (DataRow dt in dtMenu_HoaDon.Rows)
                    {
                        if (dt["TenMenu"].ToString() == data["TenMenu"].ToString())
                        {
                            int sl = 0;
                            if (dt["SL"].ToString() != "")
                            {
                                sl = Int32.Parse(dt["SL"].ToString());
                            }
                            string mamenu = data["MaMenu"].ToString();

                            HoaDon_MenuDTO hoadon_menu = new HoaDon_MenuDTO(mamenu, mahoadon, sl);

                            if (!hoaDon_MenuBUS.ThemHoaDon_Menu(hoadon_menu))
                            {
                                suathanhcong = false;
                            }
                        }


                    }

                }

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
