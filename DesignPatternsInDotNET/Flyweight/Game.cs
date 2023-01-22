using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Game
    {
        public List<IFlyweight> Particles { get; set; }

        private static Game _instance;

        private Game()
        {
            Particles = new List<IFlyweight>();
        }

        public static Game Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new Game();
                }
                return _instance;
            }
        }

        public IFlyweight CreateParticles()
        {
            throw new NotImplementedException();
        }
    }
}
