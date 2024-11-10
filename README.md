# StudentManagementSystem
Programming Project 

The Student Management System would allow users to add, update, delete,  view all existing students in the text file, and summerise the student details by giving the average age and total number of students. This system proves to be beneficial for lectures in which they can identify new students participating with their individual courses, or to just keep track of all existing students, leaving or joining. Being able to delete, update or add, needs to be documented thoroughly as any mistake could lead to errors or misinformation inside the individual courses. That is why all data is saved inside a textfile name 'student.txt', which saves new students, removes deleted students, as well as the updated students' information.


Front-end/FORMS:


1# Homepage:
This project contains C# Microsoft forms, which was used to create a presentation layer for users to access. There were a total of 6 forms created, every form holding its own individual unique purpose. The first form, 'Homepage', is displayed immediately, giving various options for the user to select from.

2# AddStudent:
The second form, contains the ability to add a student, prompting the user to input their own 'StudentID', 'Name', 'Age', 'Course', all of which are TextBoxes.

3# ViewStudents:
Third form, allows the user to view all the students, displaying their studentID, name, age and their enrolled course.

4# Update:
This form gives the user access to update any of the 4 inputted values in form 2#.

5# Delete:
Allows the user to delete a student by searching for a existing StudentID in the 'student.txt' textfile.

6# Summary:
This form generates a summary of all students enrolled and the average age between all the students.



Back-end/Form:

1# Homepage:

Contains buttons for navigation purposes. The 'DisplayInfoMid' method is supplemented to embed a form 'childForm' into a panel ('DisplayInfoMid') in main form so it is seamless. It checks if there are an active form and if not, the new form is made active. Then it removes the borders, resizes the form to fit the full panel, and then includes it on the panel control of the panel, to be the current display.

2# AddStudent:

This code creates a form to add students to a GitHub-hosted text file. It lauches an HTT{ client and uses GitHUbs's API to retieve the file's contents, update it with a  new student's informatio, and submit the changes back. Form fields guarantee that all necessary information before submission.

3# ViewStudents:

This method, triggered by the 'DisplayStudentsbtn_Click' event, clears and configures columns in a data grid before retrieving a student data file from a URL. It divides each line into fields and populates rows with values such as "Student ID", "Name", "Age" and "Course".

4# Update:

This code allows you to update student data saved in a GitHub file. When the form loads, 'DisplayData' retrieves and displays the student records. Clicking "Search" retrieves a student by ID and allows for modifications. "Update" saves these modifications to GitHub. 'GetFileSha' returns the file's SHA for updating.

5# Delete:

This code allows you to delete student records saved on GitHub. It inserts data into a DataGridView, gets the file SHA for changes, then encrypts the changed content after deletion. It uses HttpClient to securely retrieve, display, and update student data via authorised API calls on GitHub.

6# Summary:

This code creates a summary report of student data from GitHub, counting students and determining the average age. It shows the summary in a RichTextBox and then saves it to GitHub by encoding it in Base64, getting the file's SHA, and performing an authorised API update.


Validation:

For validation, various checks are done. For example, the search makes sure that the student ID the user is searching for is 4 numbers and not letters. The name too, it makes sure no numbers or symbols are included.


GitHub between users:

Github was a invaluable tool to use, especially between Group members. It was hard at first to figure out but thanks to our collaborative 'sprints' GitHub aided in the furtherance of the project. It created no extra labour as it became our go-to tool.
