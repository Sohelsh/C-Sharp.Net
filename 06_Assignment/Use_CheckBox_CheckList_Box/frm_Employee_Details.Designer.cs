
namespace Use_CheckBox_CheckList_Box
{
    partial class frm_Employee_Details
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
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.tb_Employee_Name = new System.Windows.Forms.TextBox();
            this.lbl_Employee_Dep = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Languages = new System.Windows.Forms.Label();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.cmb__Department = new System.Windows.Forms.ComboBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.gb_Languages = new System.Windows.Forms.GroupBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.panel_Output = new System.Windows.Forms.Panel();
            this.lbl_Ans = new System.Windows.Forms.Label();
            this.lbl_Error_Emp_name = new System.Windows.Forms.Label();
            this.lbl_Error_Emp_Dep = new System.Windows.Forms.Label();
            this.lbl_Error_Gender = new System.Windows.Forms.Label();
            this.lbl_Error_lang = new System.Windows.Forms.Label();
            this.lbl_Error_hobbies = new System.Windows.Forms.Label();
            this.gb_Gender.SuspendLayout();
            this.gb_Languages.SuspendLayout();
            this.panel_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.Location = new System.Drawing.Point(48, 127);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(130, 20);
            this.lbl_Employee_Name.TabIndex = 0;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.BackColor = System.Drawing.Color.Azure;
            this.lbl_Head.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.Location = new System.Drawing.Point(489, 27);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(370, 34);
            this.lbl_Head.TabIndex = 1;
            this.lbl_Head.Text = "Employee General Details";
            // 
            // tb_Employee_Name
            // 
            this.tb_Employee_Name.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Name.Location = new System.Drawing.Point(259, 121);
            this.tb_Employee_Name.Name = "tb_Employee_Name";
            this.tb_Employee_Name.Size = new System.Drawing.Size(394, 30);
            this.tb_Employee_Name.TabIndex = 1;
            this.tb_Employee_Name.TextChanged += new System.EventHandler(this.tb_Employee_Name_TextChanged);
            // 
            // lbl_Employee_Dep
            // 
            this.lbl_Employee_Dep.AutoSize = true;
            this.lbl_Employee_Dep.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Dep.Location = new System.Drawing.Point(48, 253);
            this.lbl_Employee_Dep.Name = "lbl_Employee_Dep";
            this.lbl_Employee_Dep.Size = new System.Drawing.Size(175, 20);
            this.lbl_Employee_Dep.TabIndex = 0;
            this.lbl_Employee_Dep.Text = "Employee Department";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(48, 410);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(63, 20);
            this.lbl_Gender.TabIndex = 0;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Languages
            // 
            this.lbl_Languages.AutoSize = true;
            this.lbl_Languages.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Languages.Location = new System.Drawing.Point(791, 127);
            this.lbl_Languages.Name = "lbl_Languages";
            this.lbl_Languages.Size = new System.Drawing.Size(146, 20);
            this.lbl_Languages.TabIndex = 0;
            this.lbl_Languages.Text = "Known Languages";
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies.Location = new System.Drawing.Point(791, 356);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(68, 20);
            this.lbl_Hobbies.TabIndex = 0;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // cmb__Department
            // 
            this.cmb__Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb__Department.FormattingEnabled = true;
            this.cmb__Department.Items.AddRange(new object[] {
            "Testing",
            "Development",
            "Programming"});
            this.cmb__Department.Location = new System.Drawing.Point(259, 251);
            this.cmb__Department.Name = "cmb__Department";
            this.cmb__Department.Size = new System.Drawing.Size(375, 24);
            this.cmb__Department.TabIndex = 2;
            this.cmb__Department.TextChanged += new System.EventHandler(this.cmb__Department_TextChanged);
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Location = new System.Drawing.Point(259, 372);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(338, 95);
            this.gb_Gender.TabIndex = 3;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(218, 37);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(68, 20);
            this.rb_Female.TabIndex = 5;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            this.rb_Female.CheckedChanged += new System.EventHandler(this.rb_Female_CheckedChanged);
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(30, 37);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(55, 20);
            this.rb_Male.TabIndex = 4;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            this.rb_Male.CheckedChanged += new System.EventHandler(this.rb_Male_CheckedChanged);
            // 
            // gb_Languages
            // 
            this.gb_Languages.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gb_Languages.Controls.Add(this.cb_French);
            this.gb_Languages.Controls.Add(this.cb_Hindi);
            this.gb_Languages.Controls.Add(this.cb_English);
            this.gb_Languages.Controls.Add(this.cb_Marathi);
            this.gb_Languages.Location = new System.Drawing.Point(960, 127);
            this.gb_Languages.Name = "gb_Languages";
            this.gb_Languages.Size = new System.Drawing.Size(338, 95);
            this.gb_Languages.TabIndex = 6;
            this.gb_Languages.TabStop = false;
            this.gb_Languages.Text = "Languages";
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Location = new System.Drawing.Point(191, 69);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(65, 20);
            this.cb_French.TabIndex = 0;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            this.cb_French.CheckedChanged += new System.EventHandler(this.cb_French_CheckedChanged);
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Location = new System.Drawing.Point(28, 69);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(59, 20);
            this.cb_Hindi.TabIndex = 0;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            this.cb_Hindi.CheckedChanged += new System.EventHandler(this.cb_Hindi_CheckedChanged);
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Location = new System.Drawing.Point(191, 24);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(69, 20);
            this.cb_English.TabIndex = 0;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            this.cb_English.CheckedChanged += new System.EventHandler(this.cb_English_CheckedChanged);
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Location = new System.Drawing.Point(28, 24);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(74, 20);
            this.cb_Marathi.TabIndex = 0;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            this.cb_Marathi.CheckedChanged += new System.EventHandler(this.cb_Marathi_CheckedChanged);
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Cycling",
            "Driving",
            "Tracking",
            "Gaming",
            "Cooking",
            "Reading"});
            this.clb_Hobbies.Location = new System.Drawing.Point(960, 310);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(215, 140);
            this.clb_Hobbies.TabIndex = 10;
            this.clb_Hobbies.SelectedIndexChanged += new System.EventHandler(this.clb_Hobbies_SelectedIndexChanged);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Reset.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(527, 520);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(107, 35);
            this.btn_Reset.TabIndex = 11;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Submit.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(807, 520);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(113, 35);
            this.btn_Submit.TabIndex = 12;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.BackColor = System.Drawing.Color.Teal;
            this.lbl_Output.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.Location = new System.Drawing.Point(66, 594);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(74, 23);
            this.lbl_Output.TabIndex = 0;
            this.lbl_Output.Text = "Output";
            // 
            // panel_Output
            // 
            this.panel_Output.BackColor = System.Drawing.Color.Azure;
            this.panel_Output.Controls.Add(this.lbl_Ans);
            this.panel_Output.Location = new System.Drawing.Point(169, 580);
            this.panel_Output.Name = "panel_Output";
            this.panel_Output.Size = new System.Drawing.Size(1131, 47);
            this.panel_Output.TabIndex = 7;
            // 
            // lbl_Ans
            // 
            this.lbl_Ans.AutoSize = true;
            this.lbl_Ans.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ans.Location = new System.Drawing.Point(14, 14);
            this.lbl_Ans.Name = "lbl_Ans";
            this.lbl_Ans.Size = new System.Drawing.Size(64, 20);
            this.lbl_Ans.TabIndex = 0;
            this.lbl_Ans.Text = "Answer";
            this.lbl_Ans.Visible = false;
            // 
            // lbl_Error_Emp_name
            // 
            this.lbl_Error_Emp_name.AutoSize = true;
            this.lbl_Error_Emp_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error_Emp_name.Location = new System.Drawing.Point(524, 155);
            this.lbl_Error_Emp_name.Name = "lbl_Error_Emp_name";
            this.lbl_Error_Emp_name.Size = new System.Drawing.Size(76, 16);
            this.lbl_Error_Emp_name.TabIndex = 14;
            this.lbl_Error_Emp_name.Text = "Enter Name";
            // 
            // lbl_Error_Emp_Dep
            // 
            this.lbl_Error_Emp_Dep.AutoSize = true;
            this.lbl_Error_Emp_Dep.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error_Emp_Dep.Location = new System.Drawing.Point(524, 278);
            this.lbl_Error_Emp_Dep.Name = "lbl_Error_Emp_Dep";
            this.lbl_Error_Emp_Dep.Size = new System.Drawing.Size(113, 16);
            this.lbl_Error_Emp_Dep.TabIndex = 14;
            this.lbl_Error_Emp_Dep.Text = "Select Department";
            // 
            // lbl_Error_Gender
            // 
            this.lbl_Error_Gender.AutoSize = true;
            this.lbl_Error_Gender.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error_Gender.Location = new System.Drawing.Point(524, 470);
            this.lbl_Error_Gender.Name = "lbl_Error_Gender";
            this.lbl_Error_Gender.Size = new System.Drawing.Size(85, 16);
            this.lbl_Error_Gender.TabIndex = 14;
            this.lbl_Error_Gender.Text = "Select Gender";
            // 
            // lbl_Error_lang
            // 
            this.lbl_Error_lang.AutoSize = true;
            this.lbl_Error_lang.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error_lang.Location = new System.Drawing.Point(1148, 225);
            this.lbl_Error_lang.Name = "lbl_Error_lang";
            this.lbl_Error_lang.Size = new System.Drawing.Size(105, 16);
            this.lbl_Error_lang.TabIndex = 14;
            this.lbl_Error_lang.Text = "Select Languages";
            // 
            // lbl_Error_hobbies
            // 
            this.lbl_Error_hobbies.AutoSize = true;
            this.lbl_Error_hobbies.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error_hobbies.Location = new System.Drawing.Point(1148, 453);
            this.lbl_Error_hobbies.Name = "lbl_Error_hobbies";
            this.lbl_Error_hobbies.Size = new System.Drawing.Size(91, 16);
            this.lbl_Error_hobbies.TabIndex = 14;
            this.lbl_Error_hobbies.Text = "Select Hobbies";
            // 
            // frm_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1312, 639);
            this.Controls.Add(this.lbl_Error_hobbies);
            this.Controls.Add(this.lbl_Error_lang);
            this.Controls.Add(this.lbl_Error_Gender);
            this.Controls.Add(this.lbl_Error_Emp_Dep);
            this.Controls.Add(this.lbl_Error_Emp_name);
            this.Controls.Add(this.panel_Output);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.clb_Hobbies);
            this.Controls.Add(this.gb_Languages);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.cmb__Department);
            this.Controls.Add(this.tb_Employee_Name);
            this.Controls.Add(this.lbl_Head);
            this.Controls.Add(this.lbl_Hobbies);
            this.Controls.Add(this.lbl_Languages);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Employee_Dep);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Languages.ResumeLayout(false);
            this.gb_Languages.PerformLayout();
            this.panel_Output.ResumeLayout(false);
            this.panel_Output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.TextBox tb_Employee_Name;
        private System.Windows.Forms.Label lbl_Employee_Dep;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Languages;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.ComboBox cmb__Department;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.GroupBox gb_Languages;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.Panel panel_Output;
        private System.Windows.Forms.Label lbl_Ans;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.Label lbl_Error_Emp_name;
        private System.Windows.Forms.Label lbl_Error_Emp_Dep;
        private System.Windows.Forms.Label lbl_Error_Gender;
        private System.Windows.Forms.Label lbl_Error_lang;
        private System.Windows.Forms.Label lbl_Error_hobbies;
    }
}

