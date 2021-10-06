using CMD_Game.FunctionsSystem;
using CMD_Game.Tipos;
using System;

namespace CMD_Game.GridObjects
{
    public class Hero : ObjectGrid
    {
        public enum StatusHero
        {
            none,
            right,
            left,
            top,
            down,
            attackMoster,            
            getPosion,
            getWeapon,
            victory,
            GameOver
        }

        public StatusHero status = StatusHero.none;

        public Hero() : base(1, 1, GridType.H, 25, 1, 0) { }
        

        void ToRight(ObjectGrid[,] grid)
        {
            //[D] to move right                    
            grid.SetValue(new ObjectGrid(x, y, GridType.O), x, y);
            y++;
            if (y > 20)
            {
                //Ele não pode ultrapassar o tamanho do Grid;
                y = 20;
            }
            else
            {
                if (hp > 0)
                {
                    hp--;
                }

            }
            grid.SetValue(this, x, y);
            status = StatusHero.right;
        }

        void Toleft(ObjectGrid [,] grid)
        {
            //[A] to move left                    
            grid.SetValue(new ObjectGrid(x, y, GridType.O), x, y);
            y--;
            if (y < 1)
            {
                //Ele não pode ultrapassar o tamanho do Grid;
                y = 1;
            }
            else
            {
                if (hp > 0)
                {
                    hp--;
                }

            }
            grid.SetValue(this, x, y);
        }

        void ToDown(ObjectGrid[,] grid)
        {
            //[S] to move down                    
            grid.SetValue(new ObjectGrid(x, y, GridType.O), x, y);
            x += 1;

            if (x > 20)
            {
                //Ele não pode ultrapassar o tamanho do Grid;
                x = 20;
            }
            else
            {
                if (hp > 0)
                {
                    hp--;
                }

            }
            grid.SetValue(this, x, y);
        }

        void ToUp(ObjectGrid[,] grid)
        {
            //[W] to move up                 
            grid.SetValue(new ObjectGrid(x, y, GridType.O), x, y);
            x -= 1;

            if (x < 1)
            {
                //Ele não pode ultrapassar o tamanho do Grid;
                x = 1;
            }
            else
            {
                if (hp > 0)
                {
                    hp--;
                }
            }
            grid.SetValue(this, x, y);
        }


        public void Control(ConsoleKey key, ref ObjectGrid[,] grid)
        {
            //O Herói perde vida quando se move
            ObjectGrid right = grid[x, y + 1];
            ObjectGrid left = grid[x, y - 1];
            ObjectGrid down = grid[x + 1, y];
            ObjectGrid top = grid[x - 1, y];

            switch (key)
            {
                case ConsoleKey.D:
                    if (right._type == GridType.O)
                    {
                        ToRight(grid);
                        status = StatusHero.right;
                    }

                    if(right._type == GridType.W)
                    {
                        ToRight(grid);
                        status = StatusHero.getWeapon;
                        this.damage += right.damage;                        
                    }
                    if (right._type == GridType.P)
                    {
                        ToRight(grid);
                        status = StatusHero.getPosion;
                        this.hp += right.hp;
                        this.points += right.points;                                                                   
                    }
                    if (right._type == GridType.D)
                    {
                        ToRight(grid);
                        status = StatusHero.GameOver;
                        SystemFunction.PrintScore(this);
                    }                    
                    break;

                case ConsoleKey.A:
                    if (left._type == GridType.O)
                    {
                        Toleft(grid);
                        status = StatusHero.left;
                        Console.Clear();
                    }

                    if (left._type == GridType.W)
                    {
                        Toleft(grid);
                        this.damage += left.damage;
                        status = StatusHero.getWeapon;;
                    }
                    if (left._type == GridType.P)
                    {
                        Toleft(grid);
                        this.hp += left.hp;
                        this.points += left.points;
                        status = StatusHero.getPosion;
                    }
                    break;

                case ConsoleKey.S:
                    if (down._type == GridType.O)
                    {
                        ToDown(grid);
                        status = StatusHero.down;
                    }

                    if (down._type == GridType.W)
                    {
                        ToDown(grid);
                        this.damage += down.damage;
                        status = StatusHero.getWeapon;
                    }
                    if (down._type == GridType.P)
                    {
                        ToDown(grid);
                        this.hp += down.hp;
                        this.points += down.points;
                        status = StatusHero.getPosion;
                    }
                    if (down._type == GridType.D)
                    {
                        ToDown(grid);
                        status = StatusHero.victory;
                    }
                    break;

                case ConsoleKey.W:
                    if (top._type == GridType.O)
                    {
                        ToUp(grid);
                        status = StatusHero.top;
                    }  
                    
                    if (top._type == GridType.W)
                    {
                        ToUp(grid);
                        this.damage += top.damage;
                        status = StatusHero.getWeapon;
                    }
                    if (top._type == GridType.P)
                    {
                        ToUp(grid);
                        this.hp += top.hp;
                        this.points += top.points;
                        status = StatusHero.getPosion;
                    }
                    break;

                case ConsoleKey.Escape:
                    Program.FLAG = false;
                    break;

                case ConsoleKey.Spacebar:
                    //Antes de atacar o hero deve verificar se há mosntros ao redor                                 

                    if (top._type == GridType.M || top._type == GridType.B)
                    {                        
                        SystemFunction.Battle((Monster) top, this, grid);
                    }
                    if (down._type == GridType.M || down._type == GridType.B)
                    {
                        SystemFunction.Battle((Monster)down, this, grid);
                    }
                    if (left._type == GridType.M || left._type == GridType.B)
                    {
                        SystemFunction.Battle((Monster) left, this, grid);
                    }
                    if (right._type == GridType.M || right._type == GridType.B)
                    {
                        SystemFunction.Battle((Monster)right, this, grid);
                    }
                    status = StatusHero.attackMoster;
                    Console.Clear();
                    break;               
            }
            Console.Clear();
        }



    }   
}
