using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    class Tutor : Person
    {
        private float numOfHours;
        public Tutor() : base() { numOfHours = 0; }

        public Tutor(string fname, string lname, string id, string address, string user, string pass) : base(fname, lname, id, address, pass, user) { numOfHours = 0; }
        
        public void setnumOfHours(float numOfHours) { this.numOfHours = numOfHours; }

        public override void Menu()
        {
          new TutorMenu(this).ShowDialog();
        }
    }
}
