using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;
namespace Project_Db
{
    public partial class HireTA_Form : Form
    {
        public HireTA_Form()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string cnstring = "Data Source=success\\SQLEXPRESS01;Initial Catalog=Project;Integrated Security=True";
             //     string cnstring = "Data Source=LAB_WORK\\;Initial Catalog=task; Integrated Security=True; Encrypt=false";

             // Your SQL query
             string sqlquery = "INSERT INTO StudentTable(Name,Course,Age,Gpa) VALUES (@Name, @Course ,@Age,@Gpa)";

             try
             {
                 // Create a connection
                 using (SqlConnection con = new SqlConnection(cnstring))
                 {
                     con.Open();

                     // Create a command with the SQL query and the connection
                     using (SqlCommand cm = new SqlCommand(sqlquery, con))
                     {
                         // Add parameters to the command
                         cm.Parameters.AddWithValue("@Name", Name);
                         cm.Parameters.AddWithValue("@Course", Course);
                         cm.Parameters.AddWithValue("@Age", Age);
                         cm.Parameters.AddWithValue("@GPA", GPA);

                         // Execute the query
                         cm.ExecuteNonQuery();
                         label6.Text = "Added Successfully";

                     }
                 }


             }
             catch (Exception ex)
             {
                 label6.Text = "Error: " + ex.Message;
             }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
