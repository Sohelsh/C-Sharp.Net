
namespace Fork_Class_Mgt_System
{
    partial class frm_View_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_Data));
            this.lbl_Head = new System.Windows.Forms.Label();
            this.dgv_Show_Data = new System.Windows.Forms.DataGridView();
            this.btn_Add_Student = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Show_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Head.Font = new System.Drawing.Font("Segoe UI", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Head.Location = new System.Drawing.Point(310, 56);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(571, 77);
            this.lbl_Head.TabIndex = 11;
            this.lbl_Head.Text = " STUDENT  DETAILS";
            // 
            // dgv_Show_Data
            // 
            this.dgv_Show_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Show_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Show_Data.Location = new System.Drawing.Point(100, 160);
            this.dgv_Show_Data.Name = "dgv_Show_Data";
            this.dgv_Show_Data.RowHeadersWidth = 51;
            this.dgv_Show_Data.RowTemplate.Height = 29;
            this.dgv_Show_Data.Size = new System.Drawing.Size(1020, 478);
            this.dgv_Show_Data.TabIndex = 12;
            // 
            // btn_Add_Student
            // 
            this.btn_Add_Student.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Add_Student.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add_Student.Location = new System.Drawing.Point(445, 698);
            this.btn_Add_Student.Name = "btn_Add_Student";
            this.btn_Add_Student.Size = new System.Drawing.Size(357, 71);
            this.btn_Add_Student.TabIndex = 23;
            this.btn_Add_Student.Text = "Add Student ";
            this.btn_Add_Student.UseVisualStyleBackColor = false;
            this.btn_Add_Student.Click += new System.EventHandler(this.btn_Add_Student_Click);
            // 
            // frm_View_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1237, 829);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Add_Student);
            this.Controls.Add(this.dgv_Show_Data);
            this.Controls.Add(this.lbl_Head);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_View_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Student Details";
            this.Load += new System.EventHandler(this.frm_View_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Show_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.DataGridView dgv_Show_Data;
        private System.Windows.Forms.Button btn_Add_Student;
    }
}