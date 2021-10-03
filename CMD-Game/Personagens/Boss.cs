using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD_Game.Personagens
{
    class Boss
    {
        int _bossHp = 10;
        int _bossDamage = 2;
        int _bossattack = 15;

        public int BossHp
        {
            get
            {
                return _bossHp;
            }

            set
            {
                //vida do chefe não pode ser negativa
                if (_bossHp >= 0)
                {
                    _bossHp = value;
                }

                else
                {
                    _bossHp = 0;
                }

            }
        }
        public int BossDamage
        {
            get
            {
                return _bossDamage;
            }

            set
            {
                //o dano do monstro é até 1 
                if (_bossDamage == 2)
                {
                    _bossDamage = value;
                }

                else
                {
                    _bossDamage = 0;
                }

            }
        }
        public int BossAttack
        {
            get
            {
                return _bossattack;
            }

            set
            {
                //o ataque do chefe vale 15
                if (_bossattack == 15)
                {
                    _bossattack = value;
                }

                else
                {
                    _bossattack = 0;
                }

            }
        }

      










    }
}
