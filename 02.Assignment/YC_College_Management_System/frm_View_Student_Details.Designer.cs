
namespace YC_College_Management_System
{
    partial class frm_View_Student_Details
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
            this.lbl_Head = new System.Windows.Forms.Label();
            this.btn_Add_Student_Details = new System.Windows.Forms.Button();
            this.dgv_Student_Details = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.BackColor = System.Drawing.Color.Khaki;
            this.lbl_Head.Font = new System.Drawing.Font("Verdana", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Head.Location = new System.Drawing.Point(287, 54);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(711, 71);
            this.lbl_Head.TabIndex = 8;
            this.lbl_Head.Text = "View Student Details";
            // 
            // btn_Add_Student_Details
            // 
            this.btn_Add_Student_Details.BackColor = System.Drawing.Color.Khaki;
            this.btn_Add_Student_Details.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add_Student_Details.Location = new System.Drawing.Point(415, 658);
            this.btn_Add_Student_Details.Name = "btn_Add_Student_Details";
            this.btn_Add_Student_Details.Size = new System.Drawing.Size(444, 70);
            this.btn_Add_Student_Details.TabIndex = 9;
            this.btn_Add_Student_Details.Text = "Add Student Details";
            this.btn_Add_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Add_Student_Details.Click += new System.EventHandler(this.btn_Add_Student_Details_Click);
            // 
            // dgv_Student_Details
            // 
            this.dgv_Student_Details.AllowUserToAddRows = false;
            this.dgv_Student_Details.AllowUserToDeleteRows = false;
            this.dgv_Student_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_Details.Location = new System.Drawing.Point(142, 168);
            this.dgv_Student_Details.Name = "dgv_Student_Details";
            this.dgv_Student_Details.ReadOnly = true;
            this.dgv_Student_Details.RowHeadersWidth = 51;
            this.dgv_Student_Details.RowTemplate.Height = 29;
            this.dgv_Student_Details.Size = new System.Drawing.Size(1076, 455);
            this.dgv_Student_Details.TabIndex = 10;
            // 
            // frm_View_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1300, 780);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Student_Details);
            this.Controls.Add(this.btn_Add_Student_Details);
            this.Controls.Add(this.lbl_Head);
            this.Name = "frm_View_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student Details";
            this.Load += new System.EventHandler(this.frm_View_Student_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Button btn_Add_Student_Details;
        private System.Windows.Forms.DataGridView dgv_Student_Details;
    }
}