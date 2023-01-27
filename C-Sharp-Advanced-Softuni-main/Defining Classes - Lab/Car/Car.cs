using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        public string Make   // property
        {
            get { return make; }   // get method
            set { make = value; }  // set method
        }
        public string Model   // property
        {
            get { return model; }   // get method
            set { model = value; }  // set method
        }
        public int Year   // property
        {
            get { return year; }   // get method
            set { year = value; }  // set method
        }
    }
}
