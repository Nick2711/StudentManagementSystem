using System;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PRG_282_Project
{
    public partial class Update : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string GitHubApiUrl = "https://api.github.com/repos/Nick2711/StudentManagementSystem/contents/PRG_282_Project/Students.txt";
        private string[] lines;
        private int studentIndex = -1;

        public Update()
        {
            InitializeComponent();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            await DisplayData();
        }

        private async void Searchbtn_Click(object sender, EventArgs e)
        {
            string searchID = SearchStudentID.Text;

            if (string.IsNullOrWhiteSpace(searchID))
            {
                MessageBox.Show("Please enter a Student ID to search.");
                return;
            }

            string fileContent = await client.GetStringAsync("https://raw.githubusercontent.com/Nick2711/StudentManagementSystem/main/PRG_282_Project/Students.txt");
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
                    string newCourseInput = Prompt.ShowDialog("Enter new Course ID:\n1. Bacholars of Computing\n2. Diploma of Computing\n3. Bacholars of Information systems", "Update Course", studentData[3]);

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
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Environment.GetEnvironmentVariable("GITHUB_TOKEN"));
            client.DefaultRequestHeaders.UserAgent.ParseAdd("MyApp");

            HttpResponseMessage response = await client.GetAsync(GitHubApiUrl);
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
                string updatedContent = string.Join(Environment.NewLine, lines);
                string base64Content = Convert.ToBase64String(Encoding.UTF8.GetBytes(updatedContent));

                var payload = new
                {
                    message = "Updated student information",
                    content = base64Content,
                    sha = await GetFileSha()
                };

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Environment.GetEnvironmentVariable("GITHUB_TOKEN"));
                client.DefaultRequestHeaders.UserAgent.ParseAdd("MyApp");

                var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var response = await client.PutAsync(GitHubApiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Student information updated successfully.");
                    await DisplayData();
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

        private async Task DisplayData()
        {
            try
            {
                string fileContent = await client.GetStringAsync("https://raw.githubusercontent.com/Nick2711/StudentManagementSystem/main/PRG_282_Project/Students.txt");
                lines = fileContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("StudentID", "Student ID");
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Age", "Age");
                dataGridView1.Columns.Add("Course", "Course");

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

        private void SearchStudentID_MouseClick(object sender, MouseEventArgs e)
        {
            SearchStudentID.Clear();
        }

        private void SearchStudentID_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(SearchStudentID.Text, @"^\d{4}$"))
            {
                MessageBox.Show("Please enter a 4-digit number.");
            }
        }
    }

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
