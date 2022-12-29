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
    public partial class frm_Add_Student : Form
    {
        public frm_Add_Student()
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

        private void Only_Number(object sender, KeyPressEventArgs e)
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && tb_Mob_No.TextLength == 10 && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Student_Details(Roll_No,Name,DOB,Mob_No,Course)values(@Roll_No,@Name,@DOB,@Mob_No,@Course)";

                Cmd.Parameters.Add("Roll_No",SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Name",SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB",SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Mob_No",SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Course",SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully");

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All Information");
            }

            Con_Close();
        }

        void Clear_Controls()
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "31-12-2000";
            cmb_Course.SelectedIndex = -1;
        }

        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) From Student_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                Cmd.Dispose();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Roll_No) From Student_Details";
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1;
            }
            Con_Close();
            return Cnt;
        }

        private void frm_Add_Student_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }
      
        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_Search_Student Obj = new frm_Search_Student();
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
