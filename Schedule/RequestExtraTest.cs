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
    public partial class RequestExtraTest : Form
    {

        StudentToCourseDB stud_to_courseDB = new StudentToCourseDB();
        ExamRequestDB NewRe = new ExamRequestDB();
        string s_id;
        string course_name;
        string request;
        
        
        


        public RequestExtraTest(string id)
        {
            InitializeComponent();
            this.s_id = id;
            //fill course List and 
            stud_to_courseDB.GetCourseOfStudent(nameCourse, id);
        }

        private void RequestExtraTest_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbo_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nameCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            course_name = nameCourse.Text;
        }

        private void reson_TextChanged(object sender, EventArgs e)
        {
            
            request = reson.Text;
            
        }

        private void application_Click(object sender, EventArgs e)
        {
            while(true)
            {
                if(request=="")
                {
                    MessageBox.Show("ERROR: You need to write reson");
                    break;
                }
                if (nameCourse.Text=="")
                {
                     MessageBox.Show("ERROR: You need to write reson");
                     break;
                }
                if (request.Length > 200)
                {
                    MessageBox.Show("ERROR: You insert above 200 char'");    
                    reson.Clear();
                    break;
                }
                //all good
                NewRe.insertExamRequest(0, s_id, course_name, request);

                break;
            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
