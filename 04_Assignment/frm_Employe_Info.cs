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
    public partial class frm_Employe_Info : Form
    {
        string Gender = "";
        string ChaekBox1 = "";
        string ChaekBox2 = "";
        string ChaekBox3 = "";
        public frm_Employe_Info()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection (@"Data Source=LAPTOP-RCQ0TGDA;Initial Catalog=Software_Technologies_PVT_LTD;Integrated Security=True");
                                                 
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

        private void lbl_List_Click(object sender, EventArgs e)
        {
            frm_Show Obj = new frm_Show();
            Obj.Show();
            this.Hide();
        }

        private void frm_Employe_Info_Load(object sender, EventArgs e)
        {
            lbl_UserName.Text = Share_Class.Username;
            Clear_Controls();
        }

        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = rb_Male.Text;
          
        }

        private void rb_Female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = rb_Female.Text;
           
        }

        private void cb_English_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_English.Checked == true)
            {
                ChaekBox1 = cb_English.Text;
;                
            }
            else
            {
                ChaekBox1 = "";
            }
        }

        private void cb_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Hindi.Checked == true)
            {
                ChaekBox2 = cb_Hindi.Text;
               
            }
            else
            {
                ChaekBox2 = "";
            }

        }

        private void cb_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Marathi.Checked == true)
            {
                ChaekBox3 = cb_Marathi.Text;
                
            }
            else
            {
                ChaekBox3 = "";
            }
        }

        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();


            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count (*) from Employee_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                Cmd.Dispose();
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Emp_ID) from Employee_Details";
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1;
            }

            Con_Close();
            return Cnt;
        }
      
        void Clear_Controls()
        {
            tb_Emp_ID.Text = Convert.ToString(Auto_Incr());
            tb_Educational_Background.Clear();
            tb_Address.Clear();
            tb_Con_Number.Clear();
            tb_Email.Clear();
            tb_Emergency_Contact_Name.Clear();
            tb_Emergency_Contact_Phone_Number.Clear();
            tb_Enter_Name.Clear();
            tb_Job_Title.Clear();
            tb_Relationship.Clear();
            tb_Search.Clear();
            cmb_Skills.SelectedIndex = -1;
            cmb_Department.SelectedIndex = -1;
            cmb_Emp_Status.SelectedIndex = -1;
            rb_Female.Checked = false;
            rb_Male.Checked = false;
            cb_English.Checked = false;
            cb_Hindi.Checked = false;
            cb_Marathi.Checked = false;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {                                                                                      
            

            if (tb_Enter_Name.Text != "" && tb_Address.Text != "" && tb_Con_Number.TextLength == 10 && tb_Educational_Background.Text != "" && tb_Job_Title.Text != "" && tb_Email.Text != "" && tb_Educational_Background.Text != "" && cmb_Department.Text != "" && cmb_Emp_Status.Text != "" && cmb_Skills.Text != "" && Gender != "" && (ChaekBox1 != "" || ChaekBox2 != "" || ChaekBox3 != ""))
            {
                Con_Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Employee_Details Values(@Id,@Name,@DOB,@Cont_No,@Gender,@Address,@Email,@Job,@Dept,@DOJ,@Status,@Edu,@Skill,@Lang)";
                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Emp_ID.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Enter_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Cont_No", SqlDbType.Decimal).Value = tb_Con_Number.Text;
                Cmd.Parameters.Add("Gender", SqlDbType.VarChar).Value = Gender;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email.Text;
                Cmd.Parameters.Add("Job", SqlDbType.NVarChar).Value = tb_Job_Title.Text;
                Cmd.Parameters.Add("Dept", SqlDbType.NVarChar).Value = cmb_Department.Text;
                Cmd.Parameters.Add("DOJ", SqlDbType.Date).Value = dtp_DOJ.Value.Date;
                Cmd.Parameters.Add("Status", SqlDbType.NVarChar).Value = cmb_Emp_Status.Text;
                Cmd.Parameters.Add("Edu", SqlDbType.NVarChar).Value = tb_Educational_Background.Text;
                Cmd.Parameters.Add("Skill", SqlDbType.NVarChar).Value = cmb_Skills.Text;
                Cmd.Parameters.Add("Lang", SqlDbType.VarChar).Value = ChaekBox1 + " " + ChaekBox2 + " " + ChaekBox3;

                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Insert Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All Information", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

             Con_Close();
        }

        private void Only_Numric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Letter(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void lbl_Employee_Click(object sender, EventArgs e)
        {
            frm_Employe_Info Obj = new frm_Employe_Info();
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Search.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Select * From Employee_Details Where Emp_ID = @ID";
                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Search.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Enter_Name.Text = Dr.GetString(Dr.GetOrdinal("Emp_Name"));
                    dtp_DOB.Text = (Dr["Emp_DOB"].ToString());
                    tb_Con_Number.Text = (Dr["Emp_Cont_No"].ToString());
                    //Gender = Dr.GetString(Dr.GetOrdinal("Emp_Gender"));  // Doubt
                    tb_Address.Text = Dr.GetString(Dr.GetOrdinal("Emp_Address"));
                    tb_Email.Text = Dr.GetString(Dr.GetOrdinal("Emp_Email"));
                    tb_Job_Title.Text = Dr.GetString(Dr.GetOrdinal("Emp_Job_Title"));
                    cmb_Department.Text = Dr.GetString(Dr.GetOrdinal("Emp_Dep"));
                    dtp_DOJ.Text = (Dr["Emp_DOJ"].ToString());
                    cmb_Emp_Status.Text = Dr.GetString(Dr.GetOrdinal("Emp_Status"));
                    tb_Educational_Background.Text = Dr.GetString(Dr.GetOrdinal("Emp_Edu"));
                    cmb_Skills.Text = Dr.GetString(Dr.GetOrdinal("Emp_Skills"));
                    //rb_.Text = Dr.GetString(Dr.GetOrdinal("Emp_Gender"));
                }
                else
                {
                    MessageBox.Show("No Record Found", "Invalid Roll No");
                    tb_Emp_ID.Clear();
                }

                Con_Close();
            }
            else
            {
                MessageBox.Show("Enter Employee Id", "");
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_Enter_Name.Text != "" && tb_Address.Text != "" && tb_Con_Number.TextLength == 10 && tb_Educational_Background.Text != "" && tb_Job_Title.Text != "" && tb_Email.Text != "" && tb_Educational_Background.Text != "" && cmb_Department.Text != "" && cmb_Emp_Status.Text != "" && cmb_Skills.Text != "" && Gender != "" && (ChaekBox1 != "" || ChaekBox2 != "" || ChaekBox3 != ""))
            {
                Con_Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Update Employee_Details Set Emp_Name = @Name,Emp_DOB = @DOB,Emp_Cont_No = @Cont_No,Emp_Gender = @Gender,Emp_Address = @Address,Emp_Email = @Email, Emp_Job_Title = @Job,Emp_Dep = @Dept,Emp_DOJ = @DOJ,Emp_Status = @Status,Emp_Edu = @Edu,Emp_Skills = @Skill,Emp_Lang = @Lang where Emp_ID = @Id";
                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Search.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Enter_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Cont_No", SqlDbType.Decimal).Value = tb_Con_Number.Text;
                Cmd.Parameters.Add("Gender", SqlDbType.VarChar).Value = Gender;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email.Text;
                Cmd.Parameters.Add("Job", SqlDbType.NVarChar).Value = tb_Job_Title.Text;
                Cmd.Parameters.Add("Dept", SqlDbType.NVarChar).Value = cmb_Department.Text;
                Cmd.Parameters.Add("DOJ", SqlDbType.Date).Value = dtp_DOJ.Value.Date;
                Cmd.Parameters.Add("Status", SqlDbType.NVarChar).Value = cmb_Emp_Status.Text;
                Cmd.Parameters.Add("Edu", SqlDbType.NVarChar).Value = tb_Educational_Background.Text;
                Cmd.Parameters.Add("Skill", SqlDbType.NVarChar).Value = cmb_Skills.Text;
                Cmd.Parameters.Add("Lang", SqlDbType.VarChar).Value = ChaekBox1 + " " + ChaekBox2 + " " + ChaekBox3;

                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Update Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Clear_Controls();
                tb_Emp_ID.Enabled = false;
            }
            else
            {
                MessageBox.Show("Fill All Information", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void lbl_Add_User_Click(object sender, EventArgs e)
        {
            if (Share_Class.Username == "Admin")
            {
                frm_Add_User Obj = new frm_Add_User();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You Are Not Admin","",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
        }

        private void lbl_Home_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_MouseHover(object sender, EventArgs e)
        {
            BA
        }
    }
}
