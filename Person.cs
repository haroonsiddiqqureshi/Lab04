using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    internal class Person
    {
        public string name { get; set; }
        public int birthyear { get; set; }
        public double grade { get; set; }
        b
        public Person (string name, int birthyear, double grade)
        {
            this.name = name;
            this.birthyear = 2566 - birthyear;
            this.grade = grade;
        }
    }
}
