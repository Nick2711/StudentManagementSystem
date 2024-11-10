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
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;



namespace PRG_282_Project
{
    public partial class Form2 : Form
    {

        //string filePath = @"C:\Belgium Campus\PRG282_Project\StudentManagementSystem\PRG_282_Project\PRG282.txt";
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

        private async void Searchbtn_Click(object sender, EventArgs e)
        {
            string searchID = SearchStudentID.Text;

            if (string.IsNullOrWhiteSpace(searchID))
            {
                MessageBox.Show("Please enter a Student ID to search.");
                return;
            }

            // Fetch data from GitHub
            string url = "https://raw.githubusercontent.com/Nick2711/StudentManagementSystem/main/PRG_282_Project/Students.txt";
            string fileContent = await client.GetStringAsync(url);
            lines = fileContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

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

                    string newCourse = studentData[3];
                    if (newCourseInput == "1") newCourse = courses[0];
                    else if (newCourseInput == "2") newCourse = courses[1];
                    else if (newCourseInput == "3") newCourse = courses[2];

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


        private async Task<string> GetFileSha()
        {
            string shaUrl = "https://api.github.com/repos/Nick2711/StudentManagementSystem/contents/PRG_282_Project/Students.txt";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Environment.GetEnvironmentVariable("GITHUB_TOKEN"));
            client.DefaultRequestHeaders.UserAgent.ParseAdd("MyApp");

            HttpResponseMessage response = await client.GetAsync(shaUrl);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                dynamic jsonData = JsonConvert.DeserializeObject(jsonResponse);
                return jsonData.sha;
            }
            throw new Exception("Failed to fetch file SHA.");
        }

        private async void Updatebtn_Click(object sender, EventArgs e)
        {
            if (studentIndex == -1)
            {
                MessageBox.Show("Please search for a student ID first.");
                return;
            }

            try
            {
                // Encode updated content in Base64
                string updatedContent = string.Join(Environment.NewLine, lines);
                string base64Content = Convert.ToBase64String(Encoding.UTF8.GetBytes(updatedContent));

                // Prepare the GitHub API payload
                var payload = new
                {
                    message = "Updated student information",
                    content = base64Content,
                    sha = await GetFileSha()
                };

                // Set up the request
                string apiUrl = "https://api.github.com/repos/Nick2711/StudentManagementSystem/contents/PRG_282_Project/Students.txt";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Environment.GetEnvironmentVariable("GITHUB_TOKEN"));
                client.DefaultRequestHeaders.UserAgent.ParseAdd("MyApp");

                // Send PUT request to update file on GitHub
                var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var response = await client.PutAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Student information updated successfully on GitHub.");
                    DisplayData(); // Refresh the DataGridView with updated data
                }
                else
                {
                    MessageBox.Show($"Error updating data: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the file: {ex.Message}");
            }
        }




        // Method to display data in DataGridView

        private static readonly HttpClient client = new HttpClient(); 
        private async void DisplayData()
        {
            try
            {

                string url = "https://raw.githubusercontent.com/Nick2711/StudentManagementSystem/refs/heads/main/PRG_282_Project/Students.txt";





                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();


                dataGridView1.Columns.Add("StudentID", "Student ID");
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Age", "Age");
                dataGridView1.Columns.Add("Course", "Course");



                string fileContent = await client.GetStringAsync(url);


                string[] lines = fileContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);


                foreach (string line in lines)
                {

                    string[] studentData = line.Split(',');


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

            catch (HttpRequestException ex)
            {
                MessageBox.Show($"An error occurred while fetching the file: {ex.Message}");
            }


            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}");
            }
        }
        //For removing the text if the user searches for an ID
        private void SearchStudentID_MouseClick(object sender, MouseEventArgs e)
        {
            SearchStudentID.Clear();
        }

        private void SearchStudentID_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(SearchStudentID.Text, @"^\d{4}$"))
            {
                MessageBox.Show("Please enter a 4 digit number");
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
