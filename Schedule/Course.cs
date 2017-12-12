using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schedule
{
    class Course
    {
        private string name;
        private string day;
        private int startHour;
        private int endHour;
        private string lecturer;

        public Course()
        {
            this.name = null;
            this.day = null;
            this.startHour = -1;
            this.endHour = -1;
            this.lecturer = null;
        }
        public Course(string name, string day, int start, int end, string lecturer)
        {
            this.name = name;
            this.day = day;
            this.startHour = start;
            this.endHour = end;
            this.lecturer = lecturer;
        }

        public void setName(string courseName) { this.name = courseName; }
        public string getName() { return name; }

        public void setDay(string d) { this.day = d; }
        public string getDay() { return day; }

        public void setStart_Hour(int starts) { this.startHour = starts; }
        public int getStart_Hout() { return startHour; }

        public void setEnd_Hour(int ends) { this.endHour = ends; }
        public int getEnd_Hour() { return endHour; }

        public void setLecturer(string lecturer) { this.lecturer = lecturer; }
        public string getLecturer() { return lecturer; }
    }
}
