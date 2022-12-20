using Game.Abstract;
using Game.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _GamerCheckService;


        public GamerManager(IGamerCheckService GamerCheckService)//dependency injection
        {
            _GamerCheckService = GamerCheckService;
        }
        public override void Save(Gamer Gamer) //override edildi(metot burada ezildi)ek olarak başka özellikler eklendi
        {
            if (_GamerCheckService.CheckIfRealPerson(Gamer))
            {
                base.Save(Gamer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
