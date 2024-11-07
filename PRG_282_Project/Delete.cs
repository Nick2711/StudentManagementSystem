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
    public partial class Delete : Form
    {

        string filePath = @"C:\Belgium Campus\PRG282_Project\StudentManagementSystem\PRG_282_Project\PRG282.txt";
        string[] lines;
        int studentIndex = -1;


        public Delete()
        {
            InitializeComponent();
        }


        private void Delete_Load(object sender, EventArgs e)
        {
            DisplayData(); // Load and display data when the form loads
        }

        private void button1_Click(object sender, EventArgs e) // Search Button
        {
            string searchID = textBox1.Text;

            if (string.IsNullOrWhiteSpace(searchID))
            {
                MessageBox.Show("Please enter a Student ID to search.");
                return;
            }

            lines = File.ReadAllLines(filePath);
            studentIndex = -1;

            // Clear DataGridView before displaying the search result
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("StudentID", "Student ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Age", "Age");
            dataGridView1.Columns.Add("Course", "Course");

            // Loop through each line to find the matching student ID
            for (int i = 0; i < lines.Length; i++)
            {
                string[] studentData = lines[i].Split(',');

                if (studentData[0] == searchID)
                {
                    studentIndex = i;
                    dataGridView1.Rows.Add(studentData); // Display found student
                    MessageBox.Show("Student found. You can delete this student if desired.");
                    return;
                }
            }

            if (studentIndex == -1)
            {
                MessageBox.Show("Student ID not found.");
            }
        }

        private void button2_Click(object sender, EventArgs e) // View All Students Button
        {
            DisplayData(); // Display all students
        }

        private void Deletebtn_Click(object sender, EventArgs e) // Delete Button
        {
            if (studentIndex == -1)
            {
                MessageBox.Show("Please search for a student to delete.");
                return;
            }

            // Ask for confirmation before deletion
            var confirmResult = MessageBox.Show("Are you sure you want to delete this student?",
                                                 "Confirm Deletion",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Remove the student from the lines array
                lines = lines.Where((line, index) => index != studentIndex).ToArray();
                File.WriteAllLines(filePath, lines); // Update the file
                MessageBox.Show("Student deleted successfully.");

                // Reset the search index and refresh the DataGridView
                studentIndex = -1;
                DisplayData(); // Refresh data to show all records after deletion
            }
        }

        // Method to display all data in DataGridView
        private void DisplayData()
        {
            // Clear existing rows and columns
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Define columns
            dataGridView1.Columns.Add("StudentID", "Student ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Age", "Age");
            dataGridView1.Columns.Add("Course", "Course");

            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Loop through each line and add it to the DataGridView
            foreach (string line in lines)
            {
                string[] studentData = line.Split(',');

                // Ensure the line has the correct number of fields
                if (studentData.Length == 4)
                {
                    dataGridView1.Rows.Add(studentData);
                }
                else
                {
                    MessageBox.Show("Some data may be missing or incorrectly formatted in the file.");
                }
            }
        }
    }
}



    }
}

