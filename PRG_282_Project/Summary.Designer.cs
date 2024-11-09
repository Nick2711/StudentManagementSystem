namespace PRG_282_Project
{
    partial class Summary
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
            this.GenerateSumbtn = new System.Windows.Forms.Button();
            this.summaryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // GenerateSumbtn
            // 
            this.GenerateSumbtn.Location = new System.Drawing.Point(200, 340);
            this.GenerateSumbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenerateSumbtn.Name = "GenerateSumbtn";
            this.GenerateSumbtn.Size = new System.Drawing.Size(153, 42);
            this.GenerateSumbtn.TabIndex = 1;
            this.GenerateSumbtn.Text = "Generate Summary";
            this.GenerateSumbtn.UseVisualStyleBackColor = true;
            this.GenerateSumbtn.Click += new System.EventHandler(this.GenerateSumbtn_Click);
            // 
            // summaryRichTextBox
            // 
            this.summaryRichTextBox.Location = new System.Drawing.Point(12, 31);
            this.summaryRichTextBox.Name = "summaryRichTextBox";
            this.summaryRichTextBox.Size = new System.Drawing.Size(512, 304);
            this.summaryRichTextBox.TabIndex = 2;
            this.summaryRichTextBox.Text = "";
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 471);
            this.Controls.Add(this.summaryRichTextBox);
            this.Controls.Add(this.GenerateSumbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Summary";
            this.Text = "Summary";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GenerateSumbtn;
        private System.Windows.Forms.RichTextBox summaryRichTextBox;
    }
}