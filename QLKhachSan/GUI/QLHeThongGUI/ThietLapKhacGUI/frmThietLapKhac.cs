using QLKhachSan.BUS;
using QLKhachSan.DTO;
using QLKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.ThietLapKhacGUI
{
    public partial class frmThietLapKhac : Form
    {
        ThietLapKhacBUS thietLapKhacBUS = new ThietLapKhacBUS();
        ThietLapKhacDAO thietLapKhacDAO = new ThietLapKhacDAO();
        string panel, logo;
        public frmThietLapKhac()
        {
            InitializeComponent();
        }

        private void frmThietLapKhac_Load(object sender, EventArgs e)
        {
            if (thietLapKhacDAO.getThietLapKhac().Rows.Count == 0)
            {
                MessageBox.Show("Chả có gì trong table cả :) ", "Thông báo");
                return;
            }  // khong co dong nao
            txtTenKhachSan.Text = thietLapKhacDAO.getThietLapKhac().Rows[0]["TenKhachSan"].ToString();
            txtDiaChi.Text = thietLapKhacDAO.getThietLapKhac().Rows[0]["DiaChi"].ToString();
            txtSDT.Text = thietLapKhacDAO.getThietLapKhac().Rows[0]["SDT"].ToString();
            bunifuDatepicker.Value = Convert.ToDateTime(thietLapKhacDAO.getThietLapKhac().Rows[0]["ThoiGian"].ToString());

            if (thietLapKhacDAO.getThietLapKhac().Rows[0]["Logo"].ToString() != "")
            {
                pictureBoxLogo.Image = Image.FromFile
                    (Path.GetFullPath(@"icon\" + thietLapKhacDAO.getThietLapKhac().Rows[0]["Logo"].ToString()));
            }
            if (thietLapKhacDAO.getThietLapKhac().Rows[0]["Panel"].ToString() != "")
            {
                picBoxPanel.Image = Image.FromFile
                    (Path.GetFullPath(@"icon\" + thietLapKhacDAO.getThietLapKhac().Rows[0]["Panel"].ToString()));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenKhachSan.Text != "")
            {
                MessageBox.Show(txtTenKhachSan.Text + "---" + txtDiaChi.Text + "---" + txtSDT.Text + "---" + bunifuDatepicker.Value.ToString("yyyy-MM-dd") + "---" + logo + "---" + panel);
                ThietLapKhacDTO t = new ThietLapKhacDTO(txtTenKhachSan.Text, txtDiaChi.Text, txtSDT.Text, bunifuDatepicker.Value.ToString("yyyy-MM-dd"),logo,panel);
                if (thietLapKhacBUS.SuaThietLapKhac(t))
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
                MessageBox.Show("Hãy nhập tên khách sạn");
            }
           
        }

        private void picBoxPanel_DoubleClick(object sender, EventArgs e)
        {
            // Show hộp thoại open file ra
            // Nhận kết quả trả về qua biến kiểu DialogResult
            DialogResult result = openFileDialog1.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(openFileDialog1.FileName);

                // Gán ảnh
                picBoxPanel.Image = img;
                string[] tenpanel = openFileDialog1.FileName.ToString().Split('\\');
                panel = tenpanel[tenpanel.Length - 1];


            }
            return;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            // Show hộp thoại open file ra
            // Nhận kết quả trả về qua biến kiểu DialogResult
            DialogResult result = openFileDialog1.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(openFileDialog1.FileName);

                // Gán ảnh
                pictureBoxLogo.Image = img;
                string[] tenlogo = openFileDialog1.FileName.ToString().Split('\\');
                logo = tenlogo[tenlogo.Length - 1];

            }
            return;
        }

 
    }
}
