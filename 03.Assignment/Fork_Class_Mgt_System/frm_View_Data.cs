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
    public partial class frm_View_Data : Form
    {
        public frm_View_Data()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Login_Details;Integrated Security=True");

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
        

        void Data_Show()
        {
            Con_Open();

            String Query = "Select * From Student_Details";
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_Show_Data.DataSource = dt;

            Con_Close();

        }

        private void frm_View_Data_Load(object sender, EventArgs e)
        {
            Data_Show();
        }

        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Add_Student Obj = new frm_Add_Student();
            Obj.Show();
            this.Hide();
        }
    }
}
