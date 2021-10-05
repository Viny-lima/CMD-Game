using CMD_Game.GridObjects;
using CMD_Game.Tipos;
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
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($" {typeStatus}");
                    Console.ResetColor();
                    break;
                case GridType.D:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
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


        public static void PrintStatusBar(ref uint heroHp, ref uint heroDamage, ref uint heroScore)
        {
            //Depois usar ref para variáveis  (ref Player.HeroHp)
            CriarLinha(40);
            Console.WriteLine($"Hero HP:{heroHp} Hero Damage:{heroDamage} Hero Score:{heroScore}".PadLeft(39));
            CriarLinha(40);
        }


        public static void PrintGrid(ObjectGrid[,] grid)
        {

            //Imprimindo no Grid no Console
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    PrintGridColors(grid[i, j]._type);
                }

                //Quebra de linha
                Console.WriteLine("");
            }

            SystemFunction.CriarLinha(40);
            SystemFunction.PrintControl();
            SystemFunction.CriarLinha(40);
        }


        public static void StartGrid(ObjectGrid[,] grid)
        {
            //Com o tipo valor interno vazio em sua construção            

            for (int i = 0; i <= 21; i++)
            {
                for (int j = 0; j <= 21; j++)
                {
                    grid[i, j] = new ObjectGrid(i, j);
                }
            }
        }

        /*
        //Em fase de teste
        public static void duelMonster(Monster monster, Hero hero)
        {
            if (monster.hp > 0)
            {
                monster.hp -= hero.damage;
            } 
            else if (monster.hp == 0)
            {
                grid[monster._x,monster._y] = GridType.O;
                hero.score += monster.points;
            }

            if (hero.hp > 0)
            {
                hero.hp -= monster.damage;
            }
            else if (hero.hp == 0)
            {
                //Se a vida do herói zerar o programa deve fechar
                Program.FLAG = false;
            }            
        }

        public static void duelBoss(Boss boss, Hero hero)
        {
            if (boss.hp > 0)
            {
                boss.hp -= hero.damage;
            }
            else if (boss.hp == 0)
            {
                grid[boss._x, boss._y] = GridType.O;
                hero.score += boss.points;
            }

            if (hero.hp > 0)
            {
                hero.hp -= boss.damage;
            }
            else if (hero.hp == 0)
            {
                //Se a vida do herói zerar o programa deve fechar
                grid[hero._x, hero._y] = GridType.O;
                Program.FLAG = false;
            }
        }
        */
    }
}
