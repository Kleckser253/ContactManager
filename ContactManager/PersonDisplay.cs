using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class PersonDisplay
    {
        public Person PersonObject { get; set; }   // Original-Person bleibt erhalten

        public string Anrede { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Titel { get; set; }
        public string Sozialversicherungsnummer { get; set; }
        public string Privattelefon { get; set; }
        public string Mobiltelefon { get; set; }
        public string Geschäftstelefon { get; set; }
        public string EMail { get; set; }
        public string Nationalität { get; set; }
        public string Straße { get; set; }
        public string Hausnummer { get; set; }
        public int PLZ { get; set; }
        public string Ort { get; set; }
        public string Geschlecht { get; set; }
        public string Status { get; set; }
    }
}
