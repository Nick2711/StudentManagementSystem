using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_282_Project
{
    public partial class ViewStudents : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public ViewStudents()
        {
            InitializeComponent();
        }

        private async void DisplayStudentsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string url = $"https://raw.githubusercontent.com/Nick2711/StudentManagementSystem/main/PRG_282_Project/Students.txt?{DateTime.Now.Ticks}";

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
    }
}
