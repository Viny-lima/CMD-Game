using CMD_Game.FunctionsSystem;
using CMD_Game.GridObjects;
using CMD_Game.Tipos;
using System;
using static CMD_Game.Tipos.ObjectGrid;

namespace CMD_Game
{
    class Program
    {
        public static bool FLAG = true;
        static void Main(string[] args)
        {                      
            ObjectGrid[,] battleField = new ObjectGrid[22, 22]; //Grid do jogo           
            SystemFunction.StartGrid(battleField); //Setando valores no grid

            Hero hero = new Hero(battleField);
            Destiny destiny = new Destiny(battleField);
            
            Boss monstroChefe = new Boss(SystemFunction.RandNum(3, 18), SystemFunction.RandNum(3, 18), battleField);
            Weapon arma = new Weapon(SystemFunction.RandNum(3, 18), SystemFunction.RandNum(3, 18), battleField);
            Poison[] poisons = new Poison[8];
            for (int i = 0; i <= 7; i++)
            {
                Poison poison = new Poison(SystemFunction.RandNum(3, 18), SystemFunction.RandNum(3, 18), battleField);
                poisons[i] = poison;
            }
            Monster[] monsters = new Monster[6];
            for (int i = 0; i <= 5; i++)
            {
                Monster monstro = new Monster(SystemFunction.RandNum(3, 18), SystemFunction.RandNum(3, 18), battleField);
                monsters[i] = monstro;
            }
            
            while (FLAG)
            {
                Console.Clear();
                SystemFunction.PrintStatusBar(ref hero.hp, ref hero.damage, ref hero.score);
                SystemFunction.PrintGrid(battleField);
                foreach(Monster monster in monsters)
                {
                    Console.Write("A Posição do M: " + monster.Position);
                }
                Console.Write("A Posição do hero: " + hero.Position);
                ConsoleKey key = Console.ReadKey().Key;
                hero.Move(key, battleField); 
                foreach(Monster monster in monsters)
                {
                    monster.Move(key, battleField);                    
                }
            }

        }

    }
    
}
