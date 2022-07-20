using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6Example1
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["Chapter6Example1.Properties.Settings.AdvisConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter
                ("SELECT * FROM Advisor", conn))
            {
                DataTable advisorTable = new DataTable();
                adapter.Fill(advisorTable);
                advisorCombobox.DisplayMember = "advisorName";
                advisorCombobox.ValueMember = "advisorId";
                advisorCombobox.DataSource = advisorTable;
            }
        }

        private void advisorlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(conn = new SqlConnection(connectionString))
            using(SqlCommand cmd = new SqlCommand
                ("SELECT adviseeId, adviseeName FROM advisee" +
                "WHERE advisee.advisorId = @advisorId",conn))
            using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@advisorId",
                    advisorCombobox.SelectedValue.ToString());
                DataTable adviseeTable = new DataTable();
                adapter.Fill(adviseeTable);
                advisorlistBox.DisplayMember = "adviseeName";
                advisorlistBox.ValueMember = "adviseeId";
                advisorlistBox.DataSource = "adviseeTable";
            }
        }
    }
}
