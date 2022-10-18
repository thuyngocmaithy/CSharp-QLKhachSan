using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhachSan.BUS;
using QLKhachSanDAO;
using QLKhachSan;
using QLKhachSan.GUI.QLHeThongGUI.QLMenuGUI;
using System.Reflection;


namespace QLKhachSan.GUI.QLHeThongGUI
{
    public partial class frmQLMenu : Form
    {
        public frmQLMenu()
        {
            InitializeComponent();
        }

        private void frmQLMenu_Load(object sender, EventArgs e)
        {
            MenuBUS mnBUS = new MenuBUS();
            dataGridMenu.DataSource = mnBUS.GetMenu();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dialogThemMenu dialogThem = new dialogThemMenu();
            dialogThem.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aaa1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblReset_Click(object sender, EventArgs e)
        {
                Reset();
        }
        public static DataGridViewRow selectedrow;
        public static DataGridViewCell selectedcell;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /*if(e.RowIndex > 1)
            {   
                selectedrow = dataGridMenu.Rows[e.RowIndex];
                newdialogSuamenu.GetNewdialogSuamenu.ShowDialog();
            }*/
           
        }


        public void Reset()
        {
            MenuBUS mnBUS = new MenuBUS();
            dataGridMenu.DataSource = mnBUS.GetMenu();

            this.dataGridMenu.Sort(this.dataGridMenu.Columns["uutien"], ListSortDirection.Ascending);
            ///this.dataGridMenu.Columns["uutien"].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e )
        {

            /*Int32 selectedRowCount = dataGridMenu.Rows.GetRowCount(DataGridViewElementStates.Selected);
             if( selectedRowCount >= 0)
             {

                 newdialogSuamenu newdialog = new newdialogSuamenu();
                 newdialog.ShowDialog();
             }*/
            if (dataGridMenu.CurrentRow.Index != -1)
            {
                selectedrow = dataGridMenu.CurrentRow;
                newdialogSuamenu newdialog = new newdialogSuamenu();
                newdialog.ShowDialog();
            }
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
            
            string mn = dataGridMenu.CurrentRow.Cells[0].Value.ToString();
            
            int r = this.dataGridMenu.CurrentCell.RowIndex;
            int c = this.dataGridMenu.CurrentCell.ColumnIndex;
            string m = dataGridMenu.Rows[r].Cells[c].ToString();
            int selectedCount = dataGridMenu.SelectedRows.Count;
            dataGridMenu.Rows.RemoveAt(selectedCount);

            MenuBUS menu = new MenuBUS();
            if (menu.XoaMenu(mn))
                {  
                    MessageBox.Show("xóa dữ liệu thành công" + mn);
                menu.GetMenu("Select * from Menu");
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại " + mn);
                }
               
                
            
        }

        private void dataGridMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dataGridMenu.CurrentRow.Index != -1)
            {
                selectedrow = dataGridMenu.CurrentRow;
                newdialogSuamenu newdialog = new newdialogSuamenu();
                newdialog.ShowDialog() ;
            }*/
        }
    }
}
