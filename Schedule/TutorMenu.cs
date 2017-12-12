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
    public partial class TutorMenu : Form
    {
        private Tutor tutor;
        public TutorMenu(Object tut)
        {
            InitializeComponent();

            this.tutor = (Tutor)tut;
            l_name.Text += tutor.getFirstName() + " " + tutor.getLastName();

            List<string> ListOptions = new List<string>();
            ListOptions.Add("צפייה במערכת");        ///
            ListOptions.Add("שינויים במערכת למתרגל");    //
            ListOptions.Add("העדפות מתרגל");                //
            ListOptions.Add("צפייה במכסת שעות נוכחית"); ///
            ListOptions.Add("צפייה ברשימת סטודנטים לקורס"); //
            ListOptions.Add("צפייה ברשימת קורסים לפי סמסטר");       //
            ListOptions.Add("הודעות אישיות");
            ListOptions.Add("עדכון פרטים אישיים");


            foreach (string Op in ListOptions)
            {
                lb_options.Items.Add(Op);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TutorMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string option_selected = lb_options.Text;
            switch (option_selected)
            {
                case "צפייה במערכת":
                    this.Hide();
                    new viewShT(l_name.Text, tutor.getID()).ShowDialog();         ////////////
                    this.Show();
                    break;
                case "שינויים במערכת למתרגל":
                    this.Hide();
                    new Requests_Tutors(tutor.getUserName(),tutor.getPassword()).ShowDialog();         ////////////
                    this.Show();
                    break;
                case "העדפות מתרגל":
                    this.Hide();
                    new TutorPreferences(tutor.getID()).ShowDialog();               ////////////////////
                    this.Show();
                    break;
                case "צפייה במכסת שעות נוכחית":
                    this.Hide();
                    new DisplayAmountHoursTutors(this.tutor.getID()).ShowDialog();               ////////////////////
                    this.Show();
                    break;
                case "צפייה ברשימת קורסים לפי סמסטר":
                    this.Hide();
                    new DisplayCoursesBySemester().ShowDialog();
                    this.Show();
                    break;

                case "צפייה ברשימת סטודנטים לקורס":           ///
                    this.Hide();
                    new StudentsList_L_T(tutor.getFirstName() + " " + tutor.getLastName()).ShowDialog();
                    this.Show();
                    break;

                case "הודעות אישיות":           //
                    this.Hide();
                    new Readmess(tutor.getID()).ShowDialog();
                    this.Show();
                    break;
                case "עדכון פרטים אישיים":
                    this.Hide();
                    new Update_User_Info(this.tutor).ShowDialog();       ////////////
                    this.Show();
                    break;
                default:
                    MessageBox.Show("Please choose option!");

                    break;

            }
        }

        private void l_name_Click(object sender, EventArgs e)
        {

        }
    }
}
