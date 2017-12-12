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
    public partial class AddSpecialDateExtraExam : Form
    {

        CoursesDB courses_db = new CoursesDB();
        SemestersDB semesterdb = new SemestersDB();
        TestScheduleDB test_Schedule_db = new TestScheduleDB();

        ActiveCoursesDB activecourse_db = new ActiveCoursesDB();
        private List<CoursesDB> coursesDBList = new List<CoursesDB>();
        CoursesDB selectedCourseOBJ = new CoursesDB();
        
        

        public AddSpecialDateExtraExam()
        {
            InitializeComponent();
            //fill course List and create a obj
            coursesDBList = courses_db.readSQLData();
            List<string> lb_namelist = new List<string>();
            foreach (CoursesDB item in coursesDBList)
                lb_namelist.Add(item.GetName());
            nameCourse.DataSource = lb_namelist;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void do_it_Click(object sender, EventArgs e)
        {
            string select_course, select_class;
            int select_hour;
            

            while (true)
            {
                //--------Name course check
                if ((nameCourse.Text == ""))
                {
                    MessageBox.Show("You need choose course");      //empty textBox or not integer
                    break;
                }
                select_course = nameCourse.Text;

                //-------check hour
                if (cb_hourse.SelectedIndex == -1)
                {
                    MessageBox.Show("You need to choose hour");
                    select_hour = 0;
                    break;
                }
                select_hour = cb_hourse.SelectedIndex + 8;

               
                if ((lb_class.Text == ""))
                {
                    MessageBox.Show("You need choose class");      //No choose in ListBox
                    break;
                }
                select_class = lb_class.Text;


                //-------All detailse fine------
                test_Schedule_db.InsertNew_Test(select_course, selectedCourseOBJ.Getsemester(), dt_date.Value, select_hour, select_class);
                this.Hide();

                break;
            }
        
        }

        private void nameCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (CoursesDB item in coursesDBList)
                if (nameCourse.Text.Contains(item.GetName()))
                {
                    selectedCourseOBJ = item;
                    break;
                }
            lb_class.Items.Clear();

            char semester_course;
            semester_course = selectedCourseOBJ.Getsemester();
            dt_date.MaxDate = DateTime.Today.AddYears(20); //for clear


            dt_date.MinDate = semesterdb.GetStartDateTestSemester(semester_course);
            dt_date.MaxDate = semesterdb.GetEndDateTestSemester(semester_course);
            dt_date.Format = DateTimePickerFormat.Short;


            cb_hourse.Items.Clear();
            cb_hourse.ResetText();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cb_hourse.Items.Clear();
            cb_hourse.ResetText();
            lb_class.Items.Clear();
            int i;

            if ((int)dt_date.Value.DayOfWeek == 6)
            {
                MessageBox.Show("illegal ,chenge day!");
            }
            else if ((int)dt_date.Value.DayOfWeek == 5)//friday
            {
                for (i = 8; i < 13; i++)
                    cb_hourse.Items.Add(i);
            }
            else
            {
                for (i = 8; i < 21; i++)
                    cb_hourse.Items.Add(i);
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lb_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_hourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int day, hour, numOfhoursOnCourse;
            //day = cb_day.SelectedIndex + 1;
            //hour = cb_hourse.SelectedIndex + 8;
            //int lecOrTut_INT = 0;

            //foreach (CoursesDB item in coursesDBList)
            //    if (nameCourse.Text.Contains(item.GetName()))
            //    {
            //        selectedCourseOBJ = item;
            //        break;
            //    }
            //if (Lec_OR_Tut == "Lecture")
            //{
            //    numOfhoursOnCourse = selectedCourseOBJ.GetNumOfLec();
            //    lecOrTut_INT = 1;
            //}
            //else
            //{
            //    numOfhoursOnCourse = selectedCourseOBJ.GetNumOfTut();
            //    lecOrTut_INT = 2;
            //}
            ////-------for lecture
            //if (day == 6 && (hour + numOfhoursOnCourse > 13) || day != 6 && (hour + numOfhoursOnCourse > 21))
            //{
            //    lb_nameLec.Items.Clear();
            //    lb_class.Items.Clear();
            //    MessageBox.Show("You have exceeded the operating hours of college");
            //}
            //else
            //{
                
                activecourse_db.fillFreeClass(lb_class);

                ////--fill lecturers that can study this cours and in this time
                //if (Lec_OR_Tut == "Lecture")
                //    lecturersdb.fillLecturers_list(lb_nameLec, lb_nameCourse.Text, day, hour, selectedCourseOBJ);
                //else
                //    tutorsdb.fillTutors_list(lb_nameLec, lb_nameCourse.Text, day, hour, selectedCourseOBJ);
            }
        
    }
}
