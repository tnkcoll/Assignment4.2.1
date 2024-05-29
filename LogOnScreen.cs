using Assignment4._2._1.Controls.Classes;
using System.Security.Cryptography.X509Certificates;

namespace Assignment4._2._1
{
    public partial class LogOnScreen : Form
    {
        bool isLoggedOn = false;
        string userName = "Teacher";
        string password = "Admin";

        public LogOnScreen()
        {
            InitializeComponent();
        }

        private void LogOnButton_Click(object sender, EventArgs e)
        {
            if (TeacherUserNameTextBox.Text == userName && TeacherPasswordTextBox.Text == password)
            {
                isLoggedOn = true;
                AddNewStudent addNewStudentForm = new AddNewStudent();
                addNewStudentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect", "Incorrect username or password", MessageBoxButtons.OK);
            }
            
        }   
    }
}
