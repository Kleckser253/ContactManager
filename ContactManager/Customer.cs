using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{

    public class Customer : Person
    {
        public string companyName { get; set; }
        public string companyContact { get; set; }
        public char customerType { get; set; }
    }

}
