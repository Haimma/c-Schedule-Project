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
    class StudentDB 
    {
        Databases con = Databases.Instance();
        SqlCommand com;

        public void insertStudent(String username,String password, String fname, String lname, String id, String address, char year, int department)
        {
            try
            {
                con.OpenCon();
                //---select high ID course
                com = new SqlCommand("INSERT INTO Students (User_Name,First_Name,Last_Name,Password,ID,Address,Department,Year) VALUES('" + username + "','" + fname + "','" + lname + "','" + password + "','" + id + "','" + address + "','" + department + "','" + year+"');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                MessageBox.Show("Student & user Saved");
                //while (rdr.Read())
                //{

                //}
                con.CloseCon();           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public bool existStudent(String username,String id)
        {
            bool flag = false;
            int flag1 = 0;
            String name = "";
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Students", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
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
                rdr.Close();
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
                com = new SqlCommand("SELECT * FROM Students", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                
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
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            if (flag)
                flag1++;
            if(flag1==2)
                return true;
            return false;
        }



        public bool CheckingBackOfCourse(string course, string id)
        {
            int flag1 = 0;

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from StudentToCourse WHERE studentId ='" + id + "' and nameOfCourse ='" + course + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    flag1++;
                }

                con.CloseCon();
                rdr.Close();
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


  
  public bool chackId(String id)
        {
            int flag1 = 0;
           
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * from Students WHERE ID ='" + id + "'", con.GetCon());
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


        public void Update_Password(string password, string id)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE Students SET Password = '" + password + "' WHERE ID = '" + id + "'", con.GetCon());
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
                com = new SqlCommand("UPDATE Students SET Address = '" + address + "' WHERE ID = '" + id + "'", con.GetCon());
                com.ExecuteNonQuery();
                MessageBox.Show("Address Changed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
        }

        public List<StudentGrade> Get_Grades(Student student)
        {
            List<StudentGrade> grades = new List<StudentGrade>();
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM StudentsGrades WHERE studentID = '" + student.getID() + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                StudentGrade grade = new StudentGrade();

                while (rdr.Read())
                {
                    grade.Set_Student_ID(rdr["studentID"].ToString());
                    grade.Set_CourseName(rdr["courseName"].ToString());
                    grade.Set_Grade(Convert.ToInt32(rdr["Grade"].ToString()));

                    grades.Add(grade);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return grades;
        }

        public Student Get_Student_By_ID(string id)
        {
            Student student = new Student();

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Students WHERE ID = '" + id + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    student.setAddress(rdr["Address"].ToString());
                    student.setAverage(float.Parse(rdr["Average"].ToString()));
                    student.setDepartment(rdr["Department"].ToString());
                    student.setFirstName(rdr["First_Name"].ToString());
                    student.setLastName(rdr["Last_Name"].ToString());
                    student.setID(id);
                    student.setPassword(rdr["Password"].ToString());
                    student.setUserName(rdr["User_Name"].ToString());
                    student.setYear(char.Parse(rdr["Year"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return student;
        }
        public string findAverage(string user)
        {
            string avg = " ";
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Students WHERE User_Name= '" + user + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    avg = rdr[8].ToString();
                }
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return avg;
        }
        public void UpdateAverage(string ID, float Average)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE Students SET Average = '" + Average + "' WHERE ID = '" + ID + "'", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                con.CloseCon();
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Student> Get_All_Students()
        {
            List<Student> students = new List<Student>();
            Student student = new Student();

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Students", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    student = new Student();
                    student.setAddress(rdr["Address"].ToString());
                    student.setFirstName(rdr["First_Name"].ToString());
                    student.setID(rdr["ID"].ToString());
                    student.setLastName(rdr["Last_Name"].ToString());
                    student.setPassword(rdr["Password"].ToString());
                    student.setUserName(rdr["User_Name"].ToString());
                    student.setAverage(Convert.ToInt32(rdr["Average"].ToString()));
                    student.setDepartment(rdr["Department"].ToString());
                    student.setYear(Convert.ToChar(rdr["Year"].ToString()));


                    students.Add(student);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return students;
        }

        public List<string> CheckCoursesToStudent(string id)
        {
            List<string> course = new List<string>();
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT nameOfCourse FROM StudentToCourse WHERE studentid = '" + id + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    course.Add(rdr["nameOfCourse"].ToString());
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

        public string returnNameOfStu(string id)
        {
            string name = "";
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Students WHERE ID = '" + id + "'", con.GetCon());

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

        public string returnYearOfStu(string id)
        {
            string year = "";
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Students WHERE ID = '" + id + "'", con.GetCon());

                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    year = rdr["Year"].ToString();
                }
                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return year;

        }

    }
}

    

