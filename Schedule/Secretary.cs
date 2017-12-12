using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    class Secretary : Person
    {
        public Secretary() : base() { }

        public Secretary(string fname, string lname, string id, string address, string user, string pass) : base(fname, lname, id, address, pass, user) { }

        public override void Menu()
        {
            new SecretaryMenu(this).ShowDialog();
        }
    }
}

