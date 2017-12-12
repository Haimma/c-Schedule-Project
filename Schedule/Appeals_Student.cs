using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schedule
{
    class Appeals_Student
    {
        private string studentID;
        private int courseID;
        private string courseName;
        private string appeal;
        private string lecturerID;
        private int status;

        public void Set_Student_ID(string id) { this.studentID = id; }
        public string Get_Student_ID() { return studentID; }
        public void Set_Course_ID(int id) { this.courseID = id; }
        public int Get_Course_ID() { return courseID; }
        public void Set_Course_Name(string name) { this.courseName = name; }
        public string Get_Course_Name() { return courseName; }
        public void Set_Appeal(string appeal) { this.appeal = appeal; }
        public string Get_Appeal() { return appeal; }
        public void Set_Lecturer_ID(string id) { this.lecturerID = id; }
        public string Get_Lecturer_ID() { return lecturerID; }
        public void Set_Status(int status) { this.status = status; }
        public int Get_Status() { return status; }

       
    }
}
