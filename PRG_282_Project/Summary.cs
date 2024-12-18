﻿using Newtonsoft.Json;
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
                string studentData = await FetchFileFromGitHub(StudentsFileUrl);
                if (studentData == null)
                {
                    MessageBox.Show("Failed to retrieve student data.");
                    return;
                }

                var studentRecords = studentData.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(record => record.Split(','))
                                                .Where(data => data.Length == 4 && int.TryParse(data[2], out _))
                                                .Select(data => new
                                                {
                                                    Id = data[0],
                                                    Name = data[1],
                                                    Age = int.Parse(data[2]),
                                                    Course = data[3]
                                                })
                                                .ToList();

                if (!studentRecords.Any())
                {
                    MessageBox.Show("No valid student data found.");
                    return;
                }

                int totalStudents = studentRecords.Count;
                double averageAge = studentRecords.Average(s => s.Age);
                int youngestAge = studentRecords.Min(s => s.Age);
                int oldestAge = studentRecords.Max(s => s.Age);

                var averageAgeByCourse = studentRecords
                    .GroupBy(s => s.Course)
                    .Select(group => new { Course = group.Key, AverageAge = group.Average(s => s.Age) })
                    .ToList();

                StringBuilder summaryText = new StringBuilder();
                summaryText.AppendLine("🌟 Student Summary Report 🌟\n");
                summaryText.AppendLine($"Total Students: {totalStudents}");
                summaryText.AppendLine($"Average Age: {averageAge:F2}");
                summaryText.AppendLine($"Youngest Student Age: {youngestAge}");
                summaryText.AppendLine($"Oldest Student Age: {oldestAge}\n");

                summaryText.AppendLine("📘 Average Age by Course:");
                foreach (var course in averageAgeByCourse)
                {
                    summaryText.AppendLine($"- {course.Course}: {course.AverageAge:F2} years");
                }

                summaryRichTextBox.Clear();
                summaryRichTextBox.SelectionFont = new Font("Arial", 14, FontStyle.Bold);
                summaryRichTextBox.SelectionColor = Color.DarkBlue;
                summaryRichTextBox.AppendText("🌟 Student Summary Report 🌟\n\n");

                summaryRichTextBox.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                summaryRichTextBox.SelectionColor = Color.Black;
                summaryRichTextBox.AppendText($"Total Students: {totalStudents}\n");
                summaryRichTextBox.AppendText($"Average Age: {averageAge:F2}\n");
                summaryRichTextBox.AppendText($"Youngest Student Age: {youngestAge}\n");
                summaryRichTextBox.AppendText($"Oldest Student Age: {oldestAge}\n\n");

                summaryRichTextBox.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                summaryRichTextBox.SelectionColor = Color.DarkGreen;
                summaryRichTextBox.AppendText("📘 Average Age by Course:\n");

                summaryRichTextBox.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                summaryRichTextBox.SelectionColor = Color.Black;
                foreach (var course in averageAgeByCourse)
                {
                    summaryRichTextBox.AppendText($"- {course.Course}: {course.AverageAge:F2} years\n");
                }

                bool isSaved = await SaveSummaryToGitHub(summaryText.ToString());
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
