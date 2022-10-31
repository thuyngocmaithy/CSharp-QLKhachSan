using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLThuChiGUI
{
    public partial class dialogSuaThuChi : Form
    {
        ThuChiBUS ThuChiBUS = new ThuChiBUS();
        string maphieuthuchi;
        public dialogSuaThuChi(string maphieuthuchi)
        {
            InitializeComponent();
            this.maphieuthuchi = maphieuthuchi;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaThuChi_Click(object sender, EventArgs e)
        {

            if (txtSuaSoTien.Text != "" && txtSuaNoiDung.Text != "")
            {
                // Tạo DTO
                ThuChiDTO tc = new ThuChiDTO(maphieuthuchi, dtSuaThoiGian.Value.ToString("yyyy-MM-dd"), cmbSuaLoaiHinh.Text, txtSuaSoTien.Text, txtSuaNoiDung.Text);

                // Sua
                if (ThuChiBUS.SuaThuChi(tc))
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
                MessageBox.Show("Hãy nhập tên loại phòng");

            }

        }
    }
}
