using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    public partial class addStudent : Form
    {

        StudentDB student_db = new StudentDB();
        UsersDB user_db = new UsersDB();
        char year;

        public addStudent()
        {
            InitializeComponent();
            //---fill the list box woth enum values
           // tb_department.Items.Add(DEPARTMENTS.General);
            tb_department.Items.Add(DEPARTMENTS.Software_Engineering);
            tb_department.Items.Add(DEPARTMENTS.Electrical_Engineering);
            tb_department.Items.Add(DEPARTMENTS.Structural_Engineering);
            tb_department.Items.Add(DEPARTMENTS.Mechanical_Engineering);
            tb_department.Items.Add(DEPARTMENTS.Chemical_Engineering);
            tb_department.Items.Add(DEPARTMENTS.Industrial_And_Management);
        }

        private void addStudent_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_addStudent_Click(object sender, EventArgs e)
        {


            int distance;       //for chack integer
            int ID;
            bool bofl = true;
            int Department_choose;

            while (bofl)
            {
                //---First name---
                if (string.IsNullOrWhiteSpace(tb_fname.Text))
                {
                    MessageBox.Show("Have empty field.");
                    break;
                }
                else if ((int.TryParse(tb_fname.Text, out distance)))
                {
                    MessageBox.Show("Illegal field is:First name\n");
                    tb_fname.Clear();
                    break;
                }

                //---Last name---
                if (string.IsNullOrWhiteSpace(tb_lname.Text))
                {
                    MessageBox.Show("Have empty field.");
                    break;
                }
                else if (int.TryParse(tb_lname.Text, out distance))
                {
                    MessageBox.Show("Illegal field is:Last name\n");
                    tb_lname.Clear();
                    break;
                }

                //--- ID---
                if (string.IsNullOrWhiteSpace(tb_id.Text))
                {
                    MessageBox.Show("Have empty field.");
                    break;
                }
                else if (!(int.TryParse(tb_id.Text, out distance)))
                {
                    MessageBox.Show("Illegal field is:ID\n");
                    tb_id.Clear();
                    break;
                }
                else
                {
                    ID = int.Parse(tb_id.Text);
                    if ((ID > 1000000000 && ID < 99999999))
                    {
                        MessageBox.Show("Illegal field is:ID\n");
                        tb_id.Clear();
                        break;
                    }
                }

                //---Address---
                if (string.IsNullOrWhiteSpace(tb_address.Text))
                {
                    MessageBox.Show("Have empty field.");
                    break;
                }
                else if (int.TryParse(tb_address.Text, out distance))
                {
                    MessageBox.Show("Illegal field is:Address\n");
                    tb_address.Clear();
                    break;
                }

                //---Username---
                if (string.IsNullOrWhiteSpace(tb_username.Text))
                {
                    MessageBox.Show("Have empty field.");
                    break;
                }
                else if (int.TryParse(tb_username.Text, out distance))
                {
                    MessageBox.Show("Illegal field is:Username\n");
                    tb_username.Clear();
                    break;
                }
                //---Password---
               
                if (string.IsNullOrWhiteSpace(tb_password.Text))
                {
                    MessageBox.Show("Have empty field.");
                    break;
                }
                else if (int.TryParse(tb_password.Text, out distance))
                {
                    if (tb_password.Text.Length != 8)
                    {
                        MessageBox.Show("Illegal field is:Password\n");
                        tb_password.Clear();
                        break;
                    }


                }
                //---Department---
                switch (tb_department.SelectedIndex + 2)
                {
                    case 1:
                        Department_choose = 1;
                        break;
                    case 2:
                        Department_choose = 2;
                        break;
                    case 3:
                        Department_choose = 3;
                        break;
                    case 4:
                        Department_choose = 4;
                        break;
                    case 5:
                        Department_choose = 5;
                        break;
                    case 6:
                        Department_choose = 6;
                        break;
                    case 7:
                        Department_choose = 7;
                        break;
                    default:
                        MessageBox.Show("You're need to choose department");
                        Department_choose = 0;
                        break;
                }
                if (Department_choose == 0) //empty department
                    break;

                if (student_db.existStudent(tb_username.Text, tb_id.Text))
                {
                    MessageBox.Show("Student already existe\n");
                    break;
                }

                switch (cb_year.SelectedIndex)
                {
                    case 0:
                        year = 'A';
                        break;
                    case 1:
                        year = 'B';
                        break;
                    case 2:
                        year = 'C';
                        break;
                    case 3:
                        year = 'D';
                        break;

                }


                //------------all good------------------
                bofl = false;
                //-------------put data to db by func---------------
                student_db.insertStudent(tb_username.Text, tb_password.Text, tb_fname.Text, tb_lname.Text, tb_id.Text, tb_address.Text, year, Department_choose);

                //************************ //user_db.-----------------------------------
                //
                user_db.insertUser(tb_username.Text, tb_password.Text, tb_id.Text, "Students");
                //
                //---------------------------------------------
                this.Hide();

            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        }
    }
