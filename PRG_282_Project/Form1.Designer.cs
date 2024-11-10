namespace PRG_282_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.GenerateSummarybtn = new System.Windows.Forms.Button();
            this.panelMediaSubmenu = new System.Windows.Forms.Panel();
            this.DeleteStudentNavbtn = new System.Windows.Forms.Button();
            this.UpdateDetailsNavbtn = new System.Windows.Forms.Button();
            this.ViewStudentsNavbtn = new System.Windows.Forms.Button();
            this.AddStudentNavbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.DisplayInfoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelMediaSubmenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DisplayInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.DarkCyan;
            this.panelSideMenu.Controls.Add(this.Exitbtn);
            this.panelSideMenu.Controls.Add(this.GenerateSummarybtn);
            this.panelSideMenu.Controls.Add(this.panelMediaSubmenu);
            this.panelSideMenu.Controls.Add(this.panel2);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(217, 580);
            this.panelSideMenu.TabIndex = 0;
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.Exitbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exitbtn.FlatAppearance.BorderSize = 0;
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbtn.Font = new System.Drawing.Font("Rockwell Nova", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< Updated upstream
            this.Exitbtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Exitbtn.Location = new System.Drawing.Point(0, 447);
=======
            this.Exitbtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.Exitbtn.Location = new System.Drawing.Point(0, 446);
>>>>>>> Stashed changes
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Exitbtn.Size = new System.Drawing.Size(217, 60);
            this.Exitbtn.TabIndex = 6;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // GenerateSummarybtn
            // 
            this.GenerateSummarybtn.BackColor = System.Drawing.Color.DarkCyan;
            this.GenerateSummarybtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.GenerateSummarybtn.FlatAppearance.BorderSize = 0;
            this.GenerateSummarybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< Updated upstream
            this.GenerateSummarybtn.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Bold);
            this.GenerateSummarybtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.GenerateSummarybtn.Location = new System.Drawing.Point(0, 390);
            this.GenerateSummarybtn.Name = "GenerateSummarybtn";
            this.GenerateSummarybtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.GenerateSummarybtn.Size = new System.Drawing.Size(217, 57);
=======
            this.GenerateSummarybtn.Font = new System.Drawing.Font("Rockwell Nova", 8.2F, System.Drawing.FontStyle.Bold);
            this.GenerateSummarybtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.GenerateSummarybtn.Location = new System.Drawing.Point(0, 390);
            this.GenerateSummarybtn.Name = "GenerateSummarybtn";
            this.GenerateSummarybtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.GenerateSummarybtn.Size = new System.Drawing.Size(217, 56);
>>>>>>> Stashed changes
            this.GenerateSummarybtn.TabIndex = 5;
            this.GenerateSummarybtn.Text = "Generate Summary";
            this.GenerateSummarybtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenerateSummarybtn.UseVisualStyleBackColor = false;
            this.GenerateSummarybtn.Click += new System.EventHandler(this.GenerateSummarybtn_Click);
            // 
            // panelMediaSubmenu
            // 
            this.panelMediaSubmenu.Controls.Add(this.DeleteStudentNavbtn);
            this.panelMediaSubmenu.Controls.Add(this.UpdateDetailsNavbtn);
            this.panelMediaSubmenu.Controls.Add(this.ViewStudentsNavbtn);
            this.panelMediaSubmenu.Controls.Add(this.AddStudentNavbtn);
            this.panelMediaSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaSubmenu.Location = new System.Drawing.Point(0, 174);
            this.panelMediaSubmenu.Name = "panelMediaSubmenu";
            this.panelMediaSubmenu.Size = new System.Drawing.Size(217, 216);
            this.panelMediaSubmenu.TabIndex = 1;
            // 
            // DeleteStudentNavbtn
            // 
            this.DeleteStudentNavbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.DeleteStudentNavbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteStudentNavbtn.FlatAppearance.BorderSize = 0;
            this.DeleteStudentNavbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< Updated upstream
            this.DeleteStudentNavbtn.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Bold);
            this.DeleteStudentNavbtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.DeleteStudentNavbtn.Location = new System.Drawing.Point(0, 161);
            this.DeleteStudentNavbtn.Name = "DeleteStudentNavbtn";
            this.DeleteStudentNavbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.DeleteStudentNavbtn.Size = new System.Drawing.Size(217, 55);
=======
            this.DeleteStudentNavbtn.Font = new System.Drawing.Font("Rockwell Nova", 8.2F, System.Drawing.FontStyle.Bold);
            this.DeleteStudentNavbtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.DeleteStudentNavbtn.Location = new System.Drawing.Point(0, 159);
            this.DeleteStudentNavbtn.Name = "DeleteStudentNavbtn";
            this.DeleteStudentNavbtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.DeleteStudentNavbtn.Size = new System.Drawing.Size(217, 72);
>>>>>>> Stashed changes
            this.DeleteStudentNavbtn.TabIndex = 4;
            this.DeleteStudentNavbtn.Text = "Delete Student";
            this.DeleteStudentNavbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteStudentNavbtn.UseVisualStyleBackColor = false;
            this.DeleteStudentNavbtn.Click += new System.EventHandler(this.DeleteStudentNavbtn_Click);
            // 
            // UpdateDetailsNavbtn
            // 
            this.UpdateDetailsNavbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.UpdateDetailsNavbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateDetailsNavbtn.FlatAppearance.BorderSize = 0;
            this.UpdateDetailsNavbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< Updated upstream
            this.UpdateDetailsNavbtn.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Bold);
            this.UpdateDetailsNavbtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.UpdateDetailsNavbtn.Location = new System.Drawing.Point(0, 104);
            this.UpdateDetailsNavbtn.Name = "UpdateDetailsNavbtn";
            this.UpdateDetailsNavbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.UpdateDetailsNavbtn.Size = new System.Drawing.Size(217, 57);
