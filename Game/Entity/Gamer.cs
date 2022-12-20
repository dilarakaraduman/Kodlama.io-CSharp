using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entity
{
    //Gamer data on database
    public class Gamer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
