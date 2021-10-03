using System;
using static CMD_Game.Tipos.ObjectGrid;

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
        
        public static void PrintStatusBar(int heroHp,int heroDamage,int heroScore)
        {
            //Depois usar ref para variáveis  (ref Player.HeroHp)
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

        public static void PrintGridColors(GridType typeStatus)
        {
            //Mudando as cores no console baseado no type value enum StatusGrid
            switch (typeStatus)
            {
                case GridType.O:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                case GridType.H:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                case GridType.B:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                case GridType.M:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                case GridType.P:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                case GridType.W:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                case GridType.D:
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

        public static int RandNum(int minValue, int maxValue)
        {
            Random randNum = new Random();

            return (int) randNum.Next(minValue, maxValue);
        }

    }
}
