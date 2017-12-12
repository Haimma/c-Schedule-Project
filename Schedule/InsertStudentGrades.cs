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
    public partial class InsertStudentGrades : Form
    {
        string  FullName, CourseData, CourseName;
        int ID, index;
        ActiveCoursesDB Active = new ActiveCoursesDB();
        StudentToCourseDB StudentsList = new StudentToCourseDB();
        StudentsGradesDB Grades = new StudentsGradesDB();
        StudentDB UpdateStudent = new StudentDB();
        List<Panel> listPanel = new List<Panel>();

        public InsertStudentGrades(string Name)
        {
            InitializeComponent();
            FullName = Name;
            int SpaceIndex = FullName.IndexOf(" ");
            Active.GetCoursesNameByLecOrTut(comboBox1, FullName.Substring(0, SpaceIndex), FullName.Substring(SpaceIndex + 1));
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                if (comboBox3.Text != "")
                {
                    if (index < listPanel.Count - 1)
                        listPanel[++index].BringToFront();
                    textBox1.Text = "הקלד/י ציון בין 0 ל 100";
                    CourseData = comboBox1.Text;
                    char Day = CourseData[CourseData.IndexOf(":") + 2];
                    int Hour = Convert.ToInt32(CourseData.Substring(CourseData.IndexOf("-") + 1));
                    ID = Active.GetIDCoursesByLecOrTut(ID, Day, Hour, FullName);
                    CourseName = CourseData.Substring(0, CourseData.IndexOf(":"));
                    StudentsList.GetStudentsInCourseCombo(comboBox10, ID, CourseName);
                }
                else
                    MessageBox.Show("אנא בחר/י גודל פקטור עבור המבחן אם אין בחר/י 0");
            }
            else
                MessageBox.Show("לא נבחר קורס");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
            comboBox10.Text = "";
            label10.Text = "";
            textBox1.Text = "הקלד/י ציון בין 0 ל 100";
            comboBox10.Items.Clear();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox10.Text != "")
            {
                try
                {
                    int grade = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(comboBox3.Text);
                    if (grade > 100)
                        grade = 100;
                    label10.Text = " ציון סופי עבור ת.ז " + comboBox10.Text + " הוא " + grade;
                    if (Grades.CheckForFirstTime(comboBox10.Text, CourseName, grade))
                        Grades.UpdateTime(comboBox10.Text, CourseName, grade);
                    else
                        Grades.InsertForFirstTime(comboBox10.Text, CourseName, grade);
                    float NewAverage = Grades.GetStudentAverage(comboBox10.Text);
                    UpdateStudent.UpdateAverage(comboBox10.Text, NewAverage);
                }
                catch
                {
                    MessageBox.Show("לא הוכנס ציון תקין");
                }
            }
            else
                MessageBox.Show("לא נבחר/ה סטודנט/ית");

        }

        private void InsertStudentGrades_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            listPanel[index].BringToFront();
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
