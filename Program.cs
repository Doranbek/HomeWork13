using System;
using System.Collections.Generic;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm farm = new Farm("Айыл Чарба", "г.Бишкек ул.Чуй №182");
            Animal cow = new Cow("Маруся", 2, "Ж", 740);
            Animal cow1 = new Cow("Бука", 2, "М", 740);
            Sheep sheep = new Sheep("Марко", 5, "М", 48);
            Animal horse = new Horse("Кашка", 7, "М", 650);
            Animal horse1 = new Horse("Тайтору", 7, "М", 650);
            
            cow.Eat();
            sheep.Eat();
            horse.Eat();
            farm.AddHorse(horse);
            farm.AddHorse(horse1);
            farm.AddCow(cow);
            farm.AddCow(cow1);
            farm.AddSheep(sheep);
            farm.FullInfo();
        }
    }
}
