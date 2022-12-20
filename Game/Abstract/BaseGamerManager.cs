using Game.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Abstract
{
    //Birden fazla şirket aynı kodu kullanabilir diyerek burada base bir class oluşturuldu.
    //Interface'i kullanan abstract class sayesinde diğer sınıflar interface'teki metotları miras alabildi.
    //abstract new'lenemez.
    //abstract sınıflar içi dolu veya boş kullanılabilir.
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Save(Gamer Gamer)//metodu ezmek için
        {
            Console.WriteLine("Saved to db :"+ Gamer.Name);
        }

        public void Upload(Gamer Gamer)
        {
            Console.WriteLine("Uploaded to db :" + Gamer.Name);
        }
        public void Delete(Gamer Gamer)
        {
            Console.WriteLine("Deleted to db :" + Gamer.Name);
        }

    }
}
