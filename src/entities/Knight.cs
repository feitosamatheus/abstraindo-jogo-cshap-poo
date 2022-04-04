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
        public Knight(String name, int level, TypeHero type, bool defesa)
        {
            this.name = name;
            this.level = level;
            this.type = type;
            this.defesa = defesa;
            this.hp = 130;
            this.mana = 100;
        }
        public override string Attack()
        {
            return "\n" + this.name + "Atacou com a espada \n";
        }

        public string Attack(Hero hero, bool defesa){

             if(this.mana <= 0){
                return "Mana insuficiente | Saldo da mana: " + this.mana;

            }else{

                if(hero.defesa && this.defesa == true){
                    hero.hp = hero.hp - 5;
                }else if(hero.defesa && !this.defesa){
                    hero.hp = hero.hp - 10;
                }else{
                    hero.hp = hero.hp - 20;
                }

                this.defesa = defesa;
                this.mana = this.mana - 10;
                return " s";
            } 
        }
    }
}