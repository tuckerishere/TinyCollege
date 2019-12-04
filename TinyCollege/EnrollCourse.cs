using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TinyCollege
{
    public partial class frmEnrollCourse : Form
    {
        string connectionString;
        SqlConnection conn;

        public frmEnrollCourse()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.TinyCollegeDBConnectionString"].ConnectionString;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEnrollCourse_Load(object sender, EventArgs e)
        {
            //connects to the database
            using (conn = new SqlConnection(connectionString))
          
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student", conn))
            {
                //creates a table for the student on load
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                //assigns the name to display
                cmbStudentSelect.DisplayMember = "studentName";
                //studentID is the reference number for the comboBox
                cmbStudentSelect.ValueMember = "studentId";
                //Calls back to the data table called above
                cmbStudentSelect.DataSource = studentTable;


            }
            using (conn = new SqlConnection(connectionString))
            //sql commands to select all  from the table
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM course", conn))
            {
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                //assigns the name to display
                cmbCourseSelect.DisplayMember = "courseName";
                //courseID is the reference number for the comboBox
                cmbCourseSelect.ValueMember = "courseId";
                //Calls back to the data table called above
                cmbCourseSelect.DataSource = courseTable;
            }
        }

        private void cmbCourseSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                    //added Indentity insert to allow the Student ID to be modified
                    ("INSERT INTO enrollment (studentId, courseId) VALUES (@studentId, @courseId)", conn))
            {


                conn.Open();
                //adds studentId to the table(Need to check if the student ID is in use and then add the next value)
                //adds name entered in the text box field(need to create validation checks)

                comd.Parameters.AddWithValue("@studentId", cmbStudentSelect.SelectedValue);
                comd.Parameters.AddWithValue("@courseId", cmbCourseSelect.SelectedValue);
                comd.ExecuteScalar();
                MessageBox.Show("Student Enrolled!");

            }
        }
    }
}
