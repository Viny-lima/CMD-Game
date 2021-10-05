using CMD_Game.Tipos;
using System;

namespace CMD_Game.GridObjects
{
    public class Hero : ObjectGrid
    {
        public uint hp = 25;
        public uint score;
        public uint damage = 1;        
        

        public Hero () : base(GridType.H, 1, 1) { }

        public override void Move(ConsoleKey key)
        {
            //O Herói perde vida quando se move
            if(hp > 0)
            {
                hp--;
            }

            switch (key)
            {
                case ConsoleKey.D:


                    if (_grid[_x, _y + 1] == GridType.O)
                    {

                        _grid[_x, _y] = GridType.O;
                        _y++;

                        if (_y > 20)
                        {

                            _y = 1;

                        }

                        _grid[_x, _y] = _type;

                    }

                    break;

                case ConsoleKey.A:
                    if (_grid[_x, _y - 1] == GridType.O)
                    {
                        //[A] to move right                    
                        _grid[_x, _y] = GridType.O;
                        _y -= 1;

                        if (_y < 1)
                        {
                            //Ele não pode ultrapassar o tamanho do Grid;
                            _y = 20;
                        }
                        _grid[_x, _y] = _type;
                        Console.WriteLine("> to move left");
                    }

                    break;

                case ConsoleKey.S:
                    if (_grid[_x + 1, _y] == GridType.O)
                    {
                        //[S] to move down                    
                        _grid[_x, _y] = GridType.O;
                        _x += 1;

                        if (_x > 20)
                        {
                            //Ele não pode ultrapassar o tamanho do Grid;
                            _x = 1;
                        }
                        _grid[_x, _y] = _type;
                        Console.WriteLine("> to move down");
                    }
                    break;

                case ConsoleKey.W:
                    if (_grid[_x - 1, _y] == GridType.O)
                    {
                        //[W] to move up                 
                        _grid[_x, _y] = GridType.O;
                        _x -= 1;

                        if (_x < 1)
                        {
                            //Ele não pode ultrapassar o tamanho do Grid;
                            _x = 20;
                        }
                        _grid[_x, _y] = _type;
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

        //Em testes
        public void SearchMonster()
        {
            GridType up = _grid[_x - 1, _y];
            GridType dow = _grid[_x + 1, _y];
            GridType left = _grid[_x, _y + 1];
            GridType right = _grid[_x, _y -1];

        }

    }   
}
