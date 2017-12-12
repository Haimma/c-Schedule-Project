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
    class UserFactory
    {

        public User GetUser(string userName, string password, string type)
        {
            User user = new User();          
            UsersDB userdb = new UsersDB();     //connection with Users Database

            try
            {
                if (type == "")
                    type = userdb.GetUserType(userName, password);

                if (type.Contains("Students"))
                    userdb.To_Student(userName, password, ref user);        //update reference
                else if (type.Contains("Lecturers"))
                    userdb.To_Lecturer(userName, password, ref user);
                else if (type.Contains("Tutors"))
                    userdb.To_Tutor(userName, password, ref user);
                else if (type.Contains("Secretarys"))
                    userdb.To_Secretary(userName, password, ref user);
                else if (type.Contains("Department_Managers"))
                    userdb.To_Department_Manager(userName, password, ref user);
                else
                {
                    throw new ArgumentException("Ivalid input.");
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return user;
            
        }

    }
}
