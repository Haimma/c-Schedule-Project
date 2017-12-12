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
    public partial class viewShT : Form
    {
        string name;
        string id;
        ActiveCoursesDB activeCourse = new ActiveCoursesDB();
        TutorsDB tutdb = new TutorsDB();

        public viewShT(string name1, string id1)
        {
            name = name1;
            id = id1;
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_curse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void viewShT_Load(object sender, EventArgs e)
        {
            
            List<string> listOfActiveCourses = new List<string>();

            List<int> numOfCourses = new List<int>();
            List<string> lecCourse = new List<string>();

            string nameFullTut;
            label3.Text = name;

            nameFullTut = tutdb.FullNameByID(id);
            lecCourse = activeCourse.returnCoursesForLec(nameFullTut);


            foreach (string Item in lecCourse)
                numOfCourses.Add(activeCourse.returnIDActiveCoursesForLec(nameFullTut, Item));


            foreach (int Item in numOfCourses)
                listOfActiveCourses.Add(activeCourse.MakeStudentSchedule(Item).ToString());

            foreach (string Item in listOfActiveCourses)
                listBox1.Items.Add(Item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
