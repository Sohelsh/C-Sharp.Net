using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace User_Manage
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void cmb_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox(cmb_Username, "UserName", "SELECT DISTINCT (UserName) FROM Login_Details WHERE UserRole = '"+ cmb_Role.Text + "'");
        }
    }
}
