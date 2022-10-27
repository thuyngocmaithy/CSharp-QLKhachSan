using QLKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace QLKhachSan.GUI.DatPhongGUI
{
    public partial class dialogDsPhongNhan : Form
    {
        FlowLayoutPanel pnlPhong, pnlTopPhong, pnlBottomPhong;
        Label lblTenPhong, lblTrangThai;
        Button btnOption;
        CheckBox ckb;
        List<CheckBox> lsCkb = new List<CheckBox>();
        LoaiPhongBUS loaiPhongBUS = new LoaiPhongBUS();
        PhongBUS phongBUS = new PhongBUS();
        PhieuDatPhongBUS phieuDatPhongBUS = new PhieuDatPhongBUS();
        ToolStripMenuItem menuItem;

        string maphieudatphong;
        public dialogDsPhongNhan(string maphieudatphong)
        {
            InitializeComponent();
            this.maphieudatphong = maphieudatphong;
        }
        private void getAllPhong()
        {
            foreach (DataRow data in phongBUS.GetPhong(
                "SELECT * FROM Phong WHERE TinhTrang = N'Phòng chờ' OR TinhTrang = N'Phòng chờ dọn'").Rows)
            {
                taoPnlPhong(data["MaPhong"].ToString(), data["TinhTrang"].ToString());
            }
        }
        private void taoPnlPhong(string name, string text)
        {
            taoPnlTopPhong(name, text);
            taoPnlBottomPhong(name, text);
            pnlPhong = new FlowLayoutPanel();
            pnlPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pnlPhong.Controls.Add(this.pnlTopPhong);
            pnlPhong.Controls.Add(this.pnlBottomPhong);
            pnlPhong.Location = new System.Drawing.Point(3, 3);
            pnlPhong.Margin = new System.Windows.Forms.Padding(0, 0, 40, 40);
            pnlPhong.Name = "pnl" + name;
            pnlPhong.Size = new System.Drawing.Size(200, 100);
            pnlPhong.TabIndex = 1;
            pnlDsPhong.Controls.Add(pnlPhong);
        }
        private void taoLblPhong(string name)
        {
            lblTenPhong = new Label();
            lblTenPhong.AutoSize = false;
            this.lblTenPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTenPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.Location = new System.Drawing.Point(0, 0);
            this.lblTenPhong.Name = "lbl" + name;
            this.lblTenPhong.Size = new System.Drawing.Size(120, 45);
            this.lblTenPhong.TabIndex = 4;
            this.lblTenPhong.Text = name;
            this.lblTenPhong.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);

        }
        private void taoBtnOption(string name, string text)
        {
            btnOption = new Button();
            btnOption.Cursor = System.Windows.Forms.Cursors.Hand;
            btnOption.Dock = DockStyle.Right;
            if (text == "Phòng chờ")
            {
                btnOption.Image = Image.FromFile
                (Path.GetFullPath(@"icon\reduce_30px.png"));
                btnOption.Image.Tag = "Check";
            }
            else
            {
                btnOption.Image = Image.FromFile
                (Path.GetFullPath(@"icon\Plus_30px.png"));
                btnOption.Image.Tag = "UnCheck";

            }

            //     btnOption.Location = new System.Drawing.Point(148, 0);
            btnOption.MinimumSize = new System.Drawing.Size(40, 40);
            btnOption.Name = name;
            btnOption.Size = new System.Drawing.Size(40, 40);
            btnOption.TabIndex = 2;
            btnOption.Click += new System.EventHandler(clickChonPhong);

        }
        private void clickChonPhong(object sender, EventArgs e)
        {
            if ((((Button)sender).Image.Tag.ToString()) == "Check")
            {
                ((Button)sender).Image = Image.FromFile
               (Path.GetFullPath(@"icon\Plus_30px.png"));
                ((Button)sender).Image.Tag = "UnCheck";
                string maphong = ((Button)sender).Name.ToString();
                foreach(var ckb in lsCkb)
                {
                    if(ckb.Name.ToString().Substring(3) == maphong)
                    {
                        ckb.Checked = false;
                    }    
                }    
            }
            else
            {
                ((Button)sender).Image = Image.FromFile
                (Path.GetFullPath(@"icon\reduce_30px.png"));
                ((Button)sender).Image.Tag = "Check";
                string maphong = ((Button)sender).Name.ToString();
                foreach (var ckb in lsCkb)
                {
                    if (ckb.Name.ToString().Substring(3) == maphong)
                    {
                        ckb.Checked = true;
                    }
                }
            }    


        }
        private void dialogDsPhongNhan_Load(object sender, EventArgs e)
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
        private void clickChonMenu(object sender, EventArgs e)
        {
            this.pnlDsPhong.Controls.Clear();
            ToolStripMenuItem itemLoaiPhong = (ToolStripMenuItem)sender;
            foreach (DataRow data in phongBUS.GetPhong(
                "SELECT * FROM Phong" +
                " WHERE MaLoaiPhong = '" + itemLoaiPhong.Tag.ToString() + "'" +
                " AND (TinhTrang = N'Phòng chờ' OR TinhTrang = N'Phòng chờ dọn')").Rows)
            {
                taoPnlPhong(data["MaPhong"].ToString(), data["TinhTrang"].ToString());
            }
        }

        private void tấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlDsPhong.Controls.Clear();
            getAllPhong();
        }

        private void btnPhongChon_Click(object sender, EventArgs e)
        {
            int countCheck = 0;
            Boolean checkTrangThai = true;
            foreach (var ckb in lsCkb)
            {
                if (ckb.Checked)
                {
                    if(!phongBUS.SuaPhong(ckb.Name.ToString().Substring(3), "Phòng đang thuê"))
                    {
                        checkTrangThai = false;
                    }    
                    countCheck++;
                }
            }
            if (countCheck > 0)
            {
               if(! phieuDatPhongBUS.SuaPhieuDatPhong(maphieudatphong))
                {
                    checkTrangThai = false;
                }    
            }
            if(checkTrangThai)
            {
                MessageBox.Show("Nhận phòng thành công");
            }    
            this.Close();
        }


        private void taoLblTrangthai(string name, string text)
        {
            lblTrangThai = new Label();
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTrangThai.Location = new System.Drawing.Point(39, 15);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTrangThai.Name = "lblTrangThai" + name;
            this.lblTrangThai.Size = new System.Drawing.Size(170, 32);
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = text;
        }


        private void taoPnlTopPhong(string name, string text)
        {
            taoLblPhong(name);
            taoBtnOption(name, text);
            pnlTopPhong = new FlowLayoutPanel();
            pnlTopPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlTopPhong.Controls.Add(this.lblTenPhong);
            pnlTopPhong.Controls.Add(this.btnOption);
            pnlTopPhong.Location = new System.Drawing.Point(0, 0);
            pnlTopPhong.Margin = new System.Windows.Forms.Padding(0);
            pnlTopPhong.MaximumSize = new System.Drawing.Size(200, 50);
            pnlTopPhong.MinimumSize = new System.Drawing.Size(200, 50);
            pnlTopPhong.Name = "pnlTopPhong" + name;
            pnlTopPhong.Size = new System.Drawing.Size(200, 50);
            pnlTopPhong.TabIndex = 1;
        }
        private void taoPnlBottomPhong(string name, string text)
        {
            pnlBottomPhong = new FlowLayoutPanel();
            taoCheckbox(name, text);
            taoLblTrangthai(name, text);
            pnlTopPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlBottomPhong.Controls.Add(this.ckb);
            pnlBottomPhong.Controls.Add(this.lblTrangThai);
            pnlBottomPhong.Location = new System.Drawing.Point(0, 50);
            pnlBottomPhong.Margin = new System.Windows.Forms.Padding(0);
            pnlBottomPhong.Name = name;
            pnlBottomPhong.Size = new System.Drawing.Size(200, 50);
            pnlBottomPhong.TabIndex = 3;
        }
        private void taoCheckbox(string name, string text)
        {
            ckb = new CheckBox();
            if (text == "Phòng chờ")
            {
                ckb.Checked = true;
            }
            else
            {
                ckb.Checked = false;
            }
            ckb.Location = new System.Drawing.Point(3, 10);
            ckb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            ckb.MinimumSize = new System.Drawing.Size(30, 30);
            ckb.Name = "ckb" + name;
            ckb.Size = new System.Drawing.Size(30, 30);
            ckb.TabIndex = 0;
            ckb.UseVisualStyleBackColor = true;
            ckb.AutoCheck = false;
            lsCkb.Add(ckb);

        }
    }
}
