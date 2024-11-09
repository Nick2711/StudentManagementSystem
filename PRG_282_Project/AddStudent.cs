using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.IO;


using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_282_Project
{
    public partial class AddStudent : Form
    {


        string filename = @"C:\Belgium Campus\PRG282_Project\StudentManagementSystem\PRG_282_Project\PRG282.txt";

        public AddStudent()
        {
            // Add items to CourseBox ComboBox
        
            InitializeComponent();
        }
        private void StudentSubmitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Capture data from input fields
                string studentID = StudentID.Text;
                string name = Name.Text;
                string age = Age.Text;
                string course = CourseBox.SelectedItem?.ToString();

                // Validate inputs
                if (string.IsNullOrWhiteSpace(studentID) || string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(age) || string.IsNullOrWhiteSpace(course))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Format data as a comma-separated line
                string studentData = $"{studentID},{name},{age},{course}";

                // Append the formatted data to the text file
                using (StreamWriter writer = new StreamWriter(filename, true))
                {
                    writer.WriteLine(studentData);
                }

                MessageBox.Show("Student added successfully!");

                // Clear input fields after submission
                StudentID.Clear();
                Name.Clear();
                Age.Clear();
                CourseBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            // Add items to CourseBox ComboBox
            CourseBox.Items.Add("Bacholars of Computing");
            CourseBox.Items.Add("Diploma of Computing");
            CourseBox.Items.Add("Bacholars of Information systems");
        }

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
      


        //public AddStudent()
        //{
        //    InitializeComponent();
        //}

        public AddStudent()
        {
            InitializeComponent();
        }




    }
}
