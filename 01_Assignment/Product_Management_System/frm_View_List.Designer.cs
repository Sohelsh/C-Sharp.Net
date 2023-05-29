
namespace Product_Management_System
{
    partial class frm_View_List
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
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_head = new System.Windows.Forms.Label();
            this.dgv_Product_List = new System.Windows.Forms.DataGridView();
            this.btn_Add_Product = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Logout.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(926, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(209, 60);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "LOGOUT";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_head.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.Location = new System.Drawing.Point(364, 46);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(373, 56);
            this.lbl_head.TabIndex = 10;
            this.lbl_head.Text = "PRODUCT LIST";
            // 
            // dgv_Product_List
            // 
            this.dgv_Product_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product_List.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_List.Location = new System.Drawing.Point(51, 127);
            this.dgv_Product_List.Name = "dgv_Product_List";
            this.dgv_Product_List.RowHeadersWidth = 51;
            this.dgv_Product_List.RowTemplate.Height = 24;
            this.dgv_Product_List.Size = new System.Drawing.Size(1028, 523);
            this.dgv_Product_List.TabIndex = 12;
            // 
            // btn_Add_Product
            // 
            this.btn_Add_Product.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Add_Product.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Product.Location = new System.Drawing.Point(424, 680);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.Size = new System.Drawing.Size(285, 60);
            this.btn_Add_Product.TabIndex = 13;
            this.btn_Add_Product.Text = "Add Product";
            this.btn_Add_Product.UseVisualStyleBackColor = false;
            this.btn_Add_Product.Click += new System.EventHandler(this.btn_Add_Product_Click);
            // 
            // frm_View_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 752);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Add_Product);
            this.Controls.Add(this.dgv_Product_List);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_head);
            this.Name = "frm_View_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCT LIST";
            this.Load += new System.EventHandler(this.frm_View_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.DataGridView dgv_Product_List;
        private System.Windows.Forms.Button btn_Add_Product;
    }
}