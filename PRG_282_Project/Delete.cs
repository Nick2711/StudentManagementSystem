using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.LinkLabel;

namespace PRG_282_Project
{
    public partial class DeleteForm : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private const string GitHubApiUrl = "https://api.github.com/repos/Nick2711/StudentManagementSystem/contents/PRG_282_Project/Students.txt";
        private string[] studentRecords;
        private int selectedStudentIndex = -1;

        public DeleteForm()
        {
            InitializeComponent();
        }

        private async Task<string> FetchStudentDataFromGitHub()
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Environment.GetEnvironmentVariable("GITHUB_TOKEN"));
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("MyApp");

            HttpResponseMessage response = await httpClient.GetAsync(GitHubApiUrl);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                dynamic jsonData = JsonConvert.DeserializeObject(jsonResponse);
                return Encoding.UTF8.GetString(Convert.FromBase64String((string)jsonData.content));
            }

            MessageBox.Show("Failed to retrieve file content from GitHub.");
            return null;
        }

        private async Task<string> FetchFileSha()
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Environment.GetEnvironmentVariable("GITHUB_TOKEN"));
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("MyApp");

            HttpResponseMessage response = await httpClient.GetAsync(GitHubApiUrl);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                dynamic jsonData = JsonConvert.DeserializeObject(jsonResponse);
                return jsonData.sha;
            }

            throw new Exception("Failed to fetch file SHA.");
        }

        private async Task<bool> UpdateStudentDataOnGitHub(string content)
        {
            try
            {
                
                string base64Content = Convert.ToBase64String(Encoding.UTF8.GetBytes(content));

               
                var payload = new
                {
                    message = "Delete student record",
                    content = base64Content,
                    sha = await FetchFileSha()
                };

                
                var requestContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(GitHubApiUrl, requestContent);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error updating data: {response.ReasonPhrase}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the file: {ex.Message}");
                return false;
            }
        }

        private async void LoadStudentData()
        {
            try
            {
                string fileContent = await FetchStudentDataFromGitHub();
                if (fileContent == null) return;

                studentRecords = fileContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                studentDataGridView.Rows.Clear();
                studentDataGridView.Columns.Clear();
                studentDataGridView.Columns.Add("StudentID", "Student ID");
                studentDataGridView.Columns.Add("Name", "Name");
                studentDataGridView.Columns.Add("Age", "Age");
                studentDataGridView.Columns.Add("Course", "Course");

                
                foreach (string line in studentRecords)
                {
                    string[] studentData = line.Split(',');
                    if (studentData.Length == 4)
                    {
                        studentDataGridView.Rows.Add(studentData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}");
            }
        }

      
     
        

        private async void SearchStudentIDTextBox_Click(object sender, EventArgs e)
        {
            string searchID = textBox1.Text;

            if (string.IsNullOrWhiteSpace(searchID))
            {
                MessageBox.Show("Please enter a Student ID to search.");
                return;
            }

            
            string url = "https://raw.githubusercontent.com/Nick2711/StudentManagementSystem/main/PRG_282_Project/PRG282.txt";
            string fileContent = await httpClient.GetStringAsync(url);
            studentRecords = fileContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            selectedStudentIndex = -1;

            for (int i = 0; i < studentRecords.Length; i++)
            {
                string[] studentData = studentRecords[i].Split(',');

                if (studentData[0] == searchID)
                {
                    selectedStudentIndex = i;
                    studentDataGridView.Rows.Add(studentData); 
                    MessageBox.Show("Student found. You can delete this student by clicking the Delete button.");
                    return;
                }
            }

            if (selectedStudentIndex == -1)
            {
                MessageBox.Show("Student ID not found.");
            }
        }

        private async void Deletebtn_Click(object sender, EventArgs e)
        {
            if (selectedStudentIndex == -1)
            {
                MessageBox.Show("Please search for a student to delete.");
                return;
            }

           
            var confirmResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
               
                studentRecords = studentRecords.Where((line, index) => index != selectedStudentIndex).ToArray();
                string updatedContent = string.Join(Environment.NewLine, studentRecords);

                
                bool success = await UpdateStudentDataOnGitHub(updatedContent);
                if (success)
                {
                    MessageBox.Show("Student deleted successfully.");
                    selectedStudentIndex = -1;
                    LoadStudentData(); 
                }
            }
        }

        private void DeleteForm_Load_1(object sender, EventArgs e)
        {
            LoadStudentData();
        }
    }
}
