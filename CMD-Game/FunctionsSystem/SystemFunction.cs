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
    }
}
