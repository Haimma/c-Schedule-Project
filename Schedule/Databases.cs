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

    class Databases
    {
        protected SqlConnection con;
        private static Databases instance;

        private Databases()
        {
            con = new SqlConnection("workstation id=AAAschedule.mssql.somee.com;packet size=4096;user id=idanlevi_SQLLogin_1;pwd=de4lypwmh3;data source=AAAschedule.mssql.somee.com;persist security info=False;initial catalog=AAAschedule");
        }
        public SqlConnection GetCon()
        {
            return con;
        }

        public static Databases Instance()
        {
            if (instance == null)
            {
                instance = new Databases();
            }
            return instance;
        }
        public bool Con_State()
        {
            if (con.State != ConnectionState.Closed)
                return false;
            return true;
            
        }

        public void CloseCon()
        {

            if (con.State != ConnectionState.Closed)
                con.Close();
        }
        public void OpenCon()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}