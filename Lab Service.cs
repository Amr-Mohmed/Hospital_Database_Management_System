using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Database_Project2
{
    public partial class Lab_Service : Form
    {
        SqlConnection con= new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True;Encrypt=True;");
        SqlDataAdapter Da;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;
        public Lab_Service()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select * from Lab_Service",con);
            
        }

        private void Lab_Service_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Lab_Service' table. You can move, or remove it, as needed.
            this.lab_ServiceTableAdapter.Fill(this.hospitalDataSet.Lab_Service);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Da);
            Da.Update(dt);
            MessageBox.Show("passed successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
