using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.GUI.MainPageGUI
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {

        }
        bool mnuExpanded = false;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!bunifuTransition1.IsCompleted) return;
            if(pnlMainMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if(!mnuExpanded)
                {
                    mnuExpanded = true;
                    pnlMainMenu.Visible = false;
                    pnlMainMenu.Width = 324;
                    bunifuTransition1.Show(pnlMainMenu);
                    lblLogoResize.Visible = false;
                }    
            }    
            else
            {
                if(mnuExpanded)
                {
                    mnuExpanded=false;
                    pnlMainMenu.Visible = false;
                    pnlMainMenu.Width = 85;
                    bunifuTransition1.Show(pnlMainMenu);
                    lblLogoResize.Visible = true;
                }    
            }    
        }
    }
}
