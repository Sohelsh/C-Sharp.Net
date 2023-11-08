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

namespace Image_Assignment
{
    public partial class frm_Add_Course : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-RCQ0TGDA;Initial Catalog=AssignmentSeven;Integrated Security=True");
        public frm_Add_Course()
        {
            InitializeComponent();
        }
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

        void Auto_Incr()
        {
            int Cnt;
            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Max(Course_Id) From Course_Deatils";
            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                string val = Dr[0].ToString();
                if (val == "")
                {
                    tb_Course_ID.Text = "1";
                }
                else
                {
                    Cnt = Convert.ToInt32(Dr[0].ToString());
                    Cnt = Cnt + 1;
                    tb_Course_ID.Text = Cnt.ToString();
                }
            }

            Con_Close();
        }

        void Clear_Controls()
        {
            Auto_Incr();
            tb_Course_Fee.Clear();
            tb_Course_Name.Clear();
        }
        private void btn_Add_Course_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Course_ID.Text != "" && tb_Course_Name.Text != ""&& tb_Course_Fee.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Course_Deatils (Course_Name,Course_Fees) values(@CourseNm,@CourseFee)";

                Cmd.Parameters.Add("CourseNm",SqlDbType.VarChar).Value = tb_Course_Name.Text;
                //Cmd.Parameters.Add("CourseId", SqlDbType.Int).Value = tb_Course_ID.Text;
                Cmd.Parameters.Add("CourseFee",SqlDbType.Money).Value = tb_Course_Fee.Text;

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

        private void frm_Add_Course_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
