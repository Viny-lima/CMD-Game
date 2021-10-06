using CMD_Game.Tipos;
using CMD_Game.FunctionsSystem;
using System;

namespace CMD_Game.GridObjects
{
    public class Monster : ObjectGrid
    {
        public Monster(int x, int y,GridType type = GridType.M, int hp = 5, int damage = 1, int points = 10) : base (x, y, type, hp, damage, points) { }        

        public void Move(ConsoleKey key, ref ObjectGrid[,] grid)
        {
            ObjectGrid right = grid[x, y + 1];
            ObjectGrid left = grid[x, y - 1];
            ObjectGrid donw = grid[x + 1, y];
            ObjectGrid top = grid[x - 1, y];

            if (key == ConsoleKey.A || key == ConsoleKey.D || key == ConsoleKey.W || key == ConsoleKey.S || key == ConsoleKey.Spacebar)
            {

                switch (SystemFunction.RandNum(1,5))
                {
                    case 1:

                        if (right._type == GridType.O)
                        {
                            grid.SetValue(new ObjectGrid(x, y, GridType.O), x, y);
                            y ++;

                            if (y > 20)
                            {

                                y = 20;

                            }

                            grid.SetValue(this, x, y);
                        }

                        break;

                    case 2:
                        if (left._type == GridType.O)
                        {
                            //[A] to move right                    
                            grid.SetValue(new ObjectGrid(x, y, GridType.O), x, y);
                            y --;

                            if (y < 1)
                            {
                                //Ele não pode ultrapassar o tamanho do Grid;
                                y = 1;
                            }

                            grid.SetValue(this, x, y);
                        }

                        break;

                    case 3:
                        if (donw._type == GridType.O)
                        {
                            //[S] to move down                    
                            grid.SetValue(new ObjectGrid(x, y, GridType.O), x, y);
                            x ++;

                            if (x > 20)
                            {
                                //Ele não pode ultrapassar o tamanho do Grid;
                                x = 20;
                            }

                            grid.SetValue(this, x, y);
                        }
                        break;

                    case 4:
                        if (top._type == GridType.O)
                        {
                            //[W] to move up                 
                            grid.SetValue(new ObjectGrid(x, y, GridType.O), x, y);
                            x --;

                            if (x < 1)
                            {
                                //Ele não pode ultrapassar o tamanho do Grid;
                                x = 1;
                            }

                            grid.SetValue(this, x, y);
                        }
                        break;
                }

                //Mostros batem em Hero
                if (right._type == GridType.H && right.hp > 2)
                {
                    right.hp -= this.damage;
                }
                if (left._type == GridType.H && right.hp > 2)
                {
                    left.hp -= this.damage;
                }
                if (donw._type == GridType.H && right.hp > 2)
                {
                    donw.hp -= this.damage;
                }
                if (top._type == GridType.H && right.hp > 2)
                {
                    top.hp -= this.damage;
                }

            }
            
            
        }

    }

}
