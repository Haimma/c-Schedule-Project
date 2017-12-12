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
    public partial class DepartmentHeadMenu : Form
    {
        private DepartmentManager department_manager;
        public DepartmentHeadMenu(Object dep)
        {
            InitializeComponent();

            this.department_manager = (DepartmentManager)dep;
            l_name.Text += department_manager.getFirstName() + " " + department_manager.getLastName();


            List<string> ListOptions = new List<string>();
            ListOptions.Add("הוספת קורס חדש - קביעת פרטי קורס");
            ListOptions.Add("שינויים במערכת לראש מחלקה");
            ListOptions.Add("ניהול קורסים");            /// לבדוק אם קיים
            ListOptions.Add("צפייה במערכת");
            ListOptions.Add("חלוקת שנת לימודים לסמסטרים ותקופות מבחנים");
            ListOptions.Add("צפייה במכסת שעות נוכחית");
            ListOptions.Add("צפייה ברשימת סטודנטים לקורס");
            ListOptions.Add("הצבת רף ממוצע מינימאלי");
            ListOptions.Add("צפייה ברשימת קורסים לפי סמסטר");
            ListOptions.Add("אישור מועד מיוחד");
            ListOptions.Add("הודעות אישיות");
            ListOptions.Add("עדכון פרטים אישיים");


            foreach (string Op in ListOptions)
            {
                lb_options.Items.Add(Op);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
     
            string option_selected = lb_options.Text;
            switch (option_selected)
            {
                case "צפייה במערכת":
                    this.Hide();
                    new viewShSec(department_manager.getFirstName()).ShowDialog();              ////////////////////
                    this.Show();
                    break;
                case "הוספת קורס חדש - קביעת פרטי קורס":
                    this.Hide();
                    new DeterminingCourseDetails().ShowDialog();
                    this.Show();
                    break;
                case "שינויים במערכת לראש מחלקה":
                    this.Hide();
                    new Requests_Check().ShowDialog();
                    this.Show();
                    break;
                
                    
                case "הודעות אישיות":           ///
                    this.Hide();
                    new Readmess(department_manager.getID()).ShowDialog();
                    this.Show();
                    break;
                case "ניהול קורסים":
                    this.Hide();
                    new ManagementCourses().ShowDialog();
                    this.Show();
                    break;
                case "חלוקת שנת לימודים לסמסטרים ותקופות מבחנים":           ///
                    this.Hide();
                    new AcademicYear().ShowDialog();
                    this.Show();
                    break;
                case "צפייה במכסת שעות נוכחית":
                    this.Hide();
                    new DisplayAmountHoursSecrt_Depar().ShowDialog();
                    this.Show();
                    break;
                case "צפייה ברשימת סטודנטים לקורס":           ///
                    this.Hide();
                    new Students_List_S_DM().ShowDialog();
                    this.Show();
                    break;
                case "הצבת רף ממוצע מינימאלי":
                    this.Hide();
                    new SemesterMinimalAverage().ShowDialog();
                    this.Show();
                    break;
                case "צפייה ברשימת קורסים לפי סמסטר":           ///
                    this.Hide();
                    new DisplayCoursesBySemester().ShowDialog();
                    this.Show();
                    break;
                case "אישור מועד מיוחד":
                    this.Hide();
                    new ConfirmSpecialExam().ShowDialog();
                    this.Show();
                    break;
                case "עדכון פרטים אישיים":
                    this.Hide();
                    new Update_User_Info(this.department_manager).ShowDialog();       ////////////
                    this.Show();
                    break;
                default:
                    MessageBox.Show("Please choose option!");
                    break;

            }


        }

        private void DepartmentHeadMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
