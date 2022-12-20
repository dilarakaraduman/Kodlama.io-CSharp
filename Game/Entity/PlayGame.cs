﻿using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entity
{
    public class PlayGame :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

    }
}
