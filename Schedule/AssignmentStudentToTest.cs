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
    public partial class AssignmentStudentToTest : Form
    {
        TestScheduleDB testdb = new TestScheduleDB();
        StudentDB studentdb = new StudentDB();

        public AssignmentStudentToTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void AssignmentStudentToTest_Load(object sender, EventArgs e)
        {
            cb_course.Enabled = false;
            button2.Enabled = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string nameCourse = cb_course.Text;

            if (testdb.chackIfTestExist(nameCourse))
            {
                int idTest = testdb.retutnNumOfTest(nameCourse, id);
                //DateTime datetime = testdb.returnDateOfTest(nameCourse, idTest);

                if (testdb.chackTest(id, nameCourse))
                {
                    MessageBox.Show("Students register for this test");
                }
                else if (!(testdb.chackTest(id, nameCourse)))
                {
                    testdb.InsertTestToStudent(id, nameCourse, idTest);
                    MessageBox.Show("test Added");
                    button2.Enabled = false;
                    cb_course.Enabled = false;
                }
                else
                    MessageBox.Show("Faile to add the test");
                
            }
            else
                MessageBox.Show("No date was set for test");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            if (checkSize(id) == false || checkId(id) == false)
            {
                MessageBox.Show("Unlegal Input ,the id have to be 9 numbers and no latters");

            }
            else if (studentdb.chackId(id) == false)
                MessageBox.Show("Id not exist");

            else
            {
                tb_id.Enabled = false;
                cb_course.DataSource = studentdb.CheckCoursesToStudent(id);
                cb_course.Enabled = true;
                button2.Enabled = true;

            }
        }
    }
}
