using System.Collections.Generic;

namespace Hospital_Journals.Classes
{
    internal class Person
    {
        private string name;
        private string address;
        private string tlf;
        private string email;
        private string cpr;
        private string doctor;
        private string age;
        private List<Journal> journalEntries;

        public Person(string name, string address, string tlf, string email, string cpr, string doctor, string age, List<Journal> journalEntries)
        {
            this.name = name;
            this.address = address;
            this.tlf = tlf;
            this.email = email;
            this.cpr = cpr;
            this.doctor = doctor;
            this.age = age;
            this.journalEntries = journalEntries;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return name; }
            set { name = value; }
        }

        public string Tlf
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return name; }
            set { name = value; }
        }

        public string Cpr
        {
            get { return name; }
            set { name = value; }
        }

        public string Doctor
        {
            get { return name; }
            set { name = value; }
        }

        public string Age
        {
            get { return name; }
            set { name = value; }
        }

    }
}