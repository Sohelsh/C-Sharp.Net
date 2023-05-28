
namespace Product_Management_System
{
    partial class frm_Login
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Login.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(429, 83);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(224, 69);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "LOGIN";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Username.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(173, 269);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(143, 32);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Password.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(173, 401);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(133, 32);
            this.lbl_Password.TabIndex = 0;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Error.Location = new System.Drawing.Point(403, 512);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(268, 20);
            this.lbl_Error.TabIndex = 0;
            this.lbl_Error.Text = "Enter Valid Username && Password";
            this.lbl_Error.Visible = false;
            // 
            // tb_Username
            // 
            this.tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(721, 265);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(281, 38);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(721, 395);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(281, 38);
            this.tb_Password.TabIndex = 2;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Submit.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(462, 613);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(173, 60);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1147, 721);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Submit;
    }
}

