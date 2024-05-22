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



        public override bool Equals(object obj)
        {
            Animal other = obj as Animal;
            if (other is null) return false;


            return other.Age == this.Age && other.Name == this.Name;
        }
        public static bool operator ==(Animal animal1, Animal animal2)
        {
            if (animal1 == null || animal2 == null) return false;

            return animal1.Equals(animal2);
        }
        public static bool operator !=(Animal human1, Animal human2)
        {
            if (human1 == null || human2 == null) return true;

            return !human1.Equals(human2);
        }



        public override string ToString()
        {
            return $"Name={Name}\tAge={Age}\tColor={Color}";
        }
    }
}
