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
    class UsersDB 
    {
        Databases con = Databases.Instance();
        SqlCommand com;

        public string GetUserType(string userName, string password)
        {
            con.OpenCon();
            com = new SqlCommand("SELECT Type FROM Users WHERE User_Name='" + userName + "'AND Password='" + password+"'", con.GetCon());
            SqlDataReader rdr;
            string type="";
            rdr = com.ExecuteReader();

            while (rdr.Read())
            {
                type = rdr["Type"].ToString();
            }

            rdr.Close();
            con.CloseCon();
            return type;
            
        }

      public void FindUser(string userName, string password, ref User user, string type)
            {
            try { 
                if(type == "")
                    type = GetUserType(userName, password);
                //MessageBox.Show(type);

                if (type.Contains("Students"))
                    To_Student(userName, password, ref user);
                else if (type.Contains("Lecturers"))
                    To_Lecturer(userName, password, ref user);
                else if (type.Contains("Tutors"))
                    To_Tutor(userName, password, ref user);
                else if (type.Contains("Secretarys"))
                    To_Secretary(userName, password, ref user);
                else if (type.Contains("Department_Managers"))
                    To_Department_Manager(userName, password, ref user);
                else
                {
                    throw new ArgumentException("Ivalid input.");

                }
                
            }

            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //MessageBox.Show(user.GetUserType());
            if (user.GetUserType() == "Student")
            {
                //MessageBox.Show(user.GetStudent().getFirstName() + " " + user.GetStudent().getLastName());
            }
            else if (user.GetUserType() == "Professor")
            {
                //MessageBox.Show(user.GetProfessor().getFirstName() + " " + user.GetProfessor().getLastName());

            }
            else if (user.GetUserType() == "Doctor")
            {
                //MessageBox.Show(user.GetDoctor().getFirstName() + " " + user.GetDoctor().getLastName());
            }
            else if (user.GetUserType() == "Junior")
            {
                //MessageBox.Show(user.GetJunior().getFirstName() + " " + user.GetJunior().getLastName());
            }
            else if (user.GetUserType() == "Tutor")
            {
                //MessageBox.Show(user.GetTutor().getFirstName() + " " + user.GetTutor().getLastName());
            }
            else if (user.GetUserType() == "Secretary")
            {
                //MessageBox.Show(user.GetSecretary().getFirstName() + " " + user.GetSecretary().getLastName());
            }
            else if (user.GetUserType() == "Department Manager")
            {
                //MessageBox.Show(user.GetDepartmentManager().getFirstName() + " " + user.GetDepartmentManager().getLastName());
            }

        }

        public void To_Student(string userName, string password, ref User user/*ref Student student, SqlDataReader rdr*/)
        {
            con.OpenCon();
            com = new SqlCommand("SELECT * FROM Students WHERE User_Name='" + userName + "'AND Password='" + password + "'", con.GetCon());
            SqlDataReader rdr;
            rdr = com.ExecuteReader();

            user.CreateStudent();

            while (rdr.Read())
            {
                user.GetStudent().setUserName(rdr["User_Name"].ToString());
                user.GetStudent().setFirstName(rdr["First_Name"].ToString());
                user.GetStudent().setLastName(rdr["Last_Name"].ToString());
                user.GetStudent().setPassword(rdr["Password"].ToString());
                user.GetStudent().setID(rdr["ID"].ToString());
                user.GetStudent().setAddress(rdr["Address"].ToString());
                
                user.GetStudent().setDepartment(rdr["Department"].ToString());
                user.GetStudent().setYear(rdr["Year"].ToString()[0]);
                user.GetStudent().setAverage(float.Parse(rdr["Average"].ToString()));
                if (rdr["Exellent"].Equals(true))
                    user.GetStudent().setExellent(true);
                else
                    user.GetStudent().setExellent(false);
            }

            rdr.Close();
            con.CloseCon();
            
        }
        
        public void To_Lecturer(string userName, string password, ref User user)
        {
            string type = GetLecturerType(userName, password);
                        
            if (type == "Professor") { To_Professor(userName, password, ref user, type); }
            else if (type == "Doctor") { To_Doctor(userName, password, ref user, type); }
            else if (type == "Junior") { To_Junior(userName, password, ref user, type); }
        }

        private string GetLecturerType(string userName, string password)
        {
            string type = "";
            con.OpenCon();
            com = new SqlCommand("SELECT Type FROM Lecturers WHERE User_Name='" + userName + "'AND Password='" + password + "'", con.GetCon());
            SqlDataReader rdr;
            rdr = com.ExecuteReader();

            while (rdr.Read())
                type = rdr["Type"].ToString();

            rdr.Close();
            con.CloseCon();

            return type;
        }

        private void To_Professor(string userName,string password, ref User user, string type/*, SqlDataReader rdr*/)
        {
            con.OpenCon();
            com = new SqlCommand("SELECT * FROM Lecturers WHERE User_Name='" + userName + "'AND Password='" + password + "' AND Type = 'Professor'", con.GetCon());
            SqlDataReader rdr;
            rdr = com.ExecuteReader();

            user.CreateProfessor();

            while (rdr.Read())
            {
                user.GetProfessor().setUserName(rdr["User_Name"].ToString());
                user.GetProfessor().setPassword(rdr["Password"].ToString());
                user.GetProfessor().setFirstName(rdr["First_Name"].ToString());
                user.GetProfessor().setLastName(rdr["Last_Name"].ToString());
                user.GetProfessor().setAddress(rdr["Address"].ToString());
                user.GetProfessor().setID(rdr["ID"].ToString());
                user.GetProfessor().setnumOfHours(float.Parse(rdr["Hours"].ToString()));
            }
            rdr.Close();
            con.CloseCon();
        }

        private void To_Doctor(string userName, string password, ref User user, string type/*SqlDataReader rdr*/)
        {
            con.OpenCon();
            com = new SqlCommand("SELECT * FROM Lecturers WHERE User_Name='" + userName + "'AND Password='" + password + "' AND Type = 'Doctor'", con.GetCon());
            SqlDataReader rdr;
            rdr = com.ExecuteReader();

            user.CreateDoctor();

            while (rdr.Read())
            {
                user.GetDoctor().setUserName(rdr["User_Name"].ToString());
                user.GetDoctor().setPassword(rdr["Password"].ToString());
                user.GetDoctor().setFirstName(rdr["First_Name"].ToString());
                user.GetDoctor().setLastName(rdr["Last_Name"].ToString());
                user.GetDoctor().setAddress(rdr["Address"].ToString());
                user.GetDoctor().setID(rdr["ID"].ToString());
                user.GetDoctor().setnumOfHours(float.Parse(rdr["Hours"].ToString()));
            }

            rdr.Close();
            con.CloseCon();
        }

        private void To_Junior(string userName, string password, ref User user, string type/*SqlDataReader rdr*/)
        {
            con.OpenCon();
            com = new SqlCommand("SELECT * FROM Lecturers WHERE User_Name='" + userName + "'AND Password='" + password + "' AND Type = 'Junior'", con.GetCon());
            SqlDataReader rdr;
            rdr = com.ExecuteReader();

            user.CreateJunior();

            while (rdr.Read())
            {
                user.GetJunior().setUserName(rdr["User_Name"].ToString());
                user.GetJunior().setPassword(rdr["Password"].ToString());
                user.GetJunior().setFirstName(rdr["First_Name"].ToString());
                user.GetJunior().setLastName(rdr["Last_Name"].ToString());
                user.GetJunior().setAddress(rdr["Address"].ToString());
                user.GetJunior().setID(rdr["ID"].ToString());

                user.GetJunior().setnumOfHours(float.Parse(rdr["Hours"].ToString()));
            }

            rdr.Close();
            con.CloseCon();
        }
        
        public void To_Tutor(string userName, string password, ref User user)
        {
            con.OpenCon();
            com = new SqlCommand("SELECT * FROM Tutors WHERE User_Name='" + userName + "'AND Password='" + password + "'", con.GetCon());
            SqlDataReader rdr;
            rdr = com.ExecuteReader();

            user.CreateTutor();

            while (rdr.Read())
            {
                user.GetTutor().setUserName(rdr["User_Name"].ToString());
                user.GetTutor().setPassword(rdr["Password"].ToString());
                user.GetTutor().setFirstName(rdr["First_Name"].ToString());
                user.GetTutor().setLastName(rdr["Last_Name"].ToString());
                user.GetTutor().setAddress(rdr["Address"].ToString());
                user.GetTutor().setID(rdr["ID"].ToString());

                user.GetTutor().setnumOfHours(float.Parse(rdr["Hours"].ToString()));
            }

            rdr.Close();
            con.CloseCon();
        }

        
        public void To_Secretary(string userName, string password, ref User user)
        {
            con.OpenCon();
            com = new SqlCommand("SELECT * FROM Secretarys WHERE User_Name='" + userName + "'AND Password='" + password + "'", con.GetCon());
            SqlDataReader rdr;
            rdr = com.ExecuteReader();

            user.CreateSecretary();

            while (rdr.Read())
            {
                user.GetSecretary().setUserName(rdr["User_Name"].ToString());
                user.GetSecretary().setPassword(rdr["Password"].ToString());
                user.GetSecretary().setFirstName(rdr["First_Name"].ToString());
                user.GetSecretary().setLastName(rdr["Last_Name"].ToString());
                user.GetSecretary().setAddress(rdr["Address"].ToString());
                user.GetSecretary().setID(rdr["ID"].ToString());
            }

            rdr.Close();
            con.CloseCon();
        }

        public void To_Department_Manager(string userName, string password, ref User user)
        {
            con.OpenCon();
            com = new SqlCommand("SELECT * FROM Department_Managers WHERE User_Name='" + userName + "'AND Password='" + password + "'", con.GetCon());
            SqlDataReader rdr;
            rdr = com.ExecuteReader();

            user.CreateDepartmentManager();

            while (rdr.Read())
            { 
                user.GetDepartmentManager().setUserName(rdr["User_Name"].ToString());
                user.GetDepartmentManager().setPassword(rdr["Password"].ToString());
                user.GetDepartmentManager().setFirstName(rdr["First_Name"].ToString());
                user.GetDepartmentManager().setLastName(rdr["Last_Name"].ToString());
                user.GetDepartmentManager().setAddress(rdr["Address"].ToString());
                user.GetDepartmentManager().setID(rdr["ID"].ToString());
            }

            rdr.Close();
            con.CloseCon();
        }

        public void insertUser(string user, string pass, string id, string type)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("INSERT INTO Users VALUES('" + user + "','" + pass + "','" + id + "','" + type + "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                //MessageBox.Show("User Saved");

                con.CloseCon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update_Password(string password, string id)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE Users SET Password = '" + password + "' WHERE ID = '" + id + "'", con.GetCon());
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
