using Assignment4._2._1.Controls.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._2._1
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void LogInToAccount_Click(object sender, EventArgs e)
        {
            LogOnScreen logOnScreen = new LogOnScreen();
            logOnScreen.ShowDialog();

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddNewStudent addNewStudent = new AddNewStudent();
            addNewStudent.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveStudentListByGPA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.studentList.Count; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (Program.studentList[j - 1].GPA < Program.studentList[j].GPA)
                    {
                        Student temp = Program.studentList[j - 1];
                        Program.studentList[j - 1] = Program.studentList[j];
                        Program.studentList[j] = temp;
                    }
                }
             }

                using (StreamWriter sw = new StreamWriter("C:\\MSSA-CCAD14\\Highest GPA.txt"))
            {
                foreach (Student student in Program.studentList)
                {
                    sw.WriteLine($"{student.StudentName}, {student.GPA}");
                }
                sw.Close();
            }
        }
    }
}
