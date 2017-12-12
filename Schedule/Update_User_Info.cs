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
    public partial class Update_User_Info : Form
    {

        private bool admin = false;

        List<Lecturer> lecturers_lst;
        List<Tutor> tutors_lst;
        List<Student> students_lst;
        List<Secretary> secreatarys_lst;

        private Lecturer lecturer;
        private LecturersDB lecDB;

        private Tutor tutor;
        private TutorsDB tutDB;

        private Student student;
        private StudentDB stuDB;

        private Secretary secretary;
        private SecretarysDB secDB;

        private DepartmentManager deptMngr;

        private string message = "";

        public Update_User_Info(Object user)
        {
            InitializeComponent();

            SetUser(user);
        }

        private void SetUser(Object user)
        {
            Person[] p = { new Lecturer(), new Tutor(), new Student(), new Secretary(), new DepartmentManager() , new Junior(), new Professor(), new Doctor()};

            if (user.GetType() == p[0].GetType() || user.GetType() == p[5].GetType() || user.GetType() == p[6].GetType() || user.GetType() == p[7].GetType())
            {
                pnl_User_Select.Visible = false;
                pnl_Update_Main.Visible = false;
                Set_Lecturer((Lecturer)user);
            }
            else if (user.GetType() == p[1].GetType())
            {
                pnl_User_Select.Visible = false;
                pnl_Update_Main.Visible = false;
                Set_Tutor((Tutor)user);
            }
            else if (user.GetType() == p[2].GetType())
            {
                pnl_User_Select.Visible = false;
                pnl_Update_Main.Visible = false;
                Set_Student((Student)user);
            }
            else if (user.GetType() == p[3].GetType())
            {
                pnl_User_Select.Visible = false;
                pnl_Update_Main.Visible = false;
                Set_Secretary((Secretary)user);
                admin = true;
                pnl_Update_Main.Visible = true;
                pnl_User_Select.Visible = true;
            }
            else if (user.GetType() == p[4].GetType())
            {
                deptMngr = (DepartmentManager)user;
                cbo_Choose_User.Items.Add("מזכירה");
                admin = true;
                pnl_Update_Main.Visible = true;
                pnl_User_Select.Visible = true;
            }
        }

        private void Set_Lecturer(Lecturer lec)
        {
            lecturer = lec;
            lecDB = new LecturersDB();
            lecturers_lst = new List<Lecturer>();
            lbl_Update.Text = "עדכון מרצה";
        }

        private void Set_Tutor(Tutor tut)
        {
            tutor = tut;
            tutDB = new TutorsDB();
            tutors_lst = new List<Tutor>();
            lbl_Update.Text = "עדכון מתגרל";
        }

        private void Set_Student(Student stu)
        {
            student = stu;
            stuDB = new StudentDB();
            students_lst = new List<Student>();
            lbl_Update.Text = "עדכון סטודנט";
        }

        private void Set_Secretary(Secretary sec)
        {
            secretary = sec;
            secDB = new SecretarysDB();
            secreatarys_lst = new List<Secretary>();
            lbl_Update.Text = "עדכון מזכירה";
        }

        private void btn_Lecturer_Address_Confirm_Click(object sender, EventArgs e)
        {
            if (txtB_Address_New.Text.Length > 0 || Check_Letters_And_Numbers_Only(txtB_Address_New.Text))
            {
                if(lecturer != null)
                    lecDB.Update_Address(txtB_Address_New.Text, lecturer.getID());
                else if (tutor != null)
                    tutDB.Update_Address(txtB_Address_New.Text, tutor.getID());
                else if (student != null)
                    stuDB.Update_Address(txtB_Address_New.Text, student.getID());
                else if (secretary != null)
                    secDB.Update_Address(txtB_Address_New.Text, secretary.getID());
                btn_Address_Cancell.PerformClick();
            }
                
            else MessageBox.Show("כתובת בלתי חוקית");
        }

        private void btn_Lecturer_Address_Click(object sender, EventArgs e)
        {
            pnl_Update.Visible = false;
        }

        private void btn_Lecturer_Password_Click(object sender, EventArgs e)
        {
            pnl_Update.Visible = false;
            pnl_Address.Visible = false;
        }

        private void btn_Lecturer_Address_Cancell_Click(object sender, EventArgs e)
        {
            pnl_Update.Visible = true;
        }

        private void btn_LecturerPassword_Cancel_Click(object sender, EventArgs e)
        {
            pnl_Update.Visible = true;
            pnl_Address.Visible = true;
        }

        private void btn_Lecturer_Main_Back_Click(object sender, EventArgs e)
        {
            if (lecturer != null)
            {
                lecturer = null;
                lecDB = null;
            }
            else if (tutor != null)
            {
                tutor = null;
                tutDB = null;
            }
            else if (student != null)
            {
                student = null;
                stuDB = null;
            }
            else if(secretary != null && admin == false)
            {
                secretary = null;
                secDB = null;
            }

            if (admin)
            {
                pnl_User_Select.Visible = true;
                txtB_User_Select_LName.Clear();
                txtB_User_Select_LName.ResetText();
                txtB_User_Select_PName.Clear();
                txtB_User_Select_PName.ResetText();
                cbo_User_Select_ID.ResetText();
                cbo_User_Select_ID.Items.Clear();

                Load_Users();
            }
        }

        private void txtB_LecturerNewPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_LecturerPassword_Confirm_Click(object sender, EventArgs e)
        {
            UsersDB userDB = new UsersDB();
            if (Check_Password()) {
                if (lecturer != null)
                {
                    lecDB.Update_Password(txtB_Password_New.Text, lecturer.getID());
                    userDB.Update_Password(txtB_Password_New.Text, lecturer.getID());
                }
                else if (tutor != null)
                {
                    tutDB.Update_Password(txtB_Password_New.Text, tutor.getID());
                    userDB.Update_Password(txtB_Password_New.Text, tutor.getID());
                }
                else if (student != null)
                {
                    stuDB.Update_Password(txtB_Password_New.Text, student.getID());
                    userDB.Update_Password(txtB_Password_New.Text, student.getID());
                }
                else if (secretary != null)
                {
                    secDB.Update_Password(txtB_Password_New.Text, secretary.getID());
                    userDB.Update_Password(txtB_Password_New.Text, secretary.getID());
                }
                
            }
            else MessageBox.Show(":סיסמא לא חוקית\n" + message);
        }

        private bool Check_Password()
        {
            if (txtB_Password_New.Text.Length == 8)
            {
                if (Check_Letters_And_Numbers_Only(txtB_Password_New.Text))
                    return true;
            }
            else message = ".אורך הסיסמא חייב להיות 8 תווים בלבד";
            return false;
        }

        private bool Check_Letters_And_Numbers_Only(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= (int)'0' && (int)s[i] <= '9')))
                {
                    message = s[i] + " :תו לא חוקי" + "\nניתן להזין רק תווים באנגלית ומספרים בלבד.";
                    return false;
                }
            }
            return true;
        }

        private void btn_User_Select_Confirm_Click(object sender, EventArgs e)
        {
            if (cbo_User_Select_ID.Text != "")
            {
                if (lecturers_lst != null)
                    Set_Lecturer(lecturers_lst[cbo_User_Select_ID.SelectedIndex]);
                else if (tutors_lst != null)
                    Set_Tutor(tutors_lst[cbo_User_Select_ID.SelectedIndex]);
                else if (students_lst != null)
                    Set_Student(students_lst[cbo_User_Select_ID.SelectedIndex]);
                else if (secreatarys_lst != null)
                    Set_Secretary(secreatarys_lst[cbo_User_Select_ID.SelectedIndex]);
                pnl_User_Select.Visible = false;
            }
            else MessageBox.Show("לא נבחרה תעודת זהות");
        }

        private void cbo_User_Select_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lecturers_lst != null)
            {
                txtB_User_Select_PName.Text = lecturers_lst[cbo_User_Select_ID.SelectedIndex].getFirstName();
                txtB_User_Select_LName.Text = lecturers_lst[cbo_User_Select_ID.SelectedIndex].getLastName();
            }
            else if (tutors_lst != null && tutors_lst.Count() > 0)
            {
                txtB_User_Select_PName.Text = tutors_lst[cbo_User_Select_ID.SelectedIndex].getFirstName();
                txtB_User_Select_LName.Text = tutors_lst[cbo_User_Select_ID.SelectedIndex].getLastName();
            }
            else if (students_lst != null && students_lst.Count() > 0)
            {
                txtB_User_Select_PName.Text = students_lst[cbo_User_Select_ID.SelectedIndex].getFirstName();
                txtB_User_Select_LName.Text = students_lst[cbo_User_Select_ID.SelectedIndex].getLastName();
            }
            else if (secreatarys_lst != null && secreatarys_lst.Count() > 0)
            {
                txtB_User_Select_PName.Text = secreatarys_lst[cbo_User_Select_ID.SelectedIndex].getFirstName();
                txtB_User_Select_LName.Text = secreatarys_lst[cbo_User_Select_ID.SelectedIndex].getLastName();
            }
        }

        private void btn_Main_Confirm_Click(object sender, EventArgs e)
        {
            Load_Users();
        }
        
        private void Load_Users()
        {
            if (cbo_Choose_User.Text != "")
            {
                pnl_Update_Main.Visible = false;
                if (cbo_Choose_User.SelectedItem.ToString() == "מרצה")
                {
                    Load_Lecturer_List();
                }
                else if (cbo_Choose_User.SelectedItem.ToString() == "מתרגל")
                {
                    Load_Tutor_List();
                }
                else if (cbo_Choose_User.SelectedItem.ToString() == "סטודנט")
                {
                    Load_Student_List();
                }
                else if (cbo_Choose_User.SelectedItem.ToString() == "מזכירה")
                {
                    Load_Secretary_List();
                }
            }
            else MessageBox.Show("לא נבחר סוג משתמש");
        }

        private void Load_Lecturer_List()
        {
            int size = 0;
            tutDB = null;
            stuDB = null;
            secDB = null;

            lecDB = new LecturersDB();
            lecturers_lst = lecDB.Get_All_Lecturers();
            size = lecturers_lst.Count();
            for (int i = 0; i < size; i++)
                cbo_User_Select_ID.Items.Add(lecturers_lst[i].getID());
        }

        private void Load_Tutor_List()
        {
            int size = 0;
            lecDB = null;
            stuDB = null;
            secDB = null;

            tutDB = new TutorsDB();
            tutors_lst = tutDB.Get_All_Tutors();
            size = tutors_lst.Count();
            for (int i = 0; i < size; i++)
                cbo_User_Select_ID.Items.Add(tutors_lst[i].getID());
        }

        private void Load_Student_List()
        {
            int size = 0;
            lecDB = null;
            tutDB = null;
            secDB = null;

            stuDB = new StudentDB();
            students_lst = stuDB.Get_All_Students();
            size = students_lst.Count();
            for (int i = 0; i < size; i++)
                cbo_User_Select_ID.Items.Add(students_lst[i].getID());
        }

        private void Load_Secretary_List()
        {
            int size = 0;
            lecDB = null;
            tutDB = null;
            stuDB = null;

            secDB = new SecretarysDB();
            secreatarys_lst = secDB.Get_All_Secretary();
            size = secreatarys_lst.Count();
            for (int i = 0; i < size; i++)
                cbo_User_Select_ID.Items.Add(secreatarys_lst[i].getID());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_Update_Main.Visible = false;
            pnl_User_Select.Visible = false;
            lecturer = null;
            tutor = null;
            student = null;
            lecDB = null;
            tutDB = null;
            stuDB = null;
            
        }

        private void btn_User_Select_Back_Click(object sender, EventArgs e)
        {
            lecturers_lst = null;
            tutors_lst = null;
            students_lst = null;
            secreatarys_lst = null;
            pnl_Update_Main.Visible = true;

            cbo_User_Select_ID.Items.Clear();
            cbo_User_Select_ID.ResetText();
            txtB_User_Select_LName.Clear();
            txtB_User_Select_LName.ResetText();
            txtB_User_Select_PName.Clear();
            txtB_User_Select_PName.ResetText();
            cbo_Choose_User.ResetText();
        }

        private void cbo_Choose_User_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Main_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
