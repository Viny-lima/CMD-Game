using CMD_Game.Tipos;
using CMD_Game.FunctionsSystem;
using System;

namespace CMD_Game.GridObjects
{
    public class Monster : ObjectGrid
    {
        public uint hp = 5;
        public uint damage = 1;
        public uint points = 5;



        public Monster(int x, int y) : base (GridType.M, x, y) { }
        public override void Move(ConsoleKey key)

        {
            if (key == ConsoleKey.A || key == ConsoleKey.D || key == ConsoleKey.W || key == ConsoleKey.S)
            {

                switch (SystemFunction.RandNum(1,4))
                {
                    case 1:

                        if (_grid[_x, _y + 1] == GridType.O)
                        {

                            _grid[_x, _y] = GridType.O;
                            _y++;

                            if (_y > 18)
                            {

                                _y = 3;

                            }

                            _grid[_x, _y] = _type;

                        }

                        break;

                    case 2:
                        if (_grid[_x, _y - 1] == GridType.O)
                        {
                            //[A] to move right                    
                            _grid[_x, _y] = GridType.O;
                            _y -= 1;

                            if (_y < 3)
                            {
                                //Ele não pode ultrapassar o tamanho do Grid;
                                _y = 18;
                            }
                            _grid[_x, _y] = _type;
                            Console.WriteLine("> to move left");
                        }

                        break;

                    case 3:
                        if (_grid[_x + 1, _y] == GridType.O)
                        {
                            //[S] to move down                    
                            _grid[_x, _y] = GridType.O;
                            _x += 1;

                            if (_x > 18)
                            {
                                //Ele não pode ultrapassar o tamanho do Grid;
                                _x = 3;
                            }
                            _grid[_x, _y] = _type;
                            Console.WriteLine("> to move down");
                        }
                        break;

                    case 4:
                        if (_grid[_x - 1, _y] == GridType.O)
                        {
                            //[W] to move up                 
                            _grid[_x, _y] = GridType.O;
                            _x -= 1;

                            if (_x < 3)
                            {
                                //Ele não pode ultrapassar o tamanho do Grid;
                                _y = 18;
                            }
                            _grid[_x, _y] = _type;
                            Console.WriteLine("> to move up");
                        }
                        break;
                }
            }

        }

    }

}
