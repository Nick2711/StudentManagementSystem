using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.IO;


using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace PRG_282_Project
{
    public partial class AddStudent : Form
    {


      

        

        private static readonly HttpClient client = new HttpClient();
            private const string GitHubApiUrl = "https://api.github.com/repos/Nick2711/StudentManagementSystem/contents/PRG_282_Project/Students.txt";
            private static readonly string GitHubToken = Environment.GetEnvironmentVariable("GITHUB_TOKEN");

        public AddStudent()
            {
                InitializeComponent();
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("MyApp", "1.0")); 
         
        }



            private async void StudentSubmitbtn_Click(object sender, EventArgs e)
            {
                try
                {
                    
                    string studentID = StudentID.Text;
                    string name = Name.Text;
                    string age = Age.Text;
                    string course = CourseBox.SelectedItem?.ToString();

                   
                    if (string.IsNullOrWhiteSpace(studentID) || string.IsNullOrWhiteSpace(name) ||
                        string.IsNullOrWhiteSpace(age) || string.IsNullOrWhiteSpace(course))
                    {
                        MessageBox.Show("Please fill in all fields.");
                        return;
                    }

                   
                    string studentData = $"{studentID},{name},{age},{course}";

                  
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GitHubToken);

                    
                    var existingContentResponse = await client.GetAsync(GitHubApiUrl);
                    existingContentResponse.EnsureSuccessStatusCode();
                    string existingContentJson = await existingContentResponse.Content.ReadAsStringAsync();
                    dynamic existingContentData = JsonConvert.DeserializeObject(existingContentJson);
                    string existingContent = Encoding.UTF8.GetString(Convert.FromBase64String((string)existingContentData.content));
                    string sha = existingContentData.sha;

                   
                    string updatedContent = existingContent + Environment.NewLine + studentData;
                    string base64UpdatedContent = Convert.ToBase64String(Encoding.UTF8.GetBytes(updatedContent));

                    
                    var payload = new
                    {
                        message = "Add new student",
                        content = base64UpdatedContent,
                        sha = sha
                    };

                    
                    var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                    var updateResponse = await client.PutAsync(GitHubApiUrl, content);

                    
                    updateResponse.EnsureSuccessStatusCode();

                    MessageBox.Show("Student added successfully!");

                   
                    StudentID.Clear();
                    Name.Clear();
                    Age.Clear();
                    CourseBox.SelectedIndex = -1;
                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show($"HTTP error: {httpEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        

        private void AddStudent_Load(object sender, EventArgs e)
        {
            
            CourseBox.Items.Add("Bacholars of Computing");
            CourseBox.Items.Add("Diploma of Computing");
            CourseBox.Items.Add("Bacholars of Information systems");
        }

        private void StudentID_TextChanged(object sender, EventArgs e)
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

        private void Name_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(Name.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Please make sure there is no numbers or '@' symbols when entering your name");

            }
        }
    }
}
