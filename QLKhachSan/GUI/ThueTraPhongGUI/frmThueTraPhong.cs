using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    public partial class frmThueTraPhong : Form
    {
        int flag = 0;
        Boolean up = true;
        string mataikhoan;
        public frmThueTraPhong(string mataikhoan)
        {
            InitializeComponent();
            this.mataikhoan = mataikhoan;
        }
        private void frmThueTraPhong_Load(object sender, EventArgs e)
        {
            HienPhongCho("","");
        }
        
        private void HienPhongCho(string sapxeptheo, string valueFind)
        {
            pnlThueTraPhong.Controls.Clear();
            frmPhongCho frmPhongCho = new frmPhongCho(sapxeptheo, up, valueFind, mataikhoan);
            frmPhongCho.TopLevel = false;
            frmPhongCho.AutoScroll = true;
            pnlThueTraPhong.Controls.Add(frmPhongCho);
            frmPhongCho.Show();
        }
        public void HienPhongCanDon(string sapxeptheo, string valueFind)
        {
            pnlThueTraPhong.Controls.Clear();
            frmPhongChoDon frmPhongChoDon = new frmPhongChoDon(sapxeptheo, up, valueFind);
            frmPhongChoDon.TopLevel = false;
            frmPhongChoDon.AutoScroll = true;
            pnlThueTraPhong.Controls.Add(frmPhongChoDon);
            frmPhongChoDon.Show();
        }
        public void HienPhongDangThue(string sapxeptheo, string valueFind)
        {
            pnlThueTraPhong.Controls.Clear();
            frmPhongDangThue frmPhongDangThue = new frmPhongDangThue(sapxeptheo, up, valueFind, mataikhoan);
            frmPhongDangThue.TopLevel = false;
            frmPhongDangThue.AutoScroll = true;
            pnlThueTraPhong.Controls.Add(frmPhongDangThue);
            frmPhongDangThue.Show();
        }
        private void HienLichSu(string sapxeptheo, string valueFind)
        {
            pnlThueTraPhong.Controls.Clear();
            frmLichSu frmLichSu = new frmLichSu(sapxeptheo, up, valueFind);
            frmLichSu.TopLevel = false;
            frmLichSu.AutoScroll = true;
            pnlThueTraPhong.Controls.Add(frmLichSu);
            frmLichSu.Show();
        }
        private void btnPhongCho_Click(object sender, EventArgs e)
        {
            HienPhongCho("", "");
        }
        private void btnPhongCanDon_Click(object sender, EventArgs e)
        {
            HienPhongCanDon("", "");
        }

        private void btnPhongDangThue_Click(object sender, EventArgs e)
        {
            HienPhongDangThue("", "");
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            HienLichSu("", "");
        }

        private void cmbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtFind.Text=="Tìm kiếm")
            {
                HienPhongCho(cmbSapXep.SelectedItem.ToString(), "");
                HienPhongCanDon(cmbSapXep.SelectedItem.ToString(), "");
                HienPhongDangThue(cmbSapXep.SelectedItem.ToString(), "");
                HienLichSu(cmbSapXep.SelectedItem.ToString(), "");


            }
            else
            HienPhongCho(cmbSapXep.SelectedItem.ToString(), txtFind.Text);
            HienPhongCanDon(cmbSapXep.SelectedItem.ToString(), txtFind.Text);
            HienPhongDangThue(cmbSapXep.SelectedItem.ToString(), txtFind.Text);
            HienLichSu(cmbSapXep.SelectedItem.ToString(), txtFind.Text);
        }

        private void btnTangGiam_Click(object sender, EventArgs e)
        {
            if(flag%2==0)
            {
                this.btnTangGiam.Image = Image.FromFile
              (Path.GetFullPath(@"icon\down_30px.png"));
                flag++;
                up = false;
                HienPhongCho(cmbSapXep.SelectedItem.ToString(),"");
                HienPhongCanDon(cmbSapXep.SelectedItem.ToString(), "");
                HienPhongDangThue(cmbSapXep.SelectedItem.ToString(), "");
                HienLichSu(cmbSapXep.SelectedItem.ToString(), "");
            }    
            else
            {
                this.btnTangGiam.Image = Image.FromFile
              (Path.GetFullPath(@"icon\up_30px.png"));
                flag++;
                up = true;
                HienPhongCho(cmbSapXep.SelectedItem.ToString(),"");
                HienPhongCanDon(cmbSapXep.SelectedItem.ToString(), "");
                HienPhongDangThue(cmbSapXep.SelectedItem.ToString(), "");
                HienLichSu(cmbSapXep.SelectedItem.ToString(), "");
            }    
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if(cmbSapXep.SelectedItem==null)
            {
                HienPhongCho("", txtFind.Text);
                HienPhongCanDon("", txtFind.Text);
                HienPhongDangThue("", txtFind.Text);
                HienLichSu("", txtFind.Text);


            }
            else
            HienPhongCho(cmbSapXep.SelectedItem.ToString(), txtFind.Text);
            HienPhongCanDon(cmbSapXep.SelectedItem.ToString(), txtFind.Text);
            HienPhongDangThue(cmbSapXep.SelectedItem.ToString(), txtFind.Text);
            HienLichSu(cmbSapXep.SelectedItem.ToString(), txtFind.Text);
        }

        private void txtFind_Click(object sender, EventArgs e)
        {
            txtFind.ResetText();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlThueTraPhong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}