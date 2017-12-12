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
    public partial class Requests_Students : Form
    {
        private string ID;
        private int OriginalCourseID;
        private int NewCourseID;
        private int Status;

        private string[] type = new string[2] { "Tutore", "Lecture" };
        private int Lecture_Or_Tuition = -1; // 1 = Lecture, 0 = Tuition

        List<int> courseID = new List<int>();
        List<int> AltCourseID = new List<int>();

        private Student student = new Student();

        private StudentToCourseDB stdntToCourseDB = new StudentToCourseDB();

        private string lecOrTutHeb = "";

        /*
           Used only to creat a temporary object to get information.
       */
        public Requests_Students() { }
        public Requests_Students(Object stdnt)
        {
            InitializeComponent();
            
            this.student = (Student)stdnt;

            //if (Lecture_Or_Tuition == 0)
            //    pnl_Tutorlbl.Visible = true;
            //else if (Lecture_Or_Tuition == 1)
            //    pnl_Tutorlbl.Visible = false;

            txtB_AltCourse_Title.ReadOnly = true;
            //txtBox_LecturerOrTutor.ReadOnly = true;
            //txtBox_Original_Day.ReadOnly = true;
            //txtBox_Original_Ends.ReadOnly = true;
            //txtBox_Original_Start.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        string selectedCourse = "";

        private void cbo_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedCourse != cbo_Course.Text)
            {
                lstBox_Alternatives.Items.Clear();
                stdntToCourseDB.Fill_Current_Course_Data(courseID[cbo_Course.SelectedIndex], txtBox_Original_Day, txtBox_Original_Start, txtBox_Original_Ends, txtBox_LecturerOrTutor, type[Lecture_Or_Tuition]);
                AltCourseID = stdntToCourseDB.Fill_Alternative_Courses(lstBox_Alternatives, courseID[cbo_Course.SelectedIndex], cbo_Course.Text, type[Lecture_Or_Tuition]);
            }
        }

        private void Lable_Original_Start_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstBox_Alternatives.SelectedItem != null)
            {
                Requests_StudentsDB reqStdntDB = new Requests_StudentsDB();
                reqStdntDB.Add_Request(student, courseID[cbo_Course.SelectedIndex], AltCourseID[lstBox_Alternatives.SelectedIndex]);
            }
            else MessageBox.Show("לא נבחר קורס");
        }

        private void pnl_Tutorlbl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_ChangeLecture_Click(object sender, EventArgs e)
        {
            //courseID = new List<int>();
            //selectedCourse = "";
            //lecOrTutHeb = "מרצה";
            //txtB_AltCourse_Title.Text = lecOrTutHeb + "\t\tיום" + "\tשעות" + "\tכיתה";

            //pnl_ChangeTuition.Visible = false;
            //pnl_Tutorlbl.Visible = false;
            //pnl_StudentRequests.Visible = false;
            //Lecture_Or_Tuition = 1;
            //stdntToCourseDB.GetCoursesID(cbo_Course, ref courseID, student.getID(), type[Lecture_Or_Tuition]);
        }

        private void btn_ChangeTuition_Click(object sender, EventArgs e)
        {
            //selectedCourse = "";
            //lecOrTutHeb = "מתרגל";
            //txtB_AltCourse_Title.Text = lecOrTutHeb + "\t\tיום" + "\tשעות" + "\tכיתה";
            
            //courseID = new List<int>();
            //pnl_ChangeTuition.Visible = true;
            //pnl_Tutorlbl.Visible = true;
            //pnl_StudentRequests.Visible = false;
            //Lecture_Or_Tuition = 0;
            //stdntToCourseDB.GetCoursesID(cbo_Course, ref courseID, student.getID(), type[Lecture_Or_Tuition]);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            selectedCourse = "";
            pnl_StudentRequests.Visible = true;
            panel_Student_Request.Visible = true;
            cbo_Course.Items.Clear();
            cbo_Course.ResetText();

            //txtBox_Original_Day.ResetText();
            //txtBox_Original_Ends.ResetText();
            //txtBox_Original_Start.ResetText();
            //txtBox_LecturerOrTutor.ResetText();

            lstBox_Alternatives.Items.Clear();
        }


        public void Set_ID(string ID) { this.ID = ID; }
        public string Get_ID() { return ID; }
        public void Set_OriginalCourseID(int o_id) { this.OriginalCourseID = o_id; }
        public int Get_OriginalCourseID() { return OriginalCourseID; }
        public void Set_NewCourseID(int n_id) { this.NewCourseID = n_id; }
        public int Get_NewCourseID() { return NewCourseID; }
        public void Set_Status(int s) { this.Status = s; }
        public int Get_Status() { return Status; }

        private void Requests_Students_Load(object sender, EventArgs e)
        {

        }

        private void btn_Tuition_Click(object sender, EventArgs e)
        {
            selectedCourse = "";
            lecOrTutHeb = "מתרגל";
            txtB_AltCourse_Title.Text = lecOrTutHeb + "\t\tיום" + "\tשעות" + "\tכיתה";

            panel_Student_Request.Visible = false;
            courseID = new List<int>();
            pnl_ChangeTuition.Visible = true;
            pnl_Tutorlbl.Visible = true;
            pnl_StudentRequests.Visible = false;
            Lecture_Or_Tuition = 0;
            stdntToCourseDB.GetCoursesID(cbo_Course, ref courseID, student.getID(), type[Lecture_Or_Tuition]);
        }

        private void btn_Lecture_Click(object sender, EventArgs e)
        {
            courseID = new List<int>();
            selectedCourse = "";
            lecOrTutHeb = "מרצה";
            txtB_AltCourse_Title.Text = lecOrTutHeb + "\t\tיום" + "\tשעות" + "\tכיתה";

            panel_Student_Request.Visible = false;
            pnl_ChangeTuition.Visible = false;
            pnl_Tutorlbl.Visible = false;
            pnl_StudentRequests.Visible = false;
            Lecture_Or_Tuition = 1;
            stdntToCourseDB.GetCoursesID(cbo_Course, ref courseID, student.getID(), type[Lecture_Or_Tuition]);
        }

        private void btn_Main_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
