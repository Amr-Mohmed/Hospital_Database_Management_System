using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project2
{
    public partial class Main_interface : Form
    {
        public Main_interface()
        {
            InitializeComponent();
        }

        private void Main_interface_Load(object sender, EventArgs e)
        {

        }

        private void deparToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
            doc.Show();

        }

        private void mangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bcostToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addLabServiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();  
            patient.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department department = new Department();  
            department.Show();
        }

        private void bedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bed bed = new Bed();   
            bed.Show();
        }

        private void labServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab_Service lab = new Lab_Service();
            lab.Show();
        }

        private void queriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search se= new Search();    
            se.Show();
        }
    }
}
