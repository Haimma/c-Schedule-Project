using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    class Junior:Lecturer
    {
        public Junior() : base() { }

        public Junior(string fname, string lname, string id, string address, string user, string pass, int numHours, string type) : base(fname, lname, id, address, pass, user, numHours, type) { }

    }
}
