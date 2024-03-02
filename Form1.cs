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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Database_Project2
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Hospital;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM [User] WHERE username = @username AND password = @password", con);

            SqlDataAdapter ad = new SqlDataAdapter("Select * From [User] Where username='" + textBox1.Text + "' and password='" + textBox2.Text + "' ", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Main_interface m = new Main_interface();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid user name or password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

