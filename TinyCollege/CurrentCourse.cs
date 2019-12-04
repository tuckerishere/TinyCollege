using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace TinyCollege
{
    public partial class frmCurrentCourse : Form
    {
        string connectionString;
        SqlConnection conn;
        int courseId;
        public frmCurrentCourse()
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
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT course.courseId, course.CourseName, " +
                "student.studentName FROM course JOIN enrollment ON course.courseId = enrollment.courseId " +
                "JOIN student ON enrollment.studentId = student.studentId WHERE course.courseId = " +
                "@courseId", conn))


            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {

                comd.Parameters.AddWithValue("@courseId", int.Parse(txtCourseID.Text));

                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);

                DataRow dr = courseTable.Rows[0];
                courseId = int.Parse(dr["courseId"].ToString());
                txtCourseTitle.Text = dr["courseName"].ToString();
                lstCourseData.DisplayMember = "studentName";
                lstCourseData.DataSource = courseTable;
            }
        }
    }
}
