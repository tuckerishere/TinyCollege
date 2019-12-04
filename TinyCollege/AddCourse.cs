using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TinyCollege
{
    public partial class frmAddCourse : Form
    {
        string connectionString;
        SqlConnection conn;
        public frmAddCourse()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.TinyCollegeDBConnectionString"].ConnectionString;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            {
                using (conn = new SqlConnection(connectionString))
                using (SqlCommand comd = new SqlCommand
                    //added Indentity insert to allow the Student ID to be modified
                    ("INSERT INTO course (courseName, courseSemester) VALUES (@courseName, @courseSemester)", conn))
                {


                    conn.Open();
                    //adds studentId to the table(Need to check if the student ID is in use and then add the next value)
                    //adds name entered in the text box field(need to create validation checks)

                    comd.Parameters.AddWithValue("@courseName", txtCourseTitle.Text);
                    comd.Parameters.AddWithValue("@courseSemester", cmbSemester.SelectedItem);
                    comd.ExecuteScalar();
                    MessageBox.Show("Course Added");

                }
            }
        }
    }
}
