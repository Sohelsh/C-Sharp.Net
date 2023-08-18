using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace User_Manage
{
     internal class Shared_Class
    {
        public static SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-RCQ0TGDA;Initial Catalog=User_ManageAssEight;Integrated Security=True");

        public static void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        public static void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        public static void Bind_ComboBox(ComboBox Ucmb , string Column, string Query)
        {
            Con_Open();

            Ucmb.Items.Clear();

            SqlCommand Cmd = new SqlCommand(Query,Con);

            SqlDataReader Obj = Cmd.ExecuteReader();

            while(Obj.Read())
            {
                Ucmb.Items.Add(Obj.GetString(Obj.GetOrdinal(Column)));
            }

            Obj.Dispose();
            Con_Close();
        }
    }
}
