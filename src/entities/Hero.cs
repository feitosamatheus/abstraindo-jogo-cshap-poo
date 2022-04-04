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

        public bool defesa;


        public Hero()
        {

        }
        public Hero(string name, int level, TypeHero type)
        {
            this.name = name;
            this.level = level;
            this.type = type;
        }

        public override string ToString(){
            return this.name +" "+ this.level +" "+ this.type;
        }

        public virtual string Attack(){
            return "\n " + this.name + " Atacou com a espada \n";
        }
    }
}