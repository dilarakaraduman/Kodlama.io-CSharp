using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entity;
namespace Game.Concrete
{
    public class GameManager : IGameService
    {
        public void Save(PlayGame game)
        {
            Console.WriteLine("Saved to db:"+game.Name);
        }
        
        public void Update(PlayGame game)
        {
            Console.WriteLine("Updated to db:"+game.Name);
        }
        public void Delete(PlayGame game)
        {
            Console.WriteLine("Deleted to db:"+game.Name);
        }

    }
}
