using System;
using System.Windows.Forms;

namespace TinyCollege
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Form addStudent = new frmAddStudent();
            addStudent.Show();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Form addCourse = new frmAddCourse();
            addCourse.Show();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            Form enrollCourse = new frmEnrollCourse();
            enrollCourse.Show();
        }

        private void btnWhoCourse_Click(object sender, EventArgs e)
        {
            Form StudentsInCourse = new frmCurrentlyEnrolled();
            StudentsInCourse.Show();
        }

        private void btnCourseEnrolled_Click(object sender, EventArgs e)
        {
            Form courseEnrollment = new frmCurrentCourse();
            courseEnrollment.Show();
        }
    }
}
