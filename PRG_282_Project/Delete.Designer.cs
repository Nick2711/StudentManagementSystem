﻿namespace PRG_282_Project
{
    partial class DeleteForm
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
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchStudentIDTextBox = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.SearchOnDelete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Location = new System.Drawing.Point(230, 12);
            this.studentDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowHeadersWidth = 51;
            this.studentDataGridView.RowTemplate.Height = 24;
            this.studentDataGridView.Size = new System.Drawing.Size(448, 491);
            this.studentDataGridView.TabIndex = 0;
            // 
            // SearchStudentIDTextBox
            // 
            this.SearchStudentIDTextBox.Font = new System.Drawing.Font("Rockwell Nova", 10.2F, System.Drawing.FontStyle.Bold);
            this.SearchStudentIDTextBox.Location = new System.Drawing.Point(37, 129);
            this.SearchStudentIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchStudentIDTextBox.Name = "SearchStudentIDTextBox";
            this.SearchStudentIDTextBox.Size = new System.Drawing.Size(159, 68);
            this.SearchStudentIDTextBox.TabIndex = 1;
            this.SearchStudentIDTextBox.Text = "Search";
            this.SearchStudentIDTextBox.UseVisualStyleBackColor = true;
            this.SearchStudentIDTextBox.Click += new System.EventHandler(this.SearchStudentIDTextBox_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Rockwell Nova", 10.2F, System.Drawing.FontStyle.Bold);
            this.Deletebtn.Location = new System.Drawing.Point(37, 337);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(159, 68);
            this.Deletebtn.TabIndex = 2;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // SearchOnDelete
            // 
            this.SearchOnDelete.Location = new System.Drawing.Point(12, 103);
            this.SearchOnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchOnDelete.Name = "SearchOnDelete";
            this.SearchOnDelete.Size = new System.Drawing.Size(212, 22);
            this.SearchOnDelete.TabIndex = 4;
            this.SearchOnDelete.Text = "Search for Student\'s ID ";
            this.SearchOnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchOnDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchOnDelete_MouseClick);
            this.SearchOnDelete.Validating += new System.ComponentModel.CancelEventHandler(this.SearchOnDelete_Validating);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(715, 580);
            this.Controls.Add(this.SearchOnDelete);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.SearchStudentIDTextBox);
            this.Controls.Add(this.studentDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DeleteForm";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.DeleteForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Button SearchStudentIDTextBox;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TextBox SearchOnDelete;
    }
}