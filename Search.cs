using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Database_Project2
{
    public partial class Search : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True;Encrypt=True;");



        public Search()
        {
            InitializeComponent();

            SqlDataAdapter Da;
            Da = new SqlDataAdapter("select * from Patient ", con);
            //DataTable dt = new DataTable();
            //Da.Fill(dt);
            //dataGridView1.DataSource = dt;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hospitalDataSet.Patient);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            SqlDataAdapter Da;
            Da = new SqlDataAdapter("select * from Patient where phone like '" + textBox1.Text + "%'", con);

            //DataTable dt = new DataTable();
            //Da.Fill(dt);
            //dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
