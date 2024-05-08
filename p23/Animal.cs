using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p23
{
    public class Animal
    {
        public string Name;
        public uint Age;
        public string Color;

        public Animal()
        {

        }
        public Animal(string name,uint age, string color)
        {
            this.Name = name;
            this.Age = age;
            this.Color = color;
        }
        public Animal(Animal animal)
        {
            this.Color=animal.Color;
            this.Name = animal.Name;
            this.Age = animal.Age;
        }



        public override string ToString()
        {
            return $"Name={Name}\tAge={Age}\tColor={Color}";
        }
    }
}
