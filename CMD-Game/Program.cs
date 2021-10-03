using CMD_Game.Personagens;
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
            
            //Todos os parâmetros necessários são inerentes na próprias Classe Hero
            Hero hero = new Hero();
            

            griGame.PrintGrid();
            Console.WriteLine($"Hero Position: {hero.Position}");

        }

    }
    
}
