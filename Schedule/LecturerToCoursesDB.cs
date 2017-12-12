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
    class LecturerToCoursesDB 
    {
        Databases con = Databases.Instance();
        SqlCommand com;

        public void ClearByID(string ID)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("DELETE LecturerToCourses WHERE IDlecturer = '" + ID + "'", con.GetCon());
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
        public void AddLecturerCourses(string ID,string course)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("INSERT into LecturerToCourses (NameCourse,IDlecturer) VALUES('" + course + "','" + ID + "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                //MessageBox.Show("פרטיך עודכנו בהצלחה");
                con.CloseCon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
