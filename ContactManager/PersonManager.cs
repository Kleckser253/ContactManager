using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public static class PersonManager
    {
        private static List<Person> persons = new List<Person>();

        public static void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public static List<Person> GetAllPersons()
        {
            return persons;
        }

        public static void RemovePerson(Person person)
        {
            persons.Remove(person);
        }


        public static void UpdatePerson(Person updated)
        {
            var index = persons.FindIndex(p => p == updated);
            if (index != -1)
            {
                persons[index] = updated;
            }
        }

    }

}
