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
   
    class TestScheduleDB
    {
        Databases con = Databases.Instance();
        SqlCommand com;

        List<string> freeClass_FullList = new List<string>();

        public void fillfreeclasses_list(ListBox lb_freeclasses, DateTime datetime, ComboBox hour, CoursesDB nameCourseSelect, CoursesDB coursedb)       //1 lec 2 tut
        {
            int numhTest = 3;
            int Hour = hour.SelectedIndex + 8;
            if (freeClass_FullList.Count == 0)
            {
                try
                {
                    con.OpenCon();
                    com = new SqlCommand("SELECT * FROM ListOfClasses", con.GetCon());
                    SqlDataReader rdr = com.ExecuteReader();
                    //       string nameC = "";
                    while (rdr.Read())
                    {
                        freeClass_FullList.Add(rdr.GetString(0));
                        /*
                        nameC = rdr.GetString(0) ;
                        lb_freeclasses.Items.Add(nameC);
                        lenClasses++;
                        */
                    }
                    con.CloseCon();

                }
                catch (Exception ex) // 
                {
                    MessageBox.Show(ex.Message);
                }
            }

            List<string> listHeld = new List<string>();

            /*
            int n = 0;
            foreach (string item in listHeld)
            {
                lb_freeclasses.Items.Remove(listHeld[n]);
                n++;
            }
            */
            foreach (string cla in isHeldclass(datetime, Hour, numhTest))
                lb_freeclasses.Items.Add(cla);


        }


        public List<string> isHeldclass(DateTime datetime, int hour, int numhTest)
        {
            string nameclass = "";
            DateTime dateOndata;
            List<string> freeClassesList = new List<string>();
            foreach (string cla in freeClass_FullList)
                freeClassesList.Add(cla);
            int hstart = 0, numH = 0;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM TestSchedule ", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    nameclass = rdr.GetString(4);
                    dateOndata = rdr.GetDateTime(2);
                    if (datetime == dateOndata)
                    {
                        foreach (string item_free_class in freeClass_FullList)
                        {
                            if (nameclass == item_free_class)
                            {
                                hstart = rdr.GetInt32(3);
                                numH = 3;       //const for test 3 hours
                                if ((hstart >= hour && hstart <= hour + numH) || (hstart + numhTest >= hour && hstart + numhTest <= hour + numH) || (hour >= hstart && hour <= hstart + numhTest) || (hour + numH >= hstart && hour + numH <= hstart + numhTest))
                                    freeClassesList.Remove(item_free_class);
                            }
                        }
                    }
                }
                con.CloseCon();
                return freeClassesList;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.CloseCon();
                return freeClassesList;
            }
            
        }


        public void InsertNew_Test(string nameCourse, char semester, DateTime datetime,int hour, string nameClass)
        {

            try
            {
                con.OpenCon();
                com = new SqlCommand("INSERT into TestSchedule (nameCourse,semester,date_time,hour,class) VALUES('" + nameCourse + "','" + semester + "','" + datetime.ToString("yyyy-MM-dd") + "','" + hour + "','" + nameClass + "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                MessageBox.Show("Active New Test Saved");
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


        public void Update_ActiveCourse(int id, int newhour, char newDay, string newclass, string newlecortut)
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
        
        public void InsertTestToStudent(string id, string nameCourse,  int idTest)
        {

            try
            {
                con.OpenCon();
                com = new SqlCommand("INSERT into StudentTest (studentID ,courses ,testID) VALUES('" + id + "','" + nameCourse + "','" + idTest + "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
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

        public bool chackTest(String id, string nameCourse)
        {
            int flag1 = 0;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from StudentTest WHERE studentID ='" + id + "' AND courses ='" + nameCourse + "'", con.GetCon());
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

            if (flag1 != 0)
                return true;
            return false;
        }

        public DateTime returnDateOfTest(string nameCourse, int idTest)
        {
            DateTime course = default(DateTime);
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM TestSchedule WHERE nameCourse = '" + nameCourse + "' AND testid= '" + idTest + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    course = Convert.ToDateTime(rdr["date_time"]);
                }
                con.CloseCon();
                return course;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return course;
            }
        }

        public int retutnNumOfTest(string nameCourse, string idStu)
        {
            List<int> checkCourse = new List<int>();
            int idTest = 0;

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM TestSchedule WHERE nameCourse = '" + nameCourse + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
           
                while (rdr.Read())
                {
                    checkCourse.Add(int.Parse(rdr["testid"].ToString()));
                }

                con.CloseCon();

                if (!(checkReturnTest(nameCourse, idStu)))
                    //idTest = int.Parse(rdr["testid"].ToString());
                    idTest = checkCourse[0];

                else
                {
                    for (int i = 0; i < checkCourse.Count; i++)
                    {
                            idTest = checkCourse[i];
                    }
                    //if (checkCourse[i] <= checkCourse[i + 1])
                    //{
                    //    idTest = checkCourse[i + 1];
                    //}
                    //if (checkCourse[i] > checkCourse[i + 1])
                    //{
                    //    idTest = checkCourse[i];
                    //}


                }
                //con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return idTest;
        }

        public bool chackIfTestExist(String nameCourse)
        {
            int flag1 = 0;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from TestSchedule WHERE nameCourse ='" + nameCourse + "'", con.GetCon());
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

            if (flag1 != 0)
                return true;
            return false;
        }



        public bool checkReturnTest(String nameCourse, string idStu)
        {
            int flag1 = 0;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from StudentTest WHERE courses ='" + nameCourse + "' AND studentID= '" + idStu + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    flag1++;
                }
                rdr.Close();
                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            if (flag1 != 0)
                return true;
            return false;
        }

    }
}
