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






namespace PRG_282_Project
{
    public partial class ViewStudents : Form
    {
      



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

      


        private static readonly HttpClient client = new HttpClient();

        private async void DisplayStudentsbtn_Click(object sender, EventArgs e)
        {
            try
            {
              
                string url = "https://raw.githubusercontent.com/Nick2711/StudentManagementSystem/refs/heads/main/PRG_282_Project/PRG282.txt";

                
       

              
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();


                dataGridView1.Columns.Add("StudentID", "Student ID");
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Age", "Age");
                dataGridView1.Columns.Add("Course", "Course");


               
                string fileContent = await client.GetStringAsync(url);

               
                string[] lines = fileContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

               
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






