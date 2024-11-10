namespace PRG_282_Project
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
            this.Deletebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Location = new System.Drawing.Point(255, 45);
            this.studentDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowHeadersWidth = 51;
            this.studentDataGridView.RowTemplate.Height = 24;
            this.studentDataGridView.Size = new System.Drawing.Size(448, 491);
            this.studentDataGridView.TabIndex = 0;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Deletebtn.Location = new System.Drawing.Point(43, 242);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(159, 68);
            this.Deletebtn.TabIndex = 2;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. Select the small arrow button.\r\n(Left most column)\r\n In order to select a stud" +
    "ent. \r\n2. Then Click Delete Button";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(715, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deletebtn);
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
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Label label1;
    }
}