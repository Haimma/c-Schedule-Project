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
    class HeldClassesDB 
    {
        Databases con = Databases.Instance();   //
        SqlCommand com;

        public void fillfreeclasses_list(ListBox lb_freeclasses,ComboBox day, ComboBox hour,ListBox lb_nameCourse,int LecOrTut,CoursesDB coursedb)       //1 lec 2 tut
        {
            int  lenClasses = 0,numh; 
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
                    nameC = rdr.GetString(0);        
                    lb_freeclasses.Items.Add(nameC);
                    lenClasses++;
                }
                con.CloseCon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            numecourse = lb_nameCourse.SelectedValue.ToString();
            numh = coursedb.getNumHour(numecourse, LecOrTut);

            List<string> list = new List<string>();
            list =isHeldclass(lb_freeclasses, Day, Hour, numh);
            int n=0;
            foreach (string item in list) {
                lb_freeclasses.Items.Remove(list[n]);
                n++;
                    }
        }


        

        public List<string> isHeldclass(ListBox lb_freeclasses, int day,int hour,int numhChooseCourse)
        {
           // bool flag = false;
            string nameclass = "", class_free="";
            int h = 0,numH=0;
            List<string> list = new List<string>();
            
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM HeldClasses WHERE day = '" + day + "'", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    nameclass = rdr.GetString(0);       //from heldclass

                    foreach (Object item in lb_freeclasses.Items)
                    {
                        class_free = item.ToString(); // /n to print each item on new line or you omit /n to print text on same line

                        if (nameclass == class_free)
                        {

                          //  d = rdr.GetString(1);
                          //  if (d == day.ToString())
                         //   {
                                h = rdr.GetInt32(2);
                                numH = rdr.GetInt32(3);
                                if ((h >= hour && h <= hour + numH) || (h + numhChooseCourse >= hour && h + numhChooseCourse <= hour + numH) || (hour >= h && hour <= h + numhChooseCourse) || (hour + numH >= h && hour + numH <= h + numhChooseCourse))
                                    list.Add(class_free);    //isHeldclass
                //            }
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









    }
}
