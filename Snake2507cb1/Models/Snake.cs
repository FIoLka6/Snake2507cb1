namespace Snake2507cb1.Models
{
    public class Snake
    {
        public int Id;
        public Coordinats Coordinats = new Coordinats(2, 2);
        public Vector Vector = new Vector(0, 1);
        public Snake()
        {
        }
        public override string ToString()
        {
            return $"{Coordinats.ToString()}\tvector:{Vector.ToString()}";
        }

        //todo методы изменения координат
        public void Move()
        {
            Coordinats.X += Vector.Coordinats.X;
            Coordinats.Y += Vector.Coordinats.Y;
        }
    }
}
