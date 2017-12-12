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
    class ActiveCoursesDB 
    {
        Databases con = Databases.Instance() ;  //
        SqlCommand com;

        string name;
        public string S;
        public string nameCourse;
        public string clas;
        public string day;
        public int hourStart;
        public int hourOver;
        public int numOfStudents;
        public int courseId;

        public ActiveCoursesDB(string name1) //inculde name student
        {
            name = name1;
            S = "SELECT *FROM ActiveCourses WHERE nameOfLecOrTut='" + name + "'";

        }

        public ActiveCoursesDB()    // for lecturer 
        {
            S = "SELECT *FROM ActiveCourses";

        }

        public void InsertNew_ActiveCourse(string nameCourse, string Type, char day, int hourStart, int numOfhours, string nameClass, string nameLecOrTut, int numOfStudent)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("INSERT into ActiveCourses (nameCourse,type,class,day,hourStart,numHours,numOfStudents,nameOfLecOrTut) VALUES('" + nameCourse + "','" + Type + "','" + nameClass + "','" + day + "','" + hourStart + "','" + numOfhours + "','" + numOfStudent + "','" + nameLecOrTut + "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                MessageBox.Show("Active coures Saved");
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


        public void Update_ActiveCourse(int id, int newhour,char newDay, string newclass,  string newlecortut)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE ActiveCourses SET day = '" + newDay + "',hourStart = '" + newhour + "',class = '" + newclass + "',nameOfLecOrTut = '" + newlecortut + "' WHERE IDActiveCourse = '" + id + "'", con.GetCon());
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

        public void Fill_Free_Classes_List(List<string> free_classes, int day, int hour, string courseName, int LecOrTut, CoursesDB course_DB, string type)
        {
            int class_len = 0, numHour = 0;

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ListOfClasses", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                string nameC = "";
                while (rdr.Read())
                {
                    nameC = rdr.GetString(0);
                    free_classes.Add(nameC);
                    class_len++;
                }
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception e) // 
            {
                MessageBox.Show(e.Message);
            }

            //remove "Lectur" or Tutur" if have
            //int index = courseName.IndexOf("-");
            //String fixnumecourse = courseName.Substring(/*0*/1, index);
            //numHour = course_DB.getNumHour(fixnumecourse, LecOrTut);

            List<string> list = new List<string>();
            list = isHeldClass_List(free_classes, day, hour, numHour);
            int n = 0;
            foreach (string item in list)
            {
                free_classes.Remove(list[n]);
                n++;
            }
        }

        public void fillfreeclasses_listBox(ListBox lb_freeclasses, ComboBox day, ComboBox hour, ListBox lb_nameCourse, int LecOrTut, CoursesDB coursedb,int numOfhoursOnCourse)       //1 lec 2 tut
        {
            int  lenClasses = 0;
            string numecourse;
            int Day = day.SelectedIndex + 1;
            int Hour = hour.SelectedIndex + 8;

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ListOfClasses", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                string nameC = "";
                while (rdr.Read())
                {
                    nameC = rdr.GetString(0) ;
                    lb_freeclasses.Items.Add(nameC);
                    lenClasses++;
                }
                con.CloseCon();

            }
            catch (Exception ex) // 
            {
                MessageBox.Show(ex.Message);
            }
           /*
            numecourse = lb_nameCourse.SelectedValue.ToString()+type;

            //remove "Lectur" or Tutur" if have
            int index = numecourse.IndexOf("-");
            String fixnumecourse = numecourse.Substring(0, index);
            numh = coursedb.getNumHour(fixnumecourse, LecOrTut);
            */


            numecourse = lb_nameCourse.SelectedValue.ToString();
        //    numh = coursedb.getNumHour(numecourse, LecOrTut);

            List<string> list = new List<string>();
            list = isHeldclass(lb_freeclasses, Day, Hour, numOfhoursOnCourse);
            int n = 0;
            foreach (string item in list)
            {
                lb_freeclasses.Items.Remove(list[n]);
                n++;
            }

        }


        public List<string> isHeldClass_List(List<string> free_classes, int day, int hour, int numHour)
        {
            string nameclass = "", class_free = "";
            int hstart = 0, numH = 0;
            List<string> list = new List<string>();
            char char_day;
            switch (day)
            {
                case 1:
                    char_day = 'A';
                    break;
                case 2:
                    char_day = 'B';
                    break;
                case 3:
                    char_day = 'C';
                    break;
                case 4:
                    char_day = 'D';
                    break;
                case 5:
                    char_day = 'E';
                    break;
                case 6:
                    char_day = 'F';
                    break;
                default:
                    char_day = ' ';
                    break;
            }
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ActiveCourses WHERE day = '" + char_day + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    nameclass = rdr.GetString(2);       //from heldclass

                    foreach (Object item in free_classes)
                    {
                        class_free = item.ToString(); // /n to print each item on new line or you omit /n to print text on same line

                        if (nameclass == class_free)
                        {
                            hstart = rdr.GetInt32(4);
                            numH = rdr.GetInt32(5);
                            if ((hstart >= hour && hstart <= hour + numH) || (hstart + numHour >= hour && hstart + numHour <= hour + numH) || (hour >= hstart && hour <= hstart + numHour) || (hour + numH >= hstart && hour + numH <= hstart + numHour))
                                list.Add(class_free);    //isHeldclass

                        }
                    }
                }
                con.CloseCon();
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return list;
            }
        }

        public List<string> isHeldclass(ListBox lb_freeclasses, int day, int hour, int numhChooseCourse)
        {
            string nameclass = "", class_free = "";
            int hstart = 0, numH = 0;
            List<string> list = new List<string>();
            char char_day;
            switch (day)
            {
                case 1:
                    char_day = 'A';
                    break;
                case 2:
                    char_day = 'B';
                    break;
                case 3:
                    char_day = 'C';
                    break;
                case 4:
                    char_day = 'D';
                    break;
                case 5:
                    char_day = 'E';
                    break;
                case 6:
                    char_day = 'F';
                    break;
                default:
                    char_day = ' ';
                    break;
            }
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ActiveCourses WHERE day = '" + char_day + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    nameclass = rdr.GetString(2);       //from heldclass

                    foreach (Object item in lb_freeclasses.Items)
                    {
                        class_free = item.ToString(); // /n to print each item on new line or you omit /n to print text on same line

                        if (nameclass == class_free)
                        {
                            hstart = rdr.GetInt32(4);
                            numH = rdr.GetInt32(5);
                            if ((hstart >= hour && hstart <= hour + numH) || (hstart + numhChooseCourse >= hour && hstart + numhChooseCourse <= hour + numH) || (hour >= hstart && hour <= hstart + numhChooseCourse) || (hour + numH >= hstart && hour + numH <= hstart + numhChooseCourse))
                                list.Add(class_free);    //isHeldclass

                        }
                    }
                }
                con.CloseCon();
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return list;
            }
        }

        public string Get_Course_Classroom(string FirstName, string LastName, string course, string day, int starts)
        {
            string FullName = FirstName + " " + LastName;
            //string leteralDay = "";
            string classroom = "";
            
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT class FROM ActiveCourses WHERE nameOfLecOrTut = '" + FullName + "' AND nameCourse = '" + course + "' AND day = '" + day + "' AND hourStart = '" + starts + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    classroom = rdr[0].ToString();
                }

                con.CloseCon();
                rdr.Close();

                return classroom;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }


        public string DetailsCourse(string namecourse)
        {
            //int i;
            string detailsCourse = "";
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ActiveCourses", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    if (namecourse == rdr.GetString(0) + " - " + rdr.GetString(1) +" - " + rdr.GetInt32(8))
                    {

                        detailsCourse = namecourse + "\nDay: " + rdr.GetString(3) + "    Hour: " + rdr.GetInt32(4).ToString() + "    Class: " + rdr.GetString(2) + "  With: " + rdr.GetString(7);
                    }
                }
                con.CloseCon();
                return detailsCourse;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "Error";
            }
        }


        public void fillActiveCourses_list(ListBox lb_nameCourses)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ActiveCourses", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                List<string> name = new List<string>();
                while (rdr.Read())
                {
                    name.Add(rdr[0].ToString() + " - " + rdr[1].ToString() +" - " + rdr[8].ToString());

                }
                con.CloseCon();
                lb_nameCourses.DataSource = name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int GetIDActiveCourse(ListBox lb_nameCourses)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ActiveCourses", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                int id = 0;
                while (rdr.Read())
                {
                    if ((rdr[0].ToString() + " - " + rdr[1].ToString() + " - " + rdr.GetInt32(8)) == lb_nameCourses.Text)
                        id = rdr.GetInt32(8);
                }
                con.CloseCon();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public string GetTypeActiveCourse(ListBox lb_nameCourses)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ActiveCourses", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                string type="";
                while (rdr.Read())
                {
                    if ((rdr[0].ToString() + " - " + rdr[1].ToString() + " - " + rdr.GetInt32(8)) == lb_nameCourses.Text)
                        type = rdr[1].ToString();
                }
                con.CloseCon();
                return type;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        public void Get_Course_Hours(string course, string day, string FirstName, string LastName, ComboBox courseHours)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT hourStart FROM ActiveCourses WHERE nameCourse = '" + course + "' AND day = '" + day + "' AND nameOfLecOrTut = '" + FirstName + " " + LastName + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    courseHours.Items.Add(rdr[0].ToString());
                }
                con.CloseCon();
                rdr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void Get_Remainig_Hours_Of_Day(string course, string day)
        {
            CoursesDB courseDB = new CoursesDB();
            //int lecture_length = -1;
            List<ActiveCourses> courses = new List<ActiveCourses>();
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT NumOfLec FROM Courses WHERE Name = '" + course + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                int length = 0;
                while (rdr.Read())
                {
                    length = Convert.ToInt32(rdr[0].ToString());
                }
                con.CloseCon();
                rdr.Close();

                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ActiveCourses WHERE nameCourse = '" + course + "' AND day = '" + day + "'", con.GetCon());
                rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    courses.Add(new ActiveCourses(rdr[0].ToString(),rdr[1].ToString(),rdr[3].ToString(),rdr[4].ToString(), Convert.ToInt32(rdr[5].ToString()), Convert.ToInt32(rdr[6].ToString()), Convert.ToInt32(rdr[7].ToString()), rdr[8].ToString(), rdr[9].ToString()));
                   // lecture_length = Convert.ToInt32(rdr[0].ToString());
                }
                con.CloseCon();
                rdr.Close();
                

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
              public bool ExsistInThisTime(string name,int hourselect,int hourCourse,char day)
        {
            bool flag = false;  //no teaching in this time

            try
            {
                int hstart, numH,hEnd;
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ActiveCourses WHERE nameOfLecOrTut = '"+name+"' AND day= '"+day+"'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    
                    hstart = rdr.GetInt32(4);
                    numH = rdr.GetInt32(5);
                    hEnd = numH + hstart;
                        
                    if ((hstart >= hourselect && hstart <= hourselect + numH) || (hstart + hourCourse >= hourselect && hstart + hourCourse <= hourselect + numH) || (hourselect >= hstart && hourselect <= hstart + hourCourse) || (hourselect + numH >= hstart && hourselect + numH <= hstart + hourCourse))
                        flag = true;    //tewaching in this time
                }
                con.CloseCon();
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return flag;
            }
            
        }



        public ActiveCoursesDB MakeLecD(int idActiveCourse )
              {
            //List<ActiveCoursesDB> showList = new List<ActiveCoursesDB>();
            ActiveCoursesDB activeCourse = new ActiveCoursesDB();
            try
            {
                      con.OpenCon();
                SqlCommand comm = new SqlCommand("SELECT *FROM ActiveCourses WHERE nameOfLecOrTut='" + name + "'AND IDActiveCourse='" + idActiveCourse + "'", con.GetCon());
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

        

        public List<int> returnIDActiveCoursesForStu(string idStu)
        {
            List<int> list = new List<int>();
            try
            {
                con.OpenCon();
                SqlCommand comm = new SqlCommand("SELECT * FROM StudentToCourse WHERE studentId ='" + idStu + "'", con.GetCon());
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(int.Parse(reader["activeCourseId"].ToString()));
                   
                }
                con.CloseCon();
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return list;
            }

        }

        public List<string> returnCoursesForLec(string nameLec)
        {
            List<string> list = new List<string>();
            try
            {
                con.OpenCon();
                SqlCommand comm = new SqlCommand("SELECT * FROM ActiveCourses WHERE nameOfLecOrTut ='" + nameLec + "'", con.GetCon());
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader["nameCourse"].ToString());

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

        public int returnIDActiveCoursesForLec(string nameOfLecOrTut, string nameCourse)
        {
            int idcourse = 0;
            try
            {
                con.OpenCon();
                SqlCommand comm = new SqlCommand("SELECT * FROM ActiveCourses WHERE nameCourse ='" + nameCourse + "'AND nameOfLecOrTut ='" + nameOfLecOrTut + "'", con.GetCon());
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    idcourse = int.Parse(reader["IDActiveCourse"].ToString());

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.CloseCon();
            return idcourse;

        }

        public ActiveCoursesDB MakeStudentSchedule(int idActiveCourse)
        {
            ActiveCoursesDB list1 = new ActiveCoursesDB();
            try
            {
                con.OpenCon();
                SqlCommand comm = new SqlCommand("SELECT * FROM ActiveCourses WHERE IDActiveCourse ='" + idActiveCourse + "'", con.GetCon());
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    list1.nameCourse = reader["nameCourse"].ToString();
                    list1.clas = reader["class"].ToString();
                    list1.day = reader["day"].ToString();
                    list1.hourStart = int.Parse(reader["hourStart"].ToString());
                    list1.hourOver = int.Parse(reader["numHours"].ToString());
                }
                con.CloseCon();
                return list1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return list1;
            }
        }

       

        public override string ToString()
        {
            return "" + day + "\t     " + clas + "\t\t" + hourStart.ToString() + "\t\t" + hourOver.ToString() + "\t\t" + nameCourse;
        }


        public bool inseretCourseTostudent(string id, string CoursName, int CoursId)
        {
            try
            {
                con.OpenCon();
                SqlCommand comm = new SqlCommand("INSERT INTO StudentToCourse (studentId,nameOfCourse,activeCourseId) VALUES ('" + id + "','" + CoursName + "'," + CoursId + ");", con.GetCon());
                comm.ExecuteNonQuery();
                con.CloseCon();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                con.CloseCon();
                return false;
            }
            return true;
        }

        public int GetIDCoursesByLecOrTut(int ID, char day, int hour, string FullName)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT IDActiveCourse FROM ActiveCourses WHERE nameOfLecOrTut='" + FullName + "' AND day='" + day + "' AND hourStart='" + hour + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    ID = Convert.ToInt32(rdr[0]);
                }
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ID;
        }

        public void GetCoursesNameByLecOrTut(ComboBox ComboB, string Fname, string Lname)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ActiveCourses WHERE  nameOfLecOrTut='" + Fname + " " + Lname + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    ComboB.Items.Add(rdr[0].ToString() + ": " + rdr[3].ToString() + " Start at-" + rdr[4].ToString());
                }
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ActiveCourses Get_Courses_By_ID(int id)
        {
            ActiveCourses course = new ActiveCourses();
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ActiveCourses WHERE IDActiveCourse = '" + id + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    course.Set_Name(rdr["nameCourse"].ToString());
                    string type = rdr["type"].ToString();
                    type.Replace(" ", "");
                    course.Set_Type(type);
                    course.Set_Day(rdr["day"].ToString());
                    course.Set_Start(Convert.ToInt32(rdr["hourStart"].ToString()));
                    course.Set_Length(Convert.ToInt32(rdr["numHours"].ToString()));
                    course.Set_Num_OF_Students(Convert.ToInt32(rdr["numOfStudents"].ToString()));
                    course.Set_Lecturer_Full_Name(rdr["nameOfLecOrTut"].ToString());
                    course.Set_ID(rdr["IDActiveCourse"].ToString());
                    course.Set_Classroom(rdr["class"].ToString());
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return course;
        }

        public List<Lecturer> Get_Lecturers_For_Grades(List<StudentGrade> grades, List<int> coursesID)
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            LecturersDB lecDB = new LecturersDB();
            List<string> lecNames = new List<string>();

            try
            {
                con.OpenCon();
                int size = grades.Count();

                for (int i = 0; i < size; i++)
                {
                    com = new SqlCommand("SELECT * FROM ActiveCourses WHERE IDActiveCourse = '" + grades[i].Get_Course_ID() + "' AND type = 'Lecture'", con.GetCon());
                    SqlDataReader rdr = com.ExecuteReader();

                    while (rdr.Read())
                    {
                        lecNames.Add(rdr["nameOfLecOrTut"].ToString());

                        coursesID.Add(Convert.ToInt32(rdr["IDActiveCourse"].ToString()));
                    }
                    rdr.Close();
                }

                size = lecNames.Count();
                for (int i = 0; i < size; i++)
                    lecturers.Add(lecDB.Get_Lecturer_By_Full_Name(lecNames[i]));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return lecturers;
        }


        public void fillFreeClass(ListBox lb_freeclasses)
        {
            int lenClasses = 0;

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM ListOfClasses", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                string nameC = "";
                while (rdr.Read())
                {
                    nameC = rdr.GetString(0);
                    lb_freeclasses.Items.Add(nameC);
                    lenClasses++;
                }
                con.CloseCon();

            }
            catch (Exception ex) // 
            {
                MessageBox.Show(ex.Message);
            }
        }



        






    }
}
