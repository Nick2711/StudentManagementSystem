using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_282_Project
{
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }
        private static readonly HttpClient httpClient = new HttpClient();
        private const string StudentsFileUrl = "https://raw.githubusercontent.com/Nick2711/StudentManagementSystem/main/PRG_282_Project/Students.txt";
        private const string SummaryFileApiUrl = "https://api.github.com/repos/Nick2711/StudentManagementSystem/contents/PRG_282_Project/Summary.txt";


            







        private async void GenerateSumbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch the latest student data from GitHub to ensure up-to-date summary calculation
                string studentData = await FetchFileFromGitHub(StudentsFileUrl);
                if (studentData == null)
                {
                    MessageBox.Show("Failed to retrieve student data.");
                    return;
                }

                // Split data into records, count total students, and calculate average age
                var studentRecords = studentData.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                int totalStudents = studentRecords.Length;
                double averageAge = studentRecords
                    .Select(record => record.Split(','))
                    .Where(data => data.Length == 4 && int.TryParse(data[2], out _))
                    .Select(data => int.Parse(data[2]))
                    .Average();

                // Prepare summary text for display
                string summaryText = $"Student Summary Report\n\n" +
                                     $"Total Students: {totalStudents}\n" +
                                     $"Average Age: {averageAge:F2}\n";

                // Clear and update RichTextBox display with the new summary
                summaryRichTextBox.Clear();
                summaryRichTextBox.AppendText(summaryText);

                // Save the latest summary to GitHub
                bool isSaved = await SaveSummaryToGitHub(summaryText);
                if (isSaved)
                {
                    MessageBox.Show("Summary saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private async Task<string> FetchFileFromGitHub(string fileUrl)
        {
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("MyApp");
            HttpResponseMessage response = await httpClient.GetAsync(fileUrl);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return null;
        }

        private async Task<string> GetFileSha()
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Environment.GetEnvironmentVariable("GITHUB_TOKEN"));
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("MyApp");

            HttpResponseMessage response = await httpClient.GetAsync(SummaryFileApiUrl);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                dynamic jsonData = JsonConvert.DeserializeObject(jsonResponse);
                return jsonData.sha;
            }

            return null;
        }

        private async Task<bool> SaveSummaryToGitHub(string content)
        {
            try
            {
                
                string base64Content = Convert.ToBase64String(Encoding.UTF8.GetBytes(content));

                
                string fileSha = await GetFileSha();

                
                var payload = new
                {
                    message = "Update summary report",
                    content = base64Content,
                    sha = fileSha
                };

                
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Environment.GetEnvironmentVariable("GITHUB_TOKEN"));
                httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("MyApp");

                
                var requestContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(SummaryFileApiUrl, requestContent);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the summary: {ex.Message}");
                return false;
            }
        }
    }
}
