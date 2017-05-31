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
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private DateTime birthDate;
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


    class Employee : Person
    {
        public Room room;
        private int salary;
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private string profession;
        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public Employee()
        {
            room = null;
        }

        public Employee(string name, DateTime birthDate, int salary, string profession): base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
            room = null;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", Salary: {0}, Profession: {1}, Room: {2}", salary, profession, room.Number);
        }
    }


    class Room
    {
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public Room(int number)
        {
            this.number = number;
        }
    }

}

