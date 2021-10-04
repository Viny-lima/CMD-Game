using CMD_Game.Tipos;
using CMD_Game.FunctionsSystem;

namespace CMD_Game.GridObjects
{
    public class Monster : ObjectGrid
    {
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

        public Monster(int x, int y, int hp = 5, int damage = 1, int points = 5) : base (GridType.M, x, y)
        {
            _monsterHp = hp;
            _monsterDamage = damage;
            _valuePoints = points;
        }   

    }

}
