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
namespace Product_Management_System
{
    public partial class frm_View_List : Form
    {
        public frm_View_List()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Products_System;Integrated Security=True");
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
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();
            }
        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            frm_Add_Products Obj = new frm_Add_Products();
            Obj.Show();
            this.Hide();
        }

        private void frm_View_List_Load(object sender, EventArgs e)
        {
            Data_Show();
        }

        private void Data_Show()
        {
            Con_Open();

            String Str = "Select * from Product_Details";
            SqlDataAdapter da = new SqlDataAdapter(Str,Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_Product_List.DataSource = dt;

            Con_Close();
        }
    }
}
