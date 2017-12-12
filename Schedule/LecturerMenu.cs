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
    public partial class LecturerMenu : Form
    {
        private Lecturer lecturer;
        public LecturerMenu(Object lec)
        {
            

            InitializeComponent();

            this.lecturer = (Lecturer)lec;
            l_name.Text += lecturer.getFirstName() + " " + lecturer.getLastName();

            List<string> ListOptions = new List<string>();
            ListOptions.Add("צפייה במערכת");
            ListOptions.Add("שינויים במערכת למרצה");
            ListOptions.Add("העדפות מרצה");
            ListOptions.Add("צפייה במכסת שעות נוכחית");
            ListOptions.Add("צפייה ברשימת סטודנטים לקורס");
            ListOptions.Add("הזנת ציונים");
            ListOptions.Add("אישור או דחייה של עירעור על ציון מבחן");
            ListOptions.Add("צפייה ברשימת קורסים לפי סמסטר");
            ListOptions.Add("הודעות אישיות");
            ListOptions.Add("שינוי פרטים אישיים");


            foreach (string Op in ListOptions)
            {
                lb_options.Items.Add(Op);
            }
        }

        private void LecturerMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            string option_selected = lb_options.Text;
            switch (option_selected)
            {
                case "צפייה במערכת":
                    this.Hide();
                    new viewShL(lecturer.getFirstName(),lecturer.getID()).ShowDialog();         ////////////
                    this.Show();
                    break;
                case "שינויים במערכת למרצה":
                    this.Hide();
                    new Requests_Lecturers2(lecturer.getUserName(),lecturer.getPassword()).ShowDialog();         ////////////
                    this.Show();
                    break;
                case "העדפות מרצה":
                    this.Hide();
                    new LecturerPreferences(lecturer.getID()).ShowDialog();               ////////////////////
                    this.Show();
                    break;
                case "צפייה במכסת שעות נוכחית":
                    this.Hide();
                    new DisplayAmountHoursLecturer(this.lecturer.getID()).ShowDialog();
                    this.Show();
                    break;
                case "צפייה ברשימת קורסים לפי סמסטר":
                    this.Hide();
                    new DisplayCoursesBySemester().ShowDialog();
                    this.Show();
                    break;
                case "הודעות אישיות":  ///
                    this.Hide();
                    new Readmess(lecturer.getID()).ShowDialog();
                    this.Show();
                    break;
                case "הזנת ציונים":
                    this.Hide();
                    new InsertStudentGrades(lecturer.getFirstName()+" "+lecturer.getLastName()).ShowDialog();      ////////////
                    this.Show();
                    break;
                case "אישור או דחייה של עירעור על ציון מבחן":           ///
                    this.Hide();
                    new  Lecturers_Appeals(lecturer).ShowDialog();     ////////////
                    this.Show();
                    break;
                case "צפייה ברשימת סטודנטים לקורס":           ///
                    this.Hide();
                    new StudentsList_L_T(lecturer.getFirstName() + " " +lecturer.getLastName()).ShowDialog();
                    this.Show();
                    break;
                case "שינוי פרטים אישיים":
                    this.Hide();
                    new  Update_User_Info(this.lecturer).ShowDialog();       ////////////
                    this.Show();
                    break;

                default:
                    MessageBox.Show("Please choose option!");
                    
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
