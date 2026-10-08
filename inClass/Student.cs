using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inClass
{
    public class Student : IComparable
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object? obj)
        {
            // if return 1. if self > obj
            // if return 0. if self == obj
            // if return -1. if self < obj
            Student? student = obj as Student;
            if (Age > student.Age) return 1;
            if (Age < student.Age) return -1;
            return 0;

        }

        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age;
        }

    }
}
