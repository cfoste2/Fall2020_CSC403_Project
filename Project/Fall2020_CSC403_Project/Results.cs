using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project
{
    public struct Results
    {
        public bool running { get; set; }

        public Enemy enemy { get; set; }

        private bool _enemyKO;
        public bool enemyKO {
            get {
                return _enemyKO;
            }
            set {
                _lowHP = value;
                if (_lowHP)
                {
                    EnemyDefeated(enemy);
                }
            }
        }

        private bool _lowHP;
        public bool lowHP {
            get{
                return _lowHP;
            }
            set{
                _lowHP = value;
                HealthWarn(_lowHP);
            }
        }

        public void Setup(Enemy _enemy)
        {
            this.running = true;
            this.enemy = _enemy;
            this.enemyKO = false;
            this.lowHP = false;
        }
        public event Action<bool> HealthWarn;
        public event Action<Enemy> EnemyDefeated;
    }
}
