using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace TinyCollege
{
    public partial class frmAddStudent : Form
    {
        string connectionString;
        SqlConnection conn;
        public frmAddStudent()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.TinyCollegeDBConnectionString"].ConnectionString;

        }

        private void lblstuInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                ("SET IDENTITY_INSERT student ON INSERT INTO student (studentId, studentName) VALUES (@studentId, @studentName)", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@studentId",);
                comd.Parameters.AddWithValue("@studentName", txtStudentName.Text);
                comd.ExecuteScalar();
                MessageBox.Show("Student Added");
                
            }
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            using( conn=new SqlConnection(connectionString))
            using( SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student", conn))
            {
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
            }
        }
    }
}
