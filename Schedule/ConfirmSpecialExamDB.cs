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
    class ConfirmSpecialExamDB
    {
        Databases con = Databases.Instance();
        SqlCommand com;


        public void GetIdOfStudent(ListBox ListB)
        {
            string name = "";
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ExamRequest WHERE Status = '" + 0 + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    name = rdr.GetString(1);
                    ListB.Items.Add(name);
                }
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetCourseOfStudent(ListBox ListB,string id)
        {
            string name = "";
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ExamRequest WHERE Student_id='"+id+"'AND Status='"+0+"'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    name = rdr.GetString(3);
                    ListB.Items.Add(name);
                }
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetResonOfStudent(ListBox ListB, string id, string name)
        {
            string name1 = "";
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ExamRequest WHERE Student_id='" + id + "' AND Course_name='"+name+"'AND Status='"+0+"'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    name1 = rdr.GetString(2);
                    ListB.Items.Add(name1);
                }
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cheangeStatus(int st)
        {
            try
            {
                con.OpenCon();
                //---select high ID course
                com = new SqlCommand("INSERT into ExamRequest VALUES('" + st + "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                MessageBox.Show("Status Request Saved");
                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void StatusMassege(string id,string course_name, int status)
        {
            string mass;

            if(status==-1)//decline
            {
                mass = "The request to spciel Exam in course:" + course_name + " Decline";
                try
                {
                    con.OpenCon();
                    //---select high ID course
                    com = new SqlCommand("INSERT into Message VALUES('" + mass + "'" + id + "');", con.GetCon());
                    SqlDataReader rdr;
                    rdr = com.ExecuteReader();
                    //MessageBox.Show("Status Request Saved");
                    con.CloseCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            if(status==1)//confirm
            {
                mass = "The request to spciel Exam in course:" + course_name + " Confirm";
                try
                {
                    con.OpenCon();
                    //---select high ID course
                    com = new SqlCommand("INSERT into Message VALUES('" + mass +"'"+id+ "');", con.GetCon());
                    SqlDataReader rdr;
                    rdr = com.ExecuteReader();
                    //MessageBox.Show("Status Request Saved");
                    con.CloseCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //Exception ex;
                MessageBox.Show("Critical Error");
            }
            
        }
        




    }
}
