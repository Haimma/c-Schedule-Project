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
    public partial class SetDateForTest : Form
    {

        CoursesDB courses_db = new CoursesDB();
        SemestersDB semesterdb = new SemestersDB();
        TestScheduleDB test_Schedule_db = new TestScheduleDB();

        ActiveCoursesDB activecourse_db = new ActiveCoursesDB();
        private List<CoursesDB> coursesDBList = new List<CoursesDB>();
        CoursesDB selectedCourseOBJ = new CoursesDB();

        public SetDateForTest()
        {
            InitializeComponent();
            //fill course List and create a obj
            coursesDBList = courses_db.readSQLData();
            List<string> lb_namelist = new List<string>();
            foreach (CoursesDB item in coursesDBList)
                lb_namelist.Add(item.GetName());
            lb_nameCourse.DataSource = lb_namelist;

        }

        private void lb_nameCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (CoursesDB item in coursesDBList)
                if (lb_nameCourse.Text.Contains(item.GetName()))
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

        private void SetDateForTest_Load(object sender, EventArgs e)
        {

        }

        private void cb_date_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cb_hourse.Items.Clear();
            cb_hourse.ResetText();
            lb_class.Items.Clear();
            int i;
            
            if ((int)dt_date.Value.DayOfWeek==6)
            {
                MessageBox.Show("illegal ,chenge day!");
            }
            else if((int)dt_date.Value.DayOfWeek == 5)//friday
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

        private void cb_hourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int  hour, numOfhoursOntest=3;
            hour = cb_hourse.SelectedIndex + 8;

            //-------for lecture
            if ((int)dt_date.Value.DayOfWeek == 5 && (hour + numOfhoursOntest > 13) || (int)dt_date.Value.DayOfWeek != 5 && (hour + numOfhoursOntest > 21))
            {
                lb_class.Items.Clear();
                MessageBox.Show("You have exceeded the operating hours of college");
            }
            else {
                //--fill free class list
                lb_class.Items.Clear();

                test_Schedule_db.fillfreeclasses_list(lb_class, dt_date.Value, cb_hourse, selectedCourseOBJ, courses_db);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select_course, select_class;
            int select_hour;
            //char select_day,semeter;

            while (true)
            {
                //--------Name course check
                if ((lb_nameCourse.Text == ""))
                {
                    MessageBox.Show("You need choose course");      //empty textBox or not integer
                    break;
                }
                select_course = lb_nameCourse.Text;

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
