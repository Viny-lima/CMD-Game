using CMD_Game.Tipos;

namespace CMD_Game.GridObjects
{
    public class Boss : ObjectGrid
    {
        //O Boss tambémm é um mostro contudo mais forte

        int _monsterHp;
        int _monsterDamage;
        int _valuePoints;

        public int MonsterHp
        {
            get
            {
                return _monsterHp;
            }

            set
            {
                //A morte do monstro
                if (_monsterHp <= 0)
                {
                    //Na sua localização se torna vazia
                    _grid[_x, _y] = GridType.O;
                }
                else
                {
                    _monsterHp = value;
                }
            }
        }

        public Boss(int x, int y, int hp = 10, int damage = 2, int points = 15) : base(GridType.B,x, y)
        {
            _monsterHp = hp;
            _monsterDamage = damage;
            _valuePoints = points;
        }
        
    }
}
