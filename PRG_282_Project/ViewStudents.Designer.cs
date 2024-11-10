namespace PRG_282_Project
{
    partial class ViewStudents
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
            this.DisplayStudentsbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            this.dataGridView1.Location = new System.Drawing.Point(47, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(612, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // DisplayStudentsbtn
            // 
            this.DisplayStudentsbtn.Location = new System.Drawing.Point(259, 331);
=======
            this.dataGridView1.Location = new System.Drawing.Point(11, 31);
=======
            this.dataGridView1.Location = new System.Drawing.Point(251, 31);
>>>>>>> Stashed changes
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
<<<<<<< Updated upstream
            this.dataGridView1.Size = new System.Drawing.Size(692, 330);
=======
            this.dataGridView1.Size = new System.Drawing.Size(444, 460);
>>>>>>> Stashed changes
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DisplayStudentsbtn
            // 
<<<<<<< Updated upstream
            this.DisplayStudentsbtn.Font = new System.Drawing.Font("Rockwell Nova", 10.2F, System.Drawing.FontStyle.Bold);
            this.DisplayStudentsbtn.Location = new System.Drawing.Point(256, 365);
            this.DisplayStudentsbtn.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
=======
            this.DisplayStudentsbtn.Font = new System.Drawing.Font("Rockwell Nova", 8.2F, System.Drawing.FontStyle.Bold);
            this.DisplayStudentsbtn.Location = new System.Drawing.Point(31, 240);
            this.DisplayStudentsbtn.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.DisplayStudentsbtn.Name = "DisplayStudentsbtn";
            this.DisplayStudentsbtn.Size = new System.Drawing.Size(190, 53);
            this.DisplayStudentsbtn.TabIndex = 1;
            this.DisplayStudentsbtn.Text = "Display Students";
            this.DisplayStudentsbtn.UseVisualStyleBackColor = true;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
            this.DisplayStudentsbtn.Click += new System.EventHandler(this.DisplayStudentsbtn_Click);
>>>>>>> Stashed changes
=======
            this.DisplayStudentsbtn.Click += new System.EventHandler(this.DisplayStudentsbtn_Click);
>>>>>>> Stashed changes
            // 
            // ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(714, 580);
            this.Controls.Add(this.DisplayStudentsbtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewStudents";
            this.Text = "Form3";
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
            this.Load += new System.EventHandler(this.ViewStudents_Load);
>>>>>>> Stashed changes
=======
            this.Load += new System.EventHandler(this.ViewStudents_Load);
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DisplayStudentsbtn;
    }
}