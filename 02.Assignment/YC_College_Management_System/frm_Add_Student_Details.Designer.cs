
namespace YC_College_Management_System
{
    partial class frm_Add_Student_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_View_Student_Details = new System.Windows.Forms.Button();
            this.cmd_Course = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Khaki;
            this.btn_Save.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(539, 698);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(222, 70);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Enabled = false;
            this.tb_Roll_No.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Roll_No.Location = new System.Drawing.Point(883, 178);
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(354, 51);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Roll_No.Location = new System.Drawing.Point(146, 184);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(134, 40);
            this.lbl_Roll_No.TabIndex = 6;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.BackColor = System.Drawing.Color.Khaki;
            this.lbl_Head.Font = new System.Drawing.Font("Verdana", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Head.Location = new System.Drawing.Point(301, 40);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(678, 71);
            this.lbl_Head.TabIndex = 7;
            this.lbl_Head.Text = "Add Student Details";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(146, 274);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(114, 40);
            this.lbl_Name.TabIndex = 6;
            this.lbl_Name.Text = "Name";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Name.Location = new System.Drawing.Point(883, 273);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(354, 51);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Latter);
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Mob_No.Location = new System.Drawing.Point(883, 470);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(354, 51);
            this.tb_Mob_No.TabIndex = 4;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.Lavender;
            this.lbl_DOB.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DOB.Location = new System.Drawing.Point(146, 371);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(91, 40);
            this.lbl_DOB.TabIndex = 6;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Mob_No.Location = new System.Drawing.Point(146, 476);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(181, 40);
            this.lbl_Mob_No.TabIndex = 6;
            this.lbl_Mob_No.Text = "Mobile No";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Course.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Course.Location = new System.Drawing.Point(146, 571);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(132, 40);
            this.lbl_Course.TabIndex = 6;
            this.lbl_Course.Text = "Course";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Khaki;
            this.btn_Logout.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Logout.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Logout.Location = new System.Drawing.Point(1075, -1);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(222, 70);
            this.btn_Logout.TabIndex = 9;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Khaki;
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.Location = new System.Drawing.Point(98, 698);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(370, 70);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Search Student";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_View_Student_Details
            // 
            this.btn_View_Student_Details.BackColor = System.Drawing.Color.Khaki;
            this.btn_View_Student_Details.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_View_Student_Details.Location = new System.Drawing.Point(822, 698);
            this.btn_View_Student_Details.Name = "btn_View_Student_Details";
            this.btn_View_Student_Details.Size = new System.Drawing.Size(444, 70);
            this.btn_View_Student_Details.TabIndex = 8;
            this.btn_View_Student_Details.Text = "View Student Details";
            this.btn_View_Student_Details.UseVisualStyleBackColor = false;
            this.btn_View_Student_Details.Click += new System.EventHandler(this.btn_View_Student_Details_Click);
            // 
            // cmd_Course
            // 
            this.cmd_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_Course.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_Course.FormattingEnabled = true;
            this.cmd_Course.Items.AddRange(new object[] {
            "BCA",
            "BCS",
            "MCA",
            "MCS",
            "BCOMIT"});
            this.cmd_Course.Location = new System.Drawing.Point(883, 570);
            this.cmd_Course.Name = "cmd_Course";
            this.cmd_Course.Size = new System.Drawing.Size(354, 53);
            this.cmd_Course.TabIndex = 5;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_DOB.Location = new System.Drawing.Point(883, 371);
            this.dtp_DOB.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(354, 50);
            this.dtp_DOB.TabIndex = 3;
            this.dtp_DOB.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // frm_Add_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1300, 780);
            this.ControlBox = false;
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.cmd_Course);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_View_Student_Details);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Head);
            this.Name = "frm_Add_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Student_Details";
            this.Load += new System.EventHandler(this.frm_Add_Student_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.ComboBox cmd_Course;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_View_Student_Details;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
    }
}