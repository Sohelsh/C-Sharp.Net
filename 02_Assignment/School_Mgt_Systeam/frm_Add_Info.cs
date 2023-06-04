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
    public partial class frm_Add_Info : Form
    {
        public frm_Add_Info()
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
        private void frm_Add_Info_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = Shares_Class.Username;
            Clear_Controls();
            tb_Stu_RollNo.Focus();
        }

        private void Only_Numric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

        }
        private void Only_Latter(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Stu_RollNo.Text != "" && tb_Stu_Name.Text != "" && tb_Stu_City.Text != "" && tb_Stu_Number.TextLength == 10 && cmb_Stu_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Student_Details(R_No,Name,Mob_No,City,Course) Values(@RNo,@Name,@MNo,@City,@Course)";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Stu_RollNo.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Stu_Name.Text;
                Cmd.Parameters.Add("City", SqlDbType.NVarChar).Value = tb_Stu_City.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Stu_Number.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Stu_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All Information", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        void Clear_Controls()
        {   
            tb_Stu_RollNo.Text = Convert.ToString(Auto_Incr());
            tb_Stu_City.Clear();
            tb_Stu_Name.Clear();
            tb_Stu_Number.Clear();
            cmb_Stu_Course.SelectedIndex = -1;
        }

        int Auto_Incr()
        {
            int Cnt = 0;                                        //Auto Increment Function

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) from Student_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                Cmd.Dispose();
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(R_No) from Student_Details";
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1;
            }

            Con_Close();
            return Cnt;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
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

        private void btn_View_Click(object sender, EventArgs e)
        {
            frm_Show_Stu_Info Obj = new frm_Show_Stu_Info();
            Obj.Show();
            this.Hide();
        }

    }
}
