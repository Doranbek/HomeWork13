using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    class Farm
    {

        public string NameFarm { get; set; }
        public string AdressFarm { get; set; }
        
        private  List<Horse> Horses = new List<Horse>();
        private List<Sheep> SheepFlock = new List<Sheep>();
        private List<Cow> Cows = new List<Cow>();


        public Farm(string nameFarm, string adressFarm)
        {
            NameFarm = nameFarm;
            AdressFarm = adressFarm;
        }

        public void AddHorse(Animal Horse)=>Horses.Add((Horse)Horse);
        
        public void AddCow(Animal Cow)=> Cows.Add((Cow)Cow);
        
        public void AddSheep(Animal Sheep)=>SheepFlock.Add((Sheep)Sheep);
        
        public void FullInfo()
        {
            Console.WriteLine($"\nНазвание фермы:{NameFarm} \tAдрес:{AdressFarm}");
            Console.WriteLine("Табун лошадей:");
            foreach (var obj in Horses)
            {
                Console.WriteLine($"\t{ obj.Name}");
            }
            Console.WriteLine("Стадо коров:");
            foreach (var obj in Cows)
            {
                Console.WriteLine($"\t{ obj.Name}");
            }
            Console.WriteLine("Стадо овец:");
            foreach (var obj in SheepFlock)
            {
                Console.WriteLine($"\t{ obj.Name}");
            }
            
        }
    }
}
