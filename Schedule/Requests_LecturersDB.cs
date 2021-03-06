﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Schedule
{
    class Requests_LecturersDB 
    {
        Databases con = Databases.Instance();
        SqlCommand com;

        public void Add_Request(string ID, string FirstName, string LastName, int requestType, string course, string day, int hour, string classroom)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("INSERT INTO Requests_Lecturers(ID,FirstName,LastName,Cancell,course,day,hour,classroom,Status) Values(@ID,@FirstName,@LastName,@Cancell,@course,@day,@hour,@classroom,@Status)", con.GetCon());
                com.Parameters.AddWithValue("@ID", ID);
                com.Parameters.AddWithValue("@FirstName", FirstName);
                com.Parameters.AddWithValue("@LastName", LastName);
                com.Parameters.AddWithValue("@Cancell", requestType.ToString()); // 1 for Cancell, 0 for Add. 
                com.Parameters.AddWithValue("@course", course);
                com.Parameters.AddWithValue("@day", day);
                com.Parameters.AddWithValue("@hour", hour);
                com.Parameters.AddWithValue("@classroom", classroom);
                com.Parameters.AddWithValue("@Status", Convert.ToString(-1)); // -1 Represents that the satatus is not Approved nor Denied.
                com.ExecuteNonQuery();
                con.CloseCon();

                MessageBox.Show("הבקשה נשלחה");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "הבקשה לא נשלחה");
            }
        }

        public void Check_Classes(List<string> classes)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("Select classroom FROM Requests_Lecturers Where Cancell = '" + 0 + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                List<string> requested_Classroom = new List<string>();
                int i = 0;
                while (rdr.Read())
                {
                    requested_Classroom.Add(rdr[i].ToString());
                    i++;
                }

                int req_len = requested_Classroom.Count();
                int classes_len = classes.Count();
                for (i = 0; i < req_len; i++)
                {
                    for(int j = 0; j < classes_len; j++)
                    {
                        if(classes[j] == requested_Classroom[i])
                        {
                            classes.RemoveAt(j);
                        }
                    }
                }
                con.CloseCon();
                rdr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
               
            }
            con.CloseCon();
        }

        public List<Requests_Lecturers2> Load_Lecturers()
        {
            List<Requests_Lecturers2> requests = new List<Requests_Lecturers2>();
            Requests_Lecturers2 newRequest;
            //int status = -1;
            string courseName = "";
            string tempCourseName = "";

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Requests_Lecturers WHERE Status = -1", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    newRequest = new Requests_Lecturers2();
                    newRequest.SetID(rdr["ID"].ToString());
                    newRequest.Set_FName(rdr["FirstName"].ToString());
                    newRequest.Set_LName(rdr["LastName"].ToString());
                    newRequest.Set_Cancell(Convert.ToInt32(rdr["Cancell"].ToString()));
                    newRequest.Set_Classroom(rdr["Classroom"].ToString());

                    courseName = "";
                    tempCourseName = rdr["course"].ToString();
                    for(int i = 0; i < tempCourseName.Length; i++)
                    {
                        if (!(tempCourseName[i] == ' ' && tempCourseName[i + 1] == ' '))
                            courseName += tempCourseName[i];
                        else break;
                    }
                    newRequest.Set_CourseName(courseName);

                    newRequest.Set_Day(rdr["day"].ToString());
                    newRequest.Set_Hour(Convert.ToInt32(rdr["hour"].ToString()));
                    newRequest.Set_Status(Convert.ToInt32(rdr["Status"].ToString()));
                    requests.Add(newRequest);
                }
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return requests;
        }

        public void Confirm_Deny_Request(Requests_Lecturers2 request, int newStatus)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE Requests_Lecturers SET Status = @NewStatus WHERE ID = @ID AND day = @day AND hour = @hour AND classroom = @classroom AND Status = @Status IF @@ROWCOUNT = 0 RAISERROR('No rows updated', 16, 1)", con.GetCon());
                com.Parameters.AddWithValue("@ID", request.GetID());
                com.Parameters.AddWithValue("@day", request.Get_Day());
                com.Parameters.AddWithValue("@hour", request.Get_Hour());
                com.Parameters.AddWithValue("@classroom", request.Get_Classroom());
                com.Parameters.AddWithValue("@Status", -1);
                com.Parameters.AddWithValue("@NewStatus", newStatus);
                com.ExecuteNonQuery();
                
                MessageBox.Show("הפעולה בוצעה בהצלחה");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + " הפעולה נכשלה");
            }
            con.CloseCon();
        }
    }
}
