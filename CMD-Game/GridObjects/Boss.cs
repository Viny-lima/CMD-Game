using CMD_Game.FunctionsSystem;
using CMD_Game.Tipos;
using System;

namespace CMD_Game.GridObjects
{
    public class Boss : ObjectGrid
    {
        //O Boss tambémm é um mostro contudo mais forte

        public uint hp = 10;
        public uint damage = 2;
        public uint points = 15;


        public Boss(int x, int y, ObjectGrid[,] grid) : base(x, y, GridType.B) { }
        
        public override void Move(ConsoleKey key, ObjectGrid[,] grid)

        {
            if (key == ConsoleKey.A || key == ConsoleKey.D || key == ConsoleKey.W || key == ConsoleKey.S)
            {

                switch (SystemFunction.RandNum(1, 4))
                {
                    case 1:

                        if (grid[_x, _y + 1]._type == GridType.O)
                        {

                            grid[_x, _y]._type = GridType.O;
                            _y++;

                            if (_y > 18)
                            {

                                _y = 3;

                            }

                            grid[_x, _y]._type = _type;

                        }

                        break;

                    case 2:
                        if (grid[_x, _y - 1]._type == GridType.O)
                        {
                            //[A] to move right                    
                            grid[_x, _y]._type = GridType.O;
                            _y -= 1;

                            if (_y < 3)
                            {
                                //Ele não pode ultrapassar o tamanho do Grid;
                                _y = 18;
                            }
                            grid[_x, _y]._type = _type;
                            Console.WriteLine("> to move left");
                        }

                        break;

                    case 3:
                        if (grid[_x + 1, _y]._type == GridType.O)
                        {
                            //[S] to move down                    
                            grid[_x, _y]._type = GridType.O;
                            _x += 1;

                            if (_x > 18)
                            {
                                //Ele não pode ultrapassar o tamanho do Grid;
                                _x = 3;
                            }
                            grid[_x, _y]._type = _type;
                            Console.WriteLine("> to move down");
                        }
                        break;

                    case 4:
                        if (grid[_x - 1, _y]._type == GridType.O)
                        {
                            //[W] to move up                 
                            grid[_x, _y]._type = GridType.O;
                            _x -= 1;

                            if (_x < 3)
                            {
                                //Ele não pode ultrapassar o tamanho do Grid;
                                _y = 18;
                            }
                            grid[_x, _y]._type = _type;
                            Console.WriteLine("> to move up");
                        }
                        break;
                }
            }

        }
    }
}
