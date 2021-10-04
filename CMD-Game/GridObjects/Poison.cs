using CMD_Game.Tipos;

namespace CMD_Game.GridObjects
{
    public class Poison : ObjectGrid
    {
        int _poisonHp = 6;

        public int PoisonHp 
        {
            get
            {
                return _poisonHp;
            }

            set
            {
                //restaura a vida do heroi em 6 pontos
                if (_poisonHp == 6)
                {
                    _poisonHp = value;
                }

                else
                {
                    _poisonHp = 0;
                }

            }
        }

        public Poison(int x, int y): base(GridType.P,x, y) { }
    }
}
