using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

enum DEPARTMENTS {General=1,Software_Engineering,Electrical_Engineering,Structural_Engineering,Mechanical_Engineering,Chemical_Engineering,Industrial_And_Management};

namespace Schedule
{
    public partial class DeterminingCourseDetails : Form
    {
        CoursesDB courses_db = new CoursesDB();
        public DeterminingCourseDetails()
        {
            int i;
            InitializeComponent();
            //---fill the list box woth enum values
            cb_department.Items.Add(DEPARTMENTS.General);
            cb_department.Items.Add(DEPARTMENTS.Software_Engineering);
            cb_department.Items.Add(DEPARTMENTS.Electrical_Engineering);
            cb_department.Items.Add(DEPARTMENTS.Structural_Engineering);
            cb_department.Items.Add(DEPARTMENTS.Mechanical_Engineering);
            cb_department.Items.Add(DEPARTMENTS.Chemical_Engineering);
            cb_department.Items.Add(DEPARTMENTS.Industrial_And_Management);
            for (i = 1; i <= 4; i++)
            {
                cb_lec.Items.Add(i);
                cb_tirgul.Items.Add(i);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numoflec = 0;
            int numoftut = 0;
            int quantity; // for try parse

            string nameCourse = tb_nameCoures.Text;
            int Department_choose;
            char Year;
            char Semester;
            while (true)
            {
                //--------Name course check
                if ((nameCourse == "") || (int.TryParse(nameCourse, out quantity)))
                {
                    MessageBox.Show("You need input legal name course");      //empty textBox or not integer
                    tb_nameCoures.Clear();
                    break;
                }
                if (courses_db.ExistsCourse(nameCourse))
                {
                    MessageBox.Show("The course already exists");      //empty textBox or not integer
                    tb_nameCoures.Clear();
                    break;
                }
                //-------Department check

                switch (cb_department.SelectedIndex + 1)
                {
                    case 1:
                        Department_choose = 1;
                        break;
                    case 2:
                        Department_choose = 2;
                        break;
                    case 3:
                        Department_choose = 3;
                        break;
                    case 4:
                        Department_choose = 4;
                        break;
                    case 5:
                        Department_choose = 5;
                        break;
                    case 6:
                        Department_choose = 6;
                        break;
                    case 7:
                        Department_choose = 7;
                        break;
                    default:
                        MessageBox.Show("You're need to choose department");
                        Department_choose = 0;
                        break;
                }
                if (Department_choose == 0) //empty department
                    break;
                //-------Year check
                if (rb_aYear.Checked)
                    Year = 'A';
                else if (rb_bYear.Checked)
                    Year = 'B';
                else if (rb_cYear.Checked)
                    Year = 'C';
                else if (rb_dYear.Checked)
                    Year = 'D';
                else
                {
                    MessageBox.Show("You must choose a year");
                    break;
                }

                //--------Semester check
                if (rb_aSemester.Checked)
                    Semester = 'A';
                else if (rb_bSemester.Checked)
                    Semester = 'B';
                else if (rb_cSemester.Checked)
                    Semester = 'C';
                else
                {
                    MessageBox.Show("You must choose a semester");
                    break;
                }
                //--------Number houre of lectures check
                switch (cb_lec.SelectedIndex + 1)
                {
                    case 1:
                        numoflec = 1;
                        break;
                    case 2:
                        numoflec = 2;
                        break;
                    case 3:
                        numoflec = 3;
                        break;
                    case 4:
                        numoflec = 4;
                        break;
                    default:
                        MessageBox.Show("You're need to choose number of hours lectures");
                        numoflec = 0;
                        break;
                }
                if (Department_choose == 0) //empty number of hours lectures
                    break;
                //--------Number houre of tutores check
                switch (cb_tirgul.SelectedIndex + 1)
                {
                    case 1:
                        numoftut = 1;
                        break;
                    case 2:
                        numoftut = 2;
                        break;
                    case 3:
                        numoftut = 3;
                        break;
                    case 4:
                        numoftut = 4;
                        break;
                    default:
                        MessageBox.Show("You're need to choose number of hours tutores");
                        numoftut = 0;
                        break;
                }
                if (numoftut == 0) //empty number of hours tutores
                    break;

                //-------All detailse fine------
                courses_db.insertCourses(nameCourse, Department_choose, Year, Semester, numoflec, numoftut);
                this.Hide();
                break;
            }
        }


        private void tb_nameCoures_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DeterminingCourseDetails_Load(object sender, EventArgs e)
        {

        }

        private void DeterminingCourseDetails_Load_1(object sender, EventArgs e)
        {
            //
        }

        private void tb_numOfLec_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DeterminingCourseDetails_Load_2(object sender, EventArgs e)
        {

        }

        private void cb_department_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
