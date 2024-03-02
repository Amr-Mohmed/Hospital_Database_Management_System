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
    public partial class Doctor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True;");
        SqlDataAdapter Da;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;
        public Doctor()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select * from Doctor ", con);
            DataTable dt = new DataTable();
            Da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hospitalDataSet.Doctor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Da);
            Da.Update(dt);
            MessageBox.Show("passed successfully!" , "success" , MessageBoxButtons.OK ,MessageBoxIcon.Information );
        }
    }
}
