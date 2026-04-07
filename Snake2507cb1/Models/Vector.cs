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
                // Проверка диапазона (-1, 0, 1)
                if (value.X >= -1 && value.X <= 1 &&
                    value.Y >= -1 && value.Y <= 1)
                {
                    // Не даём установить нулевой вектор (0,0)
                    if (value.X == 0 && value.Y == 0)
                    {
                        throw new Exception($"Не верное значение координат {value.ToString()}");
                    }
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

        // Проверка: можно ли повернуть на новый вектор (без разворота на 180)
        public bool CanChangeTo(Vector newVector)
        {
            // Если сумма векторов равна (0,0), значит они противоположны (разворот на 180)
            short sumX = (short)(this.Coordinats.X + newVector.Coordinats.X);
            short sumY = (short)(this.Coordinats.Y + newVector.Coordinats.Y);

            // Возвращаем false, если это разворот, иначе true
            return !(sumX == 0 && sumY == 0);
        }
    }
}