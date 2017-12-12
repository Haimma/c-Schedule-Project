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
    class ExamRequestDB
    {
        Databases con = Databases.Instance();   //singleton
        SqlCommand com;

        string st_id,text,course_name;
        int status;


        public ExamRequestDB()
        {
            st_id="";
            text="";
            course_name="";
            status=1;
        }

        public void insertExamRequest(int Status,string Student_id,string Course_name,string Request)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("INSERT into ExamRequest (Status,Student_id,Course_name,Request) VALUES('" + Status + "','" + Student_id + "','" + Course_name + "','" + Request + "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                MessageBox.Show("Request For Exam Saved");
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

        public void updateExamRequest(string id)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE ExamRequest SET Status='" + 1 + "'where Student_id='" + id + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                //MessageBox.Show("Request For Exam Saved");
                //while (rdr.Read())
                //{

                //}
                con.CloseCon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
