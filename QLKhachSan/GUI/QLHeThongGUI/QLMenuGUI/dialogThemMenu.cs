using Guna.UI2.WinForms;
using QLKhachSan.BUS;
using QLKhachSanDTO;
using System;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.QLMenuGUI
{
    public partial class dialogThemMenu : Form
    {
        MenuBUS mnBUS = new MenuBUS();
        public dialogThemMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(richTextBoxTenMenu.Text == " "|| richTextBoxLoaiMenu.Text == " "|| richTextBoxGianhap.Text == " "|| richTextBoxGiaban.Text == " "|| richTextBoxUutien.Text == " ")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                string mamenu = mnBUS.TaoMaMenu();
                int uutienhienthi;
                String ut = richTextBoxUutien.Text;
                uutienhienthi = int.Parse(ut);
                string gianhap = richTextBoxGianhap.Text;
                string giaban = richTextBoxGiaban.Text;
                MenuDTO mn = new MenuDTO(mamenu, richTextBoxTenMenu.Text, richTextBoxLoaiMenu.Text, gianhap, giaban,uutienhienthi);
               
                if (mnBUS.ThemMenu(mn))
                {
                    MessageBox.Show("Thêm Thành Công");
                    resetText();

                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại");
                    resetText();
                }
            }
        }

        private void resetText()
        {
            richTextBoxTenMenu.Text = "";
            richTextBoxLoaiMenu.Text = "";
            richTextBoxGianhap.Text = "";
            richTextBoxGiaban.Text = "";
            richTextBoxUutien.Text = "";
        }

        private void richTextBoxGianhap_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(richTextBoxGianhap);
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

        private void richTextBoxGiaban_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(richTextBoxGiaban);
        }

        private void richTextBoxGianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void richTextBoxGiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void richTextBoxUutien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
