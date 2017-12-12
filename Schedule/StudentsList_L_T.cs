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
    public partial class StudentsList_L_T : Form
    {
        string FullName, CourseData;
        int ID;
        ActiveCoursesDB Active = new ActiveCoursesDB();
        StudentToCourseDB StudentsList = new StudentToCourseDB();


        public StudentsList_L_T(string Name)
        {
            InitializeComponent();
            FullName = Name;
            int SpaceIndex = FullName.IndexOf(" ");
            Active.GetCoursesNameByLecOrTut(comboBox1, FullName.Substring(0, SpaceIndex), FullName.Substring(SpaceIndex + 1));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseData = comboBox1.Text;
            char Day = CourseData[CourseData.IndexOf(":") + 2];
            int Hour = Convert.ToInt32(CourseData.Substring(CourseData.IndexOf("-") + 1));
            ID = Active.GetIDCoursesByLecOrTut(ID, Day, Hour, FullName);
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
    }
}
