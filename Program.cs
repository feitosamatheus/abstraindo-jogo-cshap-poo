using System.Reflection;
using System.Security.Cryptography;
using System.Reflection.Metadata.Ecma335;
using System;
using abstraindo_POO.src;
using abstraindo_POO.src.entities;

namespace abstraindo_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 22, TypeHero.Knight, true);

            Wizard wizard = new Wizard("Jennica", 23, TypeHero.BlackWizard);
            
            Wizard topapa = new Wizard("Topapa", 15,TypeHero.BlackWizard);

            Ninja wedge = new Ninja("Wedge", 10,TypeHero.WhiteWizard);


            Console.Write(arus.Attack());

            Console.Write($"\n Dados do jogador: {arus.ToString() + wizard.ToString() + wedge.ToString()} \n");

            Console.Write($"\n Dados do jogador: {wedge.hp} \n");
        }
    }
}
