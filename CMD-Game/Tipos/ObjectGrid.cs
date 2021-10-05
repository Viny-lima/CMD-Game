

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

        protected int _x;
        protected int _y;


        public (int, int) Position
        {
            get => (_x, _y);
        }

        public ObjectGrid(int x, int y, GridType typeValue = GridType.O)
        {            
            
                //Se na poção do Array Universal o tipo for vazio será adiconado um novo tipo baseado no obj construido.              
                this._x = x;
                this._y = y;
                this._type = typeValue;            
        }        
        
        public virtual void Move(ConsoleKey key, ObjectGrid[,] grid) { }
        
    }
}
