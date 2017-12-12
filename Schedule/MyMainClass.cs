using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schedule;
using System.Data;
using System.Data.SqlClient;

namespace Schedule
{
    static class MyMainClass
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       [STAThread]
        static void Main()
        {

      //      SqlConnection sqlConnection=new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\idanl\VisualProjectCsharp\Schedule\Schedule\Database.mdf;Integrated Security=True");
       //     SqlCommand sqlCommand=new SqlCommand();
    //        sqlCommand.Connection=sqlConnection;
     //       sqlConnection.Open();
           //
           // sqlConnection.Close();

            //----GUI----
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new addStudent());
            Application.Run(new Login());
            //Application.Run(new ManagementCourses());
            //Application.Run(new addLacturer());
            //Application.Run(new ScheduleChanges_Secretary());
            //Application.Run(new ChangeCourseDetails());
            //       Application.Run(new OpenCourse("Lecture"));
            //Application.Run(new DeterminingCourseDetails());
            //     Application.Run(new SecretaryMenu());
            //    Application.Run(new StudentMenu());
            //   Application.Run(new LecturerMenu());
            //    Application.Run(new TutorMenu());
            //   Application.Run(new DepartmentHeadMenu());
            //Application.Run(new Lecturers_Appeals(new Lecturer("Francis", "Sissy", "222222000", "Hell", "ajax", "12345678", 3, "Junior")));
            //Application.Run(new Update_User_Info(new Secretary("Mazal", "cohen", "444444000", "bazel 43", "mazal", "12345678")));
        }
    }
}
