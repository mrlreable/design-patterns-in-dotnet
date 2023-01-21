using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Simulator
    {
        private static Simulator _instance;
        private bool _isInitialized;

        private Simulator()
        {
            _isInitialized = false;
        }

        public static Simulator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Simulator();
                }
                return _instance;
            }
        }

        public void Initialize()
        {
            Console.WriteLine("Initializing simulation...");
            _isInitialized = true;
        }

        public void Simulate()
        {
            if (!_isInitialized)
            {
                Console.WriteLine("Cannot perform simulation without initializing it first...");
                return;
            }

            Console.WriteLine("Performing simulation...");
            Console.WriteLine("Simulation finished!");
        }
    }
}
