﻿namespace PRG_282_Project
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
            this.SearchStudentID = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(386, 503);
            this.dataGridView1.TabIndex = 0;
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Rockwell Nova", 10.2F, System.Drawing.FontStyle.Bold);
            this.Updatebtn.Location = new System.Drawing.Point(43, 359);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(175, 64);
            this.Updatebtn.TabIndex = 1;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // SearchStudentID
            // 
            this.SearchStudentID.Location = new System.Drawing.Point(43, 81);
            this.SearchStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchStudentID.Name = "SearchStudentID";
            this.SearchStudentID.Size = new System.Drawing.Size(175, 22);
            this.SearchStudentID.TabIndex = 2;
            this.SearchStudentID.Text = "Search for Student ID";
            this.SearchStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchStudentID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchStudentID_MouseClick);
            this.SearchStudentID.Validating += new System.ComponentModel.CancelEventHandler(this.SearchStudentID_Validating);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Rockwell Nova", 10.2F, System.Drawing.FontStyle.Bold);
            this.Searchbtn.Location = new System.Drawing.Point(43, 148);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(175, 64);
            this.Searchbtn.TabIndex = 3;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(715, 580);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.SearchStudentID);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Update";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Updatebtn;

        private System.Windows.Forms.TextBox SearchStudentID;

        private System.Windows.Forms.Button Searchbtn;
    }
}