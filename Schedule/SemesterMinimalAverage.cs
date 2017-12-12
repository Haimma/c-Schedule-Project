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
    public partial class SemesterMinimalAverage : Form
    {
        SemesterMinimalAverageDB MinSem = new SemesterMinimalAverageDB();
        public SemesterMinimalAverage()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Flag = true;
            string Year = comboBox1.Text, Semester = comboBox2.Text; ;
            int MinAverage=0;
            if (Year == "")
            {
                MessageBox.Show("לא נבחרה שנת לימוד");
                Flag = false;
            }
            if (Flag)
            {
                    if (Semester == "חורף")
                        Semester = "Winter";
                    else if (Semester == "אביב")
                        Semester = "Spring";
                    else if (Semester == "קיץ")
                        Semester = "Summer";
                if (Semester == "")
                {
                    MessageBox.Show("לא נבחר סמסטר");
                    Flag = false;
                }
            }
            if (Flag)
            {
                try
                {
                    MinAverage = Convert.ToInt32(comboBox3.Text);
                }
                catch
                {
                    MessageBox.Show("לא נבחר ממוצע מינימאלי");
                    Flag = false;
                }
            }
            if (Flag)
            {
                MinSem.ChangeMinAverage(Year, Semester, MinAverage);
            }
            
        }
    }
}
