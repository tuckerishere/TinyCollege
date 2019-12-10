using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

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
                    //adds studentId to the table.
                    //adds name entered in the text box field
                    //Validates the fields for proper format.

                    
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtCourseTitle.Text, 
                        "^[a-zA-Z]"))
                        {
                        MessageBox.Show("Course must be alphabetical.");
                        txtCourseTitle.Text.Remove(txtCourseTitle.Text.Length - 1);
                    }
                    else
                    if (string.IsNullOrWhiteSpace(txtCourseTitle.Text))
                    {
                        MessageBox.Show("You must enter a course.");
                    }
                    else
                    if (cmbSemester == null)
                    {
                        MessageBox.Show("Semester must be selected.");
                    }
                    else
                    {
                        comd.Parameters.AddWithValue("@courseName", txtCourseTitle.Text);
                        comd.Parameters.AddWithValue("@courseSemester", cmbSemester.SelectedItem);
                        comd.ExecuteScalar();
                        MessageBox.Show("Course Added");
                    }
                }
            }            
        }
        private void txtCourseTitle_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            
                    
        }
    }
}
