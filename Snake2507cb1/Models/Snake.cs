using System.Collections.Generic;

namespace Snake2507cb1.Models
{
    public class Snake
    {
        public int Id;
        public Coordinats Coordinats = new Coordinats(2, 2);
        public Vector Vector = new Vector(0, 1);
        public List<Coordinats> Body = new List<Coordinats>();
        public bool Grow = false;
        public int Score = 0; // Счётчик съеденной еды

        public Snake() { }
        public override string ToString() { return $"{Coordinats.ToString()}\tvector:{Vector.ToString()}"; }

        //todo методы изменения координат
        public void Move()
        {
            Body.Add(new Coordinats(Coordinats.X, Coordinats.Y));
            Coordinats.X += Vector.Coordinats.X;
            Coordinats.Y += Vector.Coordinats.Y;

            if (!Grow)
            {
                if (Body.Count > 0) Body.RemoveAt(0);
            }
            else
            {
                Grow = false;
            }
        }
    }
}