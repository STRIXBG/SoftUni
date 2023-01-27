using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    internal class Person
    {
        private int age;
        private string name;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age)
        {
            Name = "No Name";
            Age = age;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return string.Format($"{Name} {Age}");
        }
    }
}
