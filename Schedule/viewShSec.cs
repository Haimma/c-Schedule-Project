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
    public partial class viewShSec : Form
    {
        string name;
        TutorsDB tutorsdb = new TutorsDB();
        LecturersDB lecturersdb = new LecturersDB();
        StudentDB studentdb = new StudentDB();
        ActiveCoursesDB activeCourse = new ActiveCoursesDB();
        public viewShSec(string name1)
        {
            InitializeComponent();
            name = name1;
            cb_type.Items.Add("סטודנט");
            cb_type.Items.Add("מרצה");
            cb_type.Items.Add("מתרגל");

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void viewShSec_Load(object sender, EventArgs e)
        {
            tb_id.Enabled = false;
            button2.Enabled = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            tb_id.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string id = tb_id.Text;
            string type = cb_type.SelectedItem.ToString();
            bool flag = true;
            string name;

            if (type == "סטודנט")
            {
                if (studentdb.chackId(id) == true)
                {
                        name = studentdb.returnNameOfStu(id);
                        new viewShStu(name, id).ShowDialog();
                }
                else
                    MessageBox.Show("Id not exist");

            }
            if (type == "מרצה")
            {
                    if (lecturersdb.chackIdLecturer(id) == true)
                    {
                        name = lecturersdb.returnNameOfLec(id);
                        new viewShL(name, id).ShowDialog();
                    }
                    else
                        MessageBox.Show("Id not exist");
             }
             if (type == "מתרגל")
             {
                    if (tutorsdb.chackIdTutor(id) == true)
                    {
                        name = tutorsdb.returnNameOfTutor(id);
                        new viewShT(name, id).ShowDialog();
                        
                    }
                    else
                        MessageBox.Show("Id not exist");
        
             }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
