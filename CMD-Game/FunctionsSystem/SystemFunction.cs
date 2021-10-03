using CMD_Game.Tipos;
using System;

namespace CMD_Game.FunctionsSystem
{
    public class SystemFunction
    {
        public static void CriarLinha(int Tamanho)
        {            
            for (int i = 0; i <= Tamanho; i++)
            {
                Console.Write($"=");
            }
            Console.WriteLine("");
        }

        //Depois usar ref para variáveis  (ref Player.HeroHp)
        public static void PrintStatusBar(int heroHp,int heroDamage,int heroScore)
        {
            CriarLinha(40);
            Console.WriteLine($"Hero HP:{heroHp} Hero Damage:{heroDamage} Hero Score:{heroScore}".PadLeft(39));
            CriarLinha(40);
        }

        public static void PrintControl()
        {
            Console.WriteLine(" [A] to move left.    [D] to move rigth.");
            Console.WriteLine(" [W] to move up.      [S] to move down.");
            Console.WriteLine(" [SPACE] to attack.   [ESC} to exit.");
        }


        public static void PrintGridColors(StatusGrid typeStatus)
        {
            //Mudando as cores no console baseado no type value enum StatusGrid
            switch (typeStatus)
            {
                case StatusGrid.O:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                case StatusGrid.H:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                case StatusGrid.B:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                case StatusGrid.M:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                case StatusGrid.P:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                case StatusGrid.W:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                case StatusGrid.D:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                default:
                    //Utrapasse os tipo por algum erro ele não deve ser impresso no Console.
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
