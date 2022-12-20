using Game.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Game.Abstract
{
    //database interface
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
        void GetAll(List<Campaign> campaings);
    }
}
