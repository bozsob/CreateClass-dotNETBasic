using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        private string name;
        private DateTime birthDate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public Person() { }
        public Person(string name, DateTime birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }
        public enum Genders { Male, Female};

        public override string ToString()
        {
            return String.Format("Name: {0}, Birth date: {2}", this.name, this.birthDate);
        }
    }
}

