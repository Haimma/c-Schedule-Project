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
    public partial class Update_Course : Form
    {
        string CoursName;
        string newcours;
        public Update_Course(string Cname)
        {
            InitializeComponent();
            CoursName = Cname;
        }

        private void Update_Course_Load(object sender, EventArgs e)
        {
            label2.Text = CoursName;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public string GetNewCours()
        {
            return newcours;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            newcours = textBox1.Text;
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
