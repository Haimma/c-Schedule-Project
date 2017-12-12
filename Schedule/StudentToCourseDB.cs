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
    class StudentToCourseDB
    {
        Databases con = Databases.Instance();
        SqlCommand com;

        public void GetStudentsInCourse(ListBox ListB,int id, string CourseName)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM StudentToCourse WHERE  nameOfCourse='" + CourseName + "' AND activeCourseid='"+ id+"'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    ListB.Items.Add(rdr[0].ToString());
                }
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetCourseOfStudent(ListBox ListB, string id)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM StudentToCourse WHERE  studentid='" + id + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    ListB.Items.Add(rdr[1].ToString());
                }
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetStudentsInCourseCombo(ComboBox Combo, int id, string CourseName)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM StudentToCourse WHERE  nameOfCourse='" + CourseName + "' AND activeCourseid='" + id + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    Combo.Items.Add(rdr[0].ToString());
                }
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetCoursesID(ComboBox courses, ref List<int> courseID, string id, string lecOrTut)
        {
            List<int> IDs = new List<int>();
            List<string> courseNames = new List<string>();
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM StudentToCourse WHERE studentid = '" + id + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                
                while (rdr.Read())
                {
                    IDs.Add(Convert.ToInt32(rdr["activeCourseid"].ToString()));
                    courseNames.Add(rdr["nameOfCourse"].ToString());
                }

                for(int i = IDs.Count() - 1; i >= 0; i--)
                {
                    rdr.Close();
                    int temp_id = IDs[i];
                    com = new SqlCommand("Select * FROM ActiveCourses WHERE IDActiveCourse = '" + temp_id + "' AND type = '" + lecOrTut + "'", con.GetCon());
                    rdr = com.ExecuteReader();

                    while (rdr.Read())
                    {
                        courseID.Add(Convert.ToInt32(rdr["IDActiveCourse"].ToString()));
                        courses.Items.Add(rdr["nameCourse"].ToString());
                    }
                }

                rdr.Close();
                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        public void Fill_Current_Course_Data(int courseID, TextBox day, TextBox start, TextBox ends, TextBox LecOrTutName, string lecOrTut)
        {
            try {
                con.OpenCon();
                com = new SqlCommand("Select * FROM ActiveCourses WHERE IDActiveCourse = '" + courseID + "' AND type = '" + lecOrTut + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    day.Text = convertDay(rdr["day"].ToString());
                    start.Text = rdr["hourStart"].ToString();
                    ends.Text = (Convert.ToInt32(start.Text) + Convert.ToInt32(rdr["numHours"].ToString())).ToString();
                    LecOrTutName.Text = rdr["nameOfLecOrTut"].ToString();

                }
                rdr.Close();
                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<int> Fill_Alternative_Courses(ListBox alternatives, int courseID, string current, string lecOrtutName)
        {
            List<int> selectedCourseID = new List<int>();

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ActiveCourses WHERE nameCourse = '" + current + "' AND IDActiveCourse != '" + courseID + "' AND type = '" + lecOrtutName + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    string day = convertDay(rdr["day"].ToString());
                    int end = Convert.ToInt32(rdr["hourStart"].ToString()) + Convert.ToInt32(rdr["numHours"].ToString());
                    alternatives.Items.Add(rdr["nameOfLecOrTut"].ToString() +"\t"+ day + "\t" + rdr["hourStart"].ToString() + "-" + end + "\t" + rdr["class"].ToString());
                    selectedCourseID.Add(Convert.ToInt32(rdr["IDActiveCourse"].ToString()));
                }
                rdr.Close();
                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return selectedCourseID;
        }

        public string convertDay(string day)
        {
            if (day == "A")
                return "א'";
            else if (day == "B")
                return "ב'";
            else if (day == "C")
                return "ג'";
            else if (day == "D")
                return "ד'";
            else if (day == "E")
                return "ה'";
            else if (day == "F")
                return "ו'";
            else return null;
        }

        public void Update_By_Request(int OriginalCourseID, int NewCourseID, string studentID, string OldCourse, string NewCourse)
        {
            Boolean flag = (!con.Con_State());
            try
            {
                if (flag)
                    con.OpenCon();

                com = new SqlCommand("UPDATE StudentToCourse SET nameOfCourse = @NewName, activeCourseid = @NewCourseID WHERE studentid = @ID AND nameOfCourse = @name AND activeCourseid = @CourseID", con.GetCon());
                com.Parameters.AddWithValue("@ID", studentID);
                com.Parameters.AddWithValue("@name", OldCourse);
                com.Parameters.AddWithValue("@CourseID", OriginalCourseID);
                com.Parameters.AddWithValue("@NewName", NewCourse);
                com.Parameters.AddWithValue("@NewCourseID", NewCourseID);
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (flag)
                con.CloseCon();
        }

        public List<StudentGrade> Get_Grades(string id)
        {
            List<StudentGrade> grades = new List<StudentGrade>();
            StudentGrade grade;

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM StudentsGrades WHERE studentID = '" + id + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    grade = new StudentGrade();
                    grade.Set_Student_ID(id);
                    grade.Set_CourseName(rdr["courseName"].ToString());
                    grade.Set_Grade(Convert.ToInt32(rdr["Grade"].ToString()));

                    grades.Add(grade);
                }

                rdr.Close();

                for(int i = 0; i < grades.Count(); i++)
                {
                    grades[i].Set_Course_ID(Get_Course_ID_Grades(grades[i]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return grades;
        }

        private int Get_Course_ID_Grades(StudentGrade grade)
        {
            SqlCommand cmd = new SqlCommand("SELECT activeCourseid FROM StudentToCourse WHERE studentid = '" + grade.Get_Student_ID() + "' AND nameOFCourse = '" + grade.Get_CourseName() + "'", con.GetCon());
            SqlDataReader rdr2 = cmd.ExecuteReader();

            List<int> coursesId = new List<int>();

            while (rdr2.Read())
            {
                coursesId.Add(Convert.ToInt32(rdr2["activeCourseid"].ToString()));
            }

            rdr2.Close();
            return Find_Lecture(coursesId, grade);
        }

        private int Find_Lecture(List<int> coursesID, StudentGrade grade)
        {
            int id = -1;
            for (int i = 0; i < coursesID.Count(); i++)
            {
                SqlCommand cmd = new SqlCommand("SELECT type From ActiveCourses WHERE nameCourse = '" + grade.Get_CourseName() + "' AND IDActiveCourse = '" + coursesID[i] + "'", con.GetCon());
                SqlDataReader rdr2 = cmd.ExecuteReader();

                while (rdr2.Read())
                {
                    if(rdr2["type"].ToString() == "Lecture        ")
                        id = coursesID[i];
                }
                rdr2.Close();
            }
            return id;
        }

        public List<int> Get_Grade_By_Appeal(List<Appeals_Student> appeals)
        {
            List<int> grades = new List<int>();
            int grade = -1;

            try
            {
                con.OpenCon();
                int size = appeals.Count();
                for (int i =0; i < size; i++)
                {
                    com = new SqlCommand("SELECT * FROM StudentsGrades WHERE studentID = '" + appeals[i].Get_Student_ID() + "' AND courseName = '" + appeals[i].Get_Course_Name() + "'", con.GetCon());
                    SqlDataReader rdr = com.ExecuteReader();

                    while (rdr.Read())
                    {
                        grade = Convert.ToInt32(rdr["Grade"].ToString());
                    }

                    grades.Add(grade);
                rdr.Close();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return grades;
        }

        public List<string> chackYearToStu(String year)
        {
            List<string> course = new List<string>();
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from Courses WHERE Year ='" + year + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    course.Add(rdr["Name"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
            con.CloseCon();
            return course;
        }

        public int getNumOfCourse(string nameCourse)
        {
            int idTest = 0;
            try
            {
                int flag = 0;
                con.OpenCon();
                com = new SqlCommand("SELECT *FROM Courses where Name = '" + nameCourse + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    idTest = Convert.ToInt32(rdr["ID"]);
                }

                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return idTest;
        }

        public ActiveCoursesDB MakeStudentSchedule(string nameCourse, string nameLec)
        {
            //List<ActiveCoursesDB> showList = new List<ActiveCoursesDB>();
            ActiveCoursesDB activeCourse = new ActiveCoursesDB();
            try
            {
                con.OpenCon();
                SqlCommand comm = new SqlCommand("SELECT *FROM ActiveCourses WHERE nameCourse='" + nameCourse + "'AND nameOfLecOrTut='" + nameLec + "'", con.GetCon());
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    activeCourse.nameCourse = reader["nameCourse"].ToString();
                    activeCourse.clas = reader["class"].ToString();
                    activeCourse.day = reader["day"].ToString();
                    activeCourse.hourStart = int.Parse(reader["hourStart"].ToString());
                    activeCourse.hourOver = int.Parse(reader["numHours"].ToString());

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.CloseCon();
            return activeCourse;
        }

        public List<string> returnCoursesWithSameName(string nameCourse)
        {
            List<string> list = new List<string>();

            try
            {
                con.OpenCon();
                SqlCommand comm = new SqlCommand("SELECT * FROM ActiveCourses WHERE nameCourse ='" + nameCourse + "'", con.GetCon());
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader["IDActiveCourse"].ToString() + "_" + reader["nameCourse"].ToString() + ": " + reader["class"].ToString() + "    " + reader["day"].ToString() + "    " + reader["hourStart"].ToString() + "    " + reader["numHours"].ToString());


                }
                reader.Close();
                con.CloseCon();
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return list;
            }

        }
    }
}
