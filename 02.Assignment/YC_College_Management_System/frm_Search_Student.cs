using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YC_College_Management_System
{
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ass_No_Two_YC_Student_Details_db;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Roll_No.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand("Select * From YC_Student_Details Where Roll_No = @RNo", Con);

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Mob_No.Text = (Dr["Mob_No"].ToString());
                    cmd_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                }
                else
                {
                    MessageBox.Show("No Record Found", "Invalid Roll No");
                    tb_Roll_No.Clear();
                }

                Con_Close();
            }
            else
            {
                MessageBox.Show("Enter Roll Number");
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            dtp_DOB.Text = "31-12-2000";
            cmd_Course.SelectedIndex = -1;
            tb_Mob_No.Clear();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();
            }
        }

        private void btn_View_Student_Details_Click(object sender, EventArgs e)
        {
            frm_View_Student_Details Obj = new frm_View_Student_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Add_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details Obj = new frm_Add_Student_Details();
            Obj.Show();
            this.Hide();
        }
    }
}
