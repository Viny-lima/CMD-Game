using CMD_Game.Tipos;
using System;

namespace CMD_Game.GridObjects
{
    public class Hero : ObjectGrid
    {
        public uint hp = 25;
        public uint score;
        public uint damage = 1;        
        

        public Hero (ObjectGrid[,] grid) : base(1, 1, GridType.H) 
        {
            grid[_x, _y]._type = this._type; 
        }

        public override void Move(ConsoleKey key, ObjectGrid[,] grid)
        {
            //O Herói perde vida quando se move
            if(hp > 0)
            {
                hp--;
            }

            switch (key)
            {
                case ConsoleKey.D:


                    if (grid[_x, _y + 1]._type == GridType.O)
                    {

                        grid[_x, _y]._type = GridType.O;
                        _y++;

                        if (_y > 20)
                        {

                            _y = 1;

                        }

                        grid[_x, _y]._type = _type;

                    }

                    break;

                case ConsoleKey.A:
                    if (grid[_x, _y - 1]._type == GridType.O)
                    {
                        //[A] to move right                    
                        grid[_x, _y]._type = GridType.O;
                        _y -= 1;

                        if (_y < 1)
                        {
                            //Ele não pode ultrapassar o tamanho do Grid;
                            _y = 20;
                        }
                        grid[_x, _y]._type = _type;
                        Console.WriteLine("> to move left");
                    }

                    break;

                case ConsoleKey.S:
                    if (grid[_x + 1, _y]._type == GridType.O)
                    {
                        //[S] to move down                    
                        grid[_x, _y]._type = GridType.O;
                        _x += 1;

                        if (_x > 20)
                        {
                            //Ele não pode ultrapassar o tamanho do Grid;
                            _x = 1;
                        }
                        grid[_x, _y]._type = _type;
                        Console.WriteLine("> to move down");
                    }
                    break;

                case ConsoleKey.W:
                    if (grid[_x - 1, _y]._type == GridType.O)
                    {
                        //[W] to move up                 
                        grid[_x, _y]._type = GridType.O;
                        _x -= 1;

                        if (_x < 1)
                        {
                            //Ele não pode ultrapassar o tamanho do Grid;
                            _x = 20;
                        }
                        grid[_x, _y]._type = _type;
                        Console.WriteLine("> to move up");
                    }
                    break;

                case ConsoleKey.Escape:
                    Program.FLAG = false;
                    break;

                case ConsoleKey.Backspace:                  
                    break;


            }
        }        

    }   
}
