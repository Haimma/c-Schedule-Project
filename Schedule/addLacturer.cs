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
    public partial class addLacturer : Form
    {

        LecturersDB lecturers_db = new LecturersDB();
        UsersDB user_db = new UsersDB();

        public addLacturer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged_1(object sender, EventArgs e)
        {
            if (tb_type.Text == "דוקטור")
                label2.Text = "16";
            else if (tb_type.Text == "פרופסור")
                label2.Text = "12";
            else if (tb_type.Text == "זוטר")
                label2.Text = "32";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void b_addLecture_click(object sender, EventArgs e)
        {



        }

        private void b_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addLacturer_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tb_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int distance;       //for chack integer
            int ID;
            //string illegalfields = null;
            // short flag = 0;     //text box fine
            //-----chacking text box, 0-fine , 1-empty , 2-illegal type, -1 - empty out
            // int distance;       //for chack integer
            //int ID;
            bool bofl = true;
            string type = null;
            int hours = 0;

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
                    if ((ID < 100000000 || ID > 999999999))
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
                    MessageBox.Show("Illegal field is:Address\n");
                    tb_address.Clear();
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
                    
                    if (tb_password.Text.Length!=8)
                    {
                        MessageBox.Show("Illegal field is:Password\n");
                        tb_password.Clear();
                        break;
                    }

                }

                if (lecturers_db.existlecturer_db(tb_username.Text, tb_id.Text))
                {
                    MessageBox.Show("lecture already existe\n");
                    break;
                }


                //--------hour & type
                if (tb_type.Text == "דוקטור")
                {
                    type = "Doctor";
                    hours = 16;
                }
                else if (tb_type.Text == "פרופסור")
                {
                    type = "Professor";
                    hours = 12;
                }
                else if (tb_type.Text == "זוטר")
                {
                    type = "Junior";
                    hours = 32;
                }
                else
                {
                    MessageBox.Show("missing a type or invild type\n");
                    break;
                }

                //------------all good------------------
                bofl = false;
                //-------------put data to db by func---------------
                lecturers_db.insertlecturer_db(tb_username.Text, tb_password.Text, tb_fname.Text, tb_lname.Text, tb_id.Text, tb_address.Text, hours, type);

                //************************ //user_db.-----------------------------------
                //
                user_db.insertUser(tb_username.Text, tb_password.Text, tb_id.Text, "Lecturers");
                //
                //---------------------------------------------
                this.Hide();

            }
        }
    }
}
