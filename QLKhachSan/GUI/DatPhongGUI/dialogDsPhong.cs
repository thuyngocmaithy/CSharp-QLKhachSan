using Bunifu.Framework.UI;
using QLKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLKhachSan.GUI.DatPhongGUI
{
    public partial class dialogDsPhong : Form
    {
        List<string> lsPhong=new List<string>();
        LoaiPhongBUS loaiPhongBUS = new LoaiPhongBUS();
        PhongBUS phongBUS = new PhongBUS();
        ToolStripMenuItem menuItem;
        BunifuFlatButton btnPhong;

        public List<string> LsPhong { get => lsPhong; set => lsPhong = value; }

        public dialogDsPhong()
        {
            InitializeComponent();
        }

        private void dialogDsPhong_Load(object sender, EventArgs e)
        {
            foreach (DataRow data in loaiPhongBUS.GetLoaiPhong().Rows)
            {
                menuItem = new ToolStripMenuItem();
                menuItem.Name = "menu" + data["MaLoaiPhong"].ToString();
                menuItem.Tag = data["MaLoaiPhong"].ToString();
                menuItem.Size = new System.Drawing.Size(100, 30);
                menuItem.Text = data["TenLoaiPhong"].ToString();
                menuLoaiPhong.Items.Add(menuItem);
                this.menuItem.Click += new System.EventHandler(clickChonMenu);
            }
            getAllPhong();
        }
        private void getAllPhong()
        {
            foreach (DataRow data in phongBUS.GetPhong().Rows)
            {
                taoButtonPhong(data["MaPhong"].ToString());
            }
        }
        private void taoButtonPhong(string name)
        {
            btnPhong = new BunifuFlatButton();
            btnPhong.AutoSize = false;
            btnPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            btnPhong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            btnPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnPhong.BorderRadius = 7;
            btnPhong.ButtonText = name;
            btnPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPhong.DisabledColor = System.Drawing.Color.Gray;
            btnPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPhong.Iconcolor = System.Drawing.Color.Transparent;
            btnPhong.Iconimage = null;
            btnPhong.Iconimage_right = null;
            btnPhong.Iconimage_right_Selected = null;
            btnPhong.Iconimage_Selected = null;
            btnPhong.IconMarginLeft = 0;
            btnPhong.IconMarginRight = 0;
            btnPhong.IconRightVisible = true;
            btnPhong.IconRightZoom = 0D;
            btnPhong.IconVisible = true;
            btnPhong.IconZoom = 40D;
            btnPhong.IsTab = true;
            btnPhong.Location = new System.Drawing.Point(0, 0);
            btnPhong.Margin = new System.Windows.Forms.Padding(0);
            btnPhong.Name = name;
            btnPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            btnPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            btnPhong.OnHoverTextColor = System.Drawing.Color.White;
            btnPhong.selected = false;
            btnPhong.Size = new System.Drawing.Size(100, 50);
            btnPhong.TabIndex = 22;
            btnPhong.Text = name;
            btnPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnPhong.Textcolor = System.Drawing.Color.White;
            btnPhong.TextFont = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            pnlPhong.Controls.Add(btnPhong);
            btnPhong.Margin = new Padding(10, 10, 20, 10);
            this.btnPhong.Click += new System.EventHandler(clickChonPhong);


        }

        private void tấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlPhong.Controls.Clear();
            getAllPhong();
        }
        private void clickChonMenu(object sender, EventArgs e)
        {
            this.pnlPhong.Controls.Clear();
            ToolStripMenuItem itemLoaiPhong = (ToolStripMenuItem)sender;
            foreach (DataRow data in phongBUS.GetPhong(
                "SELECT * FROM Phong" +
                " WHERE MaLoaiPhong = '"+ itemLoaiPhong.Tag.ToString() + "'").Rows)
            {
                taoButtonPhong(data["MaPhong"].ToString());
            }
        }
        private void clickChonPhong(object sender, EventArgs e)
        {
            BunifuFlatButton btnPhong = (BunifuFlatButton)sender;
            LsPhong.Add(btnPhong.Name);
            btnPhong.Visible = false;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
