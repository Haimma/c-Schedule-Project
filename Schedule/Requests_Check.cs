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
    public partial class Requests_Check : Form
    {
        private int LecTut = -1; // 0 = Tutor, 1 = Lecturer.
        private const int DENY = 0, CONFIRM = 1;

        private Requests_LecturersDB reqLecDB = new Requests_LecturersDB();
        private List<Requests_Lecturers2> LecturerRequests;

        private Requests_TutorsDB reqTutDB = new Requests_TutorsDB();
        private List<Requests_Tutors> TutorRequests;

        private Requests_StudentsDB reqStuDB = new Requests_StudentsDB();
        private List<Requests_Students> StudentRequests;
        private List<Student> students;
        private List<ActiveCourses> OriginalCourse;
        private List<ActiveCourses> NewCourse;
        private ActiveCoursesDB activeCourseDB = new ActiveCoursesDB();

        public Requests_Check()
        {
            InitializeComponent();
            txtB_LecTut_Title.Text = "בקשה\tקורס\t        יום\t       שעה\t     כיתה";
        }

        private void lbl_StudentCourse_Click(object sender, EventArgs e)
        {

        }

        private void btn_LecturerReq_Click(object sender, EventArgs e)
        {
            cbo_LecTutReq_ID.Items.Clear();
            cbo_LecTutReq_ID.ResetText();
            lstB_LecTutReq.Items.Clear();
            lstB_LecTutReq.ResetText();

            LecTut = 1;
            pnl_Requests_Check.Visible = false;
            lbl_LecTutReq.Text = "בקשות מרצים";

            LecturerRequests = reqLecDB.Load_Lecturers();

            int size = LecturerRequests.Count();
            for (int i = 0; i < size; i++)
            {
                string id = LecturerRequests[i].GetID();
                if(!cbo_LecTutReq_ID.Items.Contains(id))
                    cbo_LecTutReq_ID.Items.Add(id);
            }
                
        }

        private void cbo_LecTutReq_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstB_LecTutReq.Items.Clear();
            lstB_LecTutReq.ResetText();

            txtB_LecTut_PName.Text = LecturerRequests[cbo_LecTutReq_ID.SelectedIndex].Get_FName();
            txtB_LecTutReq_LName.Text = LecturerRequests[cbo_LecTutReq_ID.SelectedIndex].Get_LName();

            Fill_LecTut_ListBox();
        }

        public void Fill_LecTut_ListBox()
        {
            int size = LecturerRequests.Count();
            string addOrCancel = "";
            string day = "";
            for (int i = 0; i < size; i++)
            {
                if (cbo_LecTutReq_ID.Text == LecturerRequests[i].GetID())
                {
                    if (LecturerRequests[i].Get_Cancell() == 0)
                        addOrCancel = "ביטול";
                    else addOrCancel = "הוספה";

                    day = ChangeToHebrewDay(LecturerRequests[i].Get_Day());

                    lstB_LecTutReq.Items.Add(addOrCancel + "\t" + LecturerRequests[i].Get_CourseName() + "\t\t" + day + "\t" + LecturerRequests[i].Get_Hour() + "\t" + LecturerRequests[i].Get_Classroom());
                }
            }
        }

        public string ChangeToHebrewDay(string day)
        {
            switch (day)
            {
                case "A": return "'א";
                case "B": return "ב'";
                case "C": return "ג'";
                case "D": return "ד'";
                case "E": return "ה'";
                case "F": return "ו'";
            }
            return null;
        }

        private void btn_TutorReq_Click(object sender, EventArgs e)
        {
            cbo_LecTutReq_ID.Items.Clear();
            cbo_LecTutReq_ID.ResetText();
            lstB_LecTutReq.Items.Clear();
            lstB_LecTutReq.ResetText();
            
            LecTut = 0;
            pnl_LecTutReq.Visible = true;
            pnl_Requests_Check.Visible = false;
            lbl_LecTutReq.Text = "בקשות מתרגלים";

            TutorRequests = reqTutDB.Load_Tutors();

            int size = TutorRequests.Count();
            for (int i = 0; i < size; i++)
            {
                string id = TutorRequests[i].GetID();
                if (!cbo_LecTutReq_ID.Items.Contains(id))
                    cbo_LecTutReq_ID.Items.Add(id);
            }
        }

        private void btn_LecTutReq_Confirm_Click(object sender, EventArgs e)
        {
            if (Is_Request_Selected(lstB_LecTutReq))
            {
                if (LecTut == 0)
                    reqTutDB.Confirm_Deny_Request(TutorRequests[lstB_LecTutReq.SelectedIndex], CONFIRM);
                else if (LecTut == 1)
                    reqLecDB.Confirm_Deny_Request(LecturerRequests[lstB_LecTutReq.SelectedIndex], CONFIRM);
            }
            else MessageBox.Show("לא נבחרה בקשה לאישור");

            lstB_LecTutReq.Items.Clear();
            lstB_LecTutReq.ResetText();
            LecturerRequests = reqLecDB.Load_Lecturers();
            Fill_LecTut_ListBox();
        }

        private void btn_LecTutReq_Deny_Click(object sender, EventArgs e)
        {
            if (Is_Request_Selected(lstB_LecTutReq))
            {
                if (LecTut == 0)
                    reqTutDB.Confirm_Deny_Request(TutorRequests[lstB_LecTutReq.SelectedIndex], DENY);
                else if (LecTut == 1)
                    reqLecDB.Confirm_Deny_Request(LecturerRequests[lstB_LecTutReq.SelectedIndex], DENY);
            }
            else MessageBox.Show("לא נבחרה בקשה לדחייה");

            lstB_LecTutReq.Items.Clear();
            lstB_LecTutReq.ResetText();
            LecturerRequests = reqLecDB.Load_Lecturers();
            Fill_LecTut_ListBox();
        }

        private void btn_LecTutReq_Back_Click(object sender, EventArgs e)
        {
            pnl_Requests_Check.Visible = true;
            cbo_LecTutReq_ID.Items.Clear();
            cbo_LecTutReq_ID.ResetText();
            lstB_LecTutReq.Items.Clear();
            lstB_LecTutReq.ResetText();
            txtB_LecTutReq_LName.Clear();
            txtB_LecTutReq_LName.ResetText();
            txtB_LecTut_PName.Clear();
            txtB_LecTut_PName.ResetText();
        }

        private void btn_StudentReq_Click(object sender, EventArgs e)
        {
            
            StudentRequests = reqStuDB.Load_Students(ref students);
            txtB_LName_StudentReq.Clear();
            txtB_LName_StudentReq.ResetText();
            txtB_PName_StudentReq.Clear();
            txtB_PName_StudentReq.ResetText();

            pnl_Requests_Check.Visible = false;
            pnl_LecTutReq.Visible = false;
            txtB_StudentReq_Title.Text = "בקשה\tסוג\tיום\tכיתה\tהתחלה\tסוף\tמרצה\t קורס";
            
            int size = StudentRequests.Count();
            for (int i = 0; i < size; i++)
            {
                string id = StudentRequests[i].Get_ID();
                if (!cbo_ID_StudentReq.Items.Contains(id))
                    cbo_ID_StudentReq.Items.Add(id);
            }
        }

        private void txtB_StudentReq_Title_TextChanged(object sender, EventArgs e)
        {

        }

        private Student student;
        private void cbo_ID_StudentReq_SelectedIndexChanged(object sender, EventArgs e)
        {
            OriginalCourse = new List<ActiveCourses>();
            NewCourse = new List<ActiveCourses>();
            lstB_StudentReq.Items.Clear();
            lstB_StudentReq.ResetText();

            for (int k = 0; k < students.Count(); k++)
                if (students[k].getID() == cbo_ID_StudentReq.Text)
                {
                    student = students[k];
                    break;
                }

            txtB_PName_StudentReq.Text = student.getFirstName();
            txtB_LName_StudentReq.Text = student.getLastName();

            int i = 0;
            for(int j = 0; j < StudentRequests.Count(); j++)
            {
                if (students[j].getID() == cbo_ID_StudentReq.Text)
                {
                    OriginalCourse.Add(activeCourseDB.Get_Courses_By_ID(StudentRequests[j].Get_OriginalCourseID()));
                    NewCourse.Add(activeCourseDB.Get_Courses_By_ID(StudentRequests[j].Get_NewCourseID()));

                    string day = ChangeToHebrewDay(OriginalCourse[i].Get_Day());
                    lstB_StudentReq.Items.Add("מקור:    " + OriginalCourse[i].Get_Type() + day + "\t" + OriginalCourse[i].Get_Classroom() + "\t" + OriginalCourse[i].Get_Start() + "\t" + (OriginalCourse[i].Get_Length() + OriginalCourse[i].Get_Start()) + "   " + OriginalCourse[i].Get_Lecturer_Full_Name() + "\t" + OriginalCourse[i].Get_Name());
                    day = ChangeToHebrewDay(NewCourse[i].Get_Day());
                    lstB_StudentReq.Items.Add("בקשה:  " + NewCourse[i].Get_Type() + day + "\t" + NewCourse[i].Get_Classroom() + "\t" + NewCourse[i].Get_Start() + "\t" + (NewCourse[i].Get_Length() + NewCourse[i].Get_Start()) + "   " + NewCourse[i].Get_Lecturer_Full_Name() + "\t" + NewCourse[i].Get_Name());
                    i++;
                }
            }
        }

        private void btn_StudentReq_Back_Click(object sender, EventArgs e)
        {
            pnl_Requests_Check.Visible = true;
            pnl_LecTutReq.Visible = true;
            cbo_ID_StudentReq.Items.Clear();
            cbo_ID_StudentReq.ResetText();
            txtB_LName_StudentReq.Clear();
            txtB_LName_StudentReq.ResetText();
            txtB_PName_StudentReq.Clear();
            txtB_PName_StudentReq.ResetText();
            lstB_StudentReq.Items.Clear();
            lstB_StudentReq.ResetText();
        }

        private void btn_StudentReq_Confirm_Click(object sender, EventArgs e)
        {
            Update_Database(CONFIRM);
        }

        private void btn_StudentReq_Decline_Click(object sender, EventArgs e)
        {
            Update_Database(DENY);
        }

        private void Find_Linked_Index(int selected_index, ref int[] CourseIndexes)
        {
            if (selected_index % 2 == 0)
            {
                CourseIndexes[0] = selected_index;
                CourseIndexes[1] = selected_index + 1;
            }
            else if (selected_index % 2 == 1)
            {
                CourseIndexes[0] = selected_index - 1;
                CourseIndexes[1] = selected_index;
            }
        }

        private void Update_Database(int ConfirmDeny)
        {
            int[] CourseIndexes = new int[2]; // [0] = Original, [1] = New;
            Find_Linked_Index(lstB_StudentReq.SelectedIndex, ref CourseIndexes);

            int OriginalCourseID = StudentRequests[cbo_ID_StudentReq.SelectedIndex].Get_OriginalCourseID();
            int Get_NewCourseID = StudentRequests[cbo_ID_StudentReq.SelectedIndex].Get_NewCourseID();
            string OriginalCourseName = OriginalCourse[CourseIndexes[0]].Get_Name();
            string NewCourseName = NewCourse[CourseIndexes[0]].Get_Name();
            reqStuDB.Update_Request(OriginalCourseID, Get_NewCourseID, cbo_ID_StudentReq.Text, ConfirmDeny, OriginalCourseName, NewCourseName);
        }

        private void btn_ReqCheck_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool Is_Request_Selected(ListBox requests)
        {
            if (requests.SelectedItem != null)
                return true;
            return false;
        }
    }
}
