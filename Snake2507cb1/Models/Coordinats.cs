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
        public override string ToString()
        {
            return $"[{X}:{Y}]";
        }
    }
}
