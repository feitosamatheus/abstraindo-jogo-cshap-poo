using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstraindo_POO.src.entities
{
    public class Knight : Hero
    {
        public Knight()
        {
            
        }
        public Knight(String name, int level, TypeHero type, bool defense)
        {
            this.name = name;
            this.level = level;
            this.type = type;
            this.defense = defense;
            this.hp = 130;
            this.mana = 100;
        }
    }
}