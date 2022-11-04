using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGM_Mgt_System
{
    public partial class frm_View_Student_Detalis : Form
    {
        public frm_View_Student_Detalis()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login_Page Obj = new frm_Login_Page();
            Obj.Show();
            this.Hide();
        }

        private void btn_Add_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Detalis Obj = new frm_Add_Student_Detalis();
            Obj.Show();
            this.Hide();
        }

        private void frm_View_Student_Detalis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sGM_Students_Detelis_dbDataSet.SGM_Student_Detalis' table. You can move, or remove it, as needed.
            this.sGM_Student_DetalisTableAdapter.Fill(this.sGM_Students_Detelis_dbDataSet.SGM_Student_Detalis);

        }
    }
}
