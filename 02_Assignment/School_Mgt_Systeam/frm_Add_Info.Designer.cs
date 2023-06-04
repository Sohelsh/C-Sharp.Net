
namespace School_Mgt_Systeam
{
    partial class frm_Add_Info
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
            this.tb_Stu_Name = new System.Windows.Forms.TextBox();
            this.tb_Stu_RollNo = new System.Windows.Forms.TextBox();
            this.lbl_Stu_Name = new System.Windows.Forms.Label();
            this.lbl_Stu_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.lbl_Stu_MobNo = new System.Windows.Forms.Label();
            this.lbl_Stu_City = new System.Windows.Forms.Label();
            this.tb_Stu_Number = new System.Windows.Forms.TextBox();
            this.tb_Stu_City = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Stu_Course = new System.Windows.Forms.Label();
            this.cmb_Stu_Course = new System.Windows.Forms.ComboBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Save.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Save.Location = new System.Drawing.Point(503, 681);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(202, 50);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Stu_Name
            // 
            this.tb_Stu_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Stu_Name.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stu_Name.Location = new System.Drawing.Point(776, 264);
            this.tb_Stu_Name.Name = "tb_Stu_Name";
            this.tb_Stu_Name.Size = new System.Drawing.Size(278, 34);
            this.tb_Stu_Name.TabIndex = 2;
            this.tb_Stu_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Latter);
            // 
            // tb_Stu_RollNo
            // 
            this.tb_Stu_RollNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Stu_RollNo.Enabled = false;
            this.tb_Stu_RollNo.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stu_RollNo.Location = new System.Drawing.Point(776, 172);
            this.tb_Stu_RollNo.Name = "tb_Stu_RollNo";
            this.tb_Stu_RollNo.Size = new System.Drawing.Size(278, 34);
            this.tb_Stu_RollNo.TabIndex = 1;
            this.tb_Stu_RollNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numric);
            // 
            // lbl_Stu_Name
            // 
            this.lbl_Stu_Name.AutoSize = true;
            this.lbl_Stu_Name.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Stu_Name.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stu_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Stu_Name.Location = new System.Drawing.Point(111, 266);
            this.lbl_Stu_Name.Name = "lbl_Stu_Name";
            this.lbl_Stu_Name.Size = new System.Drawing.Size(196, 32);
            this.lbl_Stu_Name.TabIndex = 4;
            this.lbl_Stu_Name.Text = "Student Name";
            // 
            // lbl_Stu_Roll_No
            // 
            this.lbl_Stu_Roll_No.AutoSize = true;
            this.lbl_Stu_Roll_No.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Stu_Roll_No.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stu_Roll_No.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Stu_Roll_No.Location = new System.Drawing.Point(111, 174);
            this.lbl_Stu_Roll_No.Name = "lbl_Stu_Roll_No";
            this.lbl_Stu_Roll_No.Size = new System.Drawing.Size(216, 32);
            this.lbl_Stu_Roll_No.TabIndex = 5;
            this.lbl_Stu_Roll_No.Text = "Student Roll No";
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Head.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Head.Location = new System.Drawing.Point(437, 54);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(275, 49);
            this.lbl_Head.TabIndex = 6;
            this.lbl_Head.Text = "ADD Student";
            // 
            // lbl_Stu_MobNo
            // 
            this.lbl_Stu_MobNo.AutoSize = true;
            this.lbl_Stu_MobNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Stu_MobNo.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stu_MobNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Stu_MobNo.Location = new System.Drawing.Point(111, 358);
            this.lbl_Stu_MobNo.Name = "lbl_Stu_MobNo";
            this.lbl_Stu_MobNo.Size = new System.Drawing.Size(226, 32);
            this.lbl_Stu_MobNo.TabIndex = 5;
            this.lbl_Stu_MobNo.Text = "Student Number";
            // 
            // lbl_Stu_City
            // 
            this.lbl_Stu_City.AutoSize = true;
            this.lbl_Stu_City.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Stu_City.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stu_City.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Stu_City.Location = new System.Drawing.Point(111, 448);
            this.lbl_Stu_City.Name = "lbl_Stu_City";
            this.lbl_Stu_City.Size = new System.Drawing.Size(172, 32);
            this.lbl_Stu_City.TabIndex = 4;
            this.lbl_Stu_City.Text = "Student City";
            // 
            // tb_Stu_Number
            // 
            this.tb_Stu_Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Stu_Number.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stu_Number.Location = new System.Drawing.Point(776, 356);
            this.tb_Stu_Number.MaxLength = 10;
            this.tb_Stu_Number.Name = "tb_Stu_Number";
            this.tb_Stu_Number.Size = new System.Drawing.Size(278, 34);
            this.tb_Stu_Number.TabIndex = 3;
            this.tb_Stu_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numric);
            // 
            // tb_Stu_City
            // 
            this.tb_Stu_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Stu_City.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stu_City.Location = new System.Drawing.Point(776, 446);
            this.tb_Stu_City.Name = "tb_Stu_City";
            this.tb_Stu_City.Size = new System.Drawing.Size(278, 34);
            this.tb_Stu_City.TabIndex = 4;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Refresh.Location = new System.Drawing.Point(156, 681);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(202, 50);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_View.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_View.Location = new System.Drawing.Point(840, 681);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(202, 50);
            this.btn_View.TabIndex = 8;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Logout.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Logout.Location = new System.Drawing.Point(982, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(202, 50);
            this.btn_Logout.TabIndex = 9;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Stu_Course
            // 
            this.lbl_Stu_Course.AutoSize = true;
            this.lbl_Stu_Course.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Stu_Course.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stu_Course.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Stu_Course.Location = new System.Drawing.Point(111, 543);
            this.lbl_Stu_Course.Name = "lbl_Stu_Course";
            this.lbl_Stu_Course.Size = new System.Drawing.Size(209, 32);
            this.lbl_Stu_Course.TabIndex = 4;
            this.lbl_Stu_Course.Text = "Student Course";
            // 
            // cmb_Stu_Course
            // 
            this.cmb_Stu_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stu_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stu_Course.FormattingEnabled = true;
            this.cmb_Stu_Course.Items.AddRange(new object[] {
            "BCA",
            "BCS",
            "BBA",
            "MCA",
            "MCS",
            "BSC",
            "BCom",
            "BA"});
            this.cmb_Stu_Course.Location = new System.Drawing.Point(776, 536);
            this.cmb_Stu_Course.Name = "cmb_Stu_Course";
            this.cmb_Stu_Course.Size = new System.Drawing.Size(278, 39);
            this.cmb_Stu_Course.TabIndex = 5;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Username.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Username.Location = new System.Drawing.Point(2, 2);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(219, 49);
            this.lbl_Username.TabIndex = 6;
            this.lbl_Username.Text = "Username";
            // 
            // frm_Add_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1196, 763);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_Stu_Course);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Stu_City);
            this.Controls.Add(this.tb_Stu_Name);
            this.Controls.Add(this.tb_Stu_Number);
            this.Controls.Add(this.tb_Stu_RollNo);
            this.Controls.Add(this.lbl_Stu_Course);
            this.Controls.Add(this.lbl_Stu_City);
            this.Controls.Add(this.lbl_Stu_MobNo);
            this.Controls.Add(this.lbl_Stu_Name);
            this.Controls.Add(this.lbl_Stu_Roll_No);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Head);
            this.Name = "frm_Add_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD INFORMATION";
            this.Load += new System.EventHandler(this.frm_Add_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Stu_Name;
        private System.Windows.Forms.TextBox tb_Stu_RollNo;
        private System.Windows.Forms.Label lbl_Stu_Name;
        private System.Windows.Forms.Label lbl_Stu_Roll_No;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Label lbl_Stu_MobNo;
        private System.Windows.Forms.Label lbl_Stu_City;
        private System.Windows.Forms.TextBox tb_Stu_Number;
        private System.Windows.Forms.TextBox tb_Stu_City;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Stu_Course;
        private System.Windows.Forms.ComboBox cmb_Stu_Course;
        private System.Windows.Forms.Label lbl_Username;
    }
}