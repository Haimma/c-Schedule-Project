﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Schedule
{
    public partial class addTutor : Form
    {
        TutorsDB tutors_db = new TutorsDB();
        UsersDB user_db = new UsersDB();

        public addTutor()
        {
            InitializeComponent();
            label9.Text = "32";
        }

        private void b_addTutors_Click_Click(object sender, EventArgs e)
        {
            int distance;       //for check integer
            int ID;
            bool bofl = true;
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
                    MessageBox.Show("Illegal field is:Username\n");
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
                    if (tb_password.Text.Length != 8)
                    {
                        MessageBox.Show("Illegal field is:Password\n");
                        tb_password.Clear();
                        break;
                    }


                }

                if (tutors_db.existTutors(tb_username.Text, tb_id.Text))
                {
                    MessageBox.Show("Tutors already existe\n");
                    break;
                }


                //------------all good------------------
                bofl = false;
                //-------------put data to db by func---------------
                tutors_db.insertTutors(tb_username.Text, tb_password.Text, tb_fname.Text, tb_lname.Text, tb_id.Text, tb_address.Text);

                //************************ //user_db.-----------------------------------
                //
                user_db.insertUser(tb_username.Text, tb_password.Text, tb_id.Text, "Tutors");

                //
                //---------------------------------------------
                this.Hide();

            }
            
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
