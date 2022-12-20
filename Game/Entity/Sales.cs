using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entity
{
    public class Sales
    {
        public int Id { get; set; }
        public string GamerName { get; set; }
        public string GameName { get; set; }
        public string CampaignName { get; set; }
        public int DiscountRate { get; set; }
        public string GamePrice { get; set; }

    }
}

