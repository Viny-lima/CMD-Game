using CMD_Game.FunctionsSystem;
using CMD_Game.Tipos;
using System;

namespace CMD_Game.GridObjects
{
    public class Boss : Monster
    {
        //O Boss tambémm é um mostro contudo mais forte
        public Boss(int x, int y) : base(x, y, GridType.B, 10, 2, 15) { }
             
        
    }
}
