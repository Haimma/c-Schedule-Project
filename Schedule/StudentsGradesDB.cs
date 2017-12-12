using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Schedule
{
    class StudentsGradesDB 
    {
        Databases con = Databases.Instance();
        SqlCommand com;
        public bool CheckForFirstTime(string ID, string CourseName, int Grade)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM StudentsGrades WHERE studentID = '" + ID + "' AND courseName = '" + CourseName + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                if (rdr.Read())
                {
                    con.CloseCon();
                    return true;
                }
                else
                {
                    con.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void InsertForFirstTime(string ID, string CourseName, int Grade)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("INSERT into StudentsGrades (studentID,courseName,Grade) VALUES('" + ID + "','" + CourseName + "','" + Grade + "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateTime(string ID, string CourseName, int Grade)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE StudentsGrades SET Grade = '" + Grade + "' WHERE studentID = '" + ID + "' AND courseName= '" + CourseName + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public float GetStudentAverage(string ID)
        {
            int GradesSum = 0,CountCourses=0;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM StudentsGrades WHERE studentID = '" + ID + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    CountCourses++;
                    GradesSum += rdr.GetInt32(2);
                }
                con.CloseCon();
                return (GradesSum / CountCourses);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return (GradesSum / CountCourses);
            }
        }

        public void Update_Grade_After_Appeal_Confirmation(int grade, Appeals_Student appeal)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE StudentGrades SET Grade = '" + grade + "' WHERE studentID = '" + appeal.Get_Student_ID() + "' AND courseName = '" + appeal.Get_Course_Name() + "'", con.GetCon());
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
        }
    }
}
