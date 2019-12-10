using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.ComponentModel;

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
                ("INSERT INTO student (studentName) VALUES (@studentName)", conn))
            {


                conn.Open();
                //adds studentId to the table
                //adds name entered in the text box field
                //Validates entries for proper format.
      
                comd.Parameters.AddWithValue("@studentName", txtStudentName.Text);
                comd.ExecuteScalar();
                MessageBox.Show("Student Added");

            }
            }
       
            private void textBox1_Validating(object sender, CancelEventArgs e)
            {
             if(txtStudentName.Text != "char")
            {
                MessageBox.Show("Name must be alphabetical.");
            }
             else
                if(string.IsNullOrWhiteSpace(txtStudentName.Text = "No Name."))
            {
                MessageBox.Show("You must enter a valid student Name.");
                e.Cancel = true;
            }
            }
    }
}
