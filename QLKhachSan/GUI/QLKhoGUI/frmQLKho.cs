using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhachSan.GUI.QLKhoGUI.PNKho;
using QLKhachSan.GUI.QLKhoGUI.TinhTrangKho;
using QLKhachSan.GUI.QLKhoGUI.DieuChinhKho;
using QLKhachSan.GUI.QLKhoGUI.PhieuKiemKho;

namespace QLKhachSan.GUI.QLKhoGUI
{
    public partial class frmQLKho : Form
    {
        public frmQLKho()
        {
            InitializeComponent();
        }

        private void btnPNKho_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmPNKho frmPNKho = new frmPNKho();
            frmPNKho.TopLevel = false;
            frmPNKho.AutoScroll = true;
            this.Controls.Add(frmPNKho);
            frmPNKho.Show();

        }

        private void btnTinhTrangKho_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmTinhTrangKho frmTinhTrangKho = new frmTinhTrangKho();
            frmTinhTrangKho.TopLevel = false;
            frmTinhTrangKho.AutoScroll = true;
            this.Controls.Add(frmTinhTrangKho);
            frmTinhTrangKho.Show();
        }

        private void btnDieuChinhKho_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmDieuChinhKho frmDieuChinhKho = new frmDieuChinhKho();
            frmDieuChinhKho.TopLevel = false;
            frmDieuChinhKho.AutoScroll = true;
            this.Controls.Add(frmDieuChinhKho);
            frmDieuChinhKho.Show();
        }

        private void btnKiemKho_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmPhieuKiemKho frmPhieuKiemKho = new frmPhieuKiemKho();
            frmPhieuKiemKho.TopLevel = false;
            frmPhieuKiemKho.AutoScroll = true;
            this.Controls.Add(frmPhieuKiemKho);
            frmPhieuKiemKho.Show();
        }
    }
}
