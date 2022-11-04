using Guna.UI2.WinForms;
using QLKhachSan.BUS;
using QLKhachSanDTO;
using System;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.QLMenuGUI
{
    public partial class dialogSuaMenu : Form
    {
        MenuBUS mnBUS = new MenuBUS();
        string mamenu, tenmenu, loaimenu, gianhap, giaban, uutienhienthi;
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


        private void richTextBoxGianhap_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(richTextBoxGianhap);
        }

        private void richTextBoxGiaban_TextChanged(object sender, EventArgs e)
        {
            AddCommaToTextBox(richTextBoxGiaban);
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

        private void richTextBoxGianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public dialogSuaMenu(string mamenu, string tenmenu, string loaimenu, string gianhap,
            string giaban, string uutienhienthi)
        {
            InitializeComponent();
            this.mamenu = mamenu;
            this.tenmenu = tenmenu;
            this.loaimenu = loaimenu;
            this.gianhap = gianhap;
            this.giaban = giaban;
            this.uutienhienthi = uutienhienthi;
        }

        private void dialogSuaMenu_Load(object sender, EventArgs e)
        {
            richTextBoxTenMenu.Text = tenmenu;
            richTextBoxLoaiMenu.Text = loaimenu;
            richTextBoxGianhap.Text = gianhap;
            richTextBoxGiaban.Text = giaban;
            richTextBoxUutien.Text = uutienhienthi;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBoxGiaban.Text == "" || richTextBoxGianhap.Text == "" || richTextBoxLoaiMenu.Text == ""  || richTextBoxTenMenu.Text == "" || richTextBoxUutien.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }

            int uutienhienthi;
            String ut = richTextBoxUutien.Text;
            uutienhienthi = int.Parse(ut);
            string gianhap = richTextBoxGianhap.Text;
            string giaban = richTextBoxGiaban.Text;
            MenuDTO mn = new MenuDTO(mamenu, richTextBoxTenMenu.Text, richTextBoxLoaiMenu.Text, gianhap, giaban, uutienhienthi);
            if (mnBUS.SuaMenu(mn))
            {
                MessageBox.Show("Sửa Thành Công");



            }
            else
            {
                MessageBox.Show("sửa Thất Bại");

            }
        }
    }
}
