﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Schedule
{
    class TutorPreferencesDB 
    {
        Databases con = Databases.Instance();
        SqlCommand com;

        public void ClearByID(string ID)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("DELETE PreferencesTutor WHERE ID_tutor = '" + ID + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                //MessageBox.Show("Deletion was succcesfully completed");
                con.CloseCon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AddLecturerPreferences(string ID, int Days, string Semester, int StartDay, int EndDay)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("INSERT into PreferencesTutor (ID_tutor,days,semesters,hourStart,hourEnd) VALUES('" + ID + "','" + Days + "','" + Semester + "','" + StartDay + "','" + EndDay + "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                MessageBox.Show("פרטיך עודכנו בהצלחה");
                con.CloseCon();    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
