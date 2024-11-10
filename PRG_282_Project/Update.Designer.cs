namespace PRG_282_Project
{
    partial class Update
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Updatebtn = new System.Windows.Forms.Button();
<<<<<<< Updated upstream:PRG_282_Project/Form2.Designer.cs
            this.textBox1 = new System.Windows.Forms.TextBox();
=======
            this.SearchStudentID = new System.Windows.Forms.TextBox();
>>>>>>> Stashed changes:PRG_282_Project/Update.Designer.cs
            this.Searchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(226, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(456, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Rockwell Nova", 10.2F, System.Drawing.FontStyle.Bold);
            this.Updatebtn.Location = new System.Drawing.Point(32, 290);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(175, 64);
            this.Updatebtn.TabIndex = 1;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
<<<<<<< Updated upstream:PRG_282_Project/Form2.Designer.cs
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Search for Student ID";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
=======
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // SearchStudentID
            // 
            this.SearchStudentID.Location = new System.Drawing.Point(32, 95);
            this.SearchStudentID.Name = "SearchStudentID";
            this.SearchStudentID.Size = new System.Drawing.Size(175, 22);
            this.SearchStudentID.TabIndex = 2;
            this.SearchStudentID.Text = "Search for Student ID";
            this.SearchStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
>>>>>>> Stashed changes:PRG_282_Project/Update.Designer.cs
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Rockwell Nova", 10.2F, System.Drawing.FontStyle.Bold);
            this.Searchbtn.Location = new System.Drawing.Point(32, 123);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(175, 64);
            this.Searchbtn.TabIndex = 3;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
<<<<<<< Updated upstream:PRG_282_Project/Form2.Designer.cs
=======
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
>>>>>>> Stashed changes:PRG_282_Project/Update.Designer.cs
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 580);
            this.Controls.Add(this.Searchbtn);
<<<<<<< Updated upstream:PRG_282_Project/Form2.Designer.cs
            this.Controls.Add(this.textBox1);
=======
            this.Controls.Add(this.SearchStudentID);
>>>>>>> Stashed changes:PRG_282_Project/Update.Designer.cs
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
<<<<<<< Updated upstream:PRG_282_Project/Form2.Designer.cs
=======
            this.Load += new System.EventHandler(this.Form2_Load);
>>>>>>> Stashed changes:PRG_282_Project/Update.Designer.cs
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Updatebtn;
<<<<<<< Updated upstream:PRG_282_Project/Form2.Designer.cs
        private System.Windows.Forms.TextBox textBox1;
=======

        private System.Windows.Forms.TextBox SearchStudentID;

>>>>>>> Stashed changes:PRG_282_Project/Update.Designer.cs
        private System.Windows.Forms.Button Searchbtn;
    }
}