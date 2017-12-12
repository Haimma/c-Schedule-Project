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
    class LecturersDB 
    {
        Databases con = Databases.Instance();
        SqlCommand com;

        public void insertlecturer_db(String username, String password, String fname, String lname, String id, String address,int hours,string type)
        {
            try
            {
                con.OpenCon();

                //---select high ID course

                com = new SqlCommand("INSERT INTO Lecturers VALUES('" + username + "','" + password + "','" + fname + "','" + lname + "','" + id + "','" + address +"','"+hours +"','"+ type+ "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                MessageBox.Show("lecturer & User Saved");

                con.CloseCon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public bool existlecturer_db(String username, String id)
        {
            bool flag = false;
            int flag1 = 0;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from Lecturers", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                String name = "";
                while (rdr.Read())
                {
                    name = rdr.GetString(0);
                    if (name == username)
                    {
                        flag = true;
                        break;
                    }
                }

                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            if (flag)
                flag1++;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from Lecturers", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                String name = "";
                while (rdr.Read())
                {
                    name = rdr.GetString(4);
                    if (name == id)
                    {
                        flag = true;
                        break;
                    }
                }

                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            if (flag)
                flag1++;
            if (flag1 == 2)
                return true;
            return false;
        }

        public void Get_Lecturer_Courses(ComboBox courses, string id)
        {
            CoursesDB courses_db = new CoursesDB();
            courses_db.Get_Courses_Name_by_User_ID(courses, id, "Lecturers");
        }

        //---fill list lecturers 
        public void fillLecturers_list(ListBox lb_nameLecturers, string nameCourse, int day, int hour,CoursesDB coursedb)
        {
            //---input to list all lecturers of this course
            List<string> IDlecturersList = new List<string>();
            char semester;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM LecturerToCourses WHERE NameCourse = '" + nameCourse + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    IDlecturersList.Add(rdr[1].ToString());
                }
                con.CloseCon();
           //     lb_nameLecturers.DataSource = IDlecturers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            semester = coursedb.GetSemeterByCourse(nameCourse);
            int numh = coursedb.getNumHour(lb_nameLecturers.Text, 1);
            //---check if each lecturer can learning in this time
            checkPreferencesLecturers(lb_nameLecturers, IDlecturersList, day, hour,semester,numh);


        }
        
        public void checkPreferencesLecturers(ListBox lb_nameLecturers, List<string> IDlecturersList_Full, int day, int hour, char semester, int numh)
        {
            List<string> id_lecturerList = new List<string>();
            foreach (string lec in IDlecturersList_Full)
                id_lecturerList.Add(lec);
            try
            {
                string nameLec = "";
                int hourStart, hourEnd;
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM PreferencesLecturer ", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    nameLec = rdr.GetString(0);
                    foreach (string idItem in IDlecturersList_Full)
                    {   //check id
                        if (nameLec == idItem)
                        {
                            if ((!rdr.GetString(2).Contains(semester) || (!(rdr.GetInt32(1).Equals(day)))))        //check semseters,days
                                id_lecturerList.Remove(idItem);
                            else {
                                hourStart = rdr.GetInt32(3);
                                hourEnd = rdr.GetInt32(4);
                                if (hourStart > hour || hourEnd < hour + numh)
                                    id_lecturerList.Remove(idItem);
                            }
                        }
                    }
                }
                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            GetFullNameByID(lb_nameLecturers, id_lecturerList); 
        }



        public void GetFullNameByID(ListBox lb_nameLecturers, List<string> IDlecturersList)
        {
            List<string> name_lecturers = new List<string>();
            string IDlec;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Lecturers ", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    IDlec = rdr.GetString(4);       //from Lecturers database
                    foreach (string item in IDlecturersList)
                        if (IDlec == item)
                         lb_nameLecturers.Items.Add(rdr.GetString(2) + " " + rdr.GetString(3));
                }
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string FullNameByID(string IDlecturers)
        {
            string fullName = "";
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Lecturers WHERE ID = '" + IDlecturers + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    fullName = rdr.GetString(2) + " " + rdr.GetString(3);
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return fullName;
        }



        public void GetLecturersNames(ComboBox ComboB)
        {
            int i = 0;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT First_Name +' '+ Last_Name FROM Lecturers", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    ComboB.Items.Add(rdr[i].ToString());
                }
                con.CloseCon();
                rdr.Close();
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
                com = new SqlCommand("UPDATE Lecturers SET Password = '" + password + "' WHERE ID = '" + id + "'", con.GetCon());
                com.ExecuteNonQuery();
                MessageBox.Show("Password changed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
        }

        public void Update_Address(string address, string id)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE Lecturers SET Address = '" + address + "' WHERE ID = '" + id + "'", con.GetCon());
                com.ExecuteNonQuery();
                MessageBox.Show("Address Changed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
        }


        public Lecturer Get_Lecturer_By_Full_Name(string fullName)
        {
            Lecturer lecturer = new Lecturer();
            string firstName = "";
            string lastName = "";
            bool flag = false;
            int i = 0;

            for (i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == ' ')
                {
                    flag = true;
                    i++;
                }

                if (fullName[i] != ' ' && !flag)
                    firstName += fullName[i];
                  else lastName += fullName[i];
            }


            lecturer.setFirstName(firstName);
            lecturer.setLastName(lastName);

            flag = false;

            try
            {
                if(con.Con_State())
                {
                    flag = true;
                    con.OpenCon();
                }

                SqlCommand cmd = new SqlCommand("Select ID FROM Lecturers WHERE First_Name = '" + firstName + "' AND Last_Name = '" + lastName + "'", con.GetCon());
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    lecturer.setID(rdr["ID"].ToString());

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (flag)
                con.CloseCon();
            return lecturer;
        }

        public List<Lecturer> Get_All_Lecturers()
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            Lecturer lecturer = new Lecturer();

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Lecturers", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    lecturer = new Lecturer();
                    lecturer.setUserName(rdr["User_Name"].ToString());
                    lecturer.setPassword(rdr["Password"].ToString());
                    lecturer.setnumOfHours(Convert.ToInt32(rdr["Hours"].ToString()));
                    lecturer.SetLecturerType(rdr["Type"].ToString());
                    lecturer.setLastName(rdr["Last_Name"].ToString());
                    lecturer.setID(rdr["ID"].ToString());
                    lecturer.setFirstName(rdr["First_Name"].ToString());
                    lecturer.setAddress(rdr["Address"].ToString());

                    lecturers.Add(lecturer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return lecturers;
        }

        public string GetAmauntHours(string lb_idLecturers)
        {
            string IDlec;
            string re;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Lecturers ", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    IDlec = rdr.GetString(4);       //from Lecturers database
                    if (IDlec == lb_idLecturers)
                    {
                        re = rdr["Hours"].ToString(); ;
                        return re;
                    }

                }
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "-1";
        }
                        
        public bool chackIdLecturer(String id)
        {
            int flag1 = 0;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from Lecturers WHERE ID ='" + id + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    flag1++;
                }

                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            if (flag1 == 1)
                return true;
            return false;
        }

        public string returnNameOfLec(string id)
        {
            string name = "";
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Tutors WHERE ID = '" + id + "'", con.GetCon());

                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    name = rdr["First_Name"].ToString();
                }
                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return name;
        }

    }
}
