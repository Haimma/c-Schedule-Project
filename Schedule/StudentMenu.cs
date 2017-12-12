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
    public partial class StudentMenu : Form
    {
        private Student student;
         public StudentMenu(Object s)
        {
            InitializeComponent();

            this.student = (Student)s;
            l_name.Text += student.getFirstName() + " " + student.getLastName();

          
            List<string> ListOptions = new List<string>();
            ListOptions.Add("צפייה במערכת");
            ListOptions.Add("בקשה לשינוי במערכת");
            ListOptions.Add("בקשה למועד מיוחד");
            ListOptions.Add("צפייה ברשימת קורסים לפי סמסטר");
            ListOptions.Add("בקשה לערעור על ציון מבחן");
            ListOptions.Add("הודעות אישיות");
            ListOptions.Add("עדכון פרטים אישיים");


            foreach (string Op in ListOptions)
            {
                lb_options.Items.Add(Op);
            }

        }

        private void lb_options_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string option_selected = lb_options.Text;
            switch (option_selected)
            {
                case "צפייה במערכת":
                    this.Hide();
                    new viewShStu(student.getFirstName(),student.getID()).ShowDialog();
                    this.Show();
                    break;
                case "בקשה לשינוי במערכת":
                    this.Hide();
                    new Requests_Students().ShowDialog();
                    this.Show();
                    break;
                case "בקשה לערעור על ציון מבחן":
                    this.Hide();
                    new Display_Student_Grades(this.student).ShowDialog();
                    this.Show();
                    break;
                case "בקשה למועד מיוחד":
                    this.Hide();
                    string s_id = student.getID();
                    new RequestExtraTest(s_id).ShowDialog();
                    this.Show();
                    break;
                case "צפייה ברשימת קורסים לפי סמסטר":
                    this.Hide();
                    new DisplayCoursesBySemester().ShowDialog();
                    this.Show();
                    break;
                case "הודעות אישיות":           ///
                    this.Hide();
                    new Readmess(student.getID()).ShowDialog();
                    this.Show();
                    break;
                case "עדכון פרטים אישיים":
                    this.Hide();
                    new Update_User_Info(this.student).ShowDialog();       ////////////
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
