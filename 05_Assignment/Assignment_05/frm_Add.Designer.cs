
namespace Assignment_05
{
    partial class frm_Add
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
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Shift_Time = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Morning = new System.Windows.Forms.RadioButton();
            this.rb_Evening = new System.Windows.Forms.RadioButton();
            this.rb_Night = new System.Windows.Forms.RadioButton();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.gb_Time = new System.Windows.Forms.GroupBox();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.gb_Gender.SuspendLayout();
            this.gb_Time.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(510, 126);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(313, 35);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Latter);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(181, 138);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(80, 27);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(46, 23);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(76, 26);
            this.rb_Male.TabIndex = 3;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            this.rb_Male.CheckedChanged += new System.EventHandler(this.rb_Male_CheckedChanged);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_Reset.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(497, 526);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(228, 52);
            this.btn_Reset.TabIndex = 8;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            this.btn_Reset.MouseLeave += new System.EventHandler(this.btn_Reset_MouseLeave);
            this.btn_Reset.MouseHover += new System.EventHandler(this.btn_Reset_MouseHover);
            // 
            // cmb_Department
            // 
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "Testing",
            "Frontend",
            "Backntend"});
            this.cmb_Department.Location = new System.Drawing.Point(510, 209);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(313, 34);
            this.cmb_Department.TabIndex = 2;
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.Location = new System.Drawing.Point(181, 208);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(158, 27);
            this.lbl_Department.TabIndex = 1;
            this.lbl_Department.Text = "Department";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(181, 292);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(101, 27);
            this.lbl_Gender.TabIndex = 1;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Shift_Time
            // 
            this.lbl_Shift_Time.AutoSize = true;
            this.lbl_Shift_Time.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Time.Location = new System.Drawing.Point(181, 392);
            this.lbl_Shift_Time.Name = "lbl_Shift_Time";
            this.lbl_Shift_Time.Size = new System.Drawing.Size(138, 27);
            this.lbl_Shift_Time.TabIndex = 1;
            this.lbl_Shift_Time.Text = "Shift Time";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Output.Location = new System.Drawing.Point(79, 683);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(114, 32);
            this.lbl_Output.TabIndex = 1;
            this.lbl_Output.Text = "Output";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(198, 23);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(99, 26);
            this.rb_Female.TabIndex = 4;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            this.rb_Female.CheckedChanged += new System.EventHandler(this.rb_Female_CheckedChanged);
            // 
            // rb_Morning
            // 
            this.rb_Morning.AutoSize = true;
            this.rb_Morning.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Morning.Location = new System.Drawing.Point(40, 28);
            this.rb_Morning.Name = "rb_Morning";
            this.rb_Morning.Size = new System.Drawing.Size(110, 26);
            this.rb_Morning.TabIndex = 5;
            this.rb_Morning.TabStop = true;
            this.rb_Morning.Text = "Morning";
            this.rb_Morning.UseVisualStyleBackColor = true;
            this.rb_Morning.CheckedChanged += new System.EventHandler(this.rb_Morning_CheckedChanged);
            // 
            // rb_Evening
            // 
            this.rb_Evening.AutoSize = true;
            this.rb_Evening.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Evening.Location = new System.Drawing.Point(192, 28);
            this.rb_Evening.Name = "rb_Evening";
            this.rb_Evening.Size = new System.Drawing.Size(105, 26);
            this.rb_Evening.TabIndex = 6;
            this.rb_Evening.TabStop = true;
            this.rb_Evening.Text = "Evening";
            this.rb_Evening.UseVisualStyleBackColor = true;
            this.rb_Evening.CheckedChanged += new System.EventHandler(this.rb_Evening_CheckedChanged);
            // 
            // rb_Night
            // 
            this.rb_Night.AutoSize = true;
            this.rb_Night.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Night.Location = new System.Drawing.Point(349, 28);
            this.rb_Night.Name = "rb_Night";
            this.rb_Night.Size = new System.Drawing.Size(83, 26);
            this.rb_Night.TabIndex = 7;
            this.rb_Night.TabStop = true;
            this.rb_Night.Text = "Night";
            this.rb_Night.UseVisualStyleBackColor = true;
            this.rb_Night.CheckedChanged += new System.EventHandler(this.rb_Night_CheckedChanged);
            // 
            // tb_Output
            // 
            this.tb_Output.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.Location = new System.Drawing.Point(219, 675);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(999, 35);
            this.tb_Output.TabIndex = 10;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_Save.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(789, 526);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(228, 52);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Save.MouseLeave += new System.EventHandler(this.btn_Save_MouseLeave);
            this.btn_Save.MouseHover += new System.EventHandler(this.btn_Save_MouseHover);
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Location = new System.Drawing.Point(510, 270);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(384, 64);
            this.gb_Gender.TabIndex = 5;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // gb_Time
            // 
            this.gb_Time.Controls.Add(this.rb_Evening);
            this.gb_Time.Controls.Add(this.rb_Morning);
            this.gb_Time.Controls.Add(this.rb_Night);
            this.gb_Time.Location = new System.Drawing.Point(510, 375);
            this.gb_Time.Name = "gb_Time";
            this.gb_Time.Size = new System.Drawing.Size(470, 64);
            this.gb_Time.TabIndex = 5;
            this.gb_Time.TabStop = false;
            this.gb_Time.Text = "Time";
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.BackColor = System.Drawing.Color.Fuchsia;
            this.lbl_Head.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.Location = new System.Drawing.Point(505, 36);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(356, 45);
            this.lbl_Head.TabIndex = 1;
            this.lbl_Head.Text = "Add Information";
            // 
            // frm_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 757);
            this.Controls.Add(this.gb_Time);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Shift_Time);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Head);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.tb_Name);
            this.Name = "frm_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Time.ResumeLayout(false);
            this.gb_Time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Shift_Time;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Morning;
        private System.Windows.Forms.RadioButton rb_Evening;
        private System.Windows.Forms.RadioButton rb_Night;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.GroupBox gb_Time;
        private System.Windows.Forms.Label lbl_Head;
    }
}

