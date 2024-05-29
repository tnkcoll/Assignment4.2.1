using Assignment4._2._1.Controls.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._2._1
{
    public partial class AddNewStudent : Form
    {
        public AddNewStudent()
        {
            InitializeComponent();
        }

        public void AddNewStudentButton_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            
            if (StudentIdTextBox.Text != null)
            {
                newStudent.StudentId = Convert.ToInt32(StudentIdTextBox.Text);
            }
            else
            {
                DisplayErrorMessage("ID");
            }

            if (StudentNameTextBox.Text != null)
            {
                newStudent.StudentName = StudentNameTextBox.Text;
            }
            else
            {
                DisplayErrorMessage("name");
            }

            if (StudentGPATextBox.Text != null)
            {
                newStudent.GPA = Convert.ToDouble(StudentGPATextBox.Text);
            }
            else
            {
                DisplayErrorMessage("name");
            }

            Program.studentList.Add(newStudent);

            StudentIdTextBox.Text = "";
            StudentNameTextBox.Text = "";
            StudentGPATextBox.Text = "";


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void DisplayErrorMessage(string entry)
        {
            MessageBox.Show($"Please enter the new student's {entry}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
