using QLKhachSan.BUS;
using QLKhachSanDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.GUI.QLHeThongGUI.QLMenuGUI
{
    public partial class dialogThemMenu : Form
    {
        public dialogThemMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(richTextBoxMaMenu.Text == " "|| richTextBoxTenMenu.Text == " "|| richTextBoxLoaiMenu.Text == " "|| richTextBoxGianhap.Text == " "|| richTextBoxGiaban.Text == " "|| richTextBoxUutien.Text == " ")
            {
                MessageBox.Show("Dữ liệu chưa được nhập đầy đủ");
            }
            else
            {
                int uutienhienthi;
                String ut = richTextBoxUutien.Text;
                uutienhienthi = int.Parse(ut);
                double gianhap = double.Parse(richTextBoxGianhap.Text); ;
                double giaban = double.Parse(richTextBoxGiaban.Text);
                MenuDTO mn = new MenuDTO(richTextBoxMaMenu.Text, richTextBoxTenMenu.Text, richTextBoxLoaiMenu.Text, gianhap, giaban,uutienhienthi);
                MenuBUS mnBUS = new MenuBUS();
                if (mnBUS.ThemMenu(mn))
                {
                    MessageBox.Show("Thêm Dữ Liệu Thành Công");

                    resetText();

                }
                else
                {
                    MessageBox.Show("Thêm Dữ Liệu Thất Bại");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
