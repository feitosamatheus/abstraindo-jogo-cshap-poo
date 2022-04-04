using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstraindo_POO.src.entities
{
        //HERANÇA
    public class Wizard : Hero
    {
        public Wizard(string name, int level, TypeHero type)
        {
            this.name = name;
            this.level = level;
            this.type = type;
            this.hp = 100;
            this.mana = 130;
        }
        public Wizard()
        {
        }
         
        //SOBRESCRITA
        public override string Attack()
        {
            return "\n " + this.name + " Lançou magia \n";
        }

        //SOBRECARGA
        public string Attack(int especial){
            if(especial 
            > 6){
                return "\n " + this.name + " Lançou magia super efetiva com bonus de: " + especial +" \n";
            }else{
                return this.name + " Lançou uma magia com força fraca com bonus de: " + especial +" \n";
            }
            
        }
    }
}