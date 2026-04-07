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
                    //не даём установить нулевой вектор
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
        //todo реализовать методы изменения вектора-перемещение через wasd

        //проверка: можно ли повернуть на новый вектор (без разворота на 180)
        public bool CanChangeTo(Vector newVector)
        {
            //если сумма векторов = 0, значит они противоположны
            short sumX = (short)(this.Coordinats.X + newVector.Coordinats.X);
            short sumY = (short)(this.Coordinats.Y + newVector.Coordinats.Y);
            return !(sumX == 0 && sumY == 0);
        }
    }
}