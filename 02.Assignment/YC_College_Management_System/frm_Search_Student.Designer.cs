
namespace YC_College_Management_System
{
    partial class frm_Search_Student
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
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmd_Course = new System.Windows.Forms.ComboBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_View_Student_Details = new System.Windows.Forms.Button();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Add_Student_Details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Enabled = false;
            this.dtp_DOB.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_DOB.Location = new System.Drawing.Point(723, 373);
            this.dtp_DOB.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(354, 50);
            this.dtp_DOB.TabIndex = 12;
            this.dtp_DOB.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // cmd_Course
            // 
            this.cmd_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_Course.Enabled = false;
            this.cmd_Course.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_Course.FormattingEnabled = true;
            this.cmd_Course.Items.AddRange(new object[] {
            "BCA",
            "BCS",
            "MCA",
            "MCS",
            "BCOMIT"});
            this.cmd_Course.Location = new System.Drawing.Point(723, 572);
            this.cmd_Course.Name = "cmd_Course";
            this.cmd_Course.Size = new System.Drawing.Size(354, 53);
            this.cmd_Course.TabIndex = 14;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Khaki;
            this.btn_Logout.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Logout.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Logout.Location = new System.Drawing.Point(1078, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(222, 70);
            this.btn_Logout.TabIndex = 24;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_View_Student_Details
            // 
            this.btn_View_Student_Details.BackColor = System.Drawing.Color.Khaki;
            this.btn_View_Student_Details.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_View_Student_Details.Location = new System.Drawing.Point(969, 705);
            this.btn_View_Student_Details.Name = "btn_View_Student_Details";
            this.btn_View_Student_Details.Size = new System.Drawing.Size(283, 70);
            this.btn_View_Student_Details.TabIndex = 23;
            this.btn_View_Student_Details.Text = "View Details";
            this.btn_View_Student_Details.UseVisualStyleBackColor = false;
            this.btn_View_Student_Details.Click += new System.EventHandler(this.btn_View_Student_Details_Click);
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Course.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Course.Location = new System.Drawing.Point(99, 578);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(132, 40);
            this.lbl_Course.TabIndex = 16;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Mob_No.Location = new System.Drawing.Point(99, 483);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(181, 40);
            this.lbl_Mob_No.TabIndex = 17;
            this.lbl_Mob_No.Text = "Mobile No";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.Lavender;
            this.lbl_DOB.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DOB.Location = new System.Drawing.Point(99, 378);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(91, 40);
            this.lbl_DOB.TabIndex = 18;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(99, 281);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(114, 40);
            this.lbl_Name.TabIndex = 19;
            this.lbl_Name.Text = "Name";
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Enabled = false;
            this.tb_Mob_No.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Mob_No.Location = new System.Drawing.Point(723, 472);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(354, 51);
            this.tb_Mob_No.TabIndex = 13;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Name.Location = new System.Drawing.Point(723, 275);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(354, 51);
            this.tb_Name.TabIndex = 11;
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Roll_No.Location = new System.Drawing.Point(723, 180);
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(354, 51);
            this.tb_Roll_No.TabIndex = 10;
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Roll_No.Location = new System.Drawing.Point(99, 191);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(134, 40);
            this.lbl_Roll_No.TabIndex = 20;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.BackColor = System.Drawing.Color.Khaki;
            this.lbl_Head.Font = new System.Drawing.Font("Verdana", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Head.Location = new System.Drawing.Point(207, 49);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(774, 71);
            this.lbl_Head.TabIndex = 22;
            this.lbl_Head.Text = "Search Student Details";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Khaki;
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.Location = new System.Drawing.Point(1100, 176);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(188, 61);
            this.btn_Search.TabIndex = 21;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Khaki;
            this.btn_Refresh.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.Location = new System.Drawing.Point(68, 705);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(222, 70);
            this.btn_Refresh.TabIndex = 21;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Add_Student_Details
            // 
            this.btn_Add_Student_Details.BackColor = System.Drawing.Color.Khaki;
            this.btn_Add_Student_Details.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add_Student_Details.Location = new System.Drawing.Point(405, 705);
            this.btn_Add_Student_Details.Name = "btn_Add_Student_Details";
            this.btn_Add_Student_Details.Size = new System.Drawing.Size(444, 70);
            this.btn_Add_Student_Details.TabIndex = 25;
            this.btn_Add_Student_Details.Text = "Add Student Details";
            this.btn_Add_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Add_Student_Details.Click += new System.EventHandler(this.btn_Add_Student_Details_Click);
            // 
            // frm_Search_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1300, 780);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Add_Student_Details);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.cmd_Course);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_View_Student_Details);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Head);
            this.Name = "frm_Search_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmd_Course;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_View_Student_Details;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Add_Student_Details;
    }
}