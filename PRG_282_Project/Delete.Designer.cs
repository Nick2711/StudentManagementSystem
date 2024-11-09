namespace PRG_282_Project
{
    partial class Delete
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
            this.button1 = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
<<<<<<< Updated upstream
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
=======
            this.SearchDeleteText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
<<<<<<< Updated upstream
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 241);
            this.dataGridView1.TabIndex = 0;
=======
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Location = new System.Drawing.Point(235, 28);
            this.studentDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowHeadersWidth = 51;
            this.studentDataGridView.RowTemplate.Height = 24;
            this.studentDataGridView.Size = new System.Drawing.Size(468, 416);
            this.studentDataGridView.TabIndex = 0;
>>>>>>> Stashed changes
            // 
            // button1
            // 
<<<<<<< Updated upstream
            this.button1.Location = new System.Drawing.Point(519, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Students";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(519, 353);
=======
            this.SearchStudentIDTextBox.Font = new System.Drawing.Font("Rockwell Nova", 10.2F, System.Drawing.FontStyle.Bold);
            this.SearchStudentIDTextBox.Location = new System.Drawing.Point(51, 98);
            this.SearchStudentIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchStudentIDTextBox.Name = "SearchStudentIDTextBox";
            this.SearchStudentIDTextBox.Size = new System.Drawing.Size(159, 48);
            this.SearchStudentIDTextBox.TabIndex = 1;
            this.SearchStudentIDTextBox.Text = "Search";
            this.SearchStudentIDTextBox.UseVisualStyleBackColor = true;
            this.SearchStudentIDTextBox.Click += new System.EventHandler(this.SearchStudentIDTextBox_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Rockwell Nova", 10.2F, System.Drawing.FontStyle.Bold);
            this.Deletebtn.Location = new System.Drawing.Point(51, 315);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(159, 68);
            this.Deletebtn.TabIndex = 2;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SearchDeleteText
            // 
<<<<<<< Updated upstream
            this.textBox1.Location = new System.Drawing.Point(212, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Search for Student\'s ID ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
=======
            this.SearchDeleteText.Location = new System.Drawing.Point(33, 72);
            this.SearchDeleteText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchDeleteText.Name = "SearchDeleteText";
            this.SearchDeleteText.Size = new System.Drawing.Size(196, 22);
            this.SearchDeleteText.TabIndex = 4;
            this.SearchDeleteText.Text = "Search for Student\'s ID ";
            this.SearchDeleteText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
>>>>>>> Stashed changes
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(714, 580);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Delete";
=======
            this.ClientSize = new System.Drawing.Size(715, 580);
            this.Controls.Add(this.SearchDeleteText);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.SearchStudentIDTextBox);
            this.Controls.Add(this.studentDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DeleteForm";
>>>>>>> Stashed changes
            this.Text = "Delete";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Deletebtn;
<<<<<<< Updated upstream
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
=======
        private System.Windows.Forms.TextBox SearchDeleteText;
>>>>>>> Stashed changes
    }
}