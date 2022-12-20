using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entity;
namespace Game.Concrete
{
	public class CampaignManager : ICampaignService
	{
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Saved to db:" + campaign.Name);
        }

        void ICampaignService.GetAll(List<Campaign> campaings)
        {
            foreach (var campaign in campaings)
            {
                Console.WriteLine("Kampanya Adý :{0}-Kampanya Oraný : %1}", campaign.Name, campaign.CampaignRate);
            }
        }
        public void Update(Campaign campaign)
		{
			Console.WriteLine("Updated to db:" + campaign.Name);
		}
		public void Delete(Campaign campaign)
		{
			Console.WriteLine("Deleted to db:" + campaign.Name);
		}
		

       
    }
}
