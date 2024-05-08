using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p23
{
    public class Human
    {
        public string Name;
        public uint Age;

        public Human()
        {

        }
        public Human(string name, uint age)
        {
            Name = name;
            Age = age;
        }
        public Human (Human other)
        {
            Name = other.Name;
            Age = other.Age;
        }



        public override string ToString()
        {
            return $"Name={Name}\tAge={Age}";
        }
    }
}
