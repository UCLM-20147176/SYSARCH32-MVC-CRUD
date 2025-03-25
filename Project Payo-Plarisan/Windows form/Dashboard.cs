using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            this.Hide();
            department.ShowDialog();
            this.Show();
        }

        private void btnCollege_Click(object sender, EventArgs e)
        {
            College college = new College();
            this.Hide();
            college.ShowDialog();
            this.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            this.Hide();
            department.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            College college = new College();
            this.Hide();
            college.ShowDialog();
            this.Show();
        }

       
    }
}
