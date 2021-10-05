using CMD_Game.Tipos;


namespace CMD_Game.GridObjects
{
    public class Destiny : ObjectGrid
    {
        public Destiny(ObjectGrid [,] grid) : base(20, 20, GridType.D) 
        {
            grid[x, y]._type = this._type;
        }

    }
}
