using CMD_Game.Tipos;
using System;

namespace CMD_Game.GridObjects
{
    public class Weapon : ObjectGrid
    {

        public Weapon(int x, int y, ObjectGrid[,] grid) : base(x, y, GridType.W, 0, 1, 0)
        {
            if (grid[base.x, base.y]._type == GridType.O)
            {
                //SetValue()
                grid[base.x, base.y]._type = this._type;
                grid[base.x, base.y].damage = this.damage;
            }
        }
                
    }
}
