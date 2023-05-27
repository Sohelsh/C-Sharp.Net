using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "Admin" && tb_Password.Text == "2023")
            {
                MessageBox.Show("Login Successfull","Welcome",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                frm_Add_Products Obj = new frm_Add_Products();
                Obj.Show();
                this.Hide();
            }
            else if(tb_Username.Text == "" && tb_Password.Text == "")
            {
                lbl_Error.Visible = true;
            }
            else
            {
                lbl_Error.Text = "Invalid Passsword or Username";
                lbl_Error.ForeColor = Color.DarkRed;
            }
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Error.Visible = true;
        }
    }
}
