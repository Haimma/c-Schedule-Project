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
    public partial class Lecturers_Appeals : Form
    {
        private Lecturer lecturer;

        private  List<Appeals_Student> appeals = new List<Appeals_Student>();
        private Appeals_StudentsDB appealsDB = new Appeals_StudentsDB();
        private LecturerToCoursesDB lecToCourseDB = new LecturerToCoursesDB();

        private List<int> grades = new List<int>();
        private StudentToCourseDB stdntToCourseDB = new StudentToCourseDB();

        private List<Student> students = new List<Student>();
        private StudentDB studentDB = new StudentDB();

        private int DENY = 0, CONFIRM = 1;

        public Lecturers_Appeals(Object o)
        {
            InitializeComponent();

            txtB_Title.Text = "קורס\t\tסטודנט\t\tציון";

            lecturer = (Lecturer)o;
            Initialise_Again();
        }

        public void Initialise_Again()
        {
            appeals = appealsDB.Get_Appeals_by_Lecturer_ID(lecturer.getID());
            int size = appeals.Count();
            for (int i = 0; i < size; i++)
            {
                students.Add(studentDB.Get_Student_By_ID(appeals[i].Get_Student_ID()));
            }
            grades = stdntToCourseDB.Get_Grade_By_Appeal(appeals);

            for (int i = 0; i < size; i++)
            {
                lstB_Appeals_List.Items.Add(appeals[i].Get_Course_Name() + "\t" + students[i].Get_Full_Name() + "\t\t" + grades[i]);
            }
        }

        private void btn_Confirm_Appeal_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string message = "";
            if (txtB_New_Grade.Text == "" || lstB_Appeals_List.SelectedItem == null)
            {
                flag = false;
                if (lstB_Appeals_List.SelectedItem == null)
                    message = ".לא נבחר ערעור";
                else if (txtB_New_Grade.Text == "")
                    message = ".לא הוזן ציון";
            }
            else if (Convert.ToInt32(txtB_New_Grade.Text) < 0 || Convert.ToInt32(txtB_New_Grade.Text) > 100)
            {
                message = ".ציון לא תקין";
                flag = false;
            }
            else
            {
                Update_All();
                flag = true;
            }
            if(!flag)
                MessageBox.Show("\nלא ניתן לבצע את הבקשה" + message);
        }

        private void Update_All()
        {
            appealsDB.Update_After_Lecturer_Review(CONFIRM, appeals[lstB_Appeals_List.SelectedIndex]);

            StudentsGradesDB Grades = new StudentsGradesDB();
            StudentDB UpdateStudent = new StudentDB();

            Grades.UpdateTime(students[lstB_Appeals_List.SelectedIndex].getID(), appeals[lstB_Appeals_List.SelectedIndex].Get_Course_Name(), Convert.ToInt32(txtB_New_Grade.Text));
            float NewAverage = Grades.GetStudentAverage(students[lstB_Appeals_List.SelectedIndex].getID());
            UpdateStudent.UpdateAverage(students[lstB_Appeals_List.SelectedIndex].getID(), NewAverage);

            lstB_Appeals_List.Items.Clear();
            lstB_Appeals_List.ResetText();
            Initialise_Again();
        }

        private void btn_Decline_Appeal_Click(object sender, EventArgs e)
        {
            appealsDB.Update_After_Lecturer_Review(DENY, appeals[lstB_Appeals_List.SelectedIndex]);
        }

        private void lstB_Appeals_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxtB_Reason.Text = appeals[lstB_Appeals_List.SelectedIndex].Get_Appeal();
        }
    }
}
