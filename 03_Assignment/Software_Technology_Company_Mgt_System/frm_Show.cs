using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Technology_Company_Mgt_System
{
    public partial class frm_Show : Form
    {
        public frm_Show()
        {
            InitializeComponent();
        }

        private void lbl_Employee_Click(object sender, EventArgs e)
        {
            frm_Employe_Info Obj = new frm_Employe_Info();
            Obj.Show();
            this.Hide();
        }

        private void lbl_List_Click(object sender, EventArgs e)
        {
            frm_Show Obj = new frm_Show();
            Obj.Show();
            this.Hide();
        }

        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();

            }
        }

        private void frm_Show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'software_Technologies_PVT_LTDDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.software_Technologies_PVT_LTDDataSet.Employee_Details);

        }

        private void dgv_Employee_Info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
