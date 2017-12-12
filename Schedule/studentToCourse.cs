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

    public partial class studentToCourse : Form
    {
        StudentDB studentdb = new StudentDB();
        ActiveCoursesDB ac = new ActiveCoursesDB();
        StudentToCourseDB studentToCoursedb = new StudentToCourseDB();
        public studentToCourse()
        {
            InitializeComponent();

        }

        private void studentToCourse_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_enter_Click(object sender, EventArgs e)
        {
            string ChoosingACourse = lb_course.Text;
            string idStu = textBox1.Text;
            string nameCourse;
            int idCourse;
            string yearStudent = studentdb.returnYearOfStu(idStu);

            int startIndex = ChoosingACourse.IndexOf(":");
            //   int endIndex = ChoosingACourse.IndexOf(",");
            int finalIndex = ChoosingACourse.IndexOf("_");

            nameCourse = ChoosingACourse.Substring(finalIndex + 1, startIndex - (finalIndex + 1));

            idCourse = int.Parse(ChoosingACourse.Substring(0, finalIndex));

            //int idcourse = studentToCoursedb.getNumOfCourse(courseName);

            if (studentdb.CheckingBackOfCourse(nameCourse, idStu))
            {
                MessageBox.Show("Students register for this course");
            }
            else
            {
                if (ac.inseretCourseTostudent(idStu, nameCourse, idCourse))
                {
                    MessageBox.Show("Cours Added");
                }
                else
                    MessageBox.Show("Faile to add the Cours");
            }

        }

        public bool checkId(string id)
        {
            try
            {

                long.Parse(id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                return false;
            }

            return true;
        }
        public bool checkSize(string id)
        {
            if (id.Length != 9)
                return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string yearStudent;
            List<string> listOfCourses = new List<string>();
            List<string> listShow = new List<string>();
            List<string> sameCoursesName = new List<string>();

            string id = textBox1.Text;
            if (checkSize(id) == false || checkId(id) == false)
            {
                MessageBox.Show("Unlegal Input ,the id have to be 9 numbers and no latters");

            }
            else if (studentdb.chackId(id) == false)
                MessageBox.Show("Id not exist");

            else
            {
                textBox1.Enabled = false;
                button1.Enabled = false;

                yearStudent = studentdb.returnYearOfStu(id);

                listOfCourses = studentToCoursedb.chackYearToStu(yearStudent);

                List<string> Lcourses = new List<string>();
                //foreach (string Item in listOfCourses)
                for (int i = 0; i < listOfCourses.Count; i++)
                {
                    Lcourses = studentToCoursedb.returnCoursesWithSameName(listOfCourses[i]);
                    if (Lcourses.Count > 0)
                    {
                        foreach (string Item in Lcourses)
                            lb_course.Items.Add(Item);
                    }

                }

                //listOfCourses = studentToCoursedb.chackYearToStu(yearStudent);
                //foreach (string Item in listOfCourses)
                //    lb_course.Items.Add(Item);

                //foreach (string Item in listOfCourses)
                //    lb_course.Items.Add(Item);

            }
        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}