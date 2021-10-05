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
            //ATENÇÂO ! FOI DEFINIDO UM GRID PADRÃO REFERÊNCIADO A TODOS OS OBJETOS DO PROGRAMA.            
            ObjectGrid[,] battleField = new ObjectGrid[22, 22];            
            SystemFunction.StartGrid(battleField); //Setando valores no grid

            Hero hero = new Hero(battleField);           

          
            while (FLAG)
            {
                Console.Clear();
                SystemFunction.PrintStatusBar(ref hero.hp, ref hero.damage, ref hero.score);
                SystemFunction.PrintGrid(battleField);
                hero.Move(Console.ReadKey().Key, battleField);
            }

        }

    }
    
}
