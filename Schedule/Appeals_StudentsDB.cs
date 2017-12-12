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
    class Appeals_StudentsDB
    {
        Databases con = Databases.Instance();  //
        SqlCommand com;

        public List<Appeals_Student> Get_Appeals_From_DB_By_Student(Student student)
        {
            List<Appeals_Student> appeals = new List<Appeals_Student>();
            Appeals_Student appeal = new Appeals_Student();

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Student_Appeals WHERE Student_ID = '" + student.getID() + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    appeal.Set_Student_ID(rdr["Student_ID"].ToString());
                    appeal.Set_Course_ID(Convert.ToInt32(rdr["ActiveCourse_ID"].ToString()));
                    appeal.Set_Course_Name(rdr["Course_Name"].ToString());
                    appeal.Set_Appeal(rdr["Appeal"].ToString());
                    appeal.Set_Lecturer_ID(rdr["Lecturer_ID"].ToString());
                    appeal.Set_Status(Convert.ToInt32(rdr["Status"].ToString()));

                    appeals.Add(appeal);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return appeals;
        }

        public void Make_Appeal(string studentID, int courseID, string courseName, string appeal, string lecturerID, int status)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("INSERT INTO Student_Appeals (Student_ID, ActiveCourse_ID, Course_Name, Appeal, Lecturer_ID, Status) VALUES(@Student_ID, @ActiveCourseID, @Course_Name, @Appeal, @Lecturer_ID, @Status)", con.GetCon());
                //'" + studentID + "','" + courseID + "','" + courseName + "'," + appeal + ",'" + lecturerID + "','" + status + "'
                //SqlDataReader rdr = com.ExecuteReader();
                com.Parameters.AddWithValue("@Student_ID", studentID);
                com.Parameters.AddWithValue("@ActiveCourseID", courseID.ToString());
                com.Parameters.AddWithValue("@Course_Name", courseName);
                com.Parameters.AddWithValue("@Appeal", appeal);
                com.Parameters.AddWithValue("@Lecturer_ID", lecturerID);
                com.Parameters.AddWithValue("@Status", status.ToString());
                com.ExecuteNonQuery();
                //while (rdr.Read()) { }
                MessageBox.Show("Appeal Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
        }

        public List<Appeals_Student> Get_Appeals_by_Lecturer_ID(string id)
        {
            List<Appeals_Student> appeals = new List<Appeals_Student>();
            Appeals_Student appeal = new Appeals_Student();
            int no_review = -1;

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Student_Appeals WHERE Lecturer_ID = '" + id + "' AND Status = '" + no_review + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    appeal = new Appeals_Student();
                    appeal.Set_Student_ID(rdr["Student_ID"].ToString());
                    appeal.Set_Status(Convert.ToInt32(rdr["Status"].ToString()));
                    appeal.Set_Lecturer_ID(id);
                    appeal.Set_Course_Name(rdr["Course_Name"].ToString());
                    appeal.Set_Course_ID(Convert.ToInt32(rdr["ActiveCourse_ID"].ToString()));
                    appeal.Set_Appeal(rdr["Appeal"].ToString());

                    appeals.Add(appeal);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return appeals;
        }

        private int DENY = 0, CONFIRM = 1;

        public void Update_After_Lecturer_Review(int ConfirmDeny, Appeals_Student appeal)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE Student_Appeals SET Status = '" + ConfirmDeny + "' WHERE Student_ID = '" + appeal.Get_Student_ID() + "' AND ActiveCourse_ID = '" + appeal.Get_Course_ID() + "' AND Lecturer_ID = '" + appeal.Get_Lecturer_ID() + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read()) { }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
        }
    }
}
