
namespace School_Mgt_Systeam
{
    partial class frm_Show_Stu_Info
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_View = new System.Windows.Forms.DataGridView();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.btn_Add_Stu = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_View
            // 
            this.dgv_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_View.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_View.Location = new System.Drawing.Point(21, 118);
            this.dgv_View.Name = "dgv_View";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_View.RowHeadersWidth = 51;
            this.dgv_View.RowTemplate.Height = 24;
            this.dgv_View.Size = new System.Drawing.Size(1171, 566);
            this.dgv_View.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Logout.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Logout.Location = new System.Drawing.Point(990, 2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(202, 50);
            this.btn_Logout.TabIndex = 10;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Head.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Head.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Head.Location = new System.Drawing.Point(426, 39);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(360, 49);
            this.lbl_Head.TabIndex = 9;
            this.lbl_Head.Text = "View Information";
            // 
            // btn_Add_Stu
            // 
            this.btn_Add_Stu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Add_Stu.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Stu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Add_Stu.Location = new System.Drawing.Point(462, 702);
            this.btn_Add_Stu.Name = "btn_Add_Stu";
            this.btn_Add_Stu.Size = new System.Drawing.Size(289, 50);
            this.btn_Add_Stu.TabIndex = 11;
            this.btn_Add_Stu.Text = "Add Student";
            this.btn_Add_Stu.UseVisualStyleBackColor = false;
            this.btn_Add_Stu.Click += new System.EventHandler(this.btn_Add_Stu_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Username.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Username.Location = new System.Drawing.Point(-1, 2);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(219, 49);
            this.lbl_Username.TabIndex = 12;
            this.lbl_Username.Text = "Username";
            // 
            // frm_Show_Stu_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 764);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.btn_Add_Stu);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_Head);
            this.Controls.Add(this.dgv_View);
            this.Name = "frm_Show_Stu_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHOW INFORMATION";
            this.Load += new System.EventHandler(this.frm_Show_Stu_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Button btn_Add_Stu;
        private System.Windows.Forms.Label lbl_Username;
    }
}