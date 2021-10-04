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

            Grid grid = GerarGrid();

            while (true)
            {
                Console.Clear();
                grid.PrintGrid();
                Console.ReadLine();
            }

        }

        public static Grid GerarGrid()
        {
            //Referenciando um Grid universal a todos os objetos 
            //ATENÇÃO ! SE ISSO NÃO FOR INSTANCIADO NÃO HAVERÁ COMPILAÇÃO !!!
            Grid griGame = new Grid();
            ObjectGrid.InsertGridUniversal(ref griGame);

            //Criando os objetos no grid
            Hero hero = new Hero();
            Destiny destiny = new Destiny();
            Boss monstroChefe = new Boss(SystemFunction.RandNum(2, 17), SystemFunction.RandNum(2, 17));
            Poison poison = new Poison(SystemFunction.RandNum(2, 17), SystemFunction.RandNum(2, 17));
            Weapon arma = new Weapon(SystemFunction.RandNum(2, 17), SystemFunction.RandNum(2, 17));

            for (int i = 0; i < 6; i++)
            {
                Monster monstro = new Monster(SystemFunction.RandNum(2, 17), SystemFunction.RandNum(2, 17));
            }


            return griGame;
        }
    }
    
}
