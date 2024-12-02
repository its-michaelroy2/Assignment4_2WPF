using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment4_2_LMS
{
    /// <summary>
    /// Interaction logic for TeacherDashboard.xaml
    /// </summary>
    public partial class TeacherDashboard : Window
    {
        private List<Student> students = new List<Student>();
        public TeacherDashboard()
        {
            InitializeComponent();
            dataGridStudents.ItemsSource = students;
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtGPA.Text, out double gpa))
            {
                Student newStudent = new Student
                {
                    StudentId = txtStudentId.Text,
                    Name = txtStudentName.Text,
                    GPA = gpa
                };

                students.Add(newStudent);
                UpdateDataGrid();
            }
            else
            {
                MessageBox.Show("Invalid GPA. Please enter a valid number.");
            }
        }

        private void btnDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridStudents.SelectedItem != null)
            {
                Student selectedStudent = (Student)dataGridStudents.SelectedItem;
                students.Remove(selectedStudent);
                UpdateDataGrid();
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void UpdateDataGrid()
        {
            dataGridStudents.ItemsSource = null;
            dataGridStudents.ItemsSource = students;
        }
    }
}
