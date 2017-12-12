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
    public partial class viewShStu : Form
    {
        string name;
        string id;
        ActiveCoursesDB activeCourse = new ActiveCoursesDB();

        public viewShStu(string name1, string id1)
        {
            name = name1;
            id = id1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lb_course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewShStu_Load(object sender, EventArgs e)
        {
            string nameOfStu = name;
            string idStu = id;
            label2.Text = nameOfStu;
            List<int> numOfCourses = activeCourse.returnIDActiveCoursesForStu(idStu);
            List<string> listOfActiveCourses = new List<string>();

            foreach(int Item in numOfCourses)
                listOfActiveCourses.Add(activeCourse.MakeStudentSchedule(Item).ToString());

            foreach (string Item in listOfActiveCourses)
                lb_course.Items.Add(Item);

        }
    }
}
