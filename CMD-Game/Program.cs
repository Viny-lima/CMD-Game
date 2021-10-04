using CMD_Game.FunctionsSystem;
using CMD_Game.GridObjects;
using CMD_Game.Tipos;
using System;

namespace CMD_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Referenciando um Grid universal a todos os objetos 
            //ATENÇÃO ! SE ISSO NÃO FOR INSTANCIADO NÃO HAVERÁ COMPILAÇÃO !!!
            Grid griGame = new Grid();
            ObjectGrid.InsertGridUniversal(ref griGame);

            //Criando os objetos no grid
            Hero hero = new Hero();
            Destiny destiny = new Destiny();
            Boss monstroChefe = new Boss(SystemFunction.RandNum(3, 18), SystemFunction.RandNum(3, 18));
            Weapon arma = new Weapon(SystemFunction.RandNum(3, 18), SystemFunction.RandNum(3, 18));

            for (int i = 0; i < 8; i++)
            {
                Poison poison = new Poison(SystemFunction.RandNum(3, 18), SystemFunction.RandNum(3, 18));
            }            
            
            for (int i = 0; i < 6; i++)
            {
                Monster monstro = new Monster(SystemFunction.RandNum(3, 18), SystemFunction.RandNum(3, 18));
            }                
          

            while (true)
            {
                Console.Clear();
                griGame.PrintGrid();
                Console.Write("A Posição do hero: " + hero.Position);
                ConsoleKey key = Console.ReadKey().Key;
                hero.Move(key);                
            }

        }

    }
    
}
