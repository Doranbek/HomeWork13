using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    internal class Horse : Animal
    {
        public int age;

        public int weight;

        public override int Age
        {
            get { return age; }
            set
            {
                if (value <= 30 && value <= 0) Console.WriteLine
                        ("Максимальные возраст лошади: 30 лет, минимальная больше нуля ;)");
                else age = value;
            }
        }

        public override int Weight
        {
            get { return weight; }
            set
            {
                if (value <= 740 && value < 0) Console.WriteLine
                        ("Максимальные вес лошади: 850 кг, минимальная больше нуля ;)");
                else weight = value;
            }
        }

        public Horse(string name, int age, string sex, int weight) : base(name, sex)
        {
            Age = age;
            Weight = weight;
        }

        public override void Eat()
        {
            Console.WriteLine("Лошади едят овес, ячмень, пшеница, рожь, кукуруза.");
        }
    }
}
