using Guna.UI2.WinForms;
using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private void setText()
        {
            foreach(DataRow dr in ThuChiBUS.GetPhieuThuChi(
                "SELECT * " +
                "FROM PhieuThuChi " +
                "WHERE MaPhieuThuChi = '"+maphieuthuchi+"'").Rows)
            {
                dtSuaThoiGian.Value = DateTime.Parse(dr["ThoiGian"].ToString());
                cmbSuaLoaiHinh.SelectedItem = dr["LoaiHinh"].ToString();
                txtSuaSoTien.Text =int.Parse( dr["SoTien"].ToString().Replace(",","")).ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
                txtSuaNoiDung.Text = dr["NoiDung"].ToString();
            }    
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

        private void txtSuaSoTien_OnValueChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtSuaSoTien);
        }
        public void AddCommaToTextBox(Guna2TextBox guna2TextBox)
        {
            string value = guna2TextBox.Text.Replace(",", "")
                .Replace("đ", "").Replace(".", "").TrimStart('0');
            decimal ul;
            if (decimal.TryParse(value, out ul))
            {
                guna2TextBox.Text = string.Format("{0:#,###}", ul);
                var length = guna2TextBox.Text.Length;
                guna2TextBox.SelectionStart = length;
            }
        }

        private void dialogSuaThuChi_Load(object sender, EventArgs e)
        {
            setText();
        }

        private void txtSuaSoTien_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(txtSuaSoTien);
        }

        private void txtSuaSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
