using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.GUI.DatPhongGUI
{
    public partial class frmCardDatPhong : Form
    {
        string hoten, status, time, soluongphong,  phongso, phone;
        public frmCardDatPhong(string hoten, string status, string time, string soluongphong, string phongso, string phone)
        {
            InitializeComponent();
            this.hoten = hoten;
            this.status = status;
            this.time = time;
            this.soluongphong = soluongphong;   
            this.phongso = phongso;
            this.phone=phone;
        }

        private void frmCardDatPhong_Load(object sender, EventArgs e)
        {
            lblHoTen.Text = hoten;
            lblPhone.Text = phone;
            lblPhongSo.Text = phongso;
            lblSoLuongPhong.Text = soluongphong;
            lblTime.Text = time;
            lblTrangThai.Text = status;
        }
    }
}
