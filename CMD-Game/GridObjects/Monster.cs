using CMD_Game.Tipos;
using CMD_Game.FunctionsSystem;
using System;

namespace CMD_Game.GridObjects
{
    public class Monster : ObjectGrid
    {
        int _monsterHp;
        int _monsterDamage;
        int _valuePoints;

        public int MonsterHp
        {
            get
            {
                return _monsterHp;
            }

            set
            {
                //A morte do monstro
                if (_monsterHp <= 0)
                {
                    //Na sua localização se torna vazia
                    _grid[_x, _y] = GridType.O;
                } 
                else
                {
                    _monsterHp = value;
                }
            }
        }

        public Monster(int x, int y, int hp = 5, int damage = 1, int points = 5) : base (GridType.M, x, y)
        {
            _monsterHp = hp;
            _monsterDamage = damage;
            _valuePoints = points;
        }   

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
