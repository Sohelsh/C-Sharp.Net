using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_CheckBox_CheckList_Box
{
    public partial class frm_Employee_Details : Form
    {
        public frm_Employee_Details()
        {
            InitializeComponent();
        }

        string Gender = "";
        string[] Lang = new string[4];

       
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            
            Validation();
            Check_Languages();

            if(tb_Employee_Name.Text != "" && cmb__Department.Text != "" && Gender != "")
            {
                lbl_Ans.Visible = true;
                lbl_Ans.Text = "Name :" + tb_Employee_Name.Text + "   " + "Department : " + cmb__Department.Text + "  " + " Gender : " + Gender + "  " + "Languages : " + Lang[0] + Lang[1] + Lang[2] + Lang[3];
            }
            else
            {
                MessageBox.Show("Fill All Information");
            }

            Clear_Control();
        }

        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Error_Gender.Visible = false;

            if(rb_Male.Checked == true)
            {
                Gender = rb_Male.Text;
            }
        }

        private void rb_Female_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Error_Gender.Visible = false;

            if (rb_Female.Checked == true)
            {
                Gender = rb_Female.Text;
            }
        }

        private void tb_Employee_Name_TextChanged(object sender, EventArgs e)
        {
            lbl_Error_Emp_name.Visible = false;
        }

        private void cmb__Department_TextChanged(object sender, EventArgs e)
        {
            lbl_Error_Emp_Dep.Visible = false;
        }

        private void cb_English_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Error_lang.Visible = false;
        }

        private void cb_Marathi_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Error_lang.Visible = false;
        }

        private void cb_Hindi_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Error_lang.Visible = false;
        }

        private void cb_French_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Error_lang.Visible = false;
        }

        private void clb_Hobbies_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Error_hobbies.Visible = false;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        void Clear_Control()
        {
            tb_Employee_Name.Clear();
            cmb__Department.SelectedIndex = -1;
            rb_Female.Checked = false;
            rb_Male.Checked = false;
            cb_English.Checked = false;
            cb_French.Checked = false;
            cb_Hindi.Checked = false;
            cb_Marathi.Checked = false;
            Clear();
            void Clear()
            {
                for(int i = 0; i < clb_Hobbies.Items.Count;i++ )
                {
                    clb_Hobbies.SetItemChecked(i, false);
                }
            }
        }
        void Validation()
        {
            if((cmb__Department.Text != "" && Gender != "" && clb_Hobbies.CheckedItems.Count == 1 && Lang.Length >= 0) ||( tb_Employee_Name.Text == ""))
            {
                lbl_Error_Emp_name.Text = "Enter Your Name";
                lbl_Error_Emp_name.Visible = true;
            }
            else if(( Gender != "" && clb_Hobbies.CheckedItems.Count == 1 && Lang.Length >= 0 && tb_Employee_Name.Text != "") || cmb__Department.Text == "" )
            {
                lbl_Error_Emp_Dep.Text = "Select Correct Department";
                lbl_Error_Emp_Dep.Visible = true;
            }
            else if((cmb__Department.Text != "" && clb_Hobbies.CheckedItems.Count == 1 && Lang.Length >= 0  && tb_Employee_Name.Text != "") || Gender == "")
            {
                lbl_Error_Gender.Text = "Select Corret Gender";
                lbl_Error_Gender.Visible = true;

            }
            else if((cmb__Department.Text != "" && Gender != "" && clb_Hobbies.CheckedItems.Count == 1 && tb_Employee_Name.Text != "") || Lang.Length <= 0)
            {
                lbl_Error_lang.Text = "Select Corret Languages";
                lbl_Error_lang.Visible = true;
            }
            else if((cmb__Department.Text != "" && Gender != "" && Lang.Length < 0 && tb_Employee_Name.Text != "") || clb_Hobbies.CheckedItems.Count <= 0)
            {
                lbl_Error_hobbies.Text = "Select Corret Hobbies";
                lbl_Error_hobbies.Visible = true;
            }
          
        }
        void Check_Languages()
        {
            int i = 0;

            for(i = 0; i < 4;i++)
            {
                if (cb_Marathi.Checked == true)
                {
                    Lang[i] = cb_Marathi.Text;
                    cb_Marathi.Checked = false;
                }
                else if (cb_Hindi.Checked == true)
                {
                    Lang[i] = cb_Hindi.Text;
                    cb_Hindi.Checked = false;
                }
                else if (cb_English.Checked == true)
                {
                    Lang[i] = cb_English.Text;
                    cb_English.Checked = false;
                }
                else if (cb_French.Checked == true)
                {  
                     Lang[i] = cb_French.Text;
                     cb_French.Checked = false;
                    
                }
            }
        }

    }
}


/*foreach (string item in clb_Hobbies.CheckedItems)
{
    listBox1.Items.Add(item);
    lbl_Ans.Text = listBox1.Text;
}
// Lang[0] = listBox1.Text;
+ clb_Hobbies.CheckedItems[0].ToString() + listBox1.Items[0]; ////p*/