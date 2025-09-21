using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Person
    {
        public string salutation { get; set; }              // z. B. Herr / Frau
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthday { get; set; }
        public bool gender { get; set; }                    // true = männlich, false = weiblich
        public string title { get; set; }                   // z. B. Dr., Prof.
        public string socialSecurityNumber { get; set; }

        public string phoneNumberPrivat { get; set; }
        public string phoneNumberMobile { get; set; }
        public string phoneNumberBusiness { get; set; }

        public string email { get; set; }
        public bool status { get; set; }                    // Aktiv/inaktiv oder Kunde/Mitarbeiter?
        public string nationality { get; set; }

        public string street { get; set; }
        public string streetNumber { get; set; }
        public int zipCode { get; set; }
        public string place { get; set; }

        public List<ContactNote> Notes { get; set; } = new List<ContactNote>();



    }
    public class ContactNote
    {
        public DateTime Date { get; set; }
        public string Note { get; set; }
    }
}
