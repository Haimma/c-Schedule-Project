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
    public partial class ConfirmSpecialExam : Form
    {
        ConfirmSpecialExamDB req = new ConfirmSpecialExamDB();
        messageDB mass = new messageDB();
        ExamRequestDB up = new ExamRequestDB();
        string id_choice;
        string course_choice;
        public ConfirmSpecialExam()
        {
            InitializeComponent();
            id_choice = "";
            course_choice = "";
            //fill
            req.GetIdOfStudent(s_id);
        }

        private void comfirm_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (id_choice == "")
                {
                    MessageBox.Show("You need choose id");
                    break;
                }
                if (course_choice == "")
                {
                    MessageBox.Show("You need choose course");
                    s_id.ClearSelected();
                    break;
                }
                mass.insert_mass_of_confirm_req(id_choice, course_choice, 1);
                up.updateExamRequest(id_choice);
                break;

            }
            this.Hide();


            //set to confirm in DB
        }

        private void s_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_choice = s_id.Text;
            course.Items.Clear();
            req.GetCourseOfStudent(course, id_choice);
        }

        private void course_SelectedIndexChanged(object sender, EventArgs e)
        {
            course_choice = course.Text;
            req.GetResonOfStudent(reson, id_choice, course_choice);

        }

        private void decline_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (id_choice == "")
                {
                    MessageBox.Show("You need choose id");
                    break;
                }
                if (course_choice == "")
                {
                    MessageBox.Show("You need choose course");
                    s_id.ClearSelected();
                    break;
                }
                break;

            }
            mass.insert_mass_of_confirm_req(id_choice, course_choice, 0);
            this.Hide();
        }

        private void decline_Click_1(object sender, EventArgs e)
        {
            while (true)
            {
                if (id_choice == "")
                {
                    MessageBox.Show("You need choose id");
                    break;
                }
                if (course_choice == "")
                {
                    MessageBox.Show("You need choose course");
                    s_id.ClearSelected();
                    break;
                }
                break;

            }
            mass.insert_mass_of_confirm_req(id_choice, course_choice, 0);
            this.Hide();
        }
    }
}
