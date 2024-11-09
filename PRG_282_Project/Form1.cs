using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_282_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //CustomiseDesing();
        }

        //private void CustomiseDesing()
        //{
        //    panelSideMenu.Visible = false;
        //    panel2.Visible = false;
        //}

        //private void HideSubMenu()
        //{
        //    if (panelSideMenu.Visible == true)
        //        panelSideMenu.Visible = false;

        //    if (panel2.Visible == true)
        //        panel2.Visible = false;

        //}

        //private void ShowSubMenu(Panel submenu)
        //{
        //    if (submenu.Visible == false)
        //    {
        //        HideSubMenu();
        //        submenu.Visible = true;
        //    }
        //    else
        //    {
        //        submenu.Visible = false;

        //    }
        //}

  

        private Form activeForm = null;
        private void DisplayInfoMid(Form childForm) 
        {
            if (activeForm == null) 
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            DisplayInfoPanel.Controls.Add(childForm);
            DisplayInfoPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStudentNavbtn_Click(object sender, EventArgs e)
        {
            DisplayInfoMid(new AddStudent());
        }


        private void ViewStudentsNavbtn_Click(object sender, EventArgs e)
        {
            DisplayInfoMid(new ViewStudents());



          

         


           

        private void ViewStudentsNavbtn_Click(object sender, EventArgs e)
        {
            DisplayInfoMid(new ViewStudents());






        }

        private void UpdateDetailsNavbtn_Click(object sender, EventArgs e)
        {
            DisplayInfoMid(new Form2());
        }

        private void DeleteStudentNavbtn_Click(object sender, EventArgs e)
        {
            DisplayInfoMid(new Delete());
        }

        private void GenerateSummarybtn_Click(object sender, EventArgs e)
        {
            DisplayInfoMid(new Summary());
        }
    }
}
