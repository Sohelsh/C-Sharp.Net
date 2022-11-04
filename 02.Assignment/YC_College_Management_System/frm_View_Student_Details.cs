using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YC_College_Management_System
{
    public partial class frm_View_Student_Details : Form
    {
        public frm_View_Student_Details()
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

        private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            Datashow();
        }

        private void Datashow()
        {
            Con_Open();

            String Query = "Select * From YC_Student_Details";
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_Student_Details.DataSource = dt;

            Con_Close();
        }

        private void btn_Add_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details Obj = new frm_Add_Student_Details();
            Obj.Show();
            this.Hide();
        }
    }
}
