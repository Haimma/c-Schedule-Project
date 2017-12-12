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
    
    public partial class DisplayCoursesBySemester : Form
    {

        public DisplayCoursesBySemester()
        {

            InitializeComponent();
            cb_semester.Items.Add("חורף");
            cb_semester.Items.Add("אביב");
            cb_semester.Items.Add("קיץ");
            cb_year.Items.Add("א");
            cb_year.Items.Add("ב");
            cb_year.Items.Add("ג");
            cb_year.Items.Add("ד");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void DisplayCoursesBySemester_Load(object sender, EventArgs e)
        {


        }

        private void lb_cuorse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string returnYear(string sem)
        {
            if (sem == "א")
                return "A";

            if (sem == "ב")
                return "B";

            if (sem == "ג")
                return "C";

            else
                return "D";
            
        }


        public string returnSemestr(string year)
        {
            if (year == "חורף")
                return "A";

            if (year == "אביב")
                return "B";

            else
                return "C";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            lb_cuorse.Items.Clear();
            CoursesDB C = new CoursesDB();
            List<string> listOfCourses = new List<string>();

            string semester = returnSemestr(cb_semester.SelectedItem.ToString());// SelectedItem.ToString();
            string year = returnYear(cb_year.SelectedItem.ToString());

            listOfCourses = C.fillCoursesBySenester_list(semester, year);
            
            foreach (string Item in listOfCourses)
                lb_cuorse.Items.Add(Item);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
