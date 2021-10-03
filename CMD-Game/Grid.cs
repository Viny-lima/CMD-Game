using CMD_Game.FunctionsSystem;
using CMD_Game.Tipos;
using System;


namespace CMD_Game
{ 
    public class Grid
    {

        //Criando a Matriz Campo de Jogo
        StatusGrid[,] _CampGame = new StatusGrid[20,20];

        public StatusGrid[,] CampGame 
        {
            get 
             {    
               return _CampGame; 
                
             }
            
            set 
            {
                _CampGame = value;
            }

        }

        public Grid()
        {
            //Construindo com valores padrão/vazio 
            for (int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    _CampGame[i, j] = StatusGrid.O;
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
                    SystemFunction.PrintGridColors(this._CampGame[i, j]);
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
