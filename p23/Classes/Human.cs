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



        public override bool Equals(object obj)
        {
            Human other = obj as Human;
            if (other is null) return false;


            return other.Age==this.Age && other.Name==this.Name;
        }
        public static bool operator==(Human human1, Human human2)
        {
            if (human1==null || human2==null) return false;

            return human1.Equals(human2);
        }
        public static bool operator !=(Human human1, Human human2)
        {
            if (human1 == null || human2 == null) return true;

            return !human1.Equals(human2);
        }




        public override string ToString()
        {
            return $"Name={Name}\tAge={Age}";
        }
    }
}
