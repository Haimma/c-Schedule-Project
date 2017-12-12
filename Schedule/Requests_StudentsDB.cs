using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Schedule
{
    class Requests_StudentsDB
    {
        Databases con = Databases.Instance();
        SqlCommand com;

        public void Add_Request(Student student, int OriginalCourseID, int RequestedCourseID)
        {
            try
            {
                con.OpenCon();

                if (Search_If_Request_Exists(student, OriginalCourseID, RequestedCourseID))
                {
                    com = new SqlCommand("INSERT INTO Requests_Students(StudentID,OriginalCourseID,RequestedCourseID,Status) VALUES(@StudentID,@OriginalCourseID,@RequestedCourseID,@Status)", con.GetCon());
                    com.Parameters.AddWithValue("@StudentID", student.getID());
                    com.Parameters.AddWithValue("@OriginalCourseID", OriginalCourseID);
                    com.Parameters.AddWithValue("@RequestedCourseID", RequestedCourseID);
                    com.Parameters.AddWithValue("@Status", -1); // 1 = Approved, 0 = Declined, -1 = Not Evaluated.
                    com.ExecuteNonQuery();
                    con.CloseCon();

                    MessageBox.Show("הבקשה נשלחה");
                }
                else throw new Exception("הבקשה כבר קיימת במערכת");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nהבקשה לא נשלחה");
            }
        }

        public bool Search_If_Request_Exists(Student student, int OriginalCourseID, int RequestedCourseID)
        {

            com = new SqlCommand("Select * FROM Requests_Students WHERE StudentID = '" + student.getID() + "' AND OriginalCourseID = '" + OriginalCourseID + "' AND RequestedCourseID = '" + RequestedCourseID + "'", con.GetCon());
            SqlDataReader rdr = com.ExecuteReader();
            return (rdr.ToString() == null);


        }

        public List<Requests_Students> Load_Students(ref List<Student> students)
        {
            List<Requests_Students> request = new List<Requests_Students>();
            Requests_Students StudentRequests;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Requests_Students WHERE Status = '-1'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    StudentRequests = new Requests_Students();
                    StudentRequests.Set_ID(rdr["StudentID"].ToString());
                    StudentRequests.Set_OriginalCourseID(Convert.ToInt32(rdr["OriginalCourseID"].ToString()));
                    StudentRequests.Set_NewCourseID(Convert.ToInt32(rdr["RequestedCourseID"].ToString()));
                    StudentRequests.Set_Status(Convert.ToInt32(rdr["Status"].ToString()));

                    request.Add(StudentRequests);
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nהבקשה לא נשלחה");
            }
            
            con.CloseCon();
            students = Get_Students(request);
            
            return request;
        }

        private List<Student> Get_Students(List<Requests_Students> requests)
        {
            List<Student> students = new List<Student>();
            Student student;
            try
            {
                con.OpenCon();

                for (int i = 0; i < requests.Count(); i++) {
                    string id = requests[i].Get_ID();
                    com = new SqlCommand("SELECT * FROM Students WHERE ID = '" + id + "'", con.GetCon());
                    SqlDataReader rdr = com.ExecuteReader();
                    student = new Student();

                    while (rdr.Read())
                    {
                        student.setFirstName(rdr["First_Name"].ToString());
                        student.setLastName(rdr["Last_Name"].ToString());
                        student.setID(rdr["ID"].ToString());
                        student.setAddress(rdr["Address"].ToString());
                        student.setUserName(rdr["User_Name"].ToString());
                        student.setPassword(rdr["Password"].ToString());
                        student.setYear(Convert.ToChar(rdr["Year"].ToString()));
                        student.setDepartment(rdr["Department"].ToString());
                       // student.setExellent(Convert.ToBoolean(rdr["Exellent"].ToString()));
                        student.setAverage(float.Parse(rdr["Average"].ToString()));
                    }
                    if (!students.Contains(student))
                        students.Add(student);
                    rdr.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            con.CloseCon();
            return students;
        }

       public void Update_Request(int OriginalourseID, int NewCourseID, string studentId, int ConfirmDeny, string OriginalCourseName, string NewCourseName)
       {
            StudentToCourseDB stuToCourseDB;
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE Requests_Students SET Status = '" + ConfirmDeny + "' WHERE StudentID = '" + studentId + "' AND OriginalCourseID = '" + OriginalourseID + "' AND RequestedCourseId = '" + NewCourseID + "'", con.GetCon());
                com.ExecuteNonQuery();

                if (ConfirmDeny == 1) {
                    stuToCourseDB = new StudentToCourseDB();
                    stuToCourseDB.Update_By_Request(OriginalourseID, NewCourseID, studentId, OriginalCourseName, NewCourseName);
                }

                MessageBox.Show("הפעולה בוצעה בהצלחה");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            con.CloseCon();
        }
    }
}
