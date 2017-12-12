using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schedule
{
    class ActiveCourses
    {
        private string name;
        private string type;
        private string classroom;
        private string day;
        private int starts;
        private int length;
        private int num_Of_Students;
        private string lecturerFullName;
        private string id;

        
        public ActiveCourses()
        {
            name = null;
            type = null;
            classroom = null;
            day = null;
            starts = 0;
            length = 0;
            num_Of_Students = 0;
            lecturerFullName = null;
            id = null;
        }

        public ActiveCourses(string name, string type, string classroom, string day, int starts, int length, int num_Of_Students, string lecturerFullName, string id)
        {
            this.name = name;
            this.type = type;
            this.day = day;
            this.starts = starts;
            this.length = length;
            this.num_Of_Students = num_Of_Students;
            this.lecturerFullName = lecturerFullName;
            this.id = id;
        }

        public string Get_Name() { return name; }
        public void Set_Name(string name) { this.name = name; }
        public string Get_Type() { return type; }
        public void Set_Type(string type) { this.type = type; }
        public string Get_Day() { return day; }
        public void Set_Day(string day) { this.day = day; }
        public int Get_Start() { return starts; }
        public void Set_Start(int start) { this.starts = start; }
        public int Get_Length() { return length; }
        public void Set_Length(int length) { this.length = length; }
        public int Get_Num_Of_Students() { return num_Of_Students; }
        public void Set_Num_OF_Students(int ammount) { this.num_Of_Students = ammount; }
        public string Get_Lecturer_Full_Name() { return lecturerFullName; }
        public void Set_Lecturer_Full_Name(string name) { this.lecturerFullName = name; }
        public string Get_ID() { return id; }
        public void Set_ID(string id) { this.id = id; }
        public void Set_Classroom(string classroom) { this.classroom = classroom; }
        public string Get_Classroom() { return classroom; }

    }
}
