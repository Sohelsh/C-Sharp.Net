
namespace Image_Assignment
{
    partial class frm_Add_Course
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
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_Course_ID = new System.Windows.Forms.TextBox();
            this.pnl_Head = new System.Windows.Forms.Panel();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.tb_Course_Name = new System.Windows.Forms.TextBox();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.tb_Course_Fee = new System.Windows.Forms.TextBox();
            this.lbl_Course_Fee = new System.Windows.Forms.Label();
            this.btn_Add_Course = new System.Windows.Forms.Button();
            this.pnl_Head.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(125, 151);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(118, 29);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "Course ID";
            // 
            // tb_Course_ID
            // 
            this.tb_Course_ID.Enabled = false;
            this.tb_Course_ID.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_ID.Location = new System.Drawing.Point(497, 151);
            this.tb_Course_ID.Name = "tb_Course_ID";
            this.tb_Course_ID.Size = new System.Drawing.Size(311, 33);
            this.tb_Course_ID.TabIndex = 2;
            // 
            // pnl_Head
            // 
            this.pnl_Head.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Head.Controls.Add(this.lbl_Head);
            this.pnl_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Head.Location = new System.Drawing.Point(0, 0);
            this.pnl_Head.Name = "pnl_Head";
            this.pnl_Head.Size = new System.Drawing.Size(943, 74);
            this.pnl_Head.TabIndex = 4;
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_Head.Location = new System.Drawing.Point(374, 18);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(205, 42);
            this.lbl_Head.TabIndex = 3;
            this.lbl_Head.Text = "Add Course ";
            // 
            // tb_Course_Name
            // 
            this.tb_Course_Name.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Name.Location = new System.Drawing.Point(497, 242);
            this.tb_Course_Name.Name = "tb_Course_Name";
            this.tb_Course_Name.Size = new System.Drawing.Size(311, 33);
            this.tb_Course_Name.TabIndex = 1;
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.Location = new System.Drawing.Point(125, 242);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(155, 29);
            this.lbl_Course_Name.TabIndex = 3;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // tb_Course_Fee
            // 
            this.tb_Course_Fee.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Fee.Location = new System.Drawing.Point(497, 345);
            this.tb_Course_Fee.Name = "tb_Course_Fee";
            this.tb_Course_Fee.Size = new System.Drawing.Size(311, 33);
            this.tb_Course_Fee.TabIndex = 2;
            // 
            // lbl_Course_Fee
            // 
            this.lbl_Course_Fee.AutoSize = true;
            this.lbl_Course_Fee.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Fee.Location = new System.Drawing.Point(125, 345);
            this.lbl_Course_Fee.Name = "lbl_Course_Fee";
            this.lbl_Course_Fee.Size = new System.Drawing.Size(128, 29);
            this.lbl_Course_Fee.TabIndex = 3;
            this.lbl_Course_Fee.Text = "Course Fee";
            // 
            // btn_Add_Course
            // 
            this.btn_Add_Course.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add_Course.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Course.Location = new System.Drawing.Point(343, 475);
            this.btn_Add_Course.Name = "btn_Add_Course";
            this.btn_Add_Course.Size = new System.Drawing.Size(198, 56);
            this.btn_Add_Course.TabIndex = 5;
            this.btn_Add_Course.Text = "Save";
            this.btn_Add_Course.UseVisualStyleBackColor = false;
            this.btn_Add_Course.Click += new System.EventHandler(this.btn_Add_Course_Click);
            // 
            // frm_Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 623);
            this.Controls.Add(this.btn_Add_Course);
            this.Controls.Add(this.pnl_Head);
            this.Controls.Add(this.lbl_Course_Fee);
            this.Controls.Add(this.lbl_Course_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.tb_Course_Fee);
            this.Controls.Add(this.tb_Course_Name);
            this.Controls.Add(this.tb_Course_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Course";
            this.Load += new System.EventHandler(this.frm_Add_Course_Load);
            this.pnl_Head.ResumeLayout(false);
            this.pnl_Head.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_Course_ID;
        private System.Windows.Forms.Panel pnl_Head;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.TextBox tb_Course_Name;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.TextBox tb_Course_Fee;
        private System.Windows.Forms.Label lbl_Course_Fee;
        private System.Windows.Forms.Button btn_Add_Course;
    }
}