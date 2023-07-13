using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Image_Assignment
{
    public partial class Form_Add : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-RCQ0TGDA;Initial Catalog=AssignmentSeven;Integrated Security=True");

        string Imagetext = "";
        public Form_Add()
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

        private void button_Show_Image_Click(object sender, EventArgs e)
        {
            Form_Show_Data Obj = new Form_Show_Data();
            this.Hide();
            Obj.Show();
        }

        private void button_Import_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files  (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            if(opnfd.ShowDialog() == DialogResult.OK)
            {
                Imagetext = opnfd.FileName;
                pictureBox_Upload_Image.Image = new Bitmap(opnfd.FileName);
            }

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            FileStream fs;
            BinaryReader br;
            Con_Open();

            if(textBox_ID.Text != "" && textBox_Desc.Text != "" && pictureBox_Upload_Image.Image != null)
            {
                string FileName = Imagetext;
                byte[] ImageData;
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into ImageData(Image_Desc,Picture) Values(@Desc,@img)";

                //Cmd.Parameters.Add("id", SqlDbType.Int).Value = textBox_ID;
                Cmd.Parameters.Add("Desc", SqlDbType.NVarChar).Value = textBox_Desc.Text;
                Cmd.Parameters.Add("img",SqlDbType.Image).Value = ImageData;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Fill All Information", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void Form_Add_Load(object sender, EventArgs e)
        {
            
        }
    }
}
