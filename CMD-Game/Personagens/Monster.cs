using CMD_Game.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD_Game.Personagens
{
    class Monster
    {
        int _monsterHp = 5;
        int _monsterDamage = 1;
        int _monsterattack = 5;

        public int MonsterHp
        {
            get
            {
                return _monsterHp;
            }

            set
            {
                //vida do monstro não pode ser negativa
                if (_monsterHp >= 0)
                {
                    _monsterHp = value;
                }

                else
                {
                    _monsterHp = 0;
                }

            }
        }

        public int MonsterDamage
        {
            get
            {
                return _monsterDamage;
            }

            set
            {
                //o dano do monstro é até 1 
                if (_monsterDamage == 1 )
                {
                    _monsterDamage = value;
                }

                else
                {
                    _monsterDamage = 0;
                }

            }
        }

        public int MonsterAttack
        {
            get
            {
                return _monsterattack;
            }

            set
            {
                //o ataque do monstro vale 5
                if (_monsterattack == 5)
                {
                    _monsterattack = value;
                }

                else
                {
                    _monsterattack = 0;
                }

            }
        }

        public Monster(StatusGrid[,] grid)
        {
            grid[2, 2] = StatusGrid.M;
        }





    }

}
