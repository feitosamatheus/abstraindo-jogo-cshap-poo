using System.Runtime.CompilerServices;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstraindo_POO.src
{
    // COM O ABSTRACT NÃO É POSSIVEL UTILIZAR DIRETAMENTE, PARA UTILIZAR A CLASSE A MESMA TEM QUE SER HERDADA EM OUTRA CLASSE. 

    public abstract class Hero
    {
        public string name;
        public int level;
        public TypeHero type;
        public int hp;
        public int mana;
        public bool defense;


        public Hero()
        {

        }
        public Hero(string name, int level, TypeHero type)
        {
            this.name = name;
            this.level = level;
            this.type = type;
        }
         public virtual string Attack(){
             return " ";
         }
        public virtual string Attack(Hero hero, bool defense){
            this.defense = defense;
            this.mana = this.mana - 10;

             if(this.mana <= 0){
                return "Mana insuficiente | Saldo da mana: " + this.mana;

            }else if(this.hp <= 0){
                return "HP insuficiente | Saldo de HP: " + this.hp;

            }else{

                if(hero.defense == true && this.defense == true){

                    hero.hp = hero.hp - 5;
                    return $"Seus escudos e do {hero.name} estão ativados" + $" (-- Dano causado no usuario -5 |HP: {hero.hp} --)\n"+ 
                    $"|MP: {this.mana}| |HP: {this.hp}| \n"+
                    "DICA: Para maior dano no adversario mantenha seus escudos desativado\n";

                }else if(hero.defense == true && this.defense == false){

                    hero.hp = hero.hp - 10;
                     return $"Escudos do {hero.name} estão ativados" + $" (-- Dano causado no usuario -10 |HP: {hero.hp} --)\n"+ 
                    $"|MP: {this.mana}| |HP: {this.hp}| \n";
                
                }else{

                    hero.hp = hero.hp - 20;
                     return $"Escudos do {hero.name} estão desativados" + $" (-- Dano causado no usario -20 |HP: {hero.hp} --)\n"+ 
                    $"|MP: {this.mana}| |HP: {this.hp}| \n";
                }
            } 
         }    

        public override string ToString(){
            return "\n\n|Nome: " +this.name +"|Level: "+ this.level +"|Type: "+ this.type + "|HP: "+this.hp + "|MP: "+this.mana+"|\n";
        }
    }
}