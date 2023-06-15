using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Software_Technology_Company_Mgt_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection (@"Data Source=LAPTOP-RCQ0TGDA;Initial Catalog=Software_Technologies_PVT_LTD;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }

        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Login_Details where Username = @Username And Password = @Password";
            Cmd.Parameters.Add("Username",SqlDbType.VarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Password",SqlDbType.VarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (tb_Username.Text == ""&& tb_Password.Text == "")
            {
                lbl_Error1.Visible = true;
                lbl_Error2.Visible = true;
            }
            else if(tb_Username.Text == "")
            {
                lbl_Error1.Visible = true;
            }
            else if(tb_Password.Text == "")
            {
                lbl_Error2.Visible = true;
            }

            else if(Cnt > 0)
            {
                Share_Class.Username = tb_Username.Text;
                MessageBox.Show("Login Successfully","Welcome",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                frm_Employe_Info Obj = new frm_Employe_Info();
                Obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Error1.Visible = true;
                lbl_Error2.Visible = true;
                lbl_Error1.Text = "Invalid Username";
                lbl_Error2.Text = "Invalid Password";
                lbl_Error1.ForeColor = Color.Crimson;
                lbl_Error2.ForeColor = Color.Crimson;
            }

            Con_Close();
        }

        private void lbl_Reset_Click(object sender, EventArgs e)
        {
            tb_Username.Clear();
            tb_Password.Clear();
        }
    }
}
