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
    public partial class Bed : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True;Encrypt=True;");
        SqlDataAdapter Da;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;
        public Bed()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select * from Bed", con);
            
        }

        private void Bed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Bed' table. You can move, or remove it, as needed.
            this.bedTableAdapter.Fill(this.hospitalDataSet.Bed);

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
