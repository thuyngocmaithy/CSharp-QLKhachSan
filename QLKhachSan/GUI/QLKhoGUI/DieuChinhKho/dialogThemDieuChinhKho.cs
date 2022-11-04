using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLKhoGUI.DieuChinhKho
{
    public partial class dialogThemDieuChinhKho : Form
    {
        PNKhoBUS PNKhoBUS = new PNKhoBUS();
        MenuBUS menuBUS = new MenuBUS();
        CTPNKhoBUS CTPNKhoBUS = new CTPNKhoBUS();
        DieuChinhKhoBUS DieuChinhKhoBUS = new DieuChinhKhoBUS();
        DieuChinhKho_MenuBUS DieuChinhKho_MenuBUS = new DieuChinhKho_MenuBUS();
        public dialogThemDieuChinhKho()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Boolean themthanhcong = true;

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
        private void themDieuChinhKho_Menu(string madieuchinhkho)
        {
            Boolean sosanh = false;
            foreach (DataRow data in menuBUS.GetMenu().Rows)
            {
                DataTable dtDieuChinh = GetDataTableFromDGV(dgvDieuChinhKho);
                foreach (DataRow dt in dtDieuChinh.Rows)
                {
                    if (dt["TenMenu"].ToString() == data["TenMenu"].ToString())
                    {
                        if (dt[1].ToString() != dt[2].ToString())
                        {
                            sosanh = true;
                        }
                        if (sosanh)
                        {
                            int sl = 0;
                            if (dt[2].ToString() != "")
                            {
                                sl = Int32.Parse(dt[2].ToString());
                            }
                            string mamenu = data["MaMenu"].ToString();
                            DieuChinhKho_MenuDTO ctpnk = new DieuChinhKho_MenuDTO(madieuchinhkho, mamenu, sl, 0);

                            if (!DieuChinhKho_MenuBUS.ThemDieuChinhKho_Menu(ctpnk))
                            {
                                themthanhcong = false;                                
                            }
                            else
                            {
                                updateSLDieuChinh(madieuchinhkho);
                            }    
                        }
                        else
                            MessageBox.Show("Cần phải thay đổi ít nhất 1 menu");

                    }


                }


            }
        }
        DataTable dtHienTaiBefore = new DataTable();
        private void updateSLDieuChinh(string madieuchinhkho)
        {
            //Kiểm tra DieuChinhKho_Menu lần đầu?
            DataTable dtCountDCK_Menu = DieuChinhKho_MenuBUS.GetDieuChinhKho_Menu(
                "SELECT MaDieuChinhKho " +
                "FROM DieuChinhKho_Menu " +
                "GROUP BY MaDieuChinhKho");
            if(dtCountDCK_Menu.Rows.Count == 1)
            {
                foreach(DataRow dr in DieuChinhKho_MenuBUS.GetDieuChinhKho_Menu(
                    "SELECT * " +
                    "FROM DieuChinhKho_Menu " +
                    "WHERE MaDieuChinhKho = '"+madieuchinhkho+"'").Rows)
                {
                    string mamenu = dr["MaMenu"].ToString();
                    int slthucte = int.Parse(dr["SLThucTe"].ToString());
                    int slnhapkho=0;
                    foreach (DataRow drPNKho in CTPNKhoBUS.GetCTPNKho(
                        "SELECT SUM(SL) AS SLNhapKho " +
                        "FROM CTPNKho " +
                        "WHERE MaMenu = '"+mamenu+"'").Rows)
                    {
                        slnhapkho = int.Parse(drPNKho["SLNhapKho"].ToString());
                    }
                    int sldieuchinh = slthucte - slnhapkho;
                    MessageBox.Show(sldieuchinh.ToString());
                    DieuChinhKho_MenuDTO ctpnk = new DieuChinhKho_MenuDTO(madieuchinhkho, mamenu, slthucte, sldieuchinh);
                    if(!DieuChinhKho_MenuBUS.SuaDieuChinhKho_Menu(ctpnk))
                    {
                        MessageBox.Show("Sửa thất bại");
                    }    
                }    
            }    
            else
            {
                foreach (DataRow dr in DieuChinhKho_MenuBUS.GetDieuChinhKho_Menu(
                    "SELECT * " +
                    "FROM DieuChinhKho_Menu " +
                    "WHERE MaDieuChinhKho = '" + madieuchinhkho + "'").Rows)
                {
                    string mamenu = dr["MaMenu"].ToString();
                    int slthucte = int.Parse(dr["SLThucTe"].ToString());
                    int slnhapkho = 0;
                    foreach (DataRow dtSLHienTai in dtHienTaiBefore.Rows)
                    {
                        if (dtSLHienTai[0].ToString()==mamenu)
                        {
                            slnhapkho = int.Parse(dtSLHienTai["SL"].ToString());
                            MessageBox.Show("slnhapkho:" + slnhapkho);
                        }    
              
                    }
                    int sldieuchinh = slthucte - slnhapkho;
                    MessageBox.Show(sldieuchinh.ToString());
                    DieuChinhKho_MenuDTO ctpnk = new DieuChinhKho_MenuDTO(madieuchinhkho, mamenu, slthucte, sldieuchinh);
                    if (!DieuChinhKho_MenuBUS.SuaDieuChinhKho_Menu(ctpnk))
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }    

        }

        private void LoadMenu()
        {
            DataTable dtCountDCK_Menu = DieuChinhKho_MenuBUS.GetDieuChinhKho_Menu(
                "SELECT MaDieuChinhKho " +
                "FROM DieuChinhKho_Menu " +
                "GROUP BY MaDieuChinhKho");
            if (dtCountDCK_Menu.Rows.Count >0)
            {
                dgvDieuChinhKho.DataSource = menuBUS.GetMenu(
           "SELECT TenMenu, SUM(SLThucTe) AS 'Số lượng hiện tại' " +
           "FROM DieuChinhKho, Menu, DieuChinhKho_Menu " +
           "WHERE DieuChinhKho.MaDieuChinhKho = DieuChinhKho_Menu.MaDieuChinhKho " +
           "AND DieuChinhKho.ThoiGianDieuChinh IN(SELECT MAX(DieuChinhKho.ThoiGianDieuChinh) FROM DieuChinhKho) " +
           "AND Menu.MaMenu = DieuChinhKho_Menu.MaMenu " +
           "GROUP BY TenMenu");
            }
            else
            {
                dgvDieuChinhKho.DataSource = menuBUS.GetMenu(
                    "SELECT Menu.TenMenu, SUM(SL) AS 'Số lượng hiện tại'" +
                    "FROM Menu, CTPNKho " +
                    "WHERE Menu.MaMenu = CTPNKho.MaMenu " +
                    "GROUP BY Menu.TenMenu");
            }    
        }
        private DataTable GetDataTableSLHienTai()
        {
            DataTable dtSLHTBefore = new DataTable();
            dtSLHTBefore.Columns.Add("Mã menu");
            dtSLHTBefore.Columns.Add("SL");
            foreach (DataRow dtSLHienTaiBefore in menuBUS.GetMenu(
                "SELECT Menu.MaMenu, SUM(SLThucTe) AS 'Số lượng hiện tại' " +
       "FROM DieuChinhKho, Menu, DieuChinhKho_Menu " +
       "WHERE DieuChinhKho.MaDieuChinhKho = DieuChinhKho_Menu.MaDieuChinhKho " +
       "AND DieuChinhKho.ThoiGianDieuChinh IN(SELECT MAX(DieuChinhKho.ThoiGianDieuChinh) FROM DieuChinhKho) " +
       "AND Menu.MaMenu = DieuChinhKho_Menu.MaMenu " +
       "GROUP BY Menu.MaMenu").Rows)
            {
                dtSLHTBefore.Rows.Add(dtSLHienTaiBefore["MaMenu"].ToString(), dtSLHienTaiBefore["Số lượng hiện tại"].ToString());
            }
            return dtSLHTBefore;
        }
      
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int tongsldieuchinh = 0;
            string madckho = DieuChinhKhoBUS.TaoMaDieuChinhKho();
            string thoigiannhap = dateNhan.Value.ToString("yyyy-MM-dd") + " " + timeNhan.Value.ToString("HH:mm");
            DieuChinhKhoDTO k = new DieuChinhKhoDTO(madckho, thoigiannhap, 0);
            dtHienTaiBefore = GetDataTableSLHienTai();
            if (DieuChinhKhoBUS.ThemDieuChinhKho(k))
            {
                themDieuChinhKho_Menu(madckho);
                foreach (DataRow dtSLThucTe in DieuChinhKho_MenuBUS.GetDieuChinhKho_Menu(
                    "SELECT SUM(SLDieuChinh) AS 'SLDieuChinh'" +
                    "FROM DieuChinhKho_Menu " +
                    "WHERE MaDieuChinhKho = '" + madckho + "'").Rows)
                {
                    tongsldieuchinh = int.Parse(dtSLThucTe["SLDieuChinh"].ToString());

                    DieuChinhKhoDTO updateDCK = new DieuChinhKhoDTO(madckho, thoigiannhap, tongsldieuchinh);
                    if (!DieuChinhKhoBUS.SuaDieuChinhKho(updateDCK))
                    {
                        themthanhcong = false;
                    }

                }
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

        private void dialogThemDieuChinhKho_Load(object sender, EventArgs e)
        {

            LoadMenu();
            dateNhan.Value = DateTime.Now;
            timeNhan.Value = DateTime.Now;
            dgvDieuChinhKho.AllowUserToAddRows = false;



            DataGridViewTextBoxColumn txtSl = new DataGridViewTextBoxColumn();
            dgvDieuChinhKho.Columns.Insert(2, txtSl);
            txtSl.HeaderText = "Số lượng thực tế";

            dgvDieuChinhKho.Columns[1].Width = 120;
            dgvDieuChinhKho.Columns[2].Width = 120;


        }
        private void LoadMenuFind()
        {
            DataTable dtCountDCK_Menu = DieuChinhKho_MenuBUS.GetDieuChinhKho_Menu(
                "SELECT MaDieuChinhKho " +
                "FROM DieuChinhKho_Menu " +
                "GROUP BY MaDieuChinhKho");
            if (dtCountDCK_Menu.Rows.Count > 0)
            {
                dgvDieuChinhKho.DataSource = menuBUS.GetMenu(
           "SELECT TenMenu, SUM(SLThucTe) AS 'Số lượng hiện tại' " +
           "FROM DieuChinhKho, Menu, DieuChinhKho_Menu " +
           "WHERE DieuChinhKho.MaDieuChinhKho = DieuChinhKho_Menu.MaDieuChinhKho " +
           "AND DieuChinhKho.ThoiGianDieuChinh IN(SELECT MAX(DieuChinhKho.ThoiGianDieuChinh) FROM DieuChinhKho) " +
           "AND Menu.MaMenu = DieuChinhKho_Menu.MaMenu " +
           "AND Menu.TenMenu LIKE N'%" + txtFind.Text.Trim() + "%' " +
           "GROUP BY TenMenu");
            }
            else
            {
                dgvDieuChinhKho.DataSource = menuBUS.GetMenu(
                    "SELECT Menu.TenMenu, SUM(SL) AS 'Số lượng hiện tại'" +
                    "FROM Menu, CTPNKho " +
                    "WHERE Menu.MaMenu = CTPNKho.MaMenu " +
                    "AND Menu.TenMenu LIKE N'%" + txtFind.Text.Trim() + "%' " +
                    "GROUP BY Menu.TenMenu");
            }
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            LoadMenuFind();
        }

        private void txtFind_Click(object sender, EventArgs e)
        {
            txtFind.ResetText();
            txtFind.ForeColor = System.Drawing.Color.Black;
        }
    }
}
