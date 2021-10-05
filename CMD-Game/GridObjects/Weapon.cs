using CMD_Game.Tipos;
using System;

namespace CMD_Game.GridObjects
{
    public class Weapon : ObjectGrid
    {

        public Weapon(int x, int y, ObjectGrid[,] grid) : base(x, y, GridType.W)
        {
            grid[_x, _y]._type = this._type;
        }
    }
}
