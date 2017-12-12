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
    class SemesterMinimalAverageDB
    {
        Databases con = Databases.Instance();
        SqlCommand com;
        public void ChangeMinAverage(string Year,string Semester,int Average)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE MinimalAverage SET Average = '" + Average + "' WHERE Year = '" +Year + "' AND Semester= '" + Semester + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                }
                MessageBox.Show("הממוצע המינימאלי השתנה ל-" + Average);
                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
