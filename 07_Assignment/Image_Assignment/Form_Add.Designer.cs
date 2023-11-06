
namespace Image_Assignment
{
    partial class Form_Add
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
            this.label_Head = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Desc = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Desc = new System.Windows.Forms.TextBox();
            this.label_Add_Image = new System.Windows.Forms.Label();
            this.pictureBox_Upload_Image = new System.Windows.Forms.PictureBox();
            this.button_Import_Image = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Show_Image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Upload_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Head
            // 
            this.label_Head.AutoSize = true;
            this.label_Head.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_Head.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Head.Location = new System.Drawing.Point(602, 6);
            this.label_Head.Name = "label_Head";
            this.label_Head.Size = new System.Drawing.Size(189, 37);
            this.label_Head.TabIndex = 0;
            this.label_Head.Text = "Add Image";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(54, 97);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(110, 25);
            this.label_Id.TabIndex = 1;
            this.label_Id.Text = "Image ID";
            // 
            // label_Desc
            // 
            this.label_Desc.AutoSize = true;
            this.label_Desc.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Desc.Location = new System.Drawing.Point(54, 167);
            this.label_Desc.Name = "label_Desc";
            this.label_Desc.Size = new System.Drawing.Size(221, 25);
            this.label_Desc.TabIndex = 1;
            this.label_Desc.Text = "Image Description ";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(328, 90);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(245, 33);
            this.textBox_ID.TabIndex = 1;
            // 
            // textBox_Desc
            // 
            this.textBox_Desc.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Desc.Location = new System.Drawing.Point(328, 236);
            this.textBox_Desc.Multiline = true;
            this.textBox_Desc.Name = "textBox_Desc";
            this.textBox_Desc.Size = new System.Drawing.Size(407, 390);
            this.textBox_Desc.TabIndex = 2;
            // 
            // label_Add_Image
            // 
            this.label_Add_Image.AutoSize = true;
            this.label_Add_Image.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Add_Image.Location = new System.Drawing.Point(998, 68);
            this.label_Add_Image.Name = "label_Add_Image";
            this.label_Add_Image.Size = new System.Drawing.Size(164, 25);
            this.label_Add_Image.TabIndex = 1;
            this.label_Add_Image.Text = "Upload Image";
            // 
            // pictureBox_Upload_Image
            // 
            this.pictureBox_Upload_Image.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_Upload_Image.Location = new System.Drawing.Point(885, 103);
            this.pictureBox_Upload_Image.Name = "pictureBox_Upload_Image";
            this.pictureBox_Upload_Image.Size = new System.Drawing.Size(436, 495);
            this.pictureBox_Upload_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Upload_Image.TabIndex = 3;
            this.pictureBox_Upload_Image.TabStop = false;
            // 
            // button_Import_Image
            // 
            this.button_Import_Image.BackColor = System.Drawing.Color.Aquamarine;
            this.button_Import_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Import_Image.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Import_Image.Location = new System.Drawing.Point(1011, 604);
            this.button_Import_Image.Name = "button_Import_Image";
            this.button_Import_Image.Size = new System.Drawing.Size(198, 49);
            this.button_Import_Image.TabIndex = 3;
            this.button_Import_Image.Text = "Import Image";
            this.button_Import_Image.UseVisualStyleBackColor = false;
            this.button_Import_Image.Click += new System.EventHandler(this.button_Import_Image_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reset.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.Location = new System.Drawing.Point(126, 715);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(198, 49);
            this.button_Reset.TabIndex = 4;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(625, 715);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(198, 49);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Show_Image
            // 
            this.button_Show_Image.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Show_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Show_Image.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show_Image.Location = new System.Drawing.Point(1104, 715);
            this.button_Show_Image.Name = "button_Show_Image";
            this.button_Show_Image.Size = new System.Drawing.Size(198, 49);
            this.button_Show_Image.TabIndex = 6;
            this.button_Show_Image.Text = "Show Data";
            this.button_Show_Image.UseVisualStyleBackColor = false;
            this.button_Show_Image.Click += new System.EventHandler(this.button_Show_Image_Click);
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1391, 786);
            this.Controls.Add(this.button_Show_Image);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Import_Image);
            this.Controls.Add(this.pictureBox_Upload_Image);
            this.Controls.Add(this.textBox_Desc);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_Add_Image);
            this.Controls.Add(this.label_Desc);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.label_Head);
            this.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Image";
            this.Load += new System.EventHandler(this.Form_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Upload_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Head;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Desc;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Desc;
        private System.Windows.Forms.Label label_Add_Image;
        private System.Windows.Forms.PictureBox pictureBox_Upload_Image;
        private System.Windows.Forms.Button button_Import_Image;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Show_Image;
    }
}

