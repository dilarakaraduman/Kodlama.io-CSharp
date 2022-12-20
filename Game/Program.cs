using Game.Adapter;
using Game.Abstract;
using Game.Concrete;
using Game.Entity;

BaseGamerManager GamerManager = new GamerManager(new MernisServiceAdapter());//fake checkperson or mernis

Console.WriteLine("-----------------------Yeni Oyuncu-----------------------");
Gamer gamer1 = new Gamer()
{
    Id = 1,
    DateOfBirth = new DateTime(2000, 8, 25),
    Name = "Dilara",
    LastName = "Karaduman",
    NationalityId = "31642668624"
};
Gamer gamer2 = new Gamer()
{
    Id = 2,
    DateOfBirth = new DateTime(1977, 6, 10),
    Name = "Fatma",
    LastName = "Karaduman",
    NationalityId = "34804563294"
};
GamerManager.Save(gamer1);
GamerManager.Save(gamer2);

Console.WriteLine("------------------------Yeni Oyun------------------------");
GameManager GameManager = new GameManager();
PlayGame game1 = new PlayGame() { Id = 1, Name = "Tetris", Price = "20" };
GameManager.Save(game1);

PlayGame game2 = new PlayGame() { Id = 2, Name = "Flappy Bird", Price = "10" };
GameManager.Save(game2);

PlayGame game3 = new PlayGame() { Id = 3, Name = "Candy Crush", Price = "30" };
GameManager.Save(game3);

Console.WriteLine("--------------Kampanya Ekleme ve Güncelleme--------------");
CampaignManager campaignManager = new CampaignManager();
Campaign campaign = new Campaign { Id = 2, Name = "Yeni Musteri", CampaignRate = 1 };
campaignManager.Update(campaign);

Console.WriteLine("----------------------Yeni Satışlar----------------------");
SalesManager salesManager = new SalesManager();
Sales sales1 = new Sales { Id = 101, GamerName = gamer1.Name, GameName = game1.Name, GamePrice = game1.Price, CampaignName = campaign.Name, DiscountRate = campaign.CampaignRate };
salesManager.Add(sales1, gamer1, game1, campaign);


Console.WriteLine("------------------Kampanya Guncellemesi-------------------");
campaignManager.Update(new Campaign { Name = campaign.Name, CampaignRate = 10 });

Console.WriteLine("--------------------Kampanya Silinmesi--------------------");
campaignManager.Delete(campaign);

Console.ReadLine(); 