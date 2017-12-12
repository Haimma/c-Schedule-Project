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
    public partial class Requests_Lecturers2 : Form
    {
        private string id;
        private string fName;
        private string lName;
        private int Cancel;
        private string CourseName;
        private string Day;
        private int Hour;
        private string Classroom;
        private int Status;

        private UsersDB users_db;
        private LecturersDB lecturers_db;
        private User user;

        int ADD_LEC = 0, CANCELL = 1;

        private List<string> courses;

        /*
            Used only to creat a temporary object to get information.
        */
        public Requests_Lecturers2() { }
        public Requests_Lecturers2(string userName, String password)
        {
            InitializeComponent();
            //this.Show();
            users_db = new UsersDB();
            user = new User();
            users_db.FindUser(userName, password, ref user, "Lecturers");
            //MessageBox.Show(user.GetType() + user.GetUserType());

            string id = "";
            id = user.Get_ID();

            lecturers_db = new LecturersDB();
            lecturers_db.Get_Lecturer_Courses(this.cbo_Courses, id);
        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // Add Lecture Button
        private void button1_Click(object sender, EventArgs e)
        {
            Panel_Cancell_Lec.Visible = false;
            Panel_Lecturer_Requests_Main.Visible = false;

            
        }

        // Add Lecture - Cancell Button
        private void Add_Lecture_Menu_Button(object sender, EventArgs e)
        {
            Panel_Cancell_Lec.Visible = true;
            Panel_Lecturer_Requests_Main.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Cancell Lecture Button
        private void Cancell_Lecture_Menu_Button(object sender, EventArgs e)
        {
            Panel_Lecturer_Requests_Main.Visible = false;
            CoursesDB course_db = new CoursesDB();

            course_db.Get_Course_Days(user, cbo_Cancell_Day, cbo_Courses.SelectedText);


        }

        // Cancell Lecture - Cancell Button
        private void CancellLeq_Cancell_Button(object sender, EventArgs e)
        {
            Panel_Lecturer_Requests_Main.Visible = true;
            cbo_Cancell_Day.Items.Clear();
            cbo_Cancell_Day.ResetText();
            cbo_Courses.ResetText();

            cbo_Cancell_Hour.Items.Clear();
            cbo_Cancell_Hour.ResetText();
        }

        // Leturers Requests - Back Button
        private void Main_Back_Button(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Cancell Lecture - Original Day ComboBox
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string engLeteralDay = "";
            switch (cbo_Cancell_Day.Text)
            {
                case "'א": engLeteralDay = "A"; break;
                case "'ב": engLeteralDay = "B"; break;
                case "'ג": engLeteralDay = "C"; break;
                case "'ד": engLeteralDay = "D"; break;
                case "'ה": engLeteralDay = "E"; break;
                case "'ו": engLeteralDay = "F"; break;
            }
            ActiveCoursesDB actCourseDB = new ActiveCoursesDB();
            actCourseDB.Get_Course_Hours(cbo_Courses.Text, engLeteralDay, user.Get_First_Name(), user.Get_Last_Name(), cbo_Cancell_Hour);
        }

        // Cancell Lecture - Original Date Lable
        private void label7_Click(object sender, EventArgs e)
        {

        }

        // Cancell Lecture - Original Hour Lable
        private void label8_Click(object sender, EventArgs e)
        {

        }

        // Cancell Lecture - Main Title Lable
        private void label6_Click(object sender, EventArgs e)
        {

        }

        // Cancell Lecture - Original Hour ComboBox
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Cancell Lecture - Final Confirmation Button
        private void CancellLec_Final_Confirmation_Button(object sender, EventArgs e)
        {
            string day = "";
            string leteralDay = cbo_Cancell_Day.Text;

           
            if      (leteralDay == "'א") { day = "A"; }
            else if (leteralDay == "'ב") { day = "B"; }
            else if (leteralDay == "'ג") { day = "C"; }
            else if (leteralDay == "'ד") { day = "D"; }
            else if (leteralDay == "'ה") { day = "E"; }
            else if (leteralDay == "'ו") { day = "F"; }
            int hour = Convert.ToInt32(cbo_Cancell_Hour.Text);

            ActiveCoursesDB actCourseDB = new ActiveCoursesDB();
            string classroom = actCourseDB.Get_Course_Classroom(user.Get_First_Name(), user.Get_Last_Name(), cbo_Courses.Text, day, hour);
            Requests_LecturersDB reqLectDB = new Requests_LecturersDB();
            reqLectDB.Add_Request(user.Get_ID(), user.Get_First_Name(), user.Get_Last_Name(), CANCELL, cbo_Courses.Text, day, hour, classroom);
            Panel_Lecturer_Requests_Main.Visible = true;
            cbo_Cancell_Day.Items.Clear();
            cbo_Cancell_Day.ResetText();
            cbo_Courses.ResetText();

            cbo_Cancell_Hour.Items.Clear();
            cbo_Cancell_Hour.ResetText();
        }

        // Add Lecture - Day ComboBox
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_Hour.Items.Clear();
            cbo_Hour.ResetText();
            //cbo_Courses.Items.Clear();
            //cbo_Courses.ResetText();
            
            if (cbo_Day.SelectedIndex + 1 == 6)//friday
            {
                for (int i = 8; i < 13; i++)
                    cbo_Hour.Items.Add(i);
            }
            else if (cbo_Day.SelectedIndex + 1 > 0)
            {
                for (int i = 8; i < 21; i++)
                    cbo_Hour.Items.Add(i);
            }
        }

        // Add Lecture - Hour comboBox
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Add Lecture - Confirmation Button
        private void button4_Click(object sender, EventArgs e)
        {
            CoursesDB courses_db = new CoursesDB();
            ActiveCoursesDB actCourseDB = new ActiveCoursesDB();
            int day = cbo_Day.SelectedIndex + 1;
            int hour = cbo_Hour.SelectedIndex + 8;
            int numOfhoursOnCourse = courses_db.getNumHour(cbo_Courses.Text, 1);    // 1 for lecturer
            if (((day == 6) && (hour + numOfhoursOnCourse > 13)) || ((day != 6) && (hour + numOfhoursOnCourse > 21)))
            {
                MessageBox.Show("Illegal hours");
            }
            else
            {
                //--fill free class list
                List<string> free_classes = new List<string>();
                actCourseDB.Fill_Free_Classes_List(free_classes, cbo_Day.SelectedIndex + 1, Convert.ToInt32(cbo_Hour.Text), cbo_Courses.Text, 1, courses_db, "Lecture");
                Requests_LecturersDB reqLec = new Requests_LecturersDB();

                reqLec.Check_Classes(free_classes);
                try {
                    if (free_classes.Count == 0)
                        throw new NullReferenceException("There are no available classrooms.");

                    string LeteralDay = cbo_Day.Text;
                    if (LeteralDay == "'א") { LeteralDay = "A"; }
                    else if (LeteralDay == "'ב") { LeteralDay = "B"; }
                    else if (LeteralDay == "'ג") { LeteralDay = "C"; }
                    else if (LeteralDay == "'ד") { LeteralDay = "D"; }
                    else if (LeteralDay == "'ה") { LeteralDay = "E"; }
                    else if (LeteralDay == "'ו") { LeteralDay = "F"; }

                    reqLec.Add_Request(user.Get_ID(), user.Get_First_Name(), user.Get_Last_Name(), ADD_LEC, cbo_Courses.Text, LeteralDay, Convert.ToInt32(cbo_Hour.Text), free_classes[0]);
                }
                catch(NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            cbo_Day.ResetText();
            cbo_Hour.ResetText();
            cbo_Courses.ResetText();

            Panel_Cancell_Lec.Visible = true;
            Panel_Lecturer_Requests_Main.Visible = true;
        }

        // Lecturer Requests - Course Select ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void SetID(string id) { this.id = id; }
        public string GetID() { return id; }
        public void Set_FName(string fName) { this.fName = fName; }
        public string Get_FName() { return fName; }
        public void Set_LName(string lName) { this.lName = lName; }
        public string Get_LName() { return lName; }
        public void Set_Cancell(int cancel) { this.Cancel = cancel; }
        public int Get_Cancell() { return Cancel; }
        public void Set_CourseName(string CourseName) { this.CourseName = CourseName; }
        public string Get_CourseName() { return CourseName; }
        public void Set_Day(string Day) { this.Day = Day; }
        public string Get_Day() { return Day; }
        public void Set_Hour(int Hour) { this.Hour = Hour; }
        public int Get_Hour() { return Hour; }
        public void Set_Classroom(string Classroom) { this.Classroom = Classroom; }
        public string Get_Classroom() { return Classroom; }
        public void Set_Status(int Status) { this.Status = Status; }
        public int Get_Status() { return Status; }
    }
}
