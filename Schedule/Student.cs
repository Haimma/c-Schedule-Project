using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
   class Student : Person
    {
     
        private char year;    //college year (A,B,C,D)
        private string department;  
        private bool exellent;      // True or False
        private float average;


        public Student(): base(){
            year = 'A';
            department = null;
            exellent = false;
            average=0;
        }
        public Student(string fname, string lname, string id, string address,string user, string pass, char year, string depart, bool ex, float avg) :base(fname,lname,id,address,user,pass){
            this.year = year;
            department = depart;
            exellent = ex;
            average=avg;
        }



        //---Getters---
        public char getYear() { return year; }
        public string getDepartment() { return department; }
        public bool getExellent() { return exellent; }
        public float getAverage() { return average; }

        //---Setters---
        public void setYear(char year) { this.year = year; }
        public void setDepartment(string department) { this.department = department; }
        public void setExellent(bool exellent) { this.exellent = exellent; }
        public void setAverage(float avg) { this.average = avg; }

        public string printObj()//--print Person object with all details
        {
            return base.printObj() + string.Format("\nyear: {0}\ndepartment: {1}\nexellent: {2}\naverage: {3}", getYear(), getDepartment(), getExellent(), getAverage());
        }

        public override void Menu()
        {
           
            new StudentMenu(this).ShowDialog();
            
            
        }

    }
}
