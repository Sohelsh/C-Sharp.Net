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
    public partial class frm_Login_Page : Form
    {
        public frm_Login_Page()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "Admin" && tb_Password.Text == "1234")
            {
                MessageBox.Show("Login Successfully", "Welcome", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                frm_Add_Student_Detalis Obj = new frm_Add_Student_Detalis();
                Obj.Show();
                this.Hide();
            }
            else
            { 
                lbl_Error.Text = "Invalid Username && Password";
                lbl_Error.ForeColor = Color.Red;
            }
            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_Error.Visible = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    }
}
