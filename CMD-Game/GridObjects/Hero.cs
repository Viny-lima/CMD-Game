﻿using CMD_Game.Tipos;
using System;

namespace CMD_Game.GridObjects
{
    class Hero : ObjectGrid
    {
        int _heroHp = 25;
        int _heroScore;
        int _heroDamage = 1;
        

        public int HeroHp
        {
            get
            {
                return _heroHp;
            }

            set
            {
                //vida do player não pode ser negativa
                if (_heroHp >= 0)
                {
                    _heroHp = value;
                }

                else
                {
                    _heroHp = 0;
                }

            }
        }                                       
        public int HeroScore
        {
            get
            {
                return _heroScore;
            }

            set
            {
                //o score não pode ser negativo
                if (_heroScore >= 0)
                {
                    _heroScore = value;
                }

                else
                {
                    _heroScore = 0;
                }

            }
        }
        public int HeroDamage
        {
            get
            {
                return _heroDamage;
            }

            set
            {
                //o dano fica entre 1 e 2
                if (_heroDamage >= 1 && _heroDamage <= 2)
                {
                    _heroDamage = value;
                }

                else
                {
                    _heroDamage = 0;
                }

            }
        }

        public Hero () : base(GridType.H, 0, 0) { }

        public void Move( ConsoleKey key)
        {          
            
            switch (key)
            {
                case ConsoleKey.D:
                    //[D] to move right                    
                    _grid[_x, _y] = GridType.O;
                    _y += 1;

                    if (_y > 19)
                    {
                        //Ele não pode ultrapassar o tamanho do Grid;
                        _y = 0;
                    }
                    _grid[_x, _y] = _type;
                    Console.WriteLine("> to move right");
                                            
                    break;

                case ConsoleKey.A:
                    //[A] to move right                    
                    _grid[_x, _y] = GridType.O;
                    _y -= 1;

                    if (_y < 0)
                    {
                        //Ele não pode ultrapassar o tamanho do Grid;
                        _y = 19;
                    }
                    _grid[_x, _y] = _type;
                    Console.WriteLine("> to move left");
                    break;
                case ConsoleKey.S:
                    //[S] to move down                    
                    _grid[_x, _y] = GridType.O;
                    _x += 1;

                    if (_x > 19)
                    {
                        //Ele não pode ultrapassar o tamanho do Grid;
                        _x = 0;
                    }
                    _grid[_x, _y] = _type;
                    Console.WriteLine("> to move down");
                    break;

                case ConsoleKey.W:
                    //[W] to move up                 
                    _grid[_x, _y] = GridType.O;
                    _x -= 1;

                    if (_x < 0)
                    {
                        //Ele não pode ultrapassar o tamanho do Grid;
                        _y = 19;
                    }
                    _grid[_x, _y] = _type;
                    Console.WriteLine("> to move up");
                    break;
            }
            

        }
    }
}