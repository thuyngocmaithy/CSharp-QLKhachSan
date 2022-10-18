using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhachSanDAO;
using QLKhachSanDTO;
using QLKhachSan;
using QLKhachSan.BUS;

namespace QLKhachSan.GUI.QLHeThongGUI.QLMenuGUI
{
    public partial class newdialogSuamenu : Form
    {
        public newdialogSuamenu()
        {
            InitializeComponent();
        }
        

        private void newdialogSuamenu_Load(object sender, EventArgs e)
        {
            richTextBoxMaMenu.Text = frmQLMenu.selectedrow.Cells[0].Value.ToString();
            richTextBoxTenMenu.Text = frmQLMenu.selectedrow.Cells[1].Value.ToString(); 
            richTextBoxLoaiMenu.Text = frmQLMenu.selectedrow.Cells[2].Value.ToString(); 
            richTextBoxGianhap.Text = frmQLMenu.selectedrow.Cells[3].Value.ToString();
            richTextBoxGiaban.Text = frmQLMenu.selectedrow.Cells[4].Value.ToString();
            richTextBoxUutien.Text = frmQLMenu.selectedrow.Cells[5].Value.ToString();
            //richTextBoxMaMenu.Text = frmQLMenu.selectedcell.RowNumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(richTextBoxGiaban.Text == "" ||richTextBoxGianhap.Text == "" || richTextBoxLoaiMenu.Text == "" || richTextBoxMaMenu.Text == "" || richTextBoxTenMenu.Text == "" || richTextBoxUutien.Text == "")
            {
                MessageBox.Show("Các ô chưa được đầy dữ liệu");
            }
            
                int uutienhienthi;
                String ut = richTextBoxUutien.Text;
                uutienhienthi = int.Parse(ut);
                double gianhap = double.Parse(richTextBoxGianhap.Text); ;
                double giaban = double.Parse(richTextBoxGiaban.Text);
                MenuDTO mn = new MenuDTO(richTextBoxMaMenu.Text, richTextBoxTenMenu.Text, richTextBoxLoaiMenu.Text, gianhap, giaban, uutienhienthi);
                MenuBUS mnBUS = new MenuBUS();
                if (mnBUS.SuaMenu(mn))
                {
                    MessageBox.Show("Sửa Dữ Liệu Thành Công");



                }
                else
                {
                    MessageBox.Show("sửa Dữ Liệu Thất Bại");

                }
                
            
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static newdialogSuamenu dialogSuaMenu;
        public static newdialogSuamenu GetNewdialogSuamenu
        {

            get
            {
                if (dialogSuaMenu == null)
                {
                    dialogSuaMenu = new newdialogSuamenu();
                }
                return dialogSuaMenu;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
