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
    public interface ISalesService
    {
        void Add(Sales sales, Gamer gamer, PlayGame game);
        void AddWithCampaign(Sales sales, Gamer gamer, PlayGame game, Campaign campaign);
        void Delete(Sales sales, Gamer gamer, PlayGame game, Campaign campaign);
        void GetAll(List<Sales> salesList);
    }
}
