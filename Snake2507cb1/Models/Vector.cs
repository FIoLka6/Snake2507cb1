namespace Snake2507cb1.Models
{
    public class Vector
    {
        private Coordinats coordinats;
        public Coordinats Coordinats
        {
            get { return coordinats; }
            set
            {
                if (value.X >= -1 && value.X <= 1 &&
                    value.Y >= -1 && value.Y <= 1)
                {
                    coordinats = value;
                }
                else
                {
                    throw new Exception($"Не верное значение координат {value.ToString()}");
                }
            }
        }
        public Vector(Coordinats coordinats)
        {
            Coordinats = coordinats;
        }
        public Vector(short x, short y)
        {
            Coordinats = new Coordinats(x, y);
        }
        public override string ToString()
        {
            return coordinats.ToString();
        }

        //todo реализовать методы изменнеия вектора (wsad)
        public void SetDirection(char key)
        {
            switch (char.ToLower(key))
            {
                case 'w': Coordinats = new Coordinats(0, -1); break;
                case 's': Coordinats = new Coordinats(0, 1); break;
                case 'a': Coordinats = new Coordinats(-1, 0); break;
                case 'd': Coordinats = new Coordinats(1, 0); break;
            }
        }
    }
}
