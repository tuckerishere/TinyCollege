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
                //added Indentity insert to allow the Student ID to be modified
                ("SET IDENTITY_INSERT student ON INSERT INTO student (studentId, studentName) VALUES (@studentId, @studentName)", conn))
            {
                conn.Open();
                //adds studentId to the table(Need to check if the student ID is in use and then add the next value)
                comd.Parameters.AddWithValue("@studentId",3);
                //adds name entered in the text box field(need to create validation checks)
                comd.Parameters.AddWithValue("@studentName", txtStudentName.Text);
                comd.ExecuteScalar();
                MessageBox.Show("Student Added");
                
            }
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
       
        }
    }
}
