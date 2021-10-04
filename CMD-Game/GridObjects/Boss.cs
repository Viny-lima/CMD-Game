using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD_Game.GridObjects
{
    public class Boss : Monster
    {
        //O Boss tambémm é um mostro contudo mais forte

        public Boss(int x, int y, int hp = 10, int damage = 2, int points = 15) : base(x, y, hp, damage, points)
        {
            _type = GridType.B;
        }

    }
}
