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
    public partial class frm_Add_Products : Form
    {
        public frm_Add_Products()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Products_System;Integrated Security=True");

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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
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

        private void btn_View_List_Click(object sender, EventArgs e)
        {
            frm_View_List Obj = new frm_View_List();
            Obj.Show();
            this.Hide();
        }

        void Clear_Controls()
        {
            tb_Product_Id.Text = Convert.ToString(Auto_Incr());
            tb_Product_Qty.Clear();
            cmb_company.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            dtp_Product_Date.Text = "";
        }

        private void frm_Add_Products_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Product_Id.Focus();
        }

        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) from Product_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if(Cnt > 0)
            {
                Cmd.Dispose();
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(P_Id) from Product_Details";
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }

            Con_Close();

            return Cnt;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
             
            if(tb_Product_Id.Text != "" && tb_Product_Qty.Text != "" && cmb_company.Text != "" && cmb_Product_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Product_Details(P_Id,P_Name,P_Company,P_Qty,P_Date) Values(@P_Id,@P_Name,@P_Company,@P_Qty,@P_Date)";

                Cmd.Parameters.Add("P_Id", SqlDbType.Int).Value = tb_Product_Id.Text;
                Cmd.Parameters.Add("P_Name", SqlDbType.NVarChar).Value = cmb_Product_Name.Text;
                Cmd.Parameters.Add("P_Company", SqlDbType.NVarChar).Value = cmb_company.Text;
                Cmd.Parameters.Add("P_Qty", SqlDbType.Decimal).Value = tb_Product_Qty.Text;
                Cmd.Parameters.Add("P_Date", SqlDbType.Date).Value = dtp_Product_Date.Value.Date;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Save Successfully","",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All Information");
            }
            Con_Close();
        }
    }
}
