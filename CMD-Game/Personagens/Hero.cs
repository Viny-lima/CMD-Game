﻿using CMD_Game.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD_Game.Personagens
{
    class Hero
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

        public Hero (StatusGrid[,] grid)
        {
            grid[0, 0] = StatusGrid.H;
        }

    }
}
