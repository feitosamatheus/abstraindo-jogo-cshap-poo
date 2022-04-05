
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
            Wizard jennica = new Wizard("Jennica", 23, TypeHero.BlackWizard, true);      
            Wizard topapa = new Wizard("Topapa", 15,TypeHero.BlackWizard, true);
            Ninja wedge = new Ninja("Wedge", 10,TypeHero.Ninja, true);

            Console.Write("Escoha o personagem que vai começar: [ 1 - Arus (Lutador) - 2 - Jennica (Mago) - 3 -Topapa (Mago) - 4 - Wedge(Ninja) ]\n" +
                "Numero do personagem: ");
            int jogador = Convert.ToInt32(Console.ReadLine());
            int oponente;
            bool defense;

            Console.Write("\nO jogo é bem simples você precisa atacar seu oponente ate que a vida do mesmo se esgote.\n\n");

            while(arus.hp > 0 && jennica.hp > 0 && topapa.hp > 0 && wedge.hp > 0){
                
                if(jogador > 4 || jogador <= 0){
                    jogador = 1;
                }

                do{
                    Console.Write($"\nJogador {jogador} é sua vez de jogar, informe o numero do heroi que você quer atacar" + 
                    "\n\n 1 - Arus (Lutador)\n 2 - Jennica (Mago)\n 3 - Topapa (Mago)\n 4 - Wedge (Ninja)" + "\n Oponente: ");
                    oponente = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"Ativar escudo? 1 - Sim || 2 - Não: ");
                    int escudo = Convert.ToInt32(Console.ReadLine());

                    if(escudo == 1){
                        defense = true;
                    }else{
                        defense = false;
                    }

                }while(oponente <= 0 || oponente > 4);
            
               switch(jogador){
                    case 1:
                        if(oponente != 1){
                            if(oponente == 2){
                                Console.Write(arus.Attack(jennica, defense) + 
                                "\nPrecione ENTER para continuar");
                                Console.ReadLine();
                            }else if(oponente == 3){
                                Console.Write(arus.Attack(topapa, defense) + 
                                "\nPrecione ENTER para continuar");
                                Console.ReadLine();
                            }else if(oponente == 4){
                                Console.Write(arus.Attack(wedge, defense)+ 
                                "\nPrecione ENTER para continuar");
                                Console.ReadLine();
                            }
                        }else{
                            Console.Write("\n[ERRO!!] Você não pode atacar você mesmo [PERDEU A VEZ]\n");
                            break;
                        }
                        break;
                    case 2:
                        if(oponente != 2){
                            if(oponente == 1){
                                Console.Write(jennica.Attack(arus, defense)+ 
                                "\nPrecione ENTER para continuar");
                                Console.ReadLine();
                            }else if(oponente == 3){
                                Console.Write(jennica.Attack(topapa, defense)+ 
                                "\nPrecione ENTER para continuar");
                                Console.ReadLine();
                            }else if(oponente == 4){
                                Console.Write(jennica.Attack(wedge, defense)+ 
                                "\nPrecione ENTER para continuar");
                                Console.ReadLine();
                            }
                        }else{
                            Console.Write("\n[ERRO!!] Você não pode atacar você mesmo [PERDEU A VEZ]\n");
                            break;
                        }
                    break;
                    case 3:
                        if(oponente != 3){
                            if(oponente == 2){
                                Console.Write(topapa.Attack(jennica, defense)+ 
                                "\nPrecione ENTER para continuar");
                                Console.ReadLine();
                            }else if(oponente == 1){
                                Console.Write(topapa.Attack(arus, defense)+ 
                                "\nPrecione ENTER para continuar");
                                Console.ReadLine();
                            }else if(oponente == 4){
                                Console.Write(topapa.Attack(wedge, defense)+ 
                                "\nPrecione ENTER para continuar");
                                Console.ReadLine();
                            }
                        }else{
                            Console.Write("\n[ERRO!!] Você não pode atacar você mesmo [PERDEU A VEZ]\n");
                            break;
                        }
                    break;
                    case 4:
                        if(oponente != 4){
                            if(oponente == 2){
                                Console.Write(wedge.Attack(jennica, defense)+ 
                                "\nPrecione ENTER para continuar");
                                Console.ReadLine();
                            }else if(oponente == 1){
                                Console.Write(wedge.Attack(arus, defense)+ 
                                "\nPrecione ENTER para continuar");
                                Console.ReadLine();
                            }else if(oponente == 3){
                                Console.Write(wedge.Attack(topapa, defense)+ 
                                "\nPrecione ENTER para continuar");
                                Console.ReadLine();
                            }
                        }else{
                            Console.Write("\n[ERRO!!] Você não pode atacar você mesmo [PERDEU A VEZ]\n");
                            break;
                        }
                        break;
                    default:
                            Console.Write("Opção Errada []\n");
                    break;
               }    
               jogador++; 
               Console.Clear();
            }

            Console.Write("STATUS DA RODADA: "+ 
               $"\n{arus.name} está com |HP: {arus.hp}|MANA: {arus.mana}|\n"+ 
               $"\n{jennica.name} está com |HP: {jennica.hp}|MANA: {jennica.mana}|\n"+
               $"\n{topapa.name} está com |HP: {topapa.hp}|MANA: {topapa.mana}|\n"+
               $"\n{wedge.name} está com |HP: {wedge.hp}|MANA: {wedge.mana}|\n");
        }
    }
}
