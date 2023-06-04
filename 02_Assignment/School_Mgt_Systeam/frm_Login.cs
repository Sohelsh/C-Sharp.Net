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

namespace School_Mgt_Systeam
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-RCQ0TGDA\;Initial Catalog=School_Mgt_Systeam;Integrated Security=True");

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
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count (*) From Login_Details where Uname = @Uname And Pwd = @Pwd";
            Cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if(Cnt > 0)
            {
                MessageBox.Show("Login Succefully", "Welcome", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

              
                Shares_Class.Username = tb_Username.Text;

                frm_Add_Info Obj = new frm_Add_Info();
                Obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Error.Text = "Invalid Username Or Password";
                lbl_Error.Show();
                lbl_Error.ForeColor = Color.DarkRed;
            }

            tb_Username.Clear();
            tb_Password.Clear();
            Con_Close();
        }
    }
}
