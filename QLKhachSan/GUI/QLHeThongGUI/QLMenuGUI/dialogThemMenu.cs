using QLKhachSan.BUS;
using QLKhachSanDTO;
using System;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.QLMenuGUI
{
    public partial class dialogThemMenu : Form
    {
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
            
            if(richTextBoxMaMenu.Text == " "|| richTextBoxTenMenu.Text == " "|| richTextBoxLoaiMenu.Text == " "|| richTextBoxGianhap.Text == " "|| richTextBoxGiaban.Text == " "|| richTextBoxUutien.Text == " ")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                int uutienhienthi;
                String ut = richTextBoxUutien.Text;
                uutienhienthi = int.Parse(ut);
                string gianhap = richTextBoxGianhap.Text;
                string giaban = richTextBoxGiaban.Text;
                MenuDTO mn = new MenuDTO(richTextBoxMaMenu.Text, richTextBoxTenMenu.Text, richTextBoxLoaiMenu.Text, gianhap, giaban,uutienhienthi);
                MenuBUS mnBUS = new MenuBUS();
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
            richTextBoxMaMenu.Text = "";
            richTextBoxTenMenu.Text = "";
            richTextBoxLoaiMenu.Text = "";
            richTextBoxGianhap.Text = "";
            richTextBoxGiaban.Text = "";
            richTextBoxUutien.Text = "";
        }




    }
}
