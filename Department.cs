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
    public partial class Department : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True;Encrypt=True;");
        SqlDataAdapter Da;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;
        public Department()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select * from Department", con);
            
        }

        private void Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hospitalDataSet.Department);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(Da);
            Da.Update(dt);
            MessageBox.Show("passed successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
