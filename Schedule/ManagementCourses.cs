using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Schedule
{

    public partial class ManagementCourses : Form
    {

        CoursesDB coursedb = new CoursesDB();
        public ManagementCourses()
        {
            InitializeComponent();
            coursedb.fillCourses_list(lb_course);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string choose = lb_course.GetItemText(lb_course.SelectedItem);
            Update_Course UP = new Update_Course(choose);
            UP.Show();
            coursedb.Update_nameCourse(UP.GetNewCours(), choose);
            lb_course.Items.Clear();
            coursedb.fillCourses_list(lb_course);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ManagementCourses_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string choose = lb_course.GetItemText(lb_course.SelectedItem);
            if (!coursedb.Remove_Course_From_DB(choose))  //exist in acticeCourses
            {
                lb_course.Items.Clear();
                coursedb.fillCourses_list(lb_course);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string choose = lb_course.GetItemText(lb_course.SelectedItem);
            coursedb.view_Course(choose);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}