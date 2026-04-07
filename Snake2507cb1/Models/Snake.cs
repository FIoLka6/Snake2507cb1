namespace Snake2507cb1.Models
{
    public class Snake
    {
        public int Id;
        public Coordinats Coordinats = new Coordinats(2, 2);
        public Vector Vector = new Vector(0, 1);

        //вспомогательное поле для отложенной смены вектора
        private Vector _nextVector = null;

        public Snake()
        {
        }
        public override string ToString()
        {
            return $"{Coordinats.ToString()}\tvector:{Vector.ToString()}";
        }
        //todo методы изменения координат

        //изменить вектор, если поворот допустим
        public void ChangeVector(Vector newVector)
        {
            //проверяем, не разворот ли это на 180 градусов
            if (Vector.CanChangeTo(newVector))
            {
                _nextVector = newVector;
            }
            //если поворот недопустим — игнорируем
        }

        //изменить координату по текущему вектору
        public void Move()
        {
            //если есть отложенный вектор — применяем его
            if (_nextVector != null)
            {
                Vector = _nextVector;
                _nextVector = null;
            }
            //новая позиция = старая + вектор
            Coordinats = Coordinats.Add(Vector.Coordinats);
        }
    }
}