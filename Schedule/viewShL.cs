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
    public partial class viewShL : Form
    {
        string name;
        string id;
        ActiveCoursesDB activeCourse;
        LecturersDB lecdb = new LecturersDB();

        public viewShL(string name1, string id1)
        {
            name = name1;
            id = id1;
            InitializeComponent();
            activeCourse = new ActiveCoursesDB(name);
        }

        private void viewShL_Load(object sender, EventArgs e)
        {
            List<string> listOfActiveCourses = new List<string>();
            List<int> numOfCourses = new List<int>();
            List<string> lecCourse = new List<string>();

            string nameFullLek;
            label3.Text = name;

            nameFullLek = lecdb.FullNameByID(id);
            lecCourse = activeCourse.returnCoursesForLec(nameFullLek);


            foreach (string Item in lecCourse)
                numOfCourses.Add(activeCourse.returnIDActiveCoursesForLec(nameFullLek, Item));


            foreach (int Item in numOfCourses)
                listOfActiveCourses.Add(activeCourse.MakeStudentSchedule(Item).ToString());

            foreach (string Item in listOfActiveCourses)
                listBox1.Items.Add(Item);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}