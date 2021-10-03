using CMD_Game.Tipos;
using CMD_Game.FunctionsSystem;

namespace CMD_Game.Personagens
{
    class Monster : ObjectGrid
    {
        int _monsterHp = 5;
        int _monsterDamage = 1;
        int _monsterattack = 5;

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
                    _grid[_x, _y] = ;
                }
            }
        }

        public int MonsterDamage
        {
            get
            {
                return _monsterDamage;
            }

            set
            {
                //o dano do monstro é até 1 
                if (_monsterDamage == 1 )
                {
                    _monsterDamage = value;
                }

                else
                {
                    _monsterDamage = 0;
                }

            }
        }

        public int MonsterAttack
        {
            get
            {
                return _monsterattack;
            }

            set
            {
                //o ataque do monstro vale 5
                if (_monsterattack == 5)
                {
                    _monsterattack = value;
                }

                else
                {
                    _monsterattack = 0;
                }

            }
        }

        public Monster(GridType[,] grid)
        {
            grid[2, 2] = GridType.M;
        }





    }

}
