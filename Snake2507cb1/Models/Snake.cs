namespace Snake2507cb1.Models
{
    public class Snake
    {
        public int Id;
        public Coordinats Coordinats = new Coordinats(2, 2);
        public Vector Vector = new Vector(0, 1);

        // Вспомогательное поле для отложенной смены вектора
        private Vector _nextVector = null;

        public Snake()
        {
        }

        public override string ToString()
        {
            return $"{Coordinats.ToString()}\tvector:{Vector.ToString()}";
        }

        // Изменить вектор, если поворот допустим
        public void ChangeVector(Vector newVector)
        {
            // Проверяем, не разворот ли это на 180 градусов
            if (Vector.CanChangeTo(newVector))
            {
                _nextVector = newVector;
            }
            // Если поворот недопустим — игнорируем нажатие
        }

        // Изменить координату по текущему вектору
        public void Move()
        {
            // Если есть отложенный вектор — применяем его
            if (_nextVector != null)
            {
                Vector = _nextVector;
                _nextVector = null;
            }

            // Новая позиция = старая + вектор
            // Используем метод Add из класса Coordinats
            Coordinats = Coordinats.Add(Vector.Coordinats);
        }
    }
}