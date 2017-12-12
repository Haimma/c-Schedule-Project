using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schedule
{
    class StudentGrade
    {
        private string studentID;
        private string courseName;
        private int grade;
        private int courseID;

        public StudentGrade() { }

        public void Set_Student_ID(string id) { this.studentID = id; }
        public string Get_Student_ID() { return studentID; }
        public void Set_CourseName(string name) { this.courseName = name; }
        public string Get_CourseName() { return courseName; }
        public void Set_Grade(int grade) { this.grade = grade; }
        public int Get_Grade() { return grade; }
        public void Set_Course_ID(int id) { this.courseID = id; }
        public int Get_Course_ID() { return courseID; }
    }
}
