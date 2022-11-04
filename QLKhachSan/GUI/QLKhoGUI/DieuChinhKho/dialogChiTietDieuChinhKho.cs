using QLKhachSan.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLKhoGUI.DieuChinhKho
{
    public partial class dialogChiTietDieuChinhKho : Form
    {
        PNKhoBUS PNKhoBUS = new PNKhoBUS();
        CTPNKhoBUS CTPNKhoBUS = new CTPNKhoBUS();
        DieuChinhKho_MenuBUS DieuChinhKho_MenuBUS = new DieuChinhKho_MenuBUS();
        DieuChinhKhoBUS DieuChinhKhoBUS = new DieuChinhKhoBUS();
        MenuBUS menuBUS = new MenuBUS();
        string madieuchinhkho;
        public dialogChiTietDieuChinhKho(string madieuchinhkho)
        {
            InitializeComponent();
            this.madieuchinhkho = madieuchinhkho;
        }
        private DataTable loadChiTiet(string tenmenuFind)
        {
            DataTable dtChiTiet = new DataTable();
            dtChiTiet.Columns.Add("Tên menu");
            dtChiTiet.Columns.Add("Số lượng điều chỉnh");
            int  sldieuchinh = 0;
            DataTable dtMenu = new DataTable();
            if(tenmenuFind=="")
            {
                dtMenu = menuBUS.GetMenu();
            }    
            else
            {
                dtMenu = menuBUS.GetMenu("SELECT * FROM Menu WHERE TenMenu LIKE N'%" + txtFind.Text.Trim() + "%' ");
            }    
            foreach (DataRow drMenu in dtMenu.Rows)
            {
                string tenmenu = drMenu["TenMenu"].ToString();
                foreach (DataRow dtDieuChinhKho in DieuChinhKhoBUS.GetDieuChinhKho(
                    "SELECT * " +
                    "FROM DieuChinhKho " +
                    "WHERE MaDieuChinhKho = '" + madieuchinhkho + "'").Rows)
                {
                    string thoigiandieuchinh = dtDieuChinhKho["ThoiGianDieuChinh"].ToString();
                    dateNhan.Value = DateTime.Parse(thoigiandieuchinh);
                    timeNhan.Value = DateTime.Parse(thoigiandieuchinh);

                }
                foreach (DataRow drSLDieuChinh in DieuChinhKho_MenuBUS.GetDieuChinhKho_Menu(
                    "SELECT MaMenu, SLDieuChinh " +
                    "FROM DieuChinhKho_Menu " +
                    "WHERE MaDieuChinhKho = '" + madieuchinhkho + "' " +
                    "AND MaMenu = '" + drMenu["MaMenu"].ToString() +"'").Rows)
                {
                        sldieuchinh =int.Parse (drSLDieuChinh["SLDieuChinh"].ToString());
                        dtChiTiet.Rows.Add(tenmenu, sldieuchinh);                   

                }
            }
            return dtChiTiet;
        }

        private void dialogChiTietDieuChinhKho_Load(object sender, EventArgs e)
        {
            dgvCTDieuChinhKho.DataSource = loadChiTiet("");
            dgvCTDieuChinhKho.Columns[0].Width = 200;
            dgvCTDieuChinhKho.Columns[1].Width = 200;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvCTDieuChinhKho.DataSource = loadChiTiet(txtFind.Text);
        }

        private void txtFind_Click(object sender, EventArgs e)
        {
            txtFind.ResetText();
            txtFind.ForeColor = System.Drawing.Color.Black;
        }
    }
}
