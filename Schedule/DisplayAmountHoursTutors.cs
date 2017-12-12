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
    public partial class DisplayAmountHoursTutors : Form
    {
        TutorsDB tutor_db = new TutorsDB();
        string id_tu;
        public DisplayAmountHoursTutors(string id)
        {
            InitializeComponent();
            this.id_tu = id;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string numH;

            numH = tutor_db.GetAmauntHours(id_tu).ToString();
            if (Int32.Parse(numH) < 0)
            {
                MessageBox.Show("Invildable num of hours for the Tutors\n");
                flag = 1;
            }
            else if (Int32.Parse(numH) == 0)
            {
                MessageBox.Show("There is no left huors for the Tutors\n");
                flag = 1;
            }
            if (flag == 0)//all good :)
                label2.Text = numH;
        }
    }
}
