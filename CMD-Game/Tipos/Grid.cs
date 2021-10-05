using CMD_Game.FunctionsSystem;
using System;
using static CMD_Game.Tipos.ObjectGrid;

namespace CMD_Game.Tipos
{ 
    public class Grid
    {
        //Class responsável pelo preenchimento e atualização da matrix do jogo, exibida no conosole

        protected GridType[,] _battleField = new GridType[22,22];

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
            for (int i = 1; i < 21; i++)
            {
                for(int j = 1; j < 21; j++)
                {
                    _battleField[i, j] = GridType.O;
                }
            }
        }
        
        public void PrintGrid()
        {           

            //Imprimindo no Grid no Console
            for (int i = 1; i < 21; i++)
            {
                for (int j = 1; j < 21; j++)
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
