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
    public partial class DisplayAmountHoursSecrt_Depar : Form
    {

        TutorsDB tutor_db = new TutorsDB();
        LecturersDB lecturers_db = new LecturersDB();



        public DisplayAmountHoursSecrt_Depar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string numH;
            int user_check = 0;
            while (flag == 0)
            {

                if (string.IsNullOrWhiteSpace(tb_id.Text))
                {
                    MessageBox.Show("Have empty field.");
                    tb_username.Text = String.Empty;
                    tb_id.Text = String.Empty;

                    break;
                }

                else if(string.IsNullOrWhiteSpace(tb_username.Text))
                {
                    MessageBox.Show("Have empty field.");
                    tb_id.Text = String.Empty;
                    tb_username.Text = String.Empty;

                    break;
                }

                //check if the Tutor exist----//check if the lecture exist
                else if((!tutor_db.existTutors(tb_username.Text, tb_id.Text))&&(!lecturers_db.existlecturer_db(tb_username.Text, tb_id.Text)))
                {
                   // MessageBox.Show("Tutor not existe\n");
                    MessageBox.Show("User not existe\n");

                    tb_id.Text = String.Empty;
                    tb_username.Text = String.Empty;
                    user_check=0;//=1
                    break;
                }else if(tutor_db.existTutors(tb_username.Text, tb_id.Text))
                {
                    user_check=1;//tutors
                    flag = 1;//out loop
                }else 
                {
                    user_check=2;//lecturer
                    flag = 1;//out loop
                }
               
                

            }
            flag = 0;
            if (user_check==0)
            {
                MessageBox.Show("ERROR:User lecture & Tutor\n");
            }
            if (user_check==2)
            {
                //lec
                numH = lecturers_db.GetAmauntHours(tb_id.Text);
                if (Convert.ToInt32(numH) < 0)
                {
                    MessageBox.Show("Invildable num of hours for the lecturers\n");
                    flag = 1;
                }
                else if (Convert.ToInt32(numH) == 0)
                {
                    MessageBox.Show("There is no left huors for the lecturers\n");
                    flag = 1;
                }
                if (flag == 0)//all good :)
                    tb_left.Text = numH.ToString();

            }
            if (user_check==1)
            {
                //tot
                numH = tutor_db.GetAmauntHours(tb_id.Text).ToString();
                if (Convert.ToInt32(numH) < 0)
                {
                    MessageBox.Show("Invildable num of hours for the Tutors\n");
                    flag = 1;
                }
                else if (Convert.ToInt32(numH) == 0)
                {
                    MessageBox.Show("There is no left huors for the Tutors\n");
                    flag = 1;
                }
                if (flag == 0)//all good :)
                    tb_left.Text = numH.ToString();
               

            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_left_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
