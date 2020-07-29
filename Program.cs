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
            Animal sheep = new Sheep("Марко", 5, "М", 48);
            Animal horse = new Horse("Кашка", 7, "М", 650);
            farm.FullInfo();
        }
    }
}
