using CMD_Game.Tipos;
using CMD_Game.FunctionsSystem;
using System;

namespace CMD_Game.GridObjects
{
    public class Monster : ObjectGrid
    {
        public Monster(int x, int y, ObjectGrid[,] grid,GridType type = GridType.M, int hp = 5, int damage = 1, int points = 10) : base (x, y, type, hp, damage, points) 
        {
            if(grid[base.x, base.y]._type == GridType.O)
            {
                //SetValue()
                grid[base.x, base.y]._type = this._type;
                grid[base.x, base.y].hp = this.hp;
                grid[base.x, base.y].damage = this.damage;
                grid[base.x, base.y].points = this.points;
            }
            
        }

        public void Move(ConsoleKey key, ObjectGrid[,] grid)
        {
            ObjectGrid right = grid[x, y + 1];
            ObjectGrid left = grid[x, y - 1];
            ObjectGrid donw = grid[x + 1, y];
            ObjectGrid top = grid[x - 1, y];

            if (key == ConsoleKey.A || key == ConsoleKey.D || key == ConsoleKey.W || key == ConsoleKey.S)
            {

                switch (SystemFunction.RandNum(1,4))
                {
                    case 1:

                        if (right._type == GridType.O)
                        {

                            grid[x, y]._type = GridType.O;
                            y++;

                            if (y > 18)
                            {

                                y = 3;

                            }

                            grid[x, y]._type = _type;

                        }

                        break;

                    case 2:
                        if (left._type == GridType.O)
                        {
                            //[A] to move right                    
                            grid[x, y]._type = GridType.O;
                            y -= 1;

                            if (y < 3)
                            {
                                //Ele não pode ultrapassar o tamanho do Grid;
                                y = 18;
                            }
                            grid[x, y]._type = _type;
                            Console.WriteLine("> to move left");
                        }

                        break;

                    case 3:
                        if (donw._type == GridType.O)
                        {
                            //[S] to move down                    
                            grid[x, y]._type = GridType.O;
                            x += 1;

                            if (x > 18)
                            {
                                //Ele não pode ultrapassar o tamanho do Grid;
                                x = 3;
                            }
                            grid[x, y]._type = _type;
                            Console.WriteLine("> to move down");
                        }
                        break;

                    case 4:
                        if (top._type == GridType.O)
                        {
                            //[W] to move up                 
                            grid[x, y]._type = GridType.O;
                            x -= 1;

                            if (x < 3)
                            {
                                //Ele não pode ultrapassar o tamanho do Grid;
                                y = 18;
                            }
                            grid[x, y]._type = _type;
                            Console.WriteLine("> to move up");
                        }
                        break;
                }
            }

        }

    }

}