=======
            this.UpdateDetailsNavbtn.Font = new System.Drawing.Font("Rockwell Nova", 8.2F, System.Drawing.FontStyle.Bold);
            this.UpdateDetailsNavbtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.UpdateDetailsNavbtn.Location = new System.Drawing.Point(0, 104);
            this.UpdateDetailsNavbtn.Name = "UpdateDetailsNavbtn";
            this.UpdateDetailsNavbtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.UpdateDetailsNavbtn.Size = new System.Drawing.Size(217, 55);
>>>>>>> Stashed changes
            this.UpdateDetailsNavbtn.TabIndex = 3;
            this.UpdateDetailsNavbtn.Text = "Update Details";
            this.UpdateDetailsNavbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateDetailsNavbtn.UseVisualStyleBackColor = false;
            this.UpdateDetailsNavbtn.Click += new System.EventHandler(this.UpdateDetailsNavbtn_Click);
            // 
            // ViewStudentsNavbtn
            // 
            this.ViewStudentsNavbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.ViewStudentsNavbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewStudentsNavbtn.FlatAppearance.BorderSize = 0;
            this.ViewStudentsNavbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< Updated upstream
            this.ViewStudentsNavbtn.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Bold);
            this.ViewStudentsNavbtn.ForeColor = System.Drawing.SystemColors.MenuText;
=======
            this.ViewStudentsNavbtn.Font = new System.Drawing.Font("Rockwell Nova", 8.2F, System.Drawing.FontStyle.Bold);
            this.ViewStudentsNavbtn.ForeColor = System.Drawing.SystemColors.Menu;
>>>>>>> Stashed changes
            this.ViewStudentsNavbtn.Location = new System.Drawing.Point(0, 51);
            this.ViewStudentsNavbtn.Name = "ViewStudentsNavbtn";
            this.ViewStudentsNavbtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.ViewStudentsNavbtn.Size = new System.Drawing.Size(217, 53);
            this.ViewStudentsNavbtn.TabIndex = 2;
            this.ViewStudentsNavbtn.Text = "View Students";
            this.ViewStudentsNavbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewStudentsNavbtn.UseVisualStyleBackColor = false;
            this.ViewStudentsNavbtn.Click += new System.EventHandler(this.ViewStudentsNavbtn_Click);
            // 
            // AddStudentNavbtn
            // 
            this.AddStudentNavbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.AddStudentNavbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddStudentNavbtn.FlatAppearance.BorderSize = 0;
            this.AddStudentNavbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< Updated upstream
            this.AddStudentNavbtn.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentNavbtn.ForeColor = System.Drawing.SystemColors.MenuText;
=======
            this.AddStudentNavbtn.Font = new System.Drawing.Font("Rockwell Nova", 8.2F, System.Drawing.FontStyle.Bold);
            this.AddStudentNavbtn.ForeColor = System.Drawing.SystemColors.Menu;
>>>>>>> Stashed changes
            this.AddStudentNavbtn.Location = new System.Drawing.Point(0, 0);
            this.AddStudentNavbtn.Name = "AddStudentNavbtn";
            this.AddStudentNavbtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.AddStudentNavbtn.Size = new System.Drawing.Size(217, 51);
            this.AddStudentNavbtn.TabIndex = 1;
            this.AddStudentNavbtn.Text = "Add Student";
            this.AddStudentNavbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStudentNavbtn.UseVisualStyleBackColor = false;
            this.AddStudentNavbtn.Click += new System.EventHandler(this.AddStudentNavbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.btnOptions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 174);
            this.panel2.TabIndex = 0;
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.DarkCyan;
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Rockwell Nova", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnOptions.Location = new System.Drawing.Point(0, 116);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOptions.Size = new System.Drawing.Size(217, 58);
            this.btnOptions.TabIndex = 0;
            this.btnOptions.Text = "Media";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.UseVisualStyleBackColor = false;

            // 
            // DisplayInfoPanel
            // 
            this.DisplayInfoPanel.BackColor = System.Drawing.Color.White;
            this.DisplayInfoPanel.Controls.Add(this.pictureBox2);
            this.DisplayInfoPanel.Controls.Add(this.pictureBox1);
            this.DisplayInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayInfoPanel.Location = new System.Drawing.Point(217, 0);
            this.DisplayInfoPanel.Name = "DisplayInfoPanel";
            this.DisplayInfoPanel.Size = new System.Drawing.Size(714, 580);
            this.DisplayInfoPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 231);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(521, 408);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 169);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(931, 580);
            this.Controls.Add(this.DisplayInfoPanel);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Home Page";
            this.panelSideMenu.ResumeLayout(false);
            this.panelMediaSubmenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.DisplayInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Panel panelMediaSubmenu;
        private System.Windows.Forms.Button UpdateDetailsNavbtn;
        private System.Windows.Forms.Button ViewStudentsNavbtn;
        private System.Windows.Forms.Button AddStudentNavbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteStudentNavbtn;
        private System.Windows.Forms.Button GenerateSummarybtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Panel DisplayInfoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

