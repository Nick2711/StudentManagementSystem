using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< Updated upstream
=======
using Newtonsoft.Json;
using System.Text.RegularExpressions;
>>>>>>> Stashed changes

namespace PRG_282_Project
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

<<<<<<< Updated upstream
=======
        private void StudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentID_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(StudentID.Text, @"^\d{4}$"))
            {
                MessageBox.Show("Please enter a 4 digit number for your Student ID");
            }
        }
>>>>>>> Stashed changes

        private void Name_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(Name.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Please make sure there is no numbers or '@' symbols when entering your name");
              
            }
           
        }
    }
}
