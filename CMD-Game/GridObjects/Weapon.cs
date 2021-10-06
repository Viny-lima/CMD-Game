using CMD_Game.Tipos;
using System;

namespace CMD_Game.GridObjects
{
    public class Weapon : ObjectGrid
    {

        public Weapon(int x, int y) : base(x, y, GridType.W, 0, 1, 0) { }        
                
    }
}
