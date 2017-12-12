using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    class User
    {
        private Student student;
        private Professor professor;
        private Doctor doctor;
        private Junior junior;
        private Tutor tutor;
        private Secretary secretary;
        private DepartmentManager deptManager;

        public User()
        {
            student = null;
            professor = null;
            doctor = null;
            junior = null;
            tutor = null;
            secretary = null;
            deptManager = null;
        }

          //============\\
         //   CREATORS   \\
        //================\\
        public void CreateStudent(/*string fname, string lname, string id, string address, string user, string pass, char year, string depart, bool ex, float avg*/)
        {
            student = new Student(/*fname, lname, id, address, user, pass, year, depart, ex, avg*/);
        }

        public void CreateProfessor(/*string fname, string lname, string id, string address, string user, string pass, int numHours, string type*/)
        {
            professor = new Professor(/*fname, lname, id, address, user, pass, numHours, type*/);
        }

        public void CreateDoctor(/*string fname, string lname, string id, string address, string user, string pass, int numHours, string type*/)
        {
            doctor = new Doctor(/*fname, lname, id, address, user, pass, numHours, type*/);
        }

        public void CreateJunior(/*string fname, string lname, string id, string address, string user, string pass, int numHours, string type*/)
        {
            junior = new Junior(/*fname, lname, id, address, user, pass, numHours, type*/);
        }

        public void CreateTutor()
        {
            tutor = new Tutor();
        }
        public void CreateSecretary(/*string fname, string lname, string id, string address, string user, string pass*/)
        {
            secretary = new Secretary(/*fname, lname, id, address, user, pass*/);
        }

        public void CreateDepartmentManager(/*string fname, string lname, string id, string address, string user, string pass*/)
        {
            deptManager = new DepartmentManager(/*fname, lname, id, address, user, pass*/);
        }
        

          //============\\
         //    GETTERS   \\
        //================\\
        public Student GetStudent() { return student; }
        public Professor GetProfessor() { return professor; }
        public Doctor GetDoctor() { return doctor; }
        public Junior GetJunior() { return junior; }
        public Tutor GetTutor() { return tutor; }
        public Secretary GetSecretary() { return secretary; }
        public DepartmentManager GetDepartmentManager() { return deptManager; }

        public string GetUserType()
        {
            if(student != null) { return "Student"; }
            else if(professor != null) { return "Professor"; }
            else if(doctor != null) { return "Doctor"; }
            else if(junior != null) { return "Junior"; }
            else if(tutor != null) { return "Tutor"; }
            else if(secretary != null) { return "Secretary"; }
            else if(deptManager != null) { return "Department Manager"; }
            else { return "No user has been defined."; }
        }

        public string Get_ID()
        {
            if (student != null) { return student.getID(); }
            else if (professor != null) { return professor.getID(); }
            else if (doctor != null) { return doctor.getID(); }
            else if (junior != null) { return junior.getID(); }
            else if (tutor != null) { return tutor.getID(); }
            else if (secretary != null) { return secretary.getID(); }
            else if (deptManager != null) { return deptManager.getID(); }
            else { return "Can't get the users ID."; }
        }

        public string Get_First_Name()
        {
            if (GetUserType() == "Student")
                return student.getFirstName();
            else if (GetUserType() == "Professor")
                return professor.getFirstName();
            else if (GetUserType() == "Doctor")
                return doctor.getFirstName();
            else if (GetUserType() == "Junior")
                return junior.getFirstName();
            else if (GetUserType() == "Tutor")
                return tutor.getFirstName();
            else if (GetUserType() == "Secretary")
                return secretary.getFirstName();
            else if (GetUserType() == "Department Manager")
                return deptManager.getFirstName();
            else
                return "No user has been defined.";
        }

        public string Get_Last_Name()
        {
            if (GetUserType() == "Student")
                return student.getLastName();
            else if (GetUserType() == "Professor")
                return professor.getLastName();
            else if (GetUserType() == "Doctor")
                return doctor.getLastName();
            else if (GetUserType() == "Junior")
                return junior.getLastName();
            else if (GetUserType() == "Tutor")
                return tutor.getLastName();
            else if (GetUserType() == "Secretary")
                return secretary.getLastName();
            else if (GetUserType() == "Department Manager")
                return deptManager.getLastName();
            else
                return "No user has been defined.";
        }

        //public void Get_Course_Days(ComboBox days)
        //{

        //}
    }
}
