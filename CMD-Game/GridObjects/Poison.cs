using CMD_Game.Tipos;

namespace CMD_Game.GridObjects
{
    public class Poison : ObjectGrid
    {       

        public Poison(int x, int y, ObjectGrid[,] grid) : base(x, y, GridType.P, 6)
        {
            if (grid[base.x, base.y]._type == GridType.O)
            {
                //SetValue()
                grid[base.x, base.y]._type = this._type;
                grid[base.x, base.y].hp = this.hp;
            }                
        }
    }
}
