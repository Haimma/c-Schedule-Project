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
    class TutorsDB
    {

        Databases con = Databases.Instance();
        SqlCommand com;
        public void insertTutors(String username, String password, String fname, String lname, String id, String address)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("INSERT into Tutors VALUES('" + username + "','" + password + "','" + fname + "','" + lname + "','" + id + "','" + address +"','"+32+ "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                MessageBox.Show("Tutors Saved");
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
        public bool existTutors(String username, String id)
        {
            bool flag = false;
            int flag1 = 0;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from Tutors", con.GetCon());
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
                com = new SqlCommand("SELECT * from Tutors", con.GetCon());
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


        public void fillTutors_list(ListBox lb_nameLecturers, string nameCourse, int day, int hour, CoursesDB selectedCourseOBJ)
        {
            //---input to list all lecturers of this course
            List<string> IDtutorsListFULL = new List<string>();
            char semester;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM TutorToCourses WHERE NameCourse = '" + nameCourse + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    IDtutorsListFULL.Add(rdr[1].ToString());
                }
                con.CloseCon();
                //     lb_nameLecturers.DataSource = IDlecturers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            semester = selectedCourseOBJ.Getsemester();
            int numh = selectedCourseOBJ.GetNumOfLec();
            //---check if each lecturer can learning in this time
            checkPreferencesTutors(lb_nameLecturers, IDtutorsListFULL, day, hour, semester, numh);


        }

        public void checkPreferencesTutors(ListBox lb_nametutorlist, List<string> IDtutorsListFULL, int day, int hour, char semester,int numh)
        {


            List<string> id_tutorsList = new List<string>();
            foreach (string lec in IDtutorsListFULL)
                id_tutorsList.Add(lec);
            try
            {
                string nameLec = "";
                int hourStart, hourEnd,peref;
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM PreferencesTutor ", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    nameLec = rdr.GetString(0);
                    peref = rdr.GetInt32(5);
                    foreach (string idItem in IDtutorsListFULL)
                    {   //check id
                        if (nameLec == idItem)
                        {
                            if ((!rdr.GetString(2).Contains(semester) || (!rdr.GetInt32(1).Equals(day))))        //check semseters,days
                                id_tutorsList.Remove(idItem);
                            else {
                                hourStart = rdr.GetInt32(3);
                                hourEnd = rdr.GetInt32(4);
                                if (hourStart > hour || hourEnd < hour + numh )
                                    id_tutorsList.Remove(idItem);
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

            GetFullNameByIDTut(lb_nametutorlist, id_tutorsList);
        }

        public void GetFullNameByIDTut(ListBox lb_nameLecturers, List<string> IDlecturersList)
        {
            string IDTut;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Tutors ", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    IDTut = rdr.GetString(4);       //from Toturs database
                    foreach (string item in IDlecturersList)
                        if (IDTut == item)
                            lb_nameLecturers.Items.Add(rdr.GetString(2) + " " + rdr.GetString(3));
                }
                con.CloseCon();
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
                com = new SqlCommand("SELECT * FROM Tutors WHERE ID = '" + IDlecturers + "'", con.GetCon());
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

        public string GetAmauntHours(string lb_idTutors)
        {
            string re;
            string IDtut;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Tutors ", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    IDtut = rdr.GetString(4);       //from Tutors database
                    if (IDtut == lb_idTutors)
                    {
                        re = rdr["Hours"].ToString();
                        return re;
                    }
                         
                }
                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "-1";
        }

        public void Update_Password(string password, string id)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE Tutors SET Password = '" + password + "' WHERE ID = '" + id + "'", con.GetCon());
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
                com = new SqlCommand("UPDATE Tutors SET Address = '" + address + "' WHERE ID = '" + id + "'", con.GetCon());
                com.ExecuteNonQuery();
                MessageBox.Show("Address Changed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
    }
            con.CloseCon();
}

        public List<Tutor> Get_All_Tutors()
        {
            List<Tutor> tutors = new List<Tutor>();
            Tutor tutor = new Tutor();

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Tutors", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    tutor = new Tutor();
                    tutor.setAddress(rdr["Address"].ToString());
                    tutor.setFirstName(rdr["First_Name"].ToString());
                    tutor.setID(rdr["ID"].ToString());
                    tutor.setLastName(rdr["Last_Name"].ToString());
                    tutor.setnumOfHours(Convert.ToInt32(rdr["Hours"].ToString()));
                    tutor.setPassword(rdr["Password"].ToString());
                    tutor.setUserName(rdr["User_Name"].ToString());

                    tutors.Add(tutor);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return tutors;
        }

        public void GetTutorsNames(ComboBox ComboB)
        {
            int i = 0;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT First_Name +' '+ Last_Name FROM Tutors", con.GetCon());
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

        public bool chackIdTutor(String id)
        {
            int flag1 = 0;

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from Tutors WHERE ID ='" + id + "'", con.GetCon());
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

        public string returnNameOfTutor(string id)
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

