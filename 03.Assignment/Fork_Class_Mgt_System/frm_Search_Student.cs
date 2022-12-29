using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fork_Class_Mgt_System
{
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Login_Details;Integrated Security=True");
       
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
        private void btn_Search_Click(object sender, EventArgs e)
        {
           
                Con_Open();

                SqlCommand Cmd = new SqlCommand("Select * From Student_Details Where Roll_No = @RNo", Con);

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Mob_No.Text = (Dr["Mob_No"].ToString());
                    cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                }
                else
                {
                    MessageBox.Show("No Record Found", "Invalid Roll No");
                    tb_Roll_No.Clear();
                }

                Con_Close();
            
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "31-12-2000";
            cmb_Course.SelectedIndex = -1;
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();

            }
        }

        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Add_Student Obj = new frm_Add_Student();
            Obj.Show();
            this.Hide();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            frm_View_Data Obj = new frm_View_Data();
            Obj.Show();
            this.Hide();
        }
    }
}
