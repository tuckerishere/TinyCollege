using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TinyCollege
{
    public partial class frmCurrentlyEnrolled : Form
    {
        string connectionString;
        SqlConnection conn;
        int studentId;
        public frmCurrentlyEnrolled()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.TinyCollegeDBConnectionString"].ConnectionString;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //connects to the database
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT student.studentId, student.studentName, " +
                "course.courseName FROM student JOIN enrollment ON student.studentId = enrollment.studentId " +
                "JOIN course ON enrollment.courseId = course.courseId WHERE student.studentId = " +
                "@studentId", conn))
               

            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                
                comd.Parameters.AddWithValue("@studentId", int.Parse(txtStudentID.Text));
 
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
         
                    DataRow dr = studentTable.Rows[0];
                    studentId = int.Parse(dr["studentId"].ToString());
                    lblStudentResults.Text = dr["studentName"].ToString();
                    lstCourseList.DisplayMember = "courseName";
                    lstCourseList.DataSource = studentTable;
                


            }
        
        }
    }
}
