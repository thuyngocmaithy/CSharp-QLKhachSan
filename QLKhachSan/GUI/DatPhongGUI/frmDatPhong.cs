using QLKhachSan.BUS;
using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLKhachSan.GUI.DatPhongGUI
{
    public partial class frmDatPhong : Form
    {
        PhieuDatPhongBUS phieuDatPhongBUS= new PhieuDatPhongBUS();
        public frmDatPhong()
        {
            InitializeComponent();
        }
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
           
        }
    }
}
