

using System;

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

        public virtual void Move(ConsoleKey key)
        {


            switch (key)
            {
                case ConsoleKey.D:


                    if (_grid[_x, _y + 1] == GridType.O)
                    {

                        _grid[_x, _y] = GridType.O;
                        _y++;

                        if (_y > 20)
                        {

                            _y = 1;

                        }

                        _grid[_x, _y] = _type;

                    }

                    break;

                case ConsoleKey.A:
                    if (_grid[_x, _y - 1] == GridType.O)
                    {
                        //[A] to move right                    
                        _grid[_x, _y] = GridType.O;
                        _y -= 1;

                        if (_y < 1)
                        {
                            //Ele não pode ultrapassar o tamanho do Grid;
                            _y = 20;
                        }
                        _grid[_x, _y] = _type;
                        Console.WriteLine("> to move left");
                    }

                    break;

                case ConsoleKey.S:
                    if (_grid[_x + 1, _y] == GridType.O)
                    {
                        //[S] to move down                    
                        _grid[_x, _y] = GridType.O;
                        _x += 1;

                        if (_x > 20)
                        {
                            //Ele não pode ultrapassar o tamanho do Grid;
                            _x = 1;
                        }
                        _grid[_x, _y] = _type;
                        Console.WriteLine("> to move down");
                    }
                    break;

                case ConsoleKey.W:
                    if (_grid[_x - 1, _y] == GridType.O)
                    {
                        //[W] to move up                 
                        _grid[_x, _y] = GridType.O;
                        _x -= 1;

                        if (_x < 1)
                        {
                            //Ele não pode ultrapassar o tamanho do Grid;
                            _y = 20;
                        }
                        _grid[_x, _y] = _type;
                        Console.WriteLine("> to move up");
                    }
                    break;

                case ConsoleKey.Escape:

                    Program.FLAG = false;
                                                                                               
                    break;


            }
           

        }
    }
}
