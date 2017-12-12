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
    public partial class Display_Student_Grades : Form
    {
        private int NO_APPEAL = -2, NO_VERIFY = -1, DENYED = 0, CONFIRMED = 1;
        private Student student;
        private StudentDB studentDB = new StudentDB();
        private ActiveCoursesDB activeCoursesDB = new ActiveCoursesDB();
        private StudentToCourseDB stdntToCourseDB = new StudentToCourseDB();
        private Appeals_StudentsDB appeal_StdntDB = new Appeals_StudentsDB();

        private List<StudentGrade> studentGrades;
        private List<Lecturer> lecturers;
        private List<Appeals_Student> appeals;
        private List<int> appeals_made = new List<int>();
        private List<int> coursesID = new List<int>();
        public Display_Student_Grades(Object s)
        {
            InitializeComponent();
            student = (Student)s;
            Initialise_Again();
        }

        private void Initialise_Again()
        {
            studentGrades = studentDB.Get_Grades(student);

            appeals = appeal_StdntDB.Get_Appeals_From_DB_By_Student(student);
            studentGrades = stdntToCourseDB.Get_Grades(student.getID());
            lecturers = activeCoursesDB.Get_Lecturers_For_Grades(studentGrades, coursesID);

            txtB__Diplay_Grades_TitleBar.Text = "קורס\t\tמרצה\t\tציון\tערעור";
            int size = studentGrades.Count();
            string courseName = "";

            string appeal_made = "";

            for (int i = 0; i < size; i++)
            {
                courseName = studentGrades[i].Get_CourseName();
                Remove_Unnecessary_Spaces(courseName);

                Appeals_Student temp = appeals.Find(a => a.Get_Course_Name() == studentGrades[i].Get_CourseName());
                if (temp != null)
                {
                    if (temp.Get_Status() == CONFIRMED)
                        appeal_made = "אושר";
                    else if (temp.Get_Status() == DENYED)
                        appeal_made = "נדחה";
                    else appeal_made = "הוגש";


                    appeals_made.Add(temp.Get_Status());
                }
                else
                {
                    appeal_made = "לא הוגש";
                    appeals_made.Add(NO_APPEAL);
                }

                lstB_Dysplay_Grades.Items.Add(courseName + "\t" + lecturers[i].Get_Full_Name() + "\t" + studentGrades[i].Get_Grade() + "\t" + appeal_made);
            }
        }

        private void btn_Appeal_Confirm_Click(object sender, EventArgs e)
        {
            appeal_StdntDB.Make_Appeal(student.getID(), coursesID[lstB_Dysplay_Grades.SelectedIndex], txtB_Appela_Course.Text, rtxtB_Appeal.Text, lecturers[lstB_Dysplay_Grades.SelectedIndex].getID(), NO_VERIFY);
            btn_Appeal_Back.PerformClick();
        }

        private void btn_Display_Grades_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private string Remove_Unnecessary_Spaces(string s)
        {
            string new_s = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (!(s[i] == ' ' && s[i + 1] == ' '))
                    new_s += s[i];
                else break;
            }

            return new_s;
        }

        private void btn_Make_Appeal_Click(object sender, EventArgs e)
        {
            if (lstB_Dysplay_Grades.SelectedItem != null)
            {
                if (appeals_made[lstB_Dysplay_Grades.SelectedIndex] == NO_APPEAL)
                {
                    pnl_Display_Grades.Visible = false;
                    txtB_Appela_Course.Text = studentGrades[lstB_Dysplay_Grades.SelectedIndex].Get_CourseName();
                    txtB_Appeal_Lecturer.Text = lecturers[lstB_Dysplay_Grades.SelectedIndex].Get_Full_Name();
                    txtB_Appeal_Grade.Text = studentGrades[lstB_Dysplay_Grades.SelectedIndex].Get_Grade()+"";
                }
                else
                {
                    MessageBox.Show("הוגש כבר ערעור לקורס זה");
                }
            }
            else MessageBox.Show("לא נבחר מבחן לערעור");
        }

        private void btn_Appeal_Back_Click(object sender, EventArgs e)
        {
            
            lstB_Dysplay_Grades.Items.Clear();
            lstB_Dysplay_Grades.ResetText();
            pnl_Display_Grades.Visible = true;
            Initialise_Again();
            

            rtxtB_Appeal.Clear();
        }
    }
}
