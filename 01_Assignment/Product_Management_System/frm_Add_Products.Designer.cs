
namespace Product_Management_System
{
    partial class frm_Add_Products
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_Product_Qty = new System.Windows.Forms.TextBox();
            this.tb_Product_Id = new System.Windows.Forms.TextBox();
            this.lbl_Product_Qty = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_head = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Product_Company = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_company = new System.Windows.Forms.ComboBox();
            this.dtp_Product_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_View_List = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(142, 652);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(173, 60);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Product_Qty
            // 
            this.tb_Product_Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Product_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Qty.Location = new System.Drawing.Point(749, 426);
            this.tb_Product_Qty.Name = "tb_Product_Qty";
            this.tb_Product_Qty.Size = new System.Drawing.Size(281, 38);
            this.tb_Product_Qty.TabIndex = 4;
            this.tb_Product_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numric);
            // 
            // tb_Product_Id
            // 
            this.tb_Product_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Product_Id.Enabled = false;
            this.tb_Product_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Id.Location = new System.Drawing.Point(749, 172);
            this.tb_Product_Id.Name = "tb_Product_Id";
            this.tb_Product_Id.Size = new System.Drawing.Size(281, 38);
            this.tb_Product_Id.TabIndex = 1;
            this.tb_Product_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numric);
            // 
            // lbl_Product_Qty
            // 
            this.lbl_Product_Qty.AutoSize = true;
            this.lbl_Product_Qty.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Product_Qty.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Qty.Location = new System.Drawing.Point(139, 432);
            this.lbl_Product_Qty.Name = "lbl_Product_Qty";
            this.lbl_Product_Qty.Size = new System.Drawing.Size(166, 32);
            this.lbl_Product_Qty.TabIndex = 5;
            this.lbl_Product_Qty.Text = "Product Qty";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(139, 269);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(195, 32);
            this.lbl_Product_Name.TabIndex = 6;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_head.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.Location = new System.Drawing.Point(375, 47);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(372, 56);
            this.lbl_head.TabIndex = 7;
            this.lbl_head.Text = "ADD PRODUCT";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Id.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(139, 178);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(153, 32);
            this.lbl_Id.TabIndex = 6;
            this.lbl_Id.Text = "Product ID";
            // 
            // lbl_Product_Company
            // 
            this.lbl_Product_Company.AutoSize = true;
            this.lbl_Product_Company.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Product_Company.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Company.Location = new System.Drawing.Point(139, 348);
            this.lbl_Product_Company.Name = "lbl_Product_Company";
            this.lbl_Product_Company.Size = new System.Drawing.Size(240, 32);
            this.lbl_Product_Company.TabIndex = 5;
            this.lbl_Product_Company.Text = "Product Company";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Date.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(139, 522);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(74, 32);
            this.lbl_Date.TabIndex = 5;
            this.lbl_Date.Text = "Date";
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Items.AddRange(new object[] {
            "Computer",
            "Mobile",
            "Laptop",
            "Washing Machine",
            "LED TV",
            "AC",
            "Printer"});
            this.cmb_Product_Name.Location = new System.Drawing.Point(749, 262);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(281, 39);
            this.cmb_Product_Name.TabIndex = 2;
            // 
            // cmb_company
            // 
            this.cmb_company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_company.FormattingEnabled = true;
            this.cmb_company.Items.AddRange(new object[] {
            "Haier",
            "LG",
            "HP",
            "Samsung",
            "OPPO",
            "Apple",
            "Nokia",
            "TATA",
            "Panasonic"});
            this.cmb_company.Location = new System.Drawing.Point(749, 341);
            this.cmb_company.Name = "cmb_company";
            this.cmb_company.Size = new System.Drawing.Size(281, 39);
            this.cmb_company.TabIndex = 3;
            // 
            // dtp_Product_Date
            // 
            this.dtp_Product_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Product_Date.Location = new System.Drawing.Point(749, 515);
            this.dtp_Product_Date.MaxDate = new System.DateTime(2023, 5, 26, 0, 0, 0, 0);
            this.dtp_Product_Date.MinDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.dtp_Product_Date.Name = "dtp_Product_Date";
            this.dtp_Product_Date.Size = new System.Drawing.Size(281, 38);
            this.dtp_Product_Date.TabIndex = 5;
            this.dtp_Product_Date.Value = new System.DateTime(2023, 5, 26, 0, 0, 0, 0);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Save.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(497, 652);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(173, 60);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_View_List
            // 
            this.btn_View_List.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_View_List.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_List.Location = new System.Drawing.Point(854, 652);
            this.btn_View_List.Name = "btn_View_List";
            this.btn_View_List.Size = new System.Drawing.Size(173, 60);
            this.btn_View_List.TabIndex = 8;
            this.btn_View_List.Text = "View List";
            this.btn_View_List.UseVisualStyleBackColor = false;
            this.btn_View_List.Click += new System.EventHandler(this.btn_View_List_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Logout.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(945, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(209, 60);
            this.btn_Logout.TabIndex = 9;
            this.btn_Logout.Text = "LOGOUT";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frm_Add_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 757);
            this.ControlBox = false;
            this.Controls.Add(this.dtp_Product_Date);
            this.Controls.Add(this.cmb_company);
            this.Controls.Add(this.cmb_Product_Name);
            this.Controls.Add(this.btn_View_List);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.tb_Product_Qty);
            this.Controls.Add(this.tb_Product_Id);
            this.Controls.Add(this.lbl_Product_Company);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Product_Qty);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.lbl_head);
            this.Name = "frm_Add_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD PRODUCT";
            this.Load += new System.EventHandler(this.frm_Add_Products_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Latter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Product_Qty;
        private System.Windows.Forms.TextBox tb_Product_Id;
        private System.Windows.Forms.Label lbl_Product_Qty;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Product_Company;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_company;
        private System.Windows.Forms.DateTimePicker dtp_Product_Date;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_View_List;
        private System.Windows.Forms.Button btn_Logout;
    }
}