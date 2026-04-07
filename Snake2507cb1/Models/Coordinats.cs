namespace Snake2507cb1.Models
{
    public class Coordinats
    {
        public short X;
        public short Y;

        public Coordinats(short x, short y)
        {
            X = x;
            Y = y;
        }

        //метод сложения координат для движения
        public Coordinats Add(Coordinats other)
        {
            return new Coordinats((short)(X + other.X), (short)(Y + other.Y));
        }

        public override string ToString()
        {
            return $"[{X}:{Y}]";
        }
    }
}