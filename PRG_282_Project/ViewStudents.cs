using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PRG_282_Project
{
    public partial class ViewStudents : Form
    {
        string filename = @"C:\Belgium Campus\PRG282_Project\StudentManagementSystem\PRG_282_Project\PRG282.txt";

        public ViewStudents()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void ViewStudents_Load(object sender, EventArgs e)
        {

        }
        private void DisplayStudentsbtn_Click(object sender, EventArgs e)
        {
            try
            {

                // Clear existing rows and columns in DataGridView
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Define columns if they haven't been defined already
                dataGridView1.Columns.Add("StudentID", "Student ID");
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Age", "Age");
                dataGridView1.Columns.Add("Course", "Course");

                // Open the file and read all lines
                string[] lines = File.ReadAllLines(filename);

                // Loop through each line in the file
                foreach (string line in lines)
                {
                    // Split each line by comma
                    string[] studentData = line.Split(',');

                    // Check if the line has the correct number of fields
                    if (studentData.Length == 4) // Adjust based on the expected number of fields
                    {
                        // Add the parsed data as a row in the DataGridView
                        dataGridView1.Rows.Add(studentData);
                    }
                    else
                    {
                        MessageBox.Show("Some data may be missing or incorrectly formatted in the file.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}");
            }
        }
    }

}
