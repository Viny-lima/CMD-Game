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
            victory
        }

        public StatusHero status = StatusHero.none;

        public Hero() : base(1, 1, GridType.H, 25, 1, 0) { }
        

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
                        //[D] to move right                    
                        grid.SetValue(new ObjectGrid(x, y, GridType.O), x, y);
                        y ++;
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
                        Console.Clear();                        
                    }

                    if(right._type == GridType.W)
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
                        this.damage += right.damage;
                        status = StatusHero.getWeapon;
                        Console.Clear();
                    }
                    if (right._type == GridType.P)
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
                        this.hp += right.hp;
                        this.points += right.points;
                        status = StatusHero.getPosion;
                        Console.Clear();

                    }
                    if (right._type == GridType.D)
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
                       
                        Program.FLAG = false;
                        status = StatusHero.victory;
                        SystemFunction.PrintScore(this,true);
                    }                    
                    break;

                case ConsoleKey.A:
                    if (left._type == GridType.O)
                    {
                        //[A] to move left                    
                        grid.SetValue(new ObjectGrid(x, y, GridType.O), x, y);
                        y --;
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
                        status = StatusHero.left;
                        Console.Clear();
                    }

                    if (left._type == GridType.W)
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
                        this.damage += left.damage;
                        status = StatusHero.getWeapon;
                        Console.Clear();
                    }
                    if (left._type == GridType.P)
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
                        this.hp += left.hp;
                        this.points += left.points;
                        status = StatusHero.getPosion;
                        Console.Clear();
                    }
                    break;

                case ConsoleKey.S:
                    if (down._type == GridType.O)
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
                        status = StatusHero.down;
                        Console.Clear();
                    }

                    if (down._type == GridType.W)
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
                        this.damage += down.damage;
                        status = StatusHero.getWeapon;
                        Console.Clear();
                    }
                    if (down._type == GridType.P)
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
                        this.hp += down.hp;
                        this.points += down.points;
                        status = StatusHero.getPosion;
                        Console.Clear();
                    }
                    if (down._type == GridType.D)
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
                       
                        Program.FLAG = false;
                        status = StatusHero.victory;
                        SystemFunction.PrintScore(this,true);
                    }
                    break;

                case ConsoleKey.W:
                    if (top._type == GridType.O)
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
                        status = StatusHero.top;
                        Console.Clear();
                    }  
                    
                    if (top._type == GridType.W)
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
                        this.damage += top.damage;
                        status = StatusHero.getWeapon;
                        Console.Clear();
                    }
                    if (top._type == GridType.P)
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
                        this.hp += top.hp;
                        this.points += top.points;
                        status = StatusHero.getPosion;
                        Console.Clear();
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
