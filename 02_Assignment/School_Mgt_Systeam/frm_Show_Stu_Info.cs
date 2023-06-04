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
    public partial class frm_Show_Stu_Info : Form
    {
        public frm_Show_Stu_Info()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-RCQ0TGDA\;Initial Catalog=School_Mgt_Systeam;Integrated Security=True");

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

        private void frm_Show_Stu_Info_Load(object sender, EventArgs e)
        {
            Data_Show();
            lbl_Username.Text = Shares_Class.Username;
        }

        private void Data_Show()
        {
            Con_Open();

            String Query = "Select * from Student_Details";
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_View.DataSource = dt;

            Con_Close();
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

        private void btn_Add_Stu_Click(object sender, EventArgs e)
        {
            frm_Add_Info Obj = new frm_Add_Info();
            Obj.Show();
            this.Hide();
        }

    }
}
