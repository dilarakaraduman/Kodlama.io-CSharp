using Game.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Abstract
{
    public interface IGamerCheckService //farklı doğrulama servisleri için arayüz yapıldı
    {
        bool CheckIfRealPerson(Gamer Gamer);//true veya false döndürerek doğrulama sağlanır.
    }
}
