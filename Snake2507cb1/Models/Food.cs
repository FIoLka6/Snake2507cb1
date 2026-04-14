using System;

namespace Snake2507cb1.Models
{
    public class Food
    {
        public Coordinats Coordinats = new Coordinats(0, 0);
        private Random random = new Random();

        public Food(int width, int height)
        {
            Spawn(width, height);
        }

        public void Spawn(int width, int height)
        {
            Coordinats = new Coordinats((short)random.Next(width), (short)random.Next(height));
        }
    }
}