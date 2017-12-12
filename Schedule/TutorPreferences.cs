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
    public partial class TutorPreferences : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index, Semester, StartDay, EndDay, DaysCount;
        CoursesDB Lec = new CoursesDB();
        TutorPreferencesDB TPreferences = new TutorPreferencesDB();
        TutorToCoursesDB TCourses = new TutorToCoursesDB();
        char A, B, C;
        string Teach, ID;
        public TutorPreferences(string IDuser)
        {
            InitializeComponent();
            ID = IDuser;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            //check in which days you want to work
            DaysCount = 0;
            if (checkBox18.CheckState == CheckState.Checked)
                DaysCount = DaysCount * 10 + 1;
            if (checkBox17.CheckState == CheckState.Checked)
                DaysCount = DaysCount * 10 + 2;
            if (checkBox16.CheckState == CheckState.Checked)
                DaysCount = DaysCount * 10 + 3;
            if (checkBox6.CheckState == CheckState.Checked)
                DaysCount = DaysCount * 10 + 4;
            if (checkBox5.CheckState == CheckState.Checked)
                DaysCount = DaysCount * 10 + 5;
            if (checkBox4.CheckState == CheckState.Checked)
                DaysCount = DaysCount * 10 + 6;
            if (DaysCount < 123)
            {
                MessageBox.Show("בחר/י לפחות שלושה ימי עבודה");
                flag = false;
            }
            //check how long your day is
            StartDay = 0; EndDay = 0;
            string TempNum = comboBox1.Text;
            if (flag)
            {
                try
                {
                    StartDay = Convert.ToInt32(TempNum);
                }
                catch
                {
                    MessageBox.Show("בחר/י שעת התחלת יום עבודה");
                    flag = false;
                }
                TempNum = comboBox2.Text;
            }
            if (flag)
            {
                try
                {
                    EndDay = Convert.ToInt32(TempNum);
                }
                catch
                {
                    MessageBox.Show("בחר/י שעת סיום יום עבודה");
                    flag = false;

                }
            }
            if (flag)
            {
                if (EndDay - StartDay < 5)
                {
                    MessageBox.Show("בחירת שעות העבודה שלך אינה תקינה. אנא בחר שוב");
                    flag = false;
                }
            }
            //check which semester you want to work
            if (flag)
            {
                A = ' '; B = ' '; C = ' ';
                Semester = comboBox4.SelectedIndex + 1;
                if (Semester == 1)
                {
                    A = 'A'; B = 'B'; C = 'C';
                    Teach = "ABC";
                }
                else if (Semester == 2)
                {
                    A = 'A'; B = 'B';
                    Teach = "AB";
                }
                else if (Semester == 3)
                {
                    A = 'A'; C = 'C';
                    Teach = "AC";
                }
                else if (Semester == 4)
                {
                    B = 'B'; C = 'C';
                    Teach = "BC";
                }
                if (A == ' ' && B == ' ' && C == ' ')
                {
                    MessageBox.Show("אנא בחר/י באילו סמסטרים ברצונך לעבוד");
                    flag = false;
                }
            }
            //if all ok
            if (flag)
            {
                if (index < listPanel.Count - 1)
                    listPanel[++index].BringToFront();

                listBox1.Items.Clear();
                listBox4.Items.Clear();
                List<string> lb_namelist = new List<string>();
                foreach (string temp in Lec.GetCourseBySemester(A, B, C))
                    listBox1.Items.Add(temp);
            }
        }
        //<- button
        private void button4_Click_1(object sender, EventArgs e)
        {
            ADD();
        }
        //-> button
        private void button6_Click_1(object sender, EventArgs e)
        {
            Remove();
        }

        //finish button
        private void button3_Click_1(object sender, EventArgs e)
        {
            TCourses.ClearByID(ID);
            foreach (string temp in listBox4.Items)
            {
                TCourses.AddLecturerCourses(ID, temp);
            }
            TPreferences.ClearByID(ID);
            TPreferences.AddLecturerPreferences(ID, DaysCount, Teach, StartDay, EndDay);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }
        private void ADD()
        {
            int x = listBox1.Items.Count - 1;
            for (int i = x; i >= 0; i--)
            {
                if (listBox1.GetSelected(i))
                {
                    listBox4.Items.Add(listBox1.Items[i]);
                    listBox1.Items.RemoveAt(i);
                }
            }
        }
        private void Remove()
        {
            int x = listBox4.Items.Count - 1;
            for (int i = x; i >= 0; i--)
            {
                if (listBox4.GetSelected(i))
                {
                    listBox1.Items.Add(listBox4.Items[i]);
                    listBox4.Items.RemoveAt(i);
                }
            }
        }

        private void TutorPreferences_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[index].BringToFront();
        }
    }
}


