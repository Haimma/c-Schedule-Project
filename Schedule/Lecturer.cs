using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Schedule
{
    class Lecturer : Person
    {
        /*
            Professor has to lecture 12 hours each semester.
            Dr. hat to lecture 16 hours each semester.
            Junior has to lecture 32 hours each semester.
        */
        private float numOfHours;
        
        private string type;

        public Lecturer() : base() { numOfHours = 0; type = null; }

        public Lecturer(string fname, string lname, string id, string address, string user, string pass, float numHours, string type)
            : base(fname, lname, id, address, pass, user)
        {
            numOfHours = numHours;
            this.type = type;
        }

        //---Getters---
        public float getnumOfHours() { return numOfHours; }
        public string GetLecturerType() { return type; }
        //---Setters---
        public void setnumOfHours(float numOfHours) { this.numOfHours = numOfHours; }
        public void SetLecturerType(string type) { this.type = type; }

        //public string printObj()//--print Person object with all details
        //{
        //    return base.printObj() + string.Format("\nnumber of hours: {0}", getnumOfHours());
        //}

        public override void Menu()
        {
           new LecturerMenu(this).ShowDialog();
        }
    }
}
