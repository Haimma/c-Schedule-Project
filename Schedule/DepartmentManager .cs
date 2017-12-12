using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule

{
    class DepartmentManager : Person
    {
        
        public DepartmentManager():base(){}

        public DepartmentManager(string fname, string lname, string id, string address, string user, string pass) : base(fname, lname, id, address, pass, user) { }

        public override void Menu()
        {
            new DepartmentHeadMenu(this).ShowDialog();
        }
    }
}