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
    public partial class ChangeCourseDetails : Form
    {
        CoursesDB courses_db = new CoursesDB();
        ActiveCoursesDB activecourse_db = new ActiveCoursesDB();
        LecturersDB lecturersdb = new LecturersDB();
        string typeCourse_select;
        int id_active_course;
        public ChangeCourseDetails()
        {
            InitializeComponent();
            activecourse_db.fillActiveCourses_list(lb_activeCourse);
        }

        private void ScheduleChanges_Secretary_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {

            string select_class = "", select_lec = "";
            int select_hour = 8, numberHoursCourse;
            char select_day = 'A';
            int index = lb_activeCourse.Text.IndexOf("-");
            string fixnumecourse = lb_activeCourse.Text.Substring(0, index);
            while (true)
            {
                //--------Name course check
                if ((lb_activeCourse.Text == ""))
                {
                    MessageBox.Show("You need choose course");      //empty textBox or not integer
                    break;
                }
                if (typeCourse_select.Contains("Lecture"))
                {
                    numberHoursCourse = courses_db.getNumHour(fixnumecourse, 1);
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
                    if (cb_hour.SelectedIndex == -1)
                    {
                        MessageBox.Show("You need to choose hour");
                        select_hour = 0;
                        break;
                    }
                    select_hour = cb_hour.SelectedIndex + 8;


                    if ((lb_class.Text == ""))
                    {
                        MessageBox.Show("You need choose class");      //No choose in ListBox
                        break;
                    }
                    select_class = lb_class.Text;

                    //----check lecturer
                    if ((lb_name_lecOrtut.Text == ""))
                    {
                        MessageBox.Show("You need choose lecturer");      //No choose in ListBox
                        break;
                    }
                    select_lec = lb_name_lecOrtut.Text;

                    //-------All detailse fine------
                    activecourse_db.Update_ActiveCourse(id_active_course, select_hour, select_day, select_class, select_lec);
                    this.Hide();
                    break;
                }
                else
                    break;
            }
        }
            
    

        private void panel_changeDateile_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_activeCourse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            L_detailCourse.Text = "";
            L_detailCourse.Text = activecourse_db.DetailsCourse(lb_activeCourse.Text);
            id_active_course = activecourse_db.GetIDActiveCourse(lb_activeCourse);
            typeCourse_select = activecourse_db.GetTypeActiveCourse(lb_activeCourse);
            
           lb_class.Items.Clear();
            cb_day.Items.Clear();
            cb_day.ResetText();
            cb_day.Items.Add('א');
            cb_day.Items.Add('ב');
            cb_day.Items.Add('ג');
            cb_day.Items.Add('ד');
            cb_day.Items.Add('ה');
            cb_day.Items.Add('ו');

            cb_hour.Items.Clear();
            cb_hour.ResetText();
            lb_name_lecOrtut.Items.Clear();
        }

        private void cb_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_hour.Items.Clear();
            cb_hour.ResetText();
            lb_name_lecOrtut.Items.Clear();
            lb_class.Items.Clear();

            int i;
            if (cb_day.SelectedIndex + 1 == 6)//friday
            {
                for (i = 8; i < 13; i++)
                    cb_hour.Items.Add(i);
            }
            else if (cb_day.SelectedIndex + 1 > 0)
            {
                for (i = 8; i < 21; i++)
                    cb_hour.Items.Add(i);
            }
        }

        private void cb_hour_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int day, hour;
            day = cb_hour.SelectedIndex + 1;
            hour = cb_hour.SelectedIndex + 8;
            int index = lb_activeCourse.Text.IndexOf("-");
            string fixnumecourse = lb_activeCourse.Text.Substring(0, index);

            if (typeCourse_select.Contains("Lecture") )
            {
                int numOfhoursOnCourse = courses_db.getNumHour(lb_activeCourse.Text, 1);    //1 for lec
                if (day == 6 && (hour + numOfhoursOnCourse > 13) || day != '6' && (hour + numOfhoursOnCourse > 21))
                {
                    lb_name_lecOrtut.Items.Clear();
                    lb_class.Items.Clear();
                    MessageBox.Show("Illegal hours");
                }
                else {
                    //--fill free class list
                    lb_class.Items.Clear();
                    lb_name_lecOrtut.Items.Clear();
                    activecourse_db.fillfreeclasses_listBox(lb_class, cb_day, cb_hour, lb_activeCourse, 1, courses_db, numOfhoursOnCourse);

                    //--fill lecturers that can study this cours and in this time
                    
                    lecturersdb.fillLecturers_list(lb_name_lecOrtut, fixnumecourse, day, hour, courses_db);
                    
                }
            }
        }




    }
}
