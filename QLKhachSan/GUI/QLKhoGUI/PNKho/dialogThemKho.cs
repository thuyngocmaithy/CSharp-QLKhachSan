using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLKhoGUI.PNKho
{
    public partial class dialogThemKho : Form
    {
        PNKhoBUS PNKhoBUS = new PNKhoBUS();
        MenuBUS menuBUS = new MenuBUS();
        CTPNKhoBUS CTPNKhoBUS = new CTPNKhoBUS();
        string trangthai, mapnkho;
        public dialogThemKho(string trangthai, string mapnkho)
        {
            InitializeComponent();
            this.trangthai = trangthai;
            this.mapnkho = mapnkho;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Boolean themthanhcong = true;
        Boolean suathanhcong = true;
        private void BtnThemKho_Click(object sender, EventArgs e)
        {

            string mapnkhothem = PNKhoBUS.TaoMaPhieuNhapKho();
            string thoigiannhap = dateNhan.Value.ToString("yyyy-MM-dd") + " " + timeNhan.Value.ToString("HH:mm");
           
            // Them
            if (trangthai == "Thêm")
            {
                PNKhoDTO k = new PNKhoDTO(mapnkhothem, thoigiannhap, txtThemGhiChu.Text);
                if (PNKhoBUS.ThemKho(k))
                {
                    themCTPNKho(mapnkhothem);
                }
                else
                {
                    themthanhcong = false;
                }
                if (themthanhcong)
                {
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    MessageBox.Show("Lưu thất bại");
                }
            }
            else
            {
                PNKhoDTO k = new PNKhoDTO(mapnkho, thoigiannhap, txtThemGhiChu.Text);
                if (PNKhoBUS.SuaKho(k))
                {
                    suaCTPNKho(mapnkho);
                }
                else
                {
                    suathanhcong = false;
                    MessageBox.Show("c");
                }
                if (suathanhcong)
                {
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    MessageBox.Show("Lưu thất bại");
                }
            }
      
      

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
        private void themCTPNKho(string mapnkho)
        {
            foreach (DataRow data in menuBUS.GetMenu().Rows)
            {
                DataTable dtCTPNKho = GetDataTableFromDGV(dgvNhapKho);
                foreach (DataRow dt in dtCTPNKho.Rows)
                {
                    if (dt["TenMenu"].ToString() == data["TenMenu"].ToString())
                    {
                        int sl = 0;
                        if (dt[1].ToString() != "")
                        {
                            sl = Int32.Parse(dt[1].ToString());
                        }
                        string mamenu = data["MaMenu"].ToString();
                        CTPNKhoDTO ctpnk = new CTPNKhoDTO(mapnkho, mamenu, sl);

                        if (!CTPNKhoBUS.ThemCTPNKho(ctpnk))
                        {
                            themthanhcong = false;
                        }
                    }


                }



            }
        }
        private void suaCTPNKho(string mapnkho)
        {
            if (CTPNKhoBUS.XoaCTPNKho(mapnkho))
            {
                foreach (DataRow data in menuBUS.GetMenu().Rows)
                {
                    DataTable dtCTPNKho = GetDataTableFromDGV(dgvNhapKho);
                    foreach (DataRow dt in dtCTPNKho.Rows)
                    {
                        if (dt["TenMenu"].ToString() == data["TenMenu"].ToString())
                        {
                            int sl = 0;
                            if (dt[1].ToString() != "")
                            {
                                sl = Int32.Parse(dt[1].ToString());
                            }
                            string mamenu = data["MaMenu"].ToString();
                            CTPNKhoDTO ctpnk = new CTPNKhoDTO(mapnkho, mamenu, sl);

                            if (!CTPNKhoBUS.ThemCTPNKho(ctpnk))
                            {
                                suathanhcong = false;
                                MessageBox.Show("b");
                            }
                        }


                    }
                }


            }
            else
            {
                MessageBox.Show("a");
                suathanhcong = false;
            }    
        }
        private void LoadMenu()
        {
            if (trangthai == "Thêm")
            {
                dgvNhapKho.DataSource = menuBUS.GetMenu(
                "SELECT TenMenu " +
                "FROM Menu");
            }
            else
            {
                dgvNhapKho.DataSource = menuBUS.GetMenu(
               "SELECT TenMenu, SL AS 'Số lượng' " +
               "FROM Menu " +
               "LEFT OUTER JOIN CTPNKho " +
               "ON MaPNKho = '" + mapnkho + "' " +
               "AND Menu.MaMenu = CTPNKho.MaMenu");
            }

        }
        private void setValueEdit()
        {
            foreach (DataRow dt in PNKhoBUS.GetPNKho(
                "SELECT * " +
                "FROM PNKho " +
                "WHERE MaPNKho = '" + mapnkho + "'").Rows)
            {
                
                DateTime date = DateTime.Parse(dt["ThoiGianNhap"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                dateNhan.Value = date;
                timeNhan.Value = date;
                txtThemGhiChu.Text = dt["GhiChu"].ToString();
            }

        }
        private void dialogThemKho_Load(object sender, EventArgs e)
        {
            if(trangthai!="Thêm")
            {
                setValueEdit();
            }
            LoadMenu();
            if(trangthai=="Thêm")
            {
                dgvNhapKho.AllowUserToAddRows = false;
                DataGridViewTextBoxColumn txtSl = new DataGridViewTextBoxColumn();
                dgvNhapKho.Columns.Insert(1, txtSl);
                txtSl.HeaderText = "Số lượng";                
            }
            dgvNhapKho.Columns[1].Width = 170;

        }
    }
}
