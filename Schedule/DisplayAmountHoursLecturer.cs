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
    public partial class DisplayAmountHoursLecturer : Form
    {
        
        LecturersDB lecturers_db = new LecturersDB();
        string id_lec;

        public DisplayAmountHoursLecturer(string id)
        {
            InitializeComponent();
            this.id_lec = id;
            int flag = 0;
            string numH;
            numH = lecturers_db.GetAmauntHours(id_lec);
            if (Int32.Parse(numH) < 0)
            {
                MessageBox.Show("Invildable num of hours for the lecturers\n");
                flag = 1;
            }
            else if (Int32.Parse(numH) == 0)
            {
                MessageBox.Show("There is no left huors for the lecturers\n");
                flag = 1;
            }
            if (flag == 0)//all good :)
                label2.Text = numH;
            //tb_left.Text = numH.ToString();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //int flag = 0, numH;

            //numH = lecturers_db.GetAmauntHours(id_lec);
            //if (numH < 0)
            //{
            //    MessageBox.Show("Invildable num of hours for the lecturers\n");
            //    flag = 1;
            //}
            //else if (numH == 0)
            //{
            //    MessageBox.Show("There is no left huors for the lecturers\n");
            //    flag = 1;
            //}
            //if (flag == 0)//all good :)
            //    label2.Text = numH.ToString();
            ////tb_left.Text = numH.ToString();
        }
    }
}
