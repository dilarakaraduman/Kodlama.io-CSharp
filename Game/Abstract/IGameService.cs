using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Game.Entity;

namespace Game.Abstract
{
    public interface IGameService
    {
        void Save(PlayGame game);
        void Update(PlayGame game);
        void Delete(PlayGame game);
    }
}
