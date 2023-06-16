using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_05
{
    public partial class frm_Add : Form
    {
        public frm_Add()
        {
            InitializeComponent();
        }

        string Gender = "",Time = "";

        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Male.Checked == true)
            {
                Gender = rb_Male.Text;
            }
            else
            {
                Gender = "";
            }
        }

        private void rb_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Female.Checked == true)
            {
                Gender = rb_Female.Text;
            }
            else
            {
                Gender = "";
            }
        }

        private void rb_Evening_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Evening.Checked == true)
            {
                Time = rb_Evening.Text;
            }
            else
            {
                Time = "";
            }

        }

        private void rb_Night_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Night.Checked == true)
            {
                Time = rb_Night.Text;
            }
            else
            {
                Time = "";
            }
        }

        private void rb_Morning_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Morning.Checked == true)
            {
                Time = rb_Morning.Text;
            }
            else
            {
                Time = "";
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            tb_Output.Clear();
            cmb_Department.SelectedIndex = -1;
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            rb_Evening.Checked = false;
            rb_Morning.Checked = false;
            rb_Night.Checked = false;
        }

        private void Only_Latter(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Reset_MouseHover(object sender, EventArgs e)
        {
            btn_Reset.BackColor = Color.HotPink;
        }

        private void btn_Reset_MouseLeave(object sender, EventArgs e)
        {
            btn_Reset.BackColor = Color.Fuchsia;
        }

        private void btn_Save_MouseHover(object sender, EventArgs e)
        {
            btn_Reset.BackColor = Color.HotPink;
        }

        private void btn_Save_MouseLeave(object sender, EventArgs e)
        {
            btn_Reset.BackColor = Color.Fuchsia;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(tb_Name.Text != "" && cmb_Department.Text != "" && Gender != "" && Time != "")
            {
                tb_Output.Text = tb_Name.Text + " from Department Testing is " + Gender + " candidate ," + "Prefers shift timing " + Time +" .";
            }
            else
            {
                MessageBox.Show("Fill All Information");
            }
        }

       
    }
}
