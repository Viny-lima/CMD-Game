using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD_Game.Personagens
{
    class Poison
    {
        int _poisonHp = 6;

        public int PoisonHp 
        {
            get
            {
                return _poisonHp;
            }

            set
            {
                //restaura a vida do heroi em 6 pontos
                if (_poisonHp == 6)
                {
                    _poisonHp = value;
                }

                else
                {
                    _poisonHp = 0;
                }

            }
        }
    }
}
