using System;
using System.Collections.Generic;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm farm = new Farm("Айыл Чарба", "г.Бишкек ул.Чуй №182");
            Animal cow = new Cow("Уй", 2, "Ж", 740);
            Animal cow1 = new Cow("Бука", 2, "М", 760);
            Sheep sheep = new Sheep("Кой", 5, "Ж", 48);
            Sheep sheep1 = new Sheep("Кочкор", 3, "М", 60);
            Animal horse = new Horse("Ат", 7, "М", 650);
            Animal horse1 = new Horse("Бээ", 7, "Ж", 650);

            cow.Eat();
            sheep.Eat();
            horse.Eat();

            while(true)
            {
                farm.FullInfo();
                Console.Write("Для добавление животных в ферму выберите из списка " +
                    "\ncow-->уй\tcow1-->бука\nsheep-->кой\tsheep1-->кочкор\nhorse-->ат\thorse1-->бээ\n>");
                
                var input = Console.ReadLine().ToLower();
                
                switch (input)
                {
                    case "cow":
                        farm.AddCow(cow); break;
                    
                    case "cow1":
                        farm.AddCow(cow1); break;                    
                    
                    case "sheep":
                        farm.AddSheep(sheep); break;
                    
                    case "sheep1":
                        farm.AddSheep(sheep1); break;                    
                    
                    case "horse":
                        farm.AddHorse(horse); break;
                    
                    case "horse1":
                        farm.AddHorse(horse1); break;
                    
                    default:
                        break;
                }                            

            }            
            
        }
    }
}
