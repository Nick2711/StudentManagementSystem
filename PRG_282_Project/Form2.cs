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
    public partial class Form2 : Form
    {
        string filePath = @"C:\Belgium Campus\PRG282_Project\StudentManagementSystem\PRG_282_Project\PRG282.txt";
        string[] lines;
        int studentIndex = -1;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DisplayData(); // Display the data when the form loads
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string searchID = SearchStudentID.Text;

            if (string.IsNullOrWhiteSpace(searchID))
            {
                MessageBox.Show("Please enter a Student ID to search.");
                return;
            }

            lines = File.ReadAllLines(filePath);
            studentIndex = -1;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] studentData = lines[i].Split(',');

                if (studentData[0] == searchID)
                {
                    studentIndex = i;

                    string newName = Prompt.ShowDialog("Enter new Name:", "Update Name", studentData[1]);
                    string newAge = Prompt.ShowDialog("Enter new Age:", "Update Age", studentData[2]);

                    string[] courses = { "Bacholars of Computing", "Diploma of Computing", "Bacholars of Information systems" };
                    string coursePrompt = "Enter new Course ID:\n1. Bacholars of Computing\n2. Diploma of Computing\n3. Bacholars of Information systems";
                    string newCourseInput = Prompt.ShowDialog(coursePrompt, "Update Course", studentData[3]);

                    string newCourse;
                    if (newCourseInput == "1")
                    {
                        newCourse = courses[0];
                    }
                    else if (newCourseInput == "2")
                    {
                        newCourse = courses[1];
                    }
                    else if (newCourseInput == "3")
                    {
                        newCourse = courses[2];
                    }
                    else
                    {
                        newCourse = studentData[3];  // Keep original course if input is invalid
                    }

                    lines[studentIndex] = $"{studentData[0]},{newName},{newAge},{newCourse}";
                    MessageBox.Show("Information ready to be updated. Press 'Update' to save changes.");
                    break;
                }
            }

            if (studentIndex == -1)
            {
                MessageBox.Show("Student ID not found.");
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (studentIndex == -1)
            {
                MessageBox.Show("Please search for a student ID first.");
                return;
            }

            try
            {
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Student information updated successfully.");
                DisplayData(); // Refresh the DataGridView with updated data
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the file: {ex.Message}");
            }
        }

        // Method to display data in DataGridView
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

    // Helper class for creating input dialogs
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string defaultValue = "")
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 10, Top = 20, Text = text };
            TextBox inputBox = new TextBox() { Left = 10, Top = 50, Width = 260, Text = defaultValue };
            Button confirmation = new Button() { Text = "Ok", Left = 200, Width = 70, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : defaultValue;
        }
    }
}
