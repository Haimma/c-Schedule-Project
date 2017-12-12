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
    public partial class SecretaryMenu : Form
    {
        private Secretary secretary;
        public SecretaryMenu(Object sec)
        {
            InitializeComponent();

            this.secretary = (Secretary)sec;
            l_name.Text += secretary.getFirstName() + " " + secretary.getLastName();

            List<string> ListOptions = new List<string>();
            ListOptions.Add("הוספת הרצאה");
            ListOptions.Add("הוספת תרגול");
            ListOptions.Add("הוספת סטודנט");
            ListOptions.Add("הוספת מרצה");
            ListOptions.Add("הוספת מתרגל");
            ListOptions.Add("הוספת מזכירה");
            ListOptions.Add("הוספת מבחן ללוח בחינות");
            ListOptions.Add("קביעת מועד מיוחד למבחן");
            ListOptions.Add("שיבוץ סטודנטים למבחן");
            ListOptions.Add("צפייה במערכת");
            ListOptions.Add("צפייה במכסת שעות נוכחית");
            ListOptions.Add("צפייה ברשימת סטודנטים");
            ListOptions.Add("צפייה ברשימת קורסים לפי סמסטר");
            ListOptions.Add("שינויים במערכת");
            ListOptions.Add("ניהול קורס");
            ListOptions.Add("עדכון פרטים אישיים");
            ListOptions.Add("הודעות אישיות");
            ListOptions.Add("שיבוץ סטודנטים לקורס");



            foreach (string Op in ListOptions)
            {
                lb_options.Items.Add(Op);
            }
        }

        private void lb_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void b_confirm_Click(object sender, EventArgs e)
        {



            string option_selected = lb_options.Text;
            switch (option_selected)
            {
                case "הוספת הרצאה":                    
                    this.Hide();
                    new OpenCourse("Lecture").ShowDialog();
                    this.Show();
                    break;
                case "הוספת תרגול":
                    this.Hide();
                    new OpenCourse("Tutore").ShowDialog();
                    this.Show();
                    break;
                case "הוספת סטודנט":
                    this.Hide();
                    new addStudent().ShowDialog();
                    this.Show();
                    break;
                case "הוספת מרצה":
                    this.Hide();
                    new addLacturer().ShowDialog();
                    this.Show();
                    break;
                case "הוספת מתרגל":
                    this.Hide();
                    new addTutor().ShowDialog();
                    this.Show();
                    break;
                case "הוספת מזכירה":
                    this.Hide();
                    new addSecretary().ShowDialog();
                    this.Show();
                    break;
                case "הוספת מבחן ללוח בחינות":
                    this.Hide();
                    new SetDateForTest().ShowDialog();
                    this.Show();
                    break;
                case "קביעת מועד מיוחד למבחן":
                    this.Hide();
                    new AddSpecialDateExtraExam().ShowDialog();
                    this.Show();
                    break;
                case "שיבוץ סטודנטים למבחן":
                    this.Hide();
                    new AssignmentStudentToTest().ShowDialog();
                    this.Show();
                    break;
                case "צפייה במערכת":
                    this.Hide();
                    new viewShSec(l_name.Text).ShowDialog(); ////full name
                    this.Show();
                    break;
                case "צפייה במכסת שעות נוכחית":
                    this.Hide();
                    new DisplayAmountHoursSecrt_Depar().ShowDialog();
                    this.Show();
                    break;
                case "צפייה ברשימת סטודנטים":
                    this.Hide();
                    new Students_List_S_DM().ShowDialog();
                    this.Show();
                    break;
                case "צפייה ברשימת קורסים לפי סמסטר":
                    this.Hide();
                    new DisplayCoursesBySemester().ShowDialog();
                    this.Show();
                    break;
                case "שינויים במערכת":
                    this.Hide();
                    new Requests_Check().ShowDialog();
                    this.Show();
                    break;
               
                case "ניהול קורס":
                    this.Hide();
                    new ManagementCourses().ShowDialog();
                    this.Show();
                    break;
                case "עדכון פרטים אישיים":
                    this.Hide();
                    new  Update_User_Info(this.secretary).ShowDialog();       ////////////
                    this.Show();
                    break;
                case "הודעות אישיות":
                    this.Hide();
                    new Readmess(secretary.getID()).ShowDialog();
                    this.Show();
                    break;
                case "שיבוץ סטודנטים לקורס":
                    this.Hide();
                    new  studentToCourse().ShowDialog();
                    this.Show();
                    break;
                default:
                    MessageBox.Show("Please choose option!");
                    break;

            }


        }

        private void SecretaryMenu_Load(object sender, EventArgs e)
        {

        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
