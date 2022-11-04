using QLKhachSan.BUS;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.ThongKeGUI
{
    public partial class frmThongKeLoiNhuan : Form
    {
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        ThuChiBUS thuChiBUS = new ThuChiBUS();
        CTPNKhoBUS ctpnKhoBUS = new CTPNKhoBUS();
        PNKhoBUS pnKhoBUS = new PNKhoBUS();
        MenuBUS menuBUS = new MenuBUS();

        public frmThongKeLoiNhuan()
        {
            InitializeComponent();
        }
        private void ThongKeLoiNhuanAll()
        {
            int thutuphong = 0, thutumenu = 0, giamtrukhac = 0, thukhac = 0, tongthu = 0;
            int chiphinhapmenu = 0, chikhac = 0, tongchi = 0;
            foreach (DataRow dr in hoaDonBUS.GetHoaDon().Rows)
            {
                int tienphong = 0, phuthu = 0, tratruoc = 0, thugiamtrukhac = 0, tienmenu=0;

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

                thutuphong += (tienphong + phuthu - tratruoc);
                thutumenu += tienmenu;
                giamtrukhac += thugiamtrukhac;
            }
            foreach (DataRow dr in thuChiBUS.GetPhieuThuChi(
                "SELECT * " +
                "FROM PhieuThuChi " +
                "WHERE LoaiHinh = 'Thu'").Rows)
            {
                int tienthu = int.Parse(dr["SoTien"].ToString().Replace(",", ""));
                thukhac += tienthu;

            }
            tongthu = thutuphong + thutumenu + giamtrukhac + thukhac;

            //SET TEXT
            txtDoanhThuPhong.Text = thutuphong.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
            txtDoanhThuMenu.Text = thutumenu.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
            txtGiamTruKhac.Text = giamtrukhac.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
            txtThuKhac.Text = thukhac.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
            txtTongDoanhThu.Text = tongthu.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);

            //CHI
            foreach (DataRow dr in thuChiBUS.GetPhieuThuChi(
               "SELECT * " +
               "FROM PhieuThuChi " +
               "WHERE LoaiHinh = 'Chi'").Rows)
            {
                int tienchi = int.Parse(dr["SoTien"].ToString().Replace(",", ""));
                chikhac += tienchi;
            }
            foreach (DataRow drPNKho in ctpnKhoBUS.GetCTPNKho().Rows)
            {
                int sl = int.Parse(drPNKho["SL"].ToString());
                foreach (DataRow drMenu in menuBUS.GetMenu(
                    "SELECT GiaNhap " +
                    "FROM Menu " +
                    "WHERE MaMenu = '" + drPNKho["MaMenu"].ToString() + "'").Rows)
                {
                    int gianhap = int.Parse(drMenu["GiaNhap"].ToString().Replace(",", ""));

                    chiphinhapmenu += (sl * gianhap);
                }
            }
            tongchi = chiphinhapmenu + chikhac;
            txtPhiNhapMenu.Text = chiphinhapmenu.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
            txtChiKhac.Text= chikhac.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
            txtTongChiPhi.Text = tongchi.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
        }
        private void ThongKeLoiNhuanThang(string thang, string nam)
        {
            int thutuphong = 0, thutumenu = 0, giamtrukhac = 0, thukhac = 0, tongthu = 0;
            int chiphinhapmenu = 0, chikhac = 0, tongchi = 0;
            foreach (DataRow dr in hoaDonBUS.GetHoaDon(
                "SELECT * " +
                "FROM HoaDon " +
                "WHERE MONTH(ThoiGianKetThuc) = '" + thang + "' " +
                "AND YEAR(ThoiGianKetThuc) = '" + nam + "'").Rows)
            {
                int tienphong = 0, phuthu = 0, tratruoc = 0, thugiamtrukhac = 0, tienmenu = 0;

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

                thutuphong += (tienphong + phuthu - tratruoc);
                thutumenu += tienmenu;
                giamtrukhac += thugiamtrukhac;
            }
            foreach (DataRow dr in thuChiBUS.GetPhieuThuChi(
                "SELECT * " +
                "FROM PhieuThuChi " +
                "WHERE LoaiHinh = 'Thu' " +
                "AND MONTH(ThoiGian) = '" + thang + "' " +
                "AND YEAR(ThoiGian) = '" + nam + "'").Rows)
            {
                int tienthu = int.Parse(dr["SoTien"].ToString().Replace(",", ""));
                thukhac += tienthu;

            }
            tongthu = thutuphong + thutumenu + giamtrukhac + thukhac;

            //SET TEXT
            txtDoanhThuPhong.Text = thutuphong.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
            txtDoanhThuMenu.Text = thutumenu.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
            txtGiamTruKhac.Text = giamtrukhac.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
            txtThuKhac.Text = thukhac.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
            txtTongDoanhThu.Text = tongthu.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);

            //CHI
            foreach (DataRow dr in thuChiBUS.GetPhieuThuChi(
               "SELECT * " +
               "FROM PhieuThuChi " +
               "WHERE LoaiHinh = 'Chi' " +
               "AND MONTH(ThoiGian) = '" + thang + "' " +
               "AND YEAR(ThoiGian) = '" + nam + "'").Rows)
            {
                int tienchi = int.Parse(dr["SoTien"].ToString().Replace(",", ""));
                chikhac += tienchi;
            }
            foreach (DataRow drPNKho in pnKhoBUS.GetPNKho(
                "SELECT MaPNKho " +
                "FROM PNKho " +
                "WHERE MONTH(ThoiGianNhap) = '" + thang + "' " +
                "AND YEAR(ThoiGianNhap) = '" + nam + "'").Rows)
            {
                foreach (DataRow drCTPNKho in ctpnKhoBUS.GetCTPNKho(
                    "SELECT * " +
                    "FROM CTPNKho " +
                    "WHERE MaPNKho = '" + drPNKho["MaPNKho"].ToString() +"'").Rows)
                {
                    int sl = int.Parse(drCTPNKho["SL"].ToString());
                    foreach (DataRow drMenu in menuBUS.GetMenu(
                        "SELECT GiaNhap " +
                        "FROM Menu " +
                        "WHERE MaMenu = '" + drCTPNKho["MaMenu"].ToString() + "'").Rows)
                    {
                        int gianhap = int.Parse(drMenu["GiaNhap"].ToString().Replace(",", ""));

                        chiphinhapmenu += (sl * gianhap);
                    }
                }
            }
            tongchi = chiphinhapmenu + chikhac;
            txtPhiNhapMenu.Text = chiphinhapmenu.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
            txtChiKhac.Text = chikhac.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
            txtTongChiPhi.Text = tongchi.ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
        }
        private void frmThongKeLoiNhuan_Load(object sender, EventArgs e)
        {
            dateThongKe.Value = DateTime.Now;
            dateThongKe.MaxDate = DateTime.Now;
            ThongKeLoiNhuanAll();
        }

        private void btnThongKeAll_Click(object sender, EventArgs e)
        {
            ThongKeLoiNhuanAll();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string thoigian = dateThongKe.Value.ToString("MM/yyyy");
            ThongKeLoiNhuanThang(thoigian.Split('/')[0], thoigian.Split('/')[1]);
        }
    }
}
