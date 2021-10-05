

using System;

namespace CMD_Game.Tipos
{
    public class ObjectGrid 
    {
        /*Class Responsável pela indentificação por tipos e localização dos objetos na matrix abaixo*/
         //Array de todos os objetos
        
        public enum GridType
        {
            O = 0,
            H = 1,
            B = 2,
            M = 3,
            P = 4,
            W = 5,
            D = 6
        }
        public GridType _type;

        public int x;
        public int y;
        public int hp;
        public int damage;
        public int points;

        public (int, int) Position
        {
            get => (x, y);
        }

        public ObjectGrid(int x, int y, GridType typeValue , int hp = 0, int damage = 0,  int points = 0)
        {                                                
                this.x = x;
                this.y = y;
                this.hp = hp;
                this.damage = damage;
                this.points = points;
                this._type = typeValue;            
        }                 
        
    }
}
