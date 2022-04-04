using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstraindo_POO.src.entities
{
    public class Ninja : Hero
    {
        public Ninja()
        {
            
        }
        public Ninja(string name, int level, TypeHero type)
        {
            this.name = name; 
            this.level = level;
            this.type = type;
            this.hp = 130;
            this.mana = 100;
        }
    }
}