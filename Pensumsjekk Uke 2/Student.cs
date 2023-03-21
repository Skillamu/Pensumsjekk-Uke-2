using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensumsjekk_Uke_2
{
    public class Student
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Course { get; private set; }

        public Student(string name, int age, string course)
        {
            Name = name;
            Age = age;
            Course = course;
        }
    }
}
