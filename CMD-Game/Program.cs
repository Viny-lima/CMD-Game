using CMD_Game.FunctionsSystem;
using CMD_Game.GridObjects;
using CMD_Game.Tipos;
using System;

namespace CMD_Game
{
    class Program
    {
        public static bool FLAG = true;               

        static void Main(string[] args)
        {   
            ObjectGrid[,] battleField = new ObjectGrid[22, 22]; //Grid Game
            SystemFunction.StartGrid(battleField); //Set  values in  grid

            Hero hero = new Hero();
            battleField.SetValue(hero, hero.x, hero.y);

            Weapon weapon = new Weapon(SystemFunction.RandNum(3, 18), SystemFunction.RandNum(3, 18));
            battleField.SetValue(weapon, weapon.x, weapon.y);

            Destiny destiny = new Destiny();
            battleField.SetValue(destiny, destiny.x, destiny.y);

            Boss boss = new Boss(SystemFunction.RandNum(3,18), SystemFunction.RandNum(3, 18));
            battleField.SetValue(boss, boss.x, boss.y);

            Monster[] monsters = new Monster[6];
            for (int i = 0; i <= 5; i++)
            {
                monsters[i] = new Monster(SystemFunction.RandNum(3, 18), SystemFunction.RandNum(3, 18));
                battleField.SetValue(monsters[i], monsters[i].x, monsters[i].y);
            }

            Poison[] poisons = new Poison[8];
            for (int i = 0; i <= 7; i++)
            {
                poisons[i] = new Poison(SystemFunction.RandNum(3, 18), SystemFunction.RandNum(3, 18));
                battleField.SetValue(poisons[i], poisons[i].x, poisons[i].y);
            }

            while (FLAG)
            {
                Console.Clear();                
                SystemFunction.PrintStatusBar(hero.hp, hero.damage, hero.points);
                SystemFunction.PrintGrid(battleField);
                Console.Write("A Posição do hero: " + hero.Position);
                ConsoleKey key = Console.ReadKey().Key;            
                
                hero.Control(key, ref battleField);//Ação do jogador
                //Monstros se movem em posição Aletória 
                boss.Move(key, ref battleField);
                foreach (Monster monster in monsters)
                {
                    monster.Move(key, ref battleField);
                }

            }
            

        }

    }
    
}
