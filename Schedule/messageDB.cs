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
    class messageDB
    {
        Databases con = Databases.Instance();  //
        SqlCommand com;

        public List<string>returnmessages(string id)
        {
            List<string> S = new List<string>();
            try
            {
                con.OpenCon();
                //---select high ID course
                SqlCommand com = new SqlCommand("SELECT * FROM Message where ID='" + id + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    S.Add(rdr["Message"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.CloseCon();
            return S;
        }

        public void InformStudentAndDepartmentManager()
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Students", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                List<Student> LS = new List<Student>();

                while (rdr.Read())
                {
                    Student temp = new Student();
                    temp.setID(rdr["ID"].ToString());
                    temp.setAverage(float.Parse(rdr["Average"].ToString()));
                    LS.Add(temp);
                }
                con.CloseCon();
                for (int i = 0; i < LS.Count; i++)
                {
                    if (LS[i].getAverage() <= 56)
                    {
                        try
                        {
                            con.OpenCon();
                            com = new SqlCommand("INSERT into Message (ID,Message) VALUES('" + LS[i].getID() + "','" + "Average student fails" + "');", con.GetCon());
                            SqlDataReader rd;
                            rd = com.ExecuteReader();
                            while (rd.Read()) { }
                            con.CloseCon();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    if (LS[i].getAverage() >= 85)
                    {
                        try
                        {
                            con.OpenCon();
                            com = new SqlCommand("INSERT into Message (ID,Message) VALUES('" + LS[i].getID() + "','" + "The student is outstanding" + "');", con.GetCon());
                            SqlDataReader rd;
                            rd = com.ExecuteReader();
                            while (rd.Read()) { }
                            con.CloseCon();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insert_mass_of_confirm_req(string id, string course_name, int status)
        {
            string mass;
            if (status == 1)
                mass = "The request to Extra Exam in Course " + course_name + " is CONFIRM";
            else
                mass = "The request to Extra Exam in Course " + course_name + " is NOT-CONFIRM";

            try
            {
                con.OpenCon();
                com = new SqlCommand("INSERT into Message (ID,Message) VALUES('" + id + "','" + mass + "');", con.GetCon());
                SqlDataReader rd;
                rd = com.ExecuteReader();
                MessageBox.Show("The informtion SENDED to the student");

                while (rd.Read()) { }
                con.CloseCon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
