using CMD_Game.Personagens;
using CMD_Game.Tipos;
using System;

namespace CMD_Game
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Criando nosso Objetos
            Grid griGame = new Grid();
            Hero hero = new Hero(griGame.CampGame);
            griGame.PrintGrid();

        }

    }
    
}
