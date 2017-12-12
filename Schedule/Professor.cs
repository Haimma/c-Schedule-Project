﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    class Professor:Lecturer
    {
        
        public Professor():base(){}

        public Professor(string fname, string lname, string id, string address, string user, string pass, int numHours, string type) : base(fname, lname, id, address, pass, user, numHours, type) { }

        public override void Menu()
        {
            new LecturerMenu(this).ShowDialog();
        }

    }
}
