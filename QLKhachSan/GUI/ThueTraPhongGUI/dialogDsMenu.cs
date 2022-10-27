using QLKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLKhachSan.GUI.ThueTraPhongGUI
{
    public partial class dialogDsMenu : Form
    {
        List<string> lsMenu = new List<string>();
        Label lblTenmenu;
        ToolStripMenuItem menuItem;
        MenuBUS menuBUS = new MenuBUS();
        string mahoadon;
        public List<string> LsMenu { get => lsMenu; set => lsMenu = value; }

        public dialogDsMenu(string mahoadon)
        {
            InitializeComponent();
            this.mahoadon = mahoadon;
        }
        private void dialogDsMenu_Load(object sender, EventArgs e)
        {
            foreach (DataRow data in menuBUS.GetMenu().Rows)
            {
                menuItem = new ToolStripMenuItem();
                menuItem.Name = "menu" + data["LoaiMenu"].ToString();
                menuItem.Tag = data["LoaiMenu"].ToString();
                menuItem.Size = new System.Drawing.Size(100, 30);
                menuItem.Text = data["LoaiMenu"].ToString();
                menuMenu.Items.Add(menuItem);
                this.menuItem.Click += new System.EventHandler(clickChonLoaiMenu);
            }
            getAllMenu();
        }

        private void getAllMenu()
        {
            foreach (DataRow data in menuBUS.GetMenu("SELECT MaMenu, TenMenu " +
                "FROM Menu " +
                "WHERE MaMenu Not in (SELECT MaMenu " +
                "FROM HoaDon_Menu " +
                "WHERE MaHoaDon='" + mahoadon + "')").Rows)
            {
                taoButtonMenu(data["MaMenu"].ToString(), data["TenMenu"].ToString());
            }
        }
        private void taoButtonMenu(string name, string text)
        {
            lblTenmenu = new Label();
            this.lblTenmenu.AutoSize = true;
            this.lblTenmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTenmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTenmenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.lblTenmenu.Location = new System.Drawing.Point(10, 10);
            this.lblTenmenu.Margin = new System.Windows.Forms.Padding(10);
            this.lblTenmenu.Name = name;
            this.lblTenmenu.Padding = new System.Windows.Forms.Padding(7);
            this.lblTenmenu.Size = new System.Drawing.Size(94, 48);
            this.lblTenmenu.TabIndex = 0;
            this.lblTenmenu.Text = text;
            this.lblTenmenu.Click += new System.EventHandler(clickChonMenu);
            pnlMenu.Controls.Add(lblTenmenu);


        }

        private void tấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlMenu.Controls.Clear();
            getAllMenu();
        }
        private void clickChonLoaiMenu(object sender, EventArgs e)
        {
            this.pnlMenu.Controls.Clear();
            ToolStripMenuItem itemLoaiMenu = (ToolStripMenuItem)sender;
            foreach (DataRow data in menuBUS.GetMenu(
                "SELECT MaMenu, TenMenu " +
                "FROM Menu " +
                "WHERE MaMenu Not in (SELECT MaMenu " +
                "FROM HoaDon_Menu " +
                "WHERE MaHoaDon='" + mahoadon + "') " +
                "AND LoaiMenu = '" + itemLoaiMenu.Tag.ToString() + "'").Rows)
            {
                taoButtonMenu(data["MaMenu"].ToString(), data["TenMenu"].ToString());
            }
        }
        private void clickChonMenu(object sender, EventArgs e)
        {
            Label lblMenu = (Label)sender;
            LsMenu.Add(lblMenu.Name);
            lblMenu.Visible = false;
        }

        private void btnMenuChon_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
