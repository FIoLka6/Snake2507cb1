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
                    throw new System.Exception($"Не верное значение координат {value.ToString()}");
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
            short newX = 0, newY = 0;
            switch (char.ToLower(key))
            {
                case 'w': newY = -1; break;
                case 's': newY = 1; break;
                case 'a': newX = -1; break;
                case 'd': newX = 1; break;
                default: return;
            }

            // Запрет разворота на 180 градусов
            if (newX == -coordinats.X && newY == -coordinats.Y)
                return;

            Coordinats = new Coordinats(newX, newY);
        }
    }
}