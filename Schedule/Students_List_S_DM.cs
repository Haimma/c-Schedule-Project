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
    public partial class Students_List_S_DM : Form
    {
        LecturersDB lec = new LecturersDB();
        TutorsDB tut = new TutorsDB();
        ActiveCoursesDB Active = new ActiveCoursesDB();
        StudentToCourseDB StudentsList = new StudentToCourseDB();
        string Fname, Lname, FullName, CourseData;
        int ID;
        public Students_List_S_DM()
        {
            InitializeComponent();
            lec.GetLecturersNames(comboBox2);
            tut.GetTutorsNames(comboBox2);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FullName = comboBox2.Text;
            int SpaceIndex =FullName.IndexOf(" ");
            Fname = FullName.Substring(0,SpaceIndex);
            Lname = FullName.Substring(SpaceIndex+1);
            comboBox1.Items.Clear();
            Active.GetCoursesNameByLecOrTut(comboBox1, Fname, Lname);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseData = comboBox1.Text;
            char Day = CourseData[CourseData.IndexOf(":") + 2];
            int Hour = Convert.ToInt32(CourseData.Substring(CourseData.IndexOf("-")+1));
            ID = Active.GetIDCoursesByLecOrTut(ID,Day,Hour,FullName);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string CourseName = CourseData.Substring(0, CourseData.IndexOf(":"));
            StudentsList.GetStudentsInCourse(listBox1, ID, CourseName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
