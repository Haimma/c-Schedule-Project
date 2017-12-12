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
    class CoursesDB 
    {
        Databases con = Databases.Instance();   //singleton
        SqlCommand com;

        private string Name;
        private int Department;
        private char year;
        private char semester;
        private int NumOfLec;
        private int NumOfTut;



        public CoursesDB(string name,int Department,char year,char semester,int NumOfLec,int NumOfTut)
        {
            this.Name = name;
            this.Department = Department;
            this.year = year;
            this.semester = semester;
            this.NumOfLec = NumOfLec;
            this.NumOfTut = NumOfTut;
        }
        private List<CoursesDB> coursesDB = new List<CoursesDB>();

        public CoursesDB() {
            this.Name = "";
            this.Department = 0;
            this.year = ' ';
            this.semester = ' ';
            this.NumOfLec = 0;
            this.NumOfTut = 0;
        }
        public string GetName() { return Name; }
        public int GetDepartment() { return Department; }
        public char Getyear() { return year; }
        public char Getsemester() { return semester; }
        public int GetNumOfLec() { return NumOfLec; }
        public int GetNumOfTut() { return NumOfTut; }
        
        public void insertCourses(String Name, int Department, char Year, char Semester,int numoflec, int numoftut)
        {

            try
            {
                con.OpenCon();
                com = new SqlCommand("INSERT into Courses (Name,Department,Year,Semester,numoflec,numoftut) VALUES('" + Name + "','" + Department + "','" + Year + "','" + Semester + "','" + numoflec + "','" + numoftut + "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                MessageBox.Show("Coures Saved");
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


        public void Update_nameCourse(String newNameCourse, String oldNameCourse)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE Courses SET Name = '" + newNameCourse + "' WHERE Name = '" + oldNameCourse + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                MessageBox.Show("Update was succcesfully completed");
                con.CloseCon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<CoursesDB> getList() { return coursesDB; }
        public void fillCourses_combobox(ComboBox cb_nameCourses)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Courses", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                string name = "";
                while (rdr.Read())
                {
                    name = rdr.GetString(1);        //choose Name course,index 1
                    cb_nameCourses.Items.Add(name);
                }
                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void fillCourses_list(ListBox lb_nameCourses)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Courses", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                List<string> name = new List<string>();
                while (rdr.Read())
                {
                    name.Add(rdr[1].ToString());
                }
                con.CloseCon();
                lb_nameCourses.DataSource = name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<CoursesDB> readSQLData()
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Courses", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    Name= rdr[0].ToString();
                    Department = rdr.GetInt32(1);
                    year = char.Parse(rdr[2].ToString());
                    semester= char.Parse(rdr[3].ToString());
                    NumOfLec = rdr.GetInt32(4);
                    NumOfTut = rdr.GetInt32(5);

                    coursesDB.Add(new CoursesDB(Name,Department,year,semester,NumOfLec,NumOfTut));
                }
                con.CloseCon();
               
                //lb_nameCourses.DataSource = name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return coursesDB;

        }


        public bool ExistsCourse(String nameCourse)
        {
            bool flag = false;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from Courses", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                String name = "";
                while (rdr.Read())
                {
                    name = rdr.GetString(0);
                    if (name == nameCourse)
                    {
                        flag = true;
                        break;
                    }
                }

                con.CloseCon();
                if (flag)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }



        public bool Remove_Course_From_DB(String nameCourse)
        {
            //check if exist in activeCourses
            bool flag = false;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from ActiveCourses", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                String name = "";
                while (rdr.Read())
                {
                    name = rdr["NameCourse"].ToString();
                    if (name == nameCourse)
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
            {
                MessageBox.Show("This Active course - you can not remove active course.");
                return true;
            }
            else    //not exist in activeCourses and can remove this courses
            {
                try
                {
                    con.OpenCon();
                    com = new SqlCommand("DELETE Courses WHERE Name = '" + nameCourse + "'", con.GetCon());
                    SqlDataReader rdr;
                    rdr = com.ExecuteReader();
                    MessageBox.Show("Deletion was succcesfully completed");
                    con.CloseCon();
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return true;
                }
            }
        }


        public char  GetSemeterByCourse(string nameCourse)
        {
            string semester="";
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT Semester FROM Courses WHERE Name = '" + nameCourse + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    semester = rdr.GetString(0);
                    
                }
                con.CloseCon();
                return char.Parse(semester);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 'X';
            }
        }

        public int getNumHour(string Select_numecourse, int lecOrtut)   //1-Lecturer 2-Tutor
        {

            string nameCourse = "";
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Courses", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                int numh = 0;
                while (rdr.Read())
                {
                    nameCourse = rdr.GetString(0);
                    if (nameCourse == Select_numecourse)
                    {
                        if (lecOrtut == 1)
                            numh = rdr.GetInt32(5);
                        else if (lecOrtut == 2)
                            numh = rdr.GetInt32(6);
                    }

                }
                con.CloseCon();
                rdr.Close();
                return numh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public void Get_Courses_Name_by_User_ID(ComboBox courses, string id, string type)
        {
            try
            {
                con.OpenCon();
                if (type == "Lecturers")
                {
                    com = new SqlCommand("SELECT NameCourse FROM LecturerToCourses WHERE IDlecturer = '" + id + "'", con.GetCon());
                    SqlDataReader rdr = com.ExecuteReader();

                    while (rdr.Read())
                    {
                        courses.Items.Add(rdr.GetString(0));
                    }

                    con.CloseCon();
                    rdr.Close();
                }
                else if(type == "Tutors")
                {
                    com = new SqlCommand("SELECT NameCourse FROM TutorToCourses WHERE IDtutor = '" + id + "'", con.GetCon());
                    SqlDataReader rdr = com.ExecuteReader();

                    while (rdr.Read())
                    {
                        courses.Items.Add(rdr.GetString(0));
                    }

                    con.CloseCon();
                    rdr.Close();
                }
                con.CloseCon();
            }
            catch(Exception e)
            {
                //MessageBox.Show("Unable to get courses for " + type);
                MessageBox.Show(e.Message);
            }
        }

        public void Get_Course_Days(User user, ComboBox days, string course)
        {
            try
            {
                string fullName = user.Get_First_Name() + " " + user.Get_Last_Name();
                con.OpenCon();
                com = new SqlCommand("SELECT day FROM ActiveCourses WHERE nameOfLecOrTut = '" + fullName + "' AND nameCourse = '" + course + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    string leteralDay = rdr.GetString(0);
                    if (leteralDay == "A")
                        days.Items.Add("'א");
                    else if (leteralDay == "B")
                        days.Items.Add("'ב");
                    else if (leteralDay == "C")
                        days.Items.Add("'ג");
                    else if (leteralDay == "D")
                        days.Items.Add("'ד");
                    else if (leteralDay == "E")
                        days.Items.Add("'ה");
                    else if (leteralDay == "F")
                        days.Items.Add("'ו");
                    else throw (new Exception("Data Base fault."));
                }

                con.CloseCon();
                rdr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error loading days: " + e.Message);
            }
        }
       
        public List<string> GetCourseBySemester(char A,char B,char C)
        {
            List<string> CourseList = new List<string>();
            //string Course = "";
            try
            {
                if (A == 'A')
                {
                    con.OpenCon();
                    com = new SqlCommand("SELECT Name FROM Courses WHERE Semester ='" + A + "'", con.GetCon());///
                    SqlDataReader rdr;
                    rdr = com.ExecuteReader();
                    while (rdr.Read())
                    {
                        CourseList.Add(rdr.GetString(0));
                    }
                    con.CloseCon();
                }
                if (B == 'B')
                {
                    con.OpenCon();
                    com = new SqlCommand("SELECT Name FROM Courses WHERE Semester ='" + B + "'", con.GetCon());///
                    SqlDataReader rdr;
                    rdr = com.ExecuteReader();
                    while (rdr.Read())
                    {
                        CourseList.Add(rdr.GetString(0));
                    }
                    con.CloseCon();
                }
                if (C == 'C')
                {
                    con.OpenCon();
                    com = new SqlCommand("SELECT Name FROM Courses WHERE Semester ='" + C + "'", con.GetCon());///
                    SqlDataReader rdr;
                    rdr = com.ExecuteReader();
                    while (rdr.Read())
                    {
                        CourseList.Add(rdr.GetString(0));
                    }
                    con.CloseCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return CourseList;

    }

        public List<string> fillCoursesBySenester_list(string semester, string year)//ListBox lb_nameCourses,
        {
            List<string> course = new List<string>();
            
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Courses WHERE Semester = '" + semester + "' AND Year= '" + year + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    course.Add(rdr["Name"].ToString());
                }
                //lb_nameCourses.DataSource = name; or->
                //foreach (string Item in name)
                //{
                //    lb_nameCourses.Items.Add(Item);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return course;
        }
    
    public void view_Course (String nameOfCourse)
       {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT *FROM Courses where Name ='" + nameOfCourse + "'", con.GetCon());
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Ths course ID is:" + reader["ID"].ToString() + "\nThe course name:" + reader["Name"].ToString() + "\n Department :" + reader["Department"].ToString() + "\n Year :" + reader["Year"].ToString() + "\n Semester : " + reader["Semester"].ToString() + "\n number of lectures : " + reader["NumOfLec"].ToString() + "\n number of exercises : " + reader["NumOfTut"].ToString());

                }
                con.CloseCon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

       }

    }
}