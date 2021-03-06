using CMD_Game.GridObjects;
using CMD_Game.Tipos;
using System;
using static CMD_Game.Tipos.ObjectGrid;

namespace CMD_Game.FunctionsSystem
{
    public static class SystemFunction
    {
        public static object Graphics { get; private set; }

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


        public static void PrintStatusBar(Hero hero)
        {            
            //Depois usar ref para variáveis  (ref Player.HeroHp)
            CriarLinha(40);
            Console.WriteLine($"Hero HP:{hero.hp} Hero Damage:{hero.damage} Hero Score:{hero.hp + hero.points}".PadLeft(39));
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
                    grid[i, j] = new ObjectGrid(i, j, GridType.O);
                }
            }
        }
        
        
        public static void Battle(Monster monster , Hero hero, ObjectGrid[,] grid)
        {
            if (monster.hp > 1)
            {
                monster.hp -= hero.damage;
            } 
            else
            {
                hero.points += monster.points;
                grid.SetValue(new ObjectGrid(monster.x, monster.y, GridType.O), monster.x, monster.y);                
            }

            if (hero.hp > 1)
            {                
                hero.hp -= monster.damage;                
            }           
        }

        public static void PrintScore(Hero hero, bool victory)
        {
            if (victory)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($">>>       VOCÊ VENCEU ! SCORE: {hero.points + hero.hp}      <<<");
                Console.ResetColor();
            }
            else
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($">>>       VOCÊ PERDEU ! SCORE: {hero.points + hero.hp}      <<<");
                Console.ResetColor();

            }
        }

        public static void PrintStatusHero(Hero hero)
        {
            if (hero.hp <= 0)
            {
                hero.status = Hero.StatusHero.GameOver;    
            }

            switch (hero.status)
            {
                case Hero.StatusHero.none:                    
                    break;
                case Hero.StatusHero.right:
                    Console.WriteLine(" To move right");
                    break;
                case Hero.StatusHero.left:
                    Console.WriteLine(" To move left");
                    break;
                case Hero.StatusHero.top:
                    Console.WriteLine(" To move up");
                    break;
                case Hero.StatusHero.down:
                    Console.WriteLine(" To move down");
                    break;
                case Hero.StatusHero.attackMoster:
                    Console.WriteLine(" To attack monster");
                    break;                
                case Hero.StatusHero.getPosion:
                    Console.WriteLine(" To get poison");
                    break;
                case Hero.StatusHero.getWeapon:
                    Console.WriteLine(" To get weapon");
                    break;
                case Hero.StatusHero.victory:
                    Console.WriteLine($" Victory !");
                    PrintScore(hero, true);
                    Program.FLAG = false; //ENCERRAR O GAME
                    break;
                case Hero.StatusHero.GameOver:
                    Console.WriteLine("Game Over !");
                    PrintScore(hero, false);
                    Program.FLAG = false; //ENCERRAR O GAME
                    break;                    
            }
        }
    }
}
