using CMD_Game.FunctionsSystem;
using System;
using static CMD_Game.Tipos.ObjectGrid;

namespace CMD_Game.Tipos
{ 
    public class Grid
    {

        //Criando a Matriz Campo de Jogo
        protected GridType[,] _battleField = new GridType[20,20];

        public GridType[,] BattleField 
        {
            get 
             {    
               return _battleField; 
                
             }
            
            set 
            {
                _battleField = value;
            }

        }

        public Grid()
        {
            //Construindo com valores padrão/vazio 
            for (int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    _battleField[i, j] = GridType.O;
                }
            }
        }
        
        public void PrintGrid()
        {
            SystemFunction.PrintStatusBar(25, 1, 0);

            //Imprimindo no Grid no Console
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    SystemFunction.PrintGridColors(this._battleField[i, j]);
                }

                //Quebra de linha
                Console.WriteLine("");
            }

            SystemFunction.CriarLinha(40);
            SystemFunction.PrintControl();
            SystemFunction.CriarLinha(40);
        }

    }
}
