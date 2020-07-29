using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    internal class Sheep : Animal
    {
        public  int age;

        public  int weight;

        public override int Age
        {
            get { return age; }
            set
            {
                if (value <= 10 && value <= 0) 
                    Console.WriteLine("Максимальные возраст овцы: 10 лет, минимальная больше нуля ;)");
                else age = value;
            }
        }

        public override int Weight
        {
            get { return weight; }
            set
            {
                if (value <= 45&& value < 0) 
                    Console.WriteLine("Максимальные вес овцы: 45 кг, минимальная больше нуля ;)");
                else weight = value;
            }
        }

        public Sheep(string name, int age, string sex, int weight) : base(name,sex)
        {
            Age = age;            
            Weight = weight;
        }

        public override void Eat()
        {
            Console.WriteLine("Овцы едят кукуруза, клевер "); 
        }
    }
}
