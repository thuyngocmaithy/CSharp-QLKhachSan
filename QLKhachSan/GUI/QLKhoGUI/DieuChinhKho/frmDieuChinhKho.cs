

using QLKhachSan.BUS;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLKhoGUI.DieuChinhKho
{
    public partial class frmDieuChinhKho : Form
    {
        PNKhoBUS PNKhoBUS = new PNKhoBUS();
        CTPNKhoBUS CTPNKhoBUS = new CTPNKhoBUS();
        DieuChinhKho_MenuBUS DieuChinhKho_MenuBUS = new DieuChinhKho_MenuBUS();
        DieuChinhKhoBUS DieuChinhKhoBUS = new DieuChinhKhoBUS();
        MenuBUS menuBUS = new MenuBUS();
        public frmDieuChinhKho()
        {
            InitializeComponent();
        }





        private void lblReset_Click(object sender, EventArgs e)
        {
            LoadPhieuKiemKho();
        }


        public void LoadPhieuKiemKho()
        {

            dgvDieuChinhKho.DataSource = taoDataTablePNKho();

        }


        private DataTable taoDataTablePNKho()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phiếu điều chỉnh");
            dt.Columns.Add("Thời gian điều chỉnh");
            dt.Columns.Add("Tổng số lượng điều chỉnh");
            dt.Columns.Add("Tổng giá điều chỉnh");
            int sldieuchinh = 0;
            int giamenu =0, giaban = 0;
            foreach (DataRow dtDieuChinhKho in DieuChinhKhoBUS.GetDieuChinhKho().Rows)
            {
                int tonggiaban = 0;
                string madieuchinhkho = dtDieuChinhKho["MaDieuChinhKho"].ToString();
                string thoigiandieuchinh = dtDieuChinhKho["ThoiGianDieuChinh"].ToString();
                string tongsldieuchinh = dtDieuChinhKho["TongSLDieuChinh"].ToString();
                foreach (DataRow drDieuChinhKho_Menu in DieuChinhKho_MenuBUS.GetDieuChinhKho_Menu(
                       "SELECT MaMenu, SLDieuChinh " +
                       "FROM DieuChinhKho_Menu " +                       
                       "WHERE MaDieuChinhKho = '" + madieuchinhkho + "'").Rows)
                {
                    sldieuchinh = int.Parse(drDieuChinhKho_Menu["SLDieuChinh"].ToString());
                    foreach (DataRow drMenu in menuBUS.GetMenu(
                        "SELECT GiaBan " +
                        "FROM Menu " +
                        "WHERE MaMenu = '" + drDieuChinhKho_Menu["MaMenu"] + "'").Rows)
                    {
                        giamenu = int.Parse(drMenu["GiaBan"].ToString().Replace(",", ""));
                        giaban = sldieuchinh * giamenu;
                        tonggiaban += giaban;
                    }                
                    
                }
                string convertGiaBan = tonggiaban.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
                dt.Rows.Add(madieuchinhkho, thoigiandieuchinh, tongsldieuchinh, convertGiaBan);
            }

            return dt;
        }

        private void lblFind_Click(object sender, EventArgs e)
        {
            LoadPNKhoFind();
        }
        public void LoadPNKhoFind()
        {
            //KIỂM TRA NGÀY NHẬN PHÒNG
            dgvDieuChinhKho.DataSource = taoDataTablePNKhoFind();
        }
        private DataTable taoDataTablePNKhoFind()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phiếu điều chỉnh");
            dt.Columns.Add("Thời gian điều chỉnh");
            dt.Columns.Add("Tổng số lượng điều chỉnh");
            dt.Columns.Add("Tổng giá điều chỉnh");
            int slthucte = 0, slhientai = 0, sldieuchinh = 0;
            int giaban = 0;
            foreach (DataRow dtDieuChinhKho in DieuChinhKhoBUS.GetDieuChinhKho(
                "SELECT * " +
                "FROM DieuChinhKho " +
                "WHERE ThoiGianDieuChinh BETWEEN '" + dateTuNgay.Value.ToString("yyyy-MM-dd") + "' AND '" + dateDenNgay.Value.ToString("yyyy-MM-dd") + "'").Rows)
            {
                string madieuchinhkho = dtDieuChinhKho["MaDieuChinhKho"].ToString();
                string thoigiandieuchinh = dtDieuChinhKho["ThoiGianDieuChinh"].ToString();
                string tongsldieuchinh = dtDieuChinhKho["TongSLDieuChinh"].ToString();
                foreach (DataRow drMenu in menuBUS.GetMenu().Rows)
                {
                    foreach (DataRow drDieuChinhKho_Menu in DieuChinhKho_MenuBUS.GetDieuChinhKho_Menu(
                        "SELECT SLDieuChinh" +
                        "FROM DieuChinhKho_Menu " +
                        "WHERE MaMenu = '" + drMenu["MaMenu"] + "' " +
                        "AND MaDieuChinhKho = '" + madieuchinhkho + "'").Rows)
                    {
                        sldieuchinh = int.Parse(drDieuChinhKho_Menu["SLDieuChinh"].ToString());
                    }
                    int giamenu = int.Parse(drMenu["GiaBan"].ToString().Replace(",", ""));
                    giaban += sldieuchinh * giamenu;
                }


                string convertGiaBan = giaban.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
                dt.Rows.Add(madieuchinhkho, thoigiandieuchinh, tongsldieuchinh, convertGiaBan);
            }
            return dt;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dialogThemDieuChinhKho dialogThemDieuChinhKho = new dialogThemDieuChinhKho();
            dialogThemDieuChinhKho.Show();
        }

        private void frmDieuChinhKho_Load(object sender, EventArgs e)
        {
            LoadPhieuKiemKho();
            dgvDieuChinhKho.AllowUserToAddRows = false;
            //Add btnDelete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            dgvDieuChinhKho.Columns.Insert(4, btnDelete);
            btnDelete.HeaderText = "Delete";
            btnDelete.Width = 100;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            //Add btnEdit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvDieuChinhKho.Columns.Insert(5, btnEdit);
            btnEdit.HeaderText = "Chi tiết";
            btnEdit.Width = 100;
            btnEdit.Text = "Xem";
            btnEdit.UseColumnTextForButtonValue = true;

            dgvDieuChinhKho.Columns[0].Width = 200;
            dgvDieuChinhKho.Columns[1].Width = 240;
            dgvDieuChinhKho.Columns[2].Width = 200;
            dgvDieuChinhKho.Columns[3].Width = 200;
        }

        private void dgvDieuChinhKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dgvDieuChinhKho.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn muốn xóa phiếu điều chỉnh kho này?", row.Cells["Mã phiếu điều chỉnh"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (DieuChinhKho_MenuBUS.XoaDieuChinhKho_Menu(row.Cells["Mã phiếu điều chỉnh"].Value.ToString()))
                    {
                        if (DieuChinhKhoBUS.XoaDieuChinhKho(row.Cells["Mã phiếu điều chỉnh"].Value.ToString()))
                        {
                            MessageBox.Show("Xóa thành công");
                            LoadPhieuKiemKho();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else if (e.ColumnIndex == 1)
            {
                DataGridViewRow row = dgvDieuChinhKho.Rows[e.RowIndex];
                dialogChiTietDieuChinhKho dialogChiTietDieuChinhKho = new dialogChiTietDieuChinhKho(row.Cells["Mã phiếu điều chỉnh"].Value.ToString());
                dialogChiTietDieuChinhKho.Show();
            }
        }


    }

}

