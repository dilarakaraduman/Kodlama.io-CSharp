using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Game.Entity;

namespace Game.Abstract
{ //Gamer can -save-upload-delete
    public interface IGamerService
    {
        void Save(Gamer Gamer);
        void Upload(Gamer Gamer);
        void Delete(Gamer Gamer);
        
    }
}
