
namespace Image_Assignment
{
    partial class Form_Show_Data
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Head = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.dataGridView_ImageData = new System.Windows.Forms.DataGridView();
            this.imageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentSevenDataSet = new Image_Assignment.AssignmentSevenDataSet();
            this.pictureBox_Your_Image = new System.Windows.Forms.PictureBox();
            this.label_Your_Image = new System.Windows.Forms.Label();
            this.button_Add_Image = new System.Windows.Forms.Button();
            this.imageDataTableAdapter = new Image_Assignment.AssignmentSevenDataSetTableAdapters.ImageDataTableAdapter();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Browes_Image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ImageData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentSevenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Your_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Head
            // 
            this.label_Head.AutoSize = true;
            this.label_Head.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Head.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Head.Location = new System.Drawing.Point(633, 9);
            this.label_Head.Name = "label_Head";
            this.label_Head.Size = new System.Drawing.Size(229, 45);
            this.label_Head.TabIndex = 1;
            this.label_Head.Text = "Show Data";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(1102, 131);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(245, 39);
            this.textBox_ID.TabIndex = 2;
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(905, 138);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(142, 32);
            this.label_Id.TabIndex = 3;
            this.label_Id.Text = "Image ID";
            // 
            // dataGridView_ImageData
            // 
            this.dataGridView_ImageData.AllowUserToAddRows = false;
            this.dataGridView_ImageData.AllowUserToDeleteRows = false;
            this.dataGridView_ImageData.AutoGenerateColumns = false;
            this.dataGridView_ImageData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ImageData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ImageData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ImageData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ImageData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageIDDataGridViewTextBoxColumn,
            this.imageDescDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView_ImageData.DataSource = this.imageDataBindingSource;
            this.dataGridView_ImageData.Location = new System.Drawing.Point(12, 138);
            this.dataGridView_ImageData.Name = "dataGridView_ImageData";
            this.dataGridView_ImageData.ReadOnly = true;
            this.dataGridView_ImageData.RowHeadersWidth = 51;
            this.dataGridView_ImageData.RowTemplate.Height = 24;
            this.dataGridView_ImageData.Size = new System.Drawing.Size(800, 529);
            this.dataGridView_ImageData.TabIndex = 4;
            this.dataGridView_ImageData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ImageData_CellClick);
            this.dataGridView_ImageData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ImageData_CellContentClick);
            // 
            // imageIDDataGridViewTextBoxColumn
            // 
            this.imageIDDataGridViewTextBoxColumn.DataPropertyName = "Image_ID";
            this.imageIDDataGridViewTextBoxColumn.HeaderText = "Image_ID";
            this.imageIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageIDDataGridViewTextBoxColumn.Name = "imageIDDataGridViewTextBoxColumn";
            this.imageIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDescDataGridViewTextBoxColumn
            // 
            this.imageDescDataGridViewTextBoxColumn.DataPropertyName = "Image_Desc";
            this.imageDescDataGridViewTextBoxColumn.HeaderText = "Image_Desc";
            this.imageDescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageDescDataGridViewTextBoxColumn.Name = "imageDescDataGridViewTextBoxColumn";
            this.imageDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // imageDataBindingSource
            // 
            this.imageDataBindingSource.DataMember = "ImageData";
            this.imageDataBindingSource.DataSource = this.assignmentSevenDataSet;
            // 
            // assignmentSevenDataSet
            // 
            this.assignmentSevenDataSet.DataSetName = "AssignmentSevenDataSet";
            this.assignmentSevenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox_Your_Image
            // 
            this.pictureBox_Your_Image.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_Your_Image.Location = new System.Drawing.Point(913, 231);
            this.pictureBox_Your_Image.Name = "pictureBox_Your_Image";
            this.pictureBox_Your_Image.Size = new System.Drawing.Size(436, 495);
            this.pictureBox_Your_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Your_Image.TabIndex = 6;
            this.pictureBox_Your_Image.TabStop = false;
            // 
            // label_Your_Image
            // 
            this.label_Your_Image.AutoSize = true;
            this.label_Your_Image.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Your_Image.Location = new System.Drawing.Point(1026, 196);
            this.label_Your_Image.Name = "label_Your_Image";
            this.label_Your_Image.Size = new System.Drawing.Size(178, 32);
            this.label_Your_Image.TabIndex = 5;
            this.label_Your_Image.Text = "Your Image";
            // 
            // button_Add_Image
            // 
            this.button_Add_Image.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Add_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add_Image.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add_Image.Location = new System.Drawing.Point(107, 719);
            this.button_Add_Image.Name = "button_Add_Image";
            this.button_Add_Image.Size = new System.Drawing.Size(198, 49);
            this.button_Add_Image.TabIndex = 1;
            this.button_Add_Image.Text = "Add Image";
            this.button_Add_Image.UseVisualStyleBackColor = false;
            this.button_Add_Image.Click += new System.EventHandler(this.button_Add_Image_Click);
            // 
            // imageDataTableAdapter
            // 
            this.imageDataTableAdapter.ClearBeforeFill = true;
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(428, 719);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(208, 49);
            this.button_Update.TabIndex = 1;
            this.button_Update.Text = "Update Image";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Browes_Image
            // 
            this.button_Browes_Image.BackColor = System.Drawing.Color.Aquamarine;
            this.button_Browes_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Browes_Image.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Browes_Image.Location = new System.Drawing.Point(1010, 732);
            this.button_Browes_Image.Name = "button_Browes_Image";
            this.button_Browes_Image.Size = new System.Drawing.Size(296, 49);
            this.button_Browes_Image.TabIndex = 7;
            this.button_Browes_Image.Text = "Browes Image";
            this.button_Browes_Image.UseVisualStyleBackColor = false;
            this.button_Browes_Image.Click += new System.EventHandler(this.button_Browes_Image_Click);
            // 
            // Form_Show_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1423, 809);
            this.Controls.Add(this.button_Browes_Image);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Add_Image);
            this.Controls.Add(this.pictureBox_Your_Image);
            this.Controls.Add(this.label_Your_Image);
            this.Controls.Add(this.dataGridView_ImageData);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.label_Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Show_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_Data";
            this.Load += new System.EventHandler(this.Form_Show_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ImageData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentSevenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Your_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Head;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.DataGridView dataGridView_ImageData;
        private System.Windows.Forms.PictureBox pictureBox_Your_Image;
        private System.Windows.Forms.Label label_Your_Image;
        private System.Windows.Forms.Button button_Add_Image;
        private AssignmentSevenDataSet assignmentSevenDataSet;
        private System.Windows.Forms.BindingSource imageDataBindingSource;
        private AssignmentSevenDataSetTableAdapters.ImageDataTableAdapter imageDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Browes_Image;
    }
}