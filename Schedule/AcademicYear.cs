using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    public partial class AcademicYear : Form
    {

        public AcademicYear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Flag = true;
            DayOfWeek b = DayOfWeek.Friday;
            DayOfWeek c = DayOfWeek.Saturday;
            DateTime WinterStart = DateTime.Parse(dateTimePicker1.Text);
            DateTime WinterEnd = DateTime.Parse(dateTimePicker2.Text);
            DateTime SpringStart = DateTime.Parse(dateTimePicker3.Text);
            DateTime SpringEnd = DateTime.Parse(dateTimePicker4.Text);
            DateTime SummerStart = DateTime.Parse(dateTimePicker5.Text);
            DateTime SummerEnd = DateTime.Parse(dateTimePicker6.Text);
            if (WinterStart > WinterEnd || WinterEnd > SpringStart || SpringStart > SpringEnd || SpringEnd > SummerStart || SummerStart > SummerEnd)
            {
                MessageBox.Show("the academic dates aren't arranged as needed.");
                Flag = false;
            }
            if ((WinterStart.DayOfWeek == b && WinterStart.DayOfWeek == c && SpringStart.DayOfWeek == b && SpringStart.DayOfWeek == c && SummerStart.DayOfWeek == b && SummerStart.DayOfWeek == c) && (Flag == true))
            {
                MessageBox.Show("semester cannot start in Friday or Saturday.");
                Flag = false;
            }
            if ((WinterEnd.DayOfWeek == c && SpringEnd.DayOfWeek == c && SummerEnd.DayOfWeek == c) && (Flag == true))
            {
                MessageBox.Show("semester cannot end in Saturday.");
                Flag = false;
            }
            //Winter
            if ((((WinterEnd - WinterStart).Days > 92 ) || ((WinterEnd - WinterStart).Days < 88)) && (Flag == true))
            {
                MessageBox.Show("Winter semester must be 88-92 days (yours "+ (WinterEnd - WinterStart).Days+").");
                Flag = false;
            }
            if ((((SpringStart - WinterEnd).Days > 33) || ((SpringStart - WinterEnd).Days < 28)) && (Flag == true))
            {
                MessageBox.Show("the Test period between Winter semester and Spring semester must be 28-33 days (yours " + (SpringStart - WinterEnd).Days + ").");
                Flag = false;
            }
            //Spring
            if ((((SpringEnd - SpringStart).Days > 115) || ((SpringEnd - SpringStart).Days < 110)) && (Flag == true))
            {
                MessageBox.Show("Spring semester must be 110-115 days(yours " + (SpringEnd - SpringStart).Days + ").");
                Flag = false;
            }
            if ((((SummerStart - SpringEnd).Days > 33) || ((SummerStart - SpringEnd).Days < 28)) && (Flag == true))
            {
                MessageBox.Show("the Test period between Spring semester and Summer semester must be 28-33 days (yours " + (SummerStart - SpringEnd).Days + ").");
                Flag = false;
            }
            //Summer
            if ((((SummerEnd - SummerStart).Days > 80) || ((SummerEnd - SummerStart).Days < 75)) && (Flag == true))
            {
                MessageBox.Show("Summer semester must be 75-80 days (yours " + (SummerEnd - SummerStart).Days + ").");
                Flag = false;
            }
            if (Flag == true)
            {
                SemestersDB Semester_db = new SemestersDB();
                string WYear = WinterStart.Year + "-" + "Winter";
                string SPYear = SpringStart.Year + "-" + "Spring";
                string SUYear = SummerStart.Year + "-" + "Summer";
                Flag = Semester_db.ExistsSemester(WYear);
                if (Flag == true)
                    Flag = Semester_db.ExistsSemester(SPYear);
                if (Flag == true)
                    Flag = Semester_db.ExistsSemester(SUYear);
                else 
                    MessageBox.Show("Your semesters already exists in database.");
                if (Flag == true)
                {                   
                    Semester_db.insertAcademicYear(WYear, WinterStart, WinterEnd);
                    Semester_db.insertAcademicYear(SPYear, SpringStart, SpringEnd);
                    Semester_db.insertAcademicYear(SUYear, SummerStart, SummerEnd);
                }
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
