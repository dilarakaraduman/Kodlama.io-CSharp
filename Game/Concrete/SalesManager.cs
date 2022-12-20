using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entity;

namespace Game.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Add(Sales sales, Gamer gamer, PlayGame game)
        {
            Console.WriteLine(gamer.Name.ToUpper() + " adli musteri " + game.Name + " adlı oyunu " + sales.Id + " satıs numarasıyla almıstır.");
        }
        public void AddWithCampaign(Sales sales, Gamer gamer, PlayGame game, Campaign campaign)
        {
            Console.WriteLine(gamer.Name.ToUpper() + " adli musteri " + game.Name + " adlı oyunu " + campaign.Name + "adli kampanya ile " + sales.Id + " satıs numarasıyla almıstır.");
        }
        public void Delete(Sales sales, Gamer gamer, PlayGame game, Campaign campaign)
        {
            Console.WriteLine(gamer.Name.ToUpper() + " adli musteri " + game.Name + " adlı oyunu " + campaign.Name + "adli kampanya ile " + sales.Id + " satıs numarasıyla aldıgı urunu iptal etmistir.");
        }

        public void GetAll(List<Sales> salesList)
        {
            foreach (var item in salesList)
            {
                Console.WriteLine("Oyun: " + item);
            }

        }
    }
}