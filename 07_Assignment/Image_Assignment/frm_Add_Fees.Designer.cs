
namespace Image_Assignment
{
    partial class frm_Add_Fees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Fees = new System.Windows.Forms.Label();
            this.tb_Total_fee = new System.Windows.Forms.TextBox();
            this.lbl_Total_Fee = new System.Windows.Forms.Label();
            this.tb_Paid = new System.Windows.Forms.TextBox();
            this.lbl_Paid_Fee = new System.Windows.Forms.Label();
            this.tb_Remaining_Fee = new System.Windows.Forms.TextBox();
            this.lbl_Remaining_Fee = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.dgv_Fees = new System.Windows.Forms.DataGridView();
            this.Course_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fees)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(260, 159);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(311, 33);
            this.tb_Name.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(40, 163);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(76, 29);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(260, 75);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(311, 33);
            this.tb_ID.TabIndex = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(40, 75);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(126, 29);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "Student ID";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.Location = new System.Drawing.Point(40, 248);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(87, 29);
            this.lbl_Course.TabIndex = 1;
            this.lbl_Course.Text = "Course";
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Location = new System.Drawing.Point(260, 246);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(311, 34);
            this.cmb_Course.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(260, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 33);
            this.textBox1.TabIndex = 0;
            // 
            // lbl_Fees
            // 
            this.lbl_Fees.AutoSize = true;
            this.lbl_Fees.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fees.Location = new System.Drawing.Point(40, 336);
            this.lbl_Fees.Name = "lbl_Fees";
            this.lbl_Fees.Size = new System.Drawing.Size(128, 29);
            this.lbl_Fees.TabIndex = 1;
            this.lbl_Fees.Text = "Course Fee";
            // 
            // tb_Total_fee
            // 
            this.tb_Total_fee.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_fee.Location = new System.Drawing.Point(993, 75);
            this.tb_Total_fee.Name = "tb_Total_fee";
            this.tb_Total_fee.Size = new System.Drawing.Size(311, 33);
            this.tb_Total_fee.TabIndex = 0;
            // 
            // lbl_Total_Fee
            // 
            this.lbl_Total_Fee.AutoSize = true;
            this.lbl_Total_Fee.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Fee.Location = new System.Drawing.Point(773, 75);
            this.lbl_Total_Fee.Name = "lbl_Total_Fee";
            this.lbl_Total_Fee.Size = new System.Drawing.Size(108, 29);
            this.lbl_Total_Fee.TabIndex = 1;
            this.lbl_Total_Fee.Text = "Total Fee";
            // 
            // tb_Paid
            // 
            this.tb_Paid.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paid.Location = new System.Drawing.Point(993, 163);
            this.tb_Paid.Name = "tb_Paid";
            this.tb_Paid.Size = new System.Drawing.Size(311, 33);
            this.tb_Paid.TabIndex = 0;
            // 
            // lbl_Paid_Fee
            // 
            this.lbl_Paid_Fee.AutoSize = true;
            this.lbl_Paid_Fee.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid_Fee.Location = new System.Drawing.Point(773, 163);
            this.lbl_Paid_Fee.Name = "lbl_Paid_Fee";
            this.lbl_Paid_Fee.Size = new System.Drawing.Size(102, 29);
            this.lbl_Paid_Fee.TabIndex = 1;
            this.lbl_Paid_Fee.Text = "Paid Fee";
            // 
            // tb_Remaining_Fee
            // 
            this.tb_Remaining_Fee.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Remaining_Fee.Location = new System.Drawing.Point(993, 248);
            this.tb_Remaining_Fee.Name = "tb_Remaining_Fee";
            this.tb_Remaining_Fee.Size = new System.Drawing.Size(311, 33);
            this.tb_Remaining_Fee.TabIndex = 0;
            // 
            // lbl_Remaining_Fee
            // 
            this.lbl_Remaining_Fee.AutoSize = true;
            this.lbl_Remaining_Fee.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remaining_Fee.Location = new System.Drawing.Point(773, 248);
            this.lbl_Remaining_Fee.Name = "lbl_Remaining_Fee";
            this.lbl_Remaining_Fee.Size = new System.Drawing.Size(169, 29);
            this.lbl_Remaining_Fee.TabIndex = 1;
            this.lbl_Remaining_Fee.Text = "Remaining Fee";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(773, 344);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(63, 29);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(993, 349);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(311, 29);
            this.dtp_Date.TabIndex = 3;
            // 
            // dgv_Fees
            // 
            this.dgv_Fees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Fees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Fees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Fees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course_Name,
            this.Fees});
            this.dgv_Fees.Location = new System.Drawing.Point(28, 421);
            this.dgv_Fees.Name = "dgv_Fees";
            this.dgv_Fees.Size = new System.Drawing.Size(580, 269);
            this.dgv_Fees.TabIndex = 4;
            // 
            // Course_Name
            // 
            this.Course_Name.HeaderText = "Course Name";
            this.Course_Name.Name = "Course_Name";
            this.Course_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Fees
            // 
            this.Fees.HeaderText = "Fees";
            this.Fees.Name = "Fees";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Add.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(586, 241);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 42);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Save.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(794, 519);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(161, 54);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1108, 519);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(161, 54);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // frm_Add_Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 749);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Fees);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.lbl_Fees);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Remaining_Fee);
            this.Controls.Add(this.lbl_Paid_Fee);
            this.Controls.Add(this.lbl_Total_Fee);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_Remaining_Fee);
            this.Controls.Add(this.tb_Paid);
            this.Controls.Add(this.tb_Total_fee);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Fees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Fees";
            this.Load += new System.EventHandler(this.frm_Add_Fees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Fees;
        private System.Windows.Forms.TextBox tb_Total_fee;
        private System.Windows.Forms.Label lbl_Total_Fee;
        private System.Windows.Forms.TextBox tb_Paid;
        private System.Windows.Forms.Label lbl_Paid_Fee;
        private System.Windows.Forms.TextBox tb_Remaining_Fee;
        private System.Windows.Forms.Label lbl_Remaining_Fee;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DataGridView dgv_Fees;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fees;
    }
}