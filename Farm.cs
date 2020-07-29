using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    class Farm
    {

        public string NameFarm { get; set; }
        public string AdressFarm { get; set; }
        private IEnumerable<object> Horses { get; set; }
        private IEnumerable<object> SheepFlock { get; set; }
        private IEnumerable<object> Cows { get; set; }

        public Farm(string nameFarm, string adressFarm)
        {
            NameFarm = nameFarm;
            AdressFarm = adressFarm;
        }

        static void AddHorse(Animal Hourse)
        {
            
            
        }
        static void AddCow(Animal Cow)
        {

        }
        static void AddSheep(Animal Sheep)
        {

        }
        public void FullInfo()
        {
            Console.WriteLine($"Название фермы:{NameFarm} адрес:{AdressFarm}");
            Console.WriteLine("Табун лошадей:");
            foreach (var obj in Horses)
            {
                Console.Write($"\t{ obj}");
            }
            Console.WriteLine("Стадо коров:");
            foreach (var obj in Cows)
            {
                Console.Write($"\t{ obj}");
            }
            Console.WriteLine("Стадо овец:");
            foreach (var obj in SheepFlock)
            {
                Console.Write($"\t{ obj}");
            }
            
        }
    }
}
