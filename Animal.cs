using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    abstract class Animal
    {
        public string Name { get; private set; }
        public string Sex { get; private set; }
        public abstract int Age { get; set; }
        public abstract int Weight { get; set; }

        public Animal(string name, int age, string sex, int weight)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Weight = weight;
        }

        protected Animal(string name, string sex)
        {
            Name = name;
            Sex = sex;
        }

        public abstract void Eat();
        
    }
}
