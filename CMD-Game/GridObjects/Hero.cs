using CMD_Game.FunctionsSystem;
using CMD_Game.Tipos;
using System;

namespace CMD_Game.GridObjects
{
    public class Hero : ObjectGrid
    {       
                    
        public Hero (ObjectGrid[,] grid) : base(1, 1, GridType.H, 100, 1, 0) 
        {
            //SetValue()
            grid[x, y]._type = this._type;
            grid[x, y].damage = this.damage;
            grid[x, y].hp = this.hp;
            grid[x, y].points = this.points;
        }

        public void Control(ConsoleKey key, ref ObjectGrid[,] grid)
        {
            //O Herói perde vida quando se move
            ObjectGrid right = grid[x, y + 1];
            ObjectGrid left = grid[x, y - 1];
            ObjectGrid donw = grid[x + 1, y];
            ObjectGrid top = grid[x - 1, y];

            switch (key)
            {
                case ConsoleKey.D:
                    if (right._type == GridType.O)
                    {

                        grid[x, y]._type = GridType.O;
                        y++;

                        if (y > 20)
                        {

                            y = 20;

                        } 
                        else
                        {
                            if (hp > 0)
                            {
                                hp--;
                            }

                        }

                        grid[x, y]._type = _type;
                    }                    
                    break;

                case ConsoleKey.A:
                    if (left._type == GridType.O)
                    {
                        //[A] to move right                    
                        grid[x, y]._type = GridType.O;
                        y -= 1;

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
                        grid[x, y]._type = _type;
                        Console.WriteLine("> to move left");
                    }                    
                    break;

                case ConsoleKey.S:
                    if (donw._type == GridType.O)
                    {
                        //[S] to move down                    
                        grid[x, y]._type = GridType.O;
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
                        grid[x, y]._type = _type;
                        Console.WriteLine("> to move down");
                    }
                    break;

                case ConsoleKey.W:
                    if (top._type == GridType.O)
                    {
                        //[W] to move up                 
                        grid[x, y]._type = GridType.O;
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
                        grid[x, y]._type = _type;
                        Console.WriteLine("> to move up");
                    }                 

                    break;

                case ConsoleKey.Escape:
                    Program.FLAG = false;
                    break;

                case ConsoleKey.Spacebar:
                    //Antes de atacar o hero deve verificar se há mosntros ao redor                                 

                    if (top._type == GridType.M || top._type == GridType.B)
                    {                        
                        SystemFunction.Battle(top, this, grid);
                    }
                    if (donw._type == GridType.M || donw._type == GridType.B)
                    {
                        SystemFunction.Battle(donw, this, grid);
                    }
                    if (left._type == GridType.M || left._type == GridType.B)
                    {
                        SystemFunction.Battle(left, this, grid);
                    }
                    if (right._type == GridType.M || right._type == GridType.B)
                    {
                        SystemFunction.Battle(right, this, grid);
                    }
                    break;


            }
        }

        public virtual void React()
        {

        }

    }   
}
