using QLKhachSan.BUS;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.LichSuGUI
{
    public partial class frmLichSu : Form
    {
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        
        public frmLichSu()
        {
            InitializeComponent();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
               ExportExcelLichSu exportExcelLichSu = new ExportExcelLichSu();
            //   exportExcelLichSu.export();

            exportExcelLichSu.ExportExcelDatabase();
        }
        private void loadLichSu()
        {
            DataTable dtLichSu = new DataTable();
            dtLichSu.Columns.Add("Mã hóa đơn");
            dtLichSu.Columns.Add("Phòng");
            dtLichSu.Columns.Add("Bắt đầu");
            dtLichSu.Columns.Add("Kết thúc");
            dtLichSu.Columns.Add("Nhận phòng");
            dtLichSu.Columns.Add("Trả phòng");
            dtLichSu.Columns.Add("Tổng tiền");

            DataTable dtTongTien = new DataTable();

            dtTongTien = hoaDonBUS.GetHoaDon(
                "SELECT * " +
                "FROM HoaDon " +
                "WHERE ThoiGianKetThuc IS NOT NULL");
            foreach (DataRow dr in dtTongTien.Rows)
            {
                int tienphong = 0, tienmenu = 0, phuthu = 0, thugiamtrukhac = 0, tratruoc = 0;
                if (dr["TienPhong"].ToString() != "")
                {
                    tienphong = int.Parse(dr["TienPhong"].ToString().Replace(",", ""));
                }
                if (dr["TienMenu"].ToString() != "")
                {
                    tienmenu = int.Parse(dr["TienMenu"].ToString().Replace(",", ""));
                }
                if (dr["PhuThu"].ToString() != "")
                {
                    phuthu = int.Parse(dr["PhuThu"].ToString().Replace(",", ""));
                }
                if (dr["ThuGiamTruKhac"].ToString() != "")
                {
                    thugiamtrukhac = int.Parse(dr["ThuGiamTruKhac"].ToString().Replace(",", ""));
                }
                if (dr["TraTruoc"].ToString() != "")
                {
                    tratruoc = int.Parse(dr["TraTruoc"].ToString().Replace(",", ""));
                }
                int tongtien = tienphong + tienmenu + phuthu + thugiamtrukhac - tratruoc;
                string convertTongtien = tongtien.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);

                dtLichSu.Rows.Add(dr["MaHoaDon"].ToString()
                    , dr["MaPhong"].ToString()
                    , dr["ThoiGianBatDau"].ToString()
                    , dr["ThoiGianKetThuc"].ToString()
                    , dr["TaiKhoanNhanPhong"].ToString()
                    , dr["TaiKhoanTraPhong"].ToString()
                    , convertTongtien);
            }
            dgvLichSu.DataSource = dtLichSu;
            
        }
        private void loadLichSuFind(string tungay, string denngay)
        {
            DataTable dtLichSu = new DataTable();
            dtLichSu.Columns.Add("Mã hóa đơn");
            dtLichSu.Columns.Add("Phòng");
            dtLichSu.Columns.Add("Bắt đầu");
            dtLichSu.Columns.Add("Kết thúc");
            dtLichSu.Columns.Add("Nhận phòng");
            dtLichSu.Columns.Add("Trả phòng");
            dtLichSu.Columns.Add("Tổng tiền");


            foreach (DataRow dr in hoaDonBUS.GetHoaDon(
                "SELECT * " +
                "FROM HoaDon " +
                "WHERE ThoiGianKetThuc BETWEEN '" + tungay + "' AND '" + denngay + "'").Rows)
            {
                int tienphong = 0, tienmenu = 0, phuthu = 0, thugiamtrukhac = 0, tratruoc = 0;
                if (dr["TienPhong"].ToString() != "")
                {
                    tienphong = int.Parse(dr["TienPhong"].ToString().Replace(",", ""));
                }
                if (dr["TienMenu"].ToString() != "")
                {
                    tienmenu = int.Parse(dr["TienMenu"].ToString().Replace(",", ""));
                }
                if (dr["PhuThu"].ToString() != "")
                {
                    phuthu = int.Parse(dr["PhuThu"].ToString().Replace(",", ""));
                }
                if (dr["ThuGiamTruKhac"].ToString() != "")
                {
                    thugiamtrukhac = int.Parse(dr["ThuGiamTruKhac"].ToString().Replace(",", ""));
                }
                if (dr["TraTruoc"].ToString() != "")
                {
                    tratruoc = int.Parse(dr["TraTruoc"].ToString().Replace(",", ""));
                }
                int tongtien = tienphong + tienmenu + phuthu + thugiamtrukhac - tratruoc;
                string convertTongtien = tongtien.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);

                dtLichSu.Rows.Add(dr["MaHoaDon"].ToString()
                    , dr["MaPhong"].ToString()
                    , dr["ThoiGianBatDau"].ToString()
                    , dr["ThoiGianKetThuc"].ToString()
                    , dr["TaiKhoanNhanPhong"].ToString()
                    , dr["TaiKhoanTraPhong"].ToString()
                    , convertTongtien);
            }
            dgvLichSu.DataSource = dtLichSu;
        }
        private void frmLichSu_Load(object sender, EventArgs e)
        {
          
            loadLichSu();
            dgvLichSu.AllowUserToAddRows = false;

            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvLichSu.Columns.Insert(7, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 100;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            //Add btnEdit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvLichSu.Columns.Insert(8, btnEdit);
            btnEdit.HeaderText = "Edit";
            btnEdit.Width = 100;
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;


        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadLichSuFind(DateBatDau.Value.ToString("yyyy-MM-dd HH:mm:ss"), DateKetThuc.Value.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void dgvLichSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dgvLichSu.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa lịch sử này?", row.Cells["Mã hóa đơn"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (hoaDonBUS.XoaHoaDon(row.Cells["Mã hóa đơn"].Value.ToString()))
                    {
                        MessageBox.Show("Xóa thành công");
                        loadLichSu();

                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            if (e.ColumnIndex == 1)
            {

                DataGridViewRow row = dgvLichSu.Rows[e.RowIndex];
                foreach (DataRow dr in hoaDonBUS.GetHoaDon(
               "SELECT * " +
               "FROM HoaDon " +
               "WHERE MaHoaDon = '" + row.Cells["Mã hóa đơn"].Value.ToString() + "'").Rows)
                {

                    GUI.ThueTraPhongGUI.dialogTraPhong dialogTraPhong = new GUI.ThueTraPhongGUI.dialogTraPhong(row.Cells["Mã hóa đơn"].Value.ToString(), "Sửa", dr["TaiKhoanTraPhong"].ToString());
                    dialogTraPhong.Show();
                }

            }
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            loadLichSu();
        }
    }
}
