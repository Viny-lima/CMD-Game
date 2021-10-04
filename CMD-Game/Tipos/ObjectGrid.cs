﻿

namespace CMD_Game.Tipos
{
    public class ObjectGrid 
    {
        /*Class Responsável pela indentificação por tipos e localização dos objetos na matrix*/
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

        static protected GridType[,] _grid;

        protected int _x;
        protected int _y;
        protected GridType _type;
        

        public (int, int) Position
        {
            get => (_x, _y);
        }

        public GridType Type { get; protected set; }

        public ObjectGrid(GridType typeValue,int x , int y )
        {
            //Quando construímos qualquer objetos do Grid
            /*
                1 - Inserimos o Tipo enum referente a ele
                2 - Inserimos o Grid o qual ele pertence
                3 - posição X & Y
            */
            if (_grid[x, y] == GridType.O)
            {
                //Os objetos só poderam ocupar lugares vazios
                _x = x;
                _y = y;
                _type = typeValue;
                _grid[x, y] = _type;
            }            
        }
        
        public static void InsertGridUniversal(ref Grid grid)
        {
            //Método que insere um Grid padrão a todos os objetos
            _grid = grid.BattleField;
        }        

    }
}