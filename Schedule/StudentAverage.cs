using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Schedule
{
    public partial class StudentAverage : Form
    {
        StudentDB student = new StudentDB();
        public StudentAverage(string user)
        {
            InitializeComponent();
            label2.Text = student.findAverage(user);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void StudentAverage_Load(object sender, EventArgs e)
        {

        }
    }
}
