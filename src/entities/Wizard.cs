using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstraindo_POO.src.entities
{
        //HERANÇA
    public class Wizard : Hero
    {
        public Wizard(string name, int level, TypeHero type, bool defense)
        {
            this.name = name;
            this.level = level;
            this.type = type;
            this.defense = defense;
            this.hp = 100;
            this.mana = 130;
        }
        public Wizard()
        {
        }
    
    }
}