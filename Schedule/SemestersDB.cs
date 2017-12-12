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
    class SemestersDB 
    {
        Databases con = Databases.Instance();
        SqlCommand com;

        public void insertAcademicYear(string type,DateTime Start, DateTime End)
        {      
            try
            {      
                con.OpenCon();
                com = new SqlCommand("INSERT into Semesters (Type,Starts,Ends) VALUES('" + type + "','" + Start.ToString("yyyy-MM-dd") + "','" + End.ToString("yyyy-MM-dd") + "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                while (rdr.Read())
                {

                }
                con.CloseCon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool ExistsSemester(String semester)
        {
            bool flag = true;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from Semesters", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                String name = "";
                while (rdr.Read())
                {
                    name = rdr.GetString(0);
                    if (name == semester)
                    {
                        flag = false;
                        break;
                    }
                }

                con.CloseCon();
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public void FillTestDateBySemester(ComboBox cb_date,char semester)
        {/*
            try
            {
                con.Open();
                com = new SqlCommand("SELECT * from Semesters", con);
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                String name = "";
                while (rdr.Read())
                {
                    name = rdr.GetString(0);
                    if (name == semester)
                    {
                        flag = false;
                        break;
                    }
                }

                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }*/
        }

        public DateTime GetStartDateTestSemester(char semester)
        {
            DateTime startDate = default(DateTime);
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from Semesters", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                String name = "";
                
                while (rdr.Read())
                {
                    name = rdr.GetString(0);
                    if (semester == 'A')
                    {
                        if (name.Contains("Winter"))
                        {
                            startDate = rdr.GetDateTime(2);
                            break;
                        }
                    }
                    else if (semester == 'B')
                    {
                        if (name.Contains("Spring"))
                        {
                            startDate = rdr.GetDateTime(2);
                            break;
                        }
                    }
                    else if (semester == 'C')
                    {
                        if (name.Contains("Summer"))
                        {
                            startDate = rdr.GetDateTime(2);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return startDate;
        }
        public DateTime GetEndDateTestSemester(char semester)
        {
            DateTime startDate = default(DateTime);
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from Semesters", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                String name = "";

                while (rdr.Read())
                {
                    name = rdr.GetString(0);
                    if (semester == 'A')
                    {
                        if (name.Contains("Spring"))
                        {
                            startDate = rdr.GetDateTime(1);
                            break;
                        }
                    }
                    else if (semester == 'B')
                    {
                        if (name.Contains("Summer"))
                        {
                            startDate = rdr.GetDateTime(1);
                            break;
                        }
                    }
                    else if (semester == 'C')
                    {
                        if (name.Contains("Summer"))
                        {
                            startDate = rdr.GetDateTime(2).AddMonths(1);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return startDate;
        }
    }
}