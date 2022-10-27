using QLKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace QLKhachSan.GUI.DatPhongGUI
{
    public partial class frmXemTheoNgay : Form
    {
        PhieuDatPhongBUS phieuDatPhongBUS = new PhieuDatPhongBUS();
        CTPDP_LoaiPhongBUS CTPDP_LoaiPhongBUS = new CTPDP_LoaiPhongBUS();
        CTPDP_PhongBUS CTPDP_PhongBUS = new CTPDP_PhongBUS();
        public frmXemTheoNgay()
        {
            InitializeComponent();
        }
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            loadFromDatPhong();
        }
        private void datePickerTuNgay_onValueChanged(object sender, EventArgs e)
        {
            loadFromDatPhong();
        }
        private void loadFromDatPhong()
        {
            this.pnlFormDatPhong.Controls.Clear();
            int stt = 1;
            foreach (DataRow data in phieuDatPhongBUS.GetPhieuDatPhong().Rows)
            {

                //GET DATE
                DateTime dateNgayNhanPhong = DateTime.Parse(data["NgayNhanPhong"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                DateTime dateNgayTraPhong = DateTime.Parse(data["NgayTraPhong"].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                //KIỂM TRA NGÀY NHẬN PHÒNG
                if (datePickerTuNgay.Value.ToString("dd/MM/yyyy") == dateNgayNhanPhong.ToString("dd/MM/yyyy"))
                {
                    //GET SL
                    int soluong = CTPDP_LoaiPhongBUS.GetCTPDP_LoaiPhong
                ("SELECT * FROM CTPhieuDatPhong_LoaiPhong WHERE MaPhieuDatPhong = '" + data["MaPhieuDatPhong"].ToString() + "'").Rows.Count;
                    //GET PHÒNG ĐẶT
                    List<string> ListPhongDat = new List<string>();
                    string phongdatStr = "";
                    foreach (DataRow dataPhongDat in CTPDP_PhongBUS.GetCTPDP_Phong
                    ("SELECT MaPhong FROM CTPhieuDatPhong_Phong WHERE MaPhieuDatPhong = '" + data["MaPhieuDatPhong"].ToString() + "'").Rows)
                    {

                        ListPhongDat.Add(dataPhongDat["MaPhong"].ToString());

                    }
                    for (int i = 0; i < ListPhongDat.Count; i++)
                    {
                        if (i == ListPhongDat.Count - 1)
                        {
                            phongdatStr += ListPhongDat[i];
                        }
                        else
                        {
                            phongdatStr += ListPhongDat[i] + ", ";

                        }
                    }
                    frmCardDatPhong frmCardDatPhong = new frmCardDatPhong(
                    data["MaPhieuDatPhong"].ToString(),
                    stt++,
                    data["HoTenKhachHang"].ToString(),
                    data["TrangThai"].ToString(),
                    dateNgayNhanPhong.ToString("dd/MM/yyyy"),
                    dateNgayTraPhong.ToString("dd/MM/yyyy"),
                    soluong,
                    phongdatStr,
                    data["SoDienThoai"].ToString()
                    );
                    frmCardDatPhong.TopLevel = false;
                    pnlFormDatPhong.Controls.Add(frmCardDatPhong);
                    frmCardDatPhong.Show();
                }
            }
        }


    }
}
