using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Assignment
{
    public partial class frm_Add_Fees : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-RCQ0TGDA;Initial Catalog=AssignmentSeven;Integrated Security=True");
        public frm_Add_Fees()
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

        void Bind_Combo_Box()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct (Course_Name) from Course_Deatils";

           SqlDataReader Dr = Cmd.ExecuteReader();

            while(Dr.Read())
            {
                cmb_Course.Items.Add(Dr.GetString(Dr.GetOrdinal("Course_Name")));
            }
            Con_Close();
        }
        private void frm_Add_Fees_Load(object sender, EventArgs e)
        {
            Bind_Combo_Box();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }
    }
}
