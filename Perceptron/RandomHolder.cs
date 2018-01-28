using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class RandomHolder
    {
        private static RandomHolder Instance;
        private Random Rand;

        private RandomHolder()
        {
            Rand = new Random();
        }

        public static RandomHolder GetInstance()
        {
            if(Instance == null)
            {
                Instance = new RandomHolder();
            }
            return Instance;
        }

        public double getRandomDouble()
        {
            return Rand.NextDouble();
        }

        public int getRandomInt()
        {
            return Rand.Next();
        }

        public int getRandomIntRange(int minVal, int maxVal)
        {
            return Rand.Next(minVal, maxVal);
        }

        public int getRandomIntRange(int maxVal)
        {
            return Rand.Next(maxVal);
        }

        public byte[] getRandomByte(byte[] buf)
        {
            Rand.NextBytes(buf);
            return buf;
        }
    }
}
