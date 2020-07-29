using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    internal class Cow : Animal
    {
        public int age;

        public int weight;

        public override int Age
        {
            get { return age; }
            set
            {
                if (value <= 20 && value <= 0) 
                    Console.WriteLine("Максимальные возраст овцы: 20 лет, минимальная больше нуля ;)");
                else age = value;
            }
        }

        public override int Weight
        {
            get { return weight; }
            set
            {
                if (value <= 850 && value < 0) 
                    Console.WriteLine("Максимальные вес коровы: 850 кг, минимальная больше нуля ;)");
                else weight = value;
            }
        }

        public Cow(string name, int age, string sex, int weight) : base(name, sex)
        {
            Age = age;
            Weight = weight;
        }

        public override void Eat()
        {
            Console.WriteLine("Коровы едят сено, овощи, фрукты, злаки.");
        }
    }
}
