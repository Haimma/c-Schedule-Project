using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    abstract class Person
    { 
        private Databases DB;
        private string firstName;
        private string lastName;
        private string ID;
        private string address;
        private string userName;
        private string password;    //letters and numbers

        public Person()
        {

          //  DB = new UsersDB();
            firstName = null;
            lastName = null;
            ID = null;
            address = null;
            userName = null;
            password = null;
        }
        public Person(string fname, string lname, string id, string address, string user, string pass)
        {
            firstName = fname;
            lastName = lname;
            ID = id;
            this.address = address;
            userName = user;
            password = pass;
        }
        //---Getters---
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getID() { return ID; }
        public string getAddress() { return address; }
        public string getUserName() { return userName; }
        public string getPassword() { return password; }
        //---Setters---
        public void setFirstName(string fName) { this.firstName = fName; }
        public void setLastName(string lName) { this.lastName = lName; }
        public void setID(string id) { this.ID = id; }
        public void setAddress(string address) { this.address = address; }
        public void setUserName(string user) { this.userName = user; }
        public void setPassword(string password) { this.password = password; }
        public string Get_Full_Name() { return firstName + " " + lastName; }
        //------------
        public string printObj()//--print Person object with all details
        {
            return string.Format("Details\n-----------------\nfull name: {0} {1}\nid: {2}\naddress: {3}\nuser name: {4}\npassword: {5}", getFirstName(), getLastName(), getID(), getAddress(), getUserName(), getPassword());
        }

        public abstract void Menu();
    }
}
