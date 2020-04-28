using System;

namespace LV2
{
    class Die
    {
        private int numberOfSides;
        private Random randomGenerator;
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = new Random();
        }
        public int Roll()
        {
            return randomGenerator.Next(1, numberOfSides + 1);
        }

    }
}
