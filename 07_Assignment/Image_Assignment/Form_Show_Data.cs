using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Assignment
{
    
    public partial class Form_Show_Data : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-RCQ0TGDA;Initial Catalog=AssignmentSeven;Integrated Security=True");
        string Imagetext = "";
        public Form_Show_Data()
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

        private void button_Add_Image_Click(object sender, EventArgs e)
        {
            Form_Add Obj = new Form_Add();
            this.Hide();
            Obj.Show();
            
        }

        private void Form_Show_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentSevenDataSet.ImageData' table. You can move, or remove it, as needed.
            this.imageDataTableAdapter.Fill(this.assignmentSevenDataSet.ImageData);

        }

        private void dataGridView_ImageData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
             textBox_ID.Text = dataGridView_ImageData.CurrentRow.Cells[0].Value.ToString();
             byte[] imgData = (byte[])dataGridView_ImageData.CurrentRow.Cells[2].Value;
             MemoryStream ms = new MemoryStream(imgData);
             pictureBox_Your_Image.Image = Image.FromStream(ms);

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            FileStream fs;
            BinaryReader br;
            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Update ImageData set Picture = @Pic where Image_ID = '" + textBox_ID.Text + "' ";

            string FileName = Imagetext;
            byte[] ImageData;
            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();

            Cmd.Parameters.Add("Pic", SqlDbType.Image).Value = ImageData;

            Cmd.ExecuteNonQuery();

            Con_Close();
            MessageBox.Show("Image Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Browes_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files  (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                Imagetext = opnfd.FileName;
                pictureBox_Your_Image.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void dataGridView_ImageData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
