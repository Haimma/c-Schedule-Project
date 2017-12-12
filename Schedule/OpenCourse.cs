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
    public partial class OpenCourse : Form
    {
       
        CoursesDB courses_db = new CoursesDB();
        LecturersDB lecturersdb = new LecturersDB();
        TutorsDB tutorsdb = new TutorsDB();
        ActiveCoursesDB activecourse_db = new ActiveCoursesDB();
        private List<CoursesDB> coursesDBList = new List<CoursesDB>();
        CoursesDB selectedCourseOBJ = new CoursesDB();
        //--fill ListBox with name of courses
        private string Lec_OR_Tut;
        public OpenCourse(string Lec_OR_Tut)
        {
            this.Lec_OR_Tut = Lec_OR_Tut;
            InitializeComponent();
            if (Lec_OR_Tut == "Lecture")
            {
                label1.Text = "פתיחת הרצאה";
                label7.Text = "מרצה";
            }
           else if (Lec_OR_Tut == "Tutore")
            {
                label1.Text = "פתיחת תרגול";
                label7.Text = "מתרגל";
            }



            // courses_db.fillCourses_list(lb_nameCourse);
            coursesDBList = courses_db.readSQLData();
            List<string> lb_namelist = new List<string>();
            foreach (CoursesDB item in coursesDBList)
                lb_namelist.Add(item.GetName());
            lb_nameCourse.DataSource = lb_namelist;

        }

        private void lb_nameCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            lb_class.Items.Clear();
            cb_day.Items.Clear();
            cb_day.ResetText();
            cb_day.Items.Add('א');
            cb_day.Items.Add('ב');
            cb_day.Items.Add('ג');
            cb_day.Items.Add('ד');
            cb_day.Items.Add('ה');
            cb_day.Items.Add('ו');

            cb_hourse.Items.Clear();
              cb_hourse.ResetText();
              lb_nameLec.Items.Clear();
        }

        private void OpenCourse_Load(object sender, EventArgs e)
        {

        }

        private void b_accept_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void cb_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_hourse.Items.Clear();
            cb_hourse.ResetText();
            lb_nameLec.Items.Clear();
            lb_class.Items.Clear(); 
             
            int i;
            if (cb_day.SelectedIndex + 1 == 6)//friday
            {
                for (i = 8; i < 13; i++)
                    cb_hourse.Items.Add(i);
            }
            else if (cb_day.SelectedIndex + 1 > 0)
            {
                for (i = 8; i < 21; i++)
                    cb_hourse.Items.Add(i);
            }

        }

        private void cb_hourse_SelectedIndexChanged(object sender, EventArgs e)
         {
            int day, hour, numOfhoursOnCourse;
            day = cb_day.SelectedIndex + 1;
            hour = cb_hourse.SelectedIndex + 8;
            int lecOrTut_INT = 0;

            foreach (CoursesDB item in coursesDBList)
                if (lb_nameCourse.Text.Contains(item.GetName()))
                {
                    selectedCourseOBJ = item;
                    break;
                }
            if (Lec_OR_Tut == "Lecture")
            {
                numOfhoursOnCourse = selectedCourseOBJ.GetNumOfLec();
                lecOrTut_INT = 1;
            }
            else {
                numOfhoursOnCourse = selectedCourseOBJ.GetNumOfTut();
                lecOrTut_INT = 2;
            }
            //-------for lecture
            if (day == 6 && (hour + numOfhoursOnCourse > 13) || day != 6 && (hour + numOfhoursOnCourse > 21))
            {
                lb_nameLec.Items.Clear();
                lb_class.Items.Clear();
                MessageBox.Show("You have exceeded the operating hours of college");
            }
            else {
                //--fill free class list
                lb_class.Items.Clear();
                lb_nameLec.Items.Clear();


                activecourse_db.fillfreeclasses_listBox(lb_class, cb_day, cb_hourse,lb_nameCourse , lecOrTut_INT, selectedCourseOBJ, numOfhoursOnCourse);

                //--fill lecturers that can study this cours and in this time
                if (Lec_OR_Tut == "Lecture")
                    lecturersdb.fillLecturers_list(lb_nameLec, lb_nameCourse.Text, day, hour, selectedCourseOBJ);
                else
                    tutorsdb.fillTutors_list(lb_nameLec, lb_nameCourse.Text, day, hour, selectedCourseOBJ);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            string select_course, select_class, select_lec;
            int select_hour, select_numOfStudents, numberHoursCourse;
            int distance;       //for chack integer
            char select_day;

            while (true)
            {
                //--------Name course check
                if ((lb_nameCourse.Text == ""))
                {
                    MessageBox.Show("You need choose course");      //empty textBox or not integer
                    break;
                }
                select_course = lb_nameCourse.Text;
                //      numberHoursCourse = courses_db.getNumHour(select_course, 1);
                numberHoursCourse = selectedCourseOBJ.GetNumOfLec();        //lecture
                //-------day check

                switch (cb_day.SelectedIndex + 1)
                {
                    case 1:
                        select_day = 'A';
                        break;
                    case 2:
                        select_day = 'B';
                        break;
                    case 3:
                        select_day = 'C';
                        break;
                    case 4:
                        select_day = 'D';
                        break;
                    case 5:
                        select_day = 'D';
                        break;
                    case 6:
                        select_day = 'E';
                        break;
                    default:
                        MessageBox.Show("You need to choose day");
                        select_day = ' ';
                        break;
                }
                if (select_day == ' ')
                    break;

                //-------check hour
                if (cb_hourse.SelectedIndex == -1)
                {
                    MessageBox.Show("You need to choose hour");
                    select_hour = 0;
                    break;
                }
                select_hour = cb_hourse.SelectedIndex + 8;

                //------check number of students
                if (!(int.TryParse(tb_numOfStudent.Text, out distance)))
                {
                    MessageBox.Show("You need to input number of student");
                    break;
                }
                else
                {
                    select_numOfStudents = int.Parse(tb_numOfStudent.Text);
                    if ((select_numOfStudents < 1 || select_numOfStudents > 70))
                    {
                        MessageBox.Show("The number of student for lecturer is between 1 to 70");
                        break;
                    }
                }
                if ((lb_class.Text == ""))
                {
                    MessageBox.Show("You need choose class");      //No choose in ListBox
                    break;
                }
                select_class = lb_class.Text;

                //----check lecturer
                select_lec = lb_nameLec.Text;
                if ((lb_nameLec.Text == ""))
                {
                    MessageBox.Show("You need choose lecturer");      //No choose in ListBox
                    break;
                }
                
                else if (activecourse_db.ExsistInThisTime(select_lec,select_hour ,numberHoursCourse,select_day))
                {
                    MessageBox.Show("This lecturer teaching in this time yet.");      //No choose in ListBox
                    break;
                }
                



                //-------All detailse fine------
                activecourse_db.InsertNew_ActiveCourse(select_course, Lec_OR_Tut, select_day, select_hour, numberHoursCourse, select_class, select_lec, select_numOfStudents);
                this.Hide();

                break;
            }

        }

        private void lb_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_nameLec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
