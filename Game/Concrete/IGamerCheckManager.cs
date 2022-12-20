using Game.Abstract;
using Game.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Concrete
{
    //Interface'den miras alır. Mernis harici fake checkperson için kullanılır.
    public class IGamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
