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
