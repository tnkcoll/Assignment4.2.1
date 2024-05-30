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
    public partial class StudentDisplayForm : Form
    {
        public StudentDisplayForm()
        {
            InitializeComponent();

            List<string?> studentsToDisplayList = new List<string?>();
  
            using StreamReader sr = new StreamReader(@"C:\MSSA-CCAD14\Highest GPA.txt");
            {
                while (sr.Peek() >= 0) 
                {
                    studentsToDisplayList.Add(sr.ReadLine());
                }
                sr.Close();
            }

            DisplayStudentsListBox.DataSource = studentsToDisplayList;
            DisplayStudentsListBox.DisplayMember = "Name";
        }
    }
}
